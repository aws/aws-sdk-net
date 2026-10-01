/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Defines what data to capture for code-level instrumentation, including arguments,
    /// return values, stack traces, local variables, and safety limits.
    /// </summary>
    public partial class CodeCaptureConfiguration
    {
        /// <summary>
        /// Gets and sets the property CaptureArguments. 
        /// <para>
        /// The function arguments to capture. Omit to capture defaults, use an empty list to
        /// capture none, use <c>["*"]</c> to capture all arguments, or specify argument names
        /// to capture selectively (up to 10 entries).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> CaptureArguments { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CaptureArguments property is set.
        /// </summary>
        internal bool IsSetCaptureArguments() => this.CaptureArguments != null && (this.CaptureArguments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CaptureLimits. 
        /// <para>
        /// Safety limits that bound what is captured, including hit counts, string length, collection
        /// depth, and stack trace size.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CaptureLimitsConfig CaptureLimits { get; set; }

        /// <summary>
        /// Checks to see if the CaptureLimits property is set.
        /// </summary>
        internal bool IsSetCaptureLimits() => this.CaptureLimits != null;

        /// <summary>
        /// Gets and sets the property CaptureLocals. 
        /// <para>
        /// The local variables to capture by name. Omit or pass an empty list to capture none.
        /// You can specify up to 20 names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<string> CaptureLocals { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CaptureLocals property is set.
        /// </summary>
        internal bool IsSetCaptureLocals() => this.CaptureLocals != null && (this.CaptureLocals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CaptureReturn. 
        /// <para>
        /// Whether to capture the return value. Defaults to false.
        /// </para>
        /// </summary>
        public bool? CaptureReturn { get; set; }

        /// <summary>
        /// Checks to see if the CaptureReturn property is set.
        /// </summary>
        internal bool IsSetCaptureReturn() => this.CaptureReturn.HasValue;

        /// <summary>
        /// Gets and sets the property CaptureStackTrace. 
        /// <para>
        /// Whether to capture a stack trace when the instrumentation point is hit. Defaults to
        /// true.
        /// </para>
        /// </summary>
        public bool? CaptureStackTrace { get; set; }

        /// <summary>
        /// Checks to see if the CaptureStackTrace property is set.
        /// </summary>
        internal bool IsSetCaptureStackTrace() => this.CaptureStackTrace.HasValue;
    }
}
