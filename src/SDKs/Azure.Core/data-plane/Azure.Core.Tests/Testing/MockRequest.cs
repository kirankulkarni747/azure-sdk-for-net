﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core.Pipeline;

namespace Azure.Core.Testing
{
    public class MockRequest : Request
    {
        public MockRequest()
        {
            RequestId = Guid.NewGuid().ToString();
        }

        private readonly Dictionary<string, List<string>> _headers = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

        protected internal override void AddHeader(string name, string value)
        {
            if (!_headers.TryGetValue(name, out var values))
            {
                _headers[name] = values = new List<string>();
            }

            values.Add(value);
        }

        protected internal override bool TryGetHeader(string name, out string value)
        {
            if (_headers.TryGetValue(name, out var values))
            {
                value = JoinHeaderValue(values);
                return true;
            }

            value = null;
            return false;
        }

        protected internal override bool TryGetHeaderValues(string name, out IEnumerable<string> values)
        {
            var result = _headers.TryGetValue(name, out var valuesList);
            values = valuesList;
            return result;
        }

        protected internal override bool ContainsHeader(string name)
        {
            return TryGetHeaderValues(name, out _);
        }

        protected internal override bool RemoveHeader(string name)
        {
            return _headers.Remove(name);
        }

        protected internal override IEnumerable<HttpHeader> EnumerateHeaders() => _headers.Select(h => new HttpHeader(h.Key, JoinHeaderValue(h.Value)));

        private static string JoinHeaderValue(IEnumerable<string> values)
        {
            return string.Join(",", values);
        }

        public override string RequestId { get; set; }

        public override string ToString() => $"{Method} {UriBuilder}";

        public override void Dispose()
        {
        }
    }
}
