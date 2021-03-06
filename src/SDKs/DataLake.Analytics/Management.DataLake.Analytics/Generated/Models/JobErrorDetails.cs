// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Data Lake Analytics job error details.
    /// </summary>
    public partial class JobErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the JobErrorDetails class.
        /// </summary>
        public JobErrorDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobErrorDetails class.
        /// </summary>
        /// <param name="errorId">The specific identifier for the type of error
        /// encountered in the job.</param>
        /// <param name="severity">The severity level of the failure. Possible
        /// values include: 'Warning', 'Error', 'Info', 'SevereWarning',
        /// 'Deprecated', 'UserWarning'</param>
        /// <param name="source">The ultimate source of the failure (usually
        /// either SYSTEM or USER).</param>
        /// <param name="message">The user friendly error message for the
        /// failure.</param>
        /// <param name="description">The error message description.</param>
        /// <param name="details">The details of the error message.</param>
        /// <param name="lineNumber">The specific line number in the job where
        /// the error occurred.</param>
        /// <param name="startOffset">The start offset in the job where the
        /// error was found</param>
        /// <param name="endOffset">The end offset in the job where the error
        /// was found.</param>
        /// <param name="resolution">The recommended resolution for the
        /// failure, if any.</param>
        /// <param name="filePath">The path to any supplemental error files, if
        /// any.</param>
        /// <param name="helpLink">The link to MSDN or Azure help for this type
        /// of error, if any.</param>
        /// <param name="internalDiagnostics">The internal diagnostic stack
        /// trace if the user requesting the job error details has sufficient
        /// permissions it will be retrieved, otherwise it will be
        /// empty.</param>
        /// <param name="innerError">The inner error of this specific job error
        /// message, if any.</param>
        public JobErrorDetails(string errorId = default(string), SeverityTypes? severity = default(SeverityTypes?), string source = default(string), string message = default(string), string description = default(string), string details = default(string), int? lineNumber = default(int?), int? startOffset = default(int?), int? endOffset = default(int?), string resolution = default(string), string filePath = default(string), string helpLink = default(string), string internalDiagnostics = default(string), JobInnerError innerError = default(JobInnerError))
        {
            ErrorId = errorId;
            Severity = severity;
            Source = source;
            Message = message;
            Description = description;
            Details = details;
            LineNumber = lineNumber;
            StartOffset = startOffset;
            EndOffset = endOffset;
            Resolution = resolution;
            FilePath = filePath;
            HelpLink = helpLink;
            InternalDiagnostics = internalDiagnostics;
            InnerError = innerError;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the specific identifier for the type of error encountered in
        /// the job.
        /// </summary>
        [JsonProperty(PropertyName = "errorId")]
        public string ErrorId { get; private set; }

        /// <summary>
        /// Gets the severity level of the failure. Possible values include:
        /// 'Warning', 'Error', 'Info', 'SevereWarning', 'Deprecated',
        /// 'UserWarning'
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public SeverityTypes? Severity { get; private set; }

        /// <summary>
        /// Gets the ultimate source of the failure (usually either SYSTEM or
        /// USER).
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; private set; }

        /// <summary>
        /// Gets the user friendly error message for the failure.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the error message description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the details of the error message.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; private set; }

        /// <summary>
        /// Gets the specific line number in the job where the error occurred.
        /// </summary>
        [JsonProperty(PropertyName = "lineNumber")]
        public int? LineNumber { get; private set; }

        /// <summary>
        /// Gets the start offset in the job where the error was found
        /// </summary>
        [JsonProperty(PropertyName = "startOffset")]
        public int? StartOffset { get; private set; }

        /// <summary>
        /// Gets the end offset in the job where the error was found.
        /// </summary>
        [JsonProperty(PropertyName = "endOffset")]
        public int? EndOffset { get; private set; }

        /// <summary>
        /// Gets the recommended resolution for the failure, if any.
        /// </summary>
        [JsonProperty(PropertyName = "resolution")]
        public string Resolution { get; private set; }

        /// <summary>
        /// Gets the path to any supplemental error files, if any.
        /// </summary>
        [JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; private set; }

        /// <summary>
        /// Gets the link to MSDN or Azure help for this type of error, if any.
        /// </summary>
        [JsonProperty(PropertyName = "helpLink")]
        public string HelpLink { get; private set; }

        /// <summary>
        /// Gets the internal diagnostic stack trace if the user requesting the
        /// job error details has sufficient permissions it will be retrieved,
        /// otherwise it will be empty.
        /// </summary>
        [JsonProperty(PropertyName = "internalDiagnostics")]
        public string InternalDiagnostics { get; private set; }

        /// <summary>
        /// Gets the inner error of this specific job error message, if any.
        /// </summary>
        [JsonProperty(PropertyName = "innerError")]
        public JobInnerError InnerError { get; private set; }

    }
}
