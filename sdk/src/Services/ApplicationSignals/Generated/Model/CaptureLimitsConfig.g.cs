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
    /// Guardrails that prevent instrumentation from impacting application performance by
    /// limiting how much data is captured.
    /// </summary>
    public partial class CaptureLimitsConfig
    {
        /// <summary>
        /// Gets and sets the property MaxCollectionDepth. 
        /// <para>
        /// The maximum nesting depth to traverse inside collections. Defaults to 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public int? MaxCollectionDepth { get; set; }

        /// <summary>
        /// Checks to see if the MaxCollectionDepth property is set.
        /// </summary>
        internal bool IsSetMaxCollectionDepth() => this.MaxCollectionDepth.HasValue;

        /// <summary>
        /// Gets and sets the property MaxCollectionWidth. 
        /// <para>
        /// The maximum number of items to capture from any collection to prevent large payloads.
        /// Defaults to 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? MaxCollectionWidth { get; set; }

        /// <summary>
        /// Checks to see if the MaxCollectionWidth property is set.
        /// </summary>
        internal bool IsSetMaxCollectionWidth() => this.MaxCollectionWidth.HasValue;

        /// <summary>
        /// Gets and sets the property MaxFieldsPerObject. 
        /// <para>
        /// The maximum number of fields to capture for any object. Defaults to 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? MaxFieldsPerObject { get; set; }

        /// <summary>
        /// Checks to see if the MaxFieldsPerObject property is set.
        /// </summary>
        internal bool IsSetMaxFieldsPerObject() => this.MaxFieldsPerObject.HasValue;

        /// <summary>
        /// Gets and sets the property MaxHits. 
        /// <para>
        /// The maximum number of times the instrumentation point can be hit before it is automatically
        /// disabled. Defaults to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxHits { get; set; }

        /// <summary>
        /// Checks to see if the MaxHits property is set.
        /// </summary>
        internal bool IsSetMaxHits() => this.MaxHits.HasValue;

        /// <summary>
        /// Gets and sets the property MaxObjectDepth. 
        /// <para>
        /// The maximum depth for nested object traversal when capturing structured data. Defaults
        /// to 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public int? MaxObjectDepth { get; set; }

        /// <summary>
        /// Checks to see if the MaxObjectDepth property is set.
        /// </summary>
        internal bool IsSetMaxObjectDepth() => this.MaxObjectDepth.HasValue;

        /// <summary>
        /// Gets and sets the property MaxStackFrames. 
        /// <para>
        /// The maximum number of stack frames to capture in stack traces. Defaults to 2.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? MaxStackFrames { get; set; }

        /// <summary>
        /// Checks to see if the MaxStackFrames property is set.
        /// </summary>
        internal bool IsSetMaxStackFrames() => this.MaxStackFrames.HasValue;

        /// <summary>
        /// Gets and sets the property MaxStackTraceSize. 
        /// <para>
        /// The maximum total size, in bytes, of a captured stack trace. Defaults to 1000.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxStackTraceSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxStackTraceSize property is set.
        /// </summary>
        internal bool IsSetMaxStackTraceSize() => this.MaxStackTraceSize.HasValue;

        /// <summary>
        /// Gets and sets the property MaxStringLength. 
        /// <para>
        /// The maximum length of captured string values in characters. Strings longer than this
        /// are truncated. Defaults to 128.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public int? MaxStringLength { get; set; }

        /// <summary>
        /// Checks to see if the MaxStringLength property is set.
        /// </summary>
        internal bool IsSetMaxStringLength() => this.MaxStringLength.HasValue;
    }
}
