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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
        private int? _maxCollectionDepth;
        private int? _maxCollectionWidth;
        private int? _maxFieldsPerObject;
        private int? _maxHits;
        private int? _maxObjectDepth;
        private int? _maxStackFrames;
        private int? _maxStackTraceSize;
        private int? _maxStringLength;

        /// <summary>
        /// Gets and sets the property MaxCollectionDepth. 
        /// <para>
        /// The maximum nesting depth to traverse inside collections. Defaults to 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int? MaxCollectionDepth
        {
            get { return this._maxCollectionDepth; }
            set { this._maxCollectionDepth = value; }
        }

        // Check to see if MaxCollectionDepth property is set
        internal bool IsSetMaxCollectionDepth()
        {
            return this._maxCollectionDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxCollectionWidth. 
        /// <para>
        /// The maximum number of items to capture from any collection to prevent large payloads.
        /// Defaults to 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int? MaxCollectionWidth
        {
            get { return this._maxCollectionWidth; }
            set { this._maxCollectionWidth = value; }
        }

        // Check to see if MaxCollectionWidth property is set
        internal bool IsSetMaxCollectionWidth()
        {
            return this._maxCollectionWidth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFieldsPerObject. 
        /// <para>
        /// The maximum number of fields to capture for any object. Defaults to 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int? MaxFieldsPerObject
        {
            get { return this._maxFieldsPerObject; }
            set { this._maxFieldsPerObject = value; }
        }

        // Check to see if MaxFieldsPerObject property is set
        internal bool IsSetMaxFieldsPerObject()
        {
            return this._maxFieldsPerObject.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxHits. 
        /// <para>
        /// The maximum number of times the instrumentation point can be hit before it is automatically
        /// disabled. Defaults to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxHits
        {
            get { return this._maxHits; }
            set { this._maxHits = value; }
        }

        // Check to see if MaxHits property is set
        internal bool IsSetMaxHits()
        {
            return this._maxHits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxObjectDepth. 
        /// <para>
        /// The maximum depth for nested object traversal when capturing structured data. Defaults
        /// to 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int? MaxObjectDepth
        {
            get { return this._maxObjectDepth; }
            set { this._maxObjectDepth = value; }
        }

        // Check to see if MaxObjectDepth property is set
        internal bool IsSetMaxObjectDepth()
        {
            return this._maxObjectDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxStackFrames. 
        /// <para>
        /// The maximum number of stack frames to capture in stack traces. Defaults to 2.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int? MaxStackFrames
        {
            get { return this._maxStackFrames; }
            set { this._maxStackFrames = value; }
        }

        // Check to see if MaxStackFrames property is set
        internal bool IsSetMaxStackFrames()
        {
            return this._maxStackFrames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxStackTraceSize. 
        /// <para>
        /// The maximum total size, in bytes, of a captured stack trace. Defaults to 1000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxStackTraceSize
        {
            get { return this._maxStackTraceSize; }
            set { this._maxStackTraceSize = value; }
        }

        // Check to see if MaxStackTraceSize property is set
        internal bool IsSetMaxStackTraceSize()
        {
            return this._maxStackTraceSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxStringLength. 
        /// <para>
        /// The maximum length of captured string values in characters. Strings longer than this
        /// are truncated. Defaults to 128.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public int? MaxStringLength
        {
            get { return this._maxStringLength; }
            set { this._maxStringLength = value; }
        }

        // Check to see if MaxStringLength property is set
        internal bool IsSetMaxStringLength()
        {
            return this._maxStringLength.HasValue; 
        }

    }
}