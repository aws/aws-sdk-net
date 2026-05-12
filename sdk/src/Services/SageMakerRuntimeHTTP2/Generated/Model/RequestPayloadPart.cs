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
 * Do not modify this file. This file is generated from the sagemaker-runtime-http2-2025-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.SageMakerRuntimeHTTP2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMakerRuntimeHTTP2.Model
{
    /// <summary>
    /// Request payload part structure.
    /// </summary>
    public partial class RequestPayloadPart
        : IEventStreamEvent
    {
        private MemoryStream _bytes;
        private string _completionState;
        private string _dataType;
        private string _p;

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// The payload bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public MemoryStream Bytes
        {
            get { return this._bytes; }
            set { this._bytes = value; }
        }

        // Check to see if Bytes property is set
        internal bool IsSetBytes()
        {
            return this._bytes != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionState. 
        /// <para>
        /// Completion state header. Can be one of these possible values: "PARTIAL", "COMPLETE".
        /// </para>
        /// </summary>
        public string CompletionState
        {
            get { return this._completionState; }
            set { this._completionState = value; }
        }

        // Check to see if CompletionState property is set
        internal bool IsSetCompletionState()
        {
            return this._completionState != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// Data type header. Can be one of these possible values: "UTF8", "BINARY".
        /// </para>
        /// </summary>
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property P. 
        /// <para>
        /// Padding string for alignment.
        /// </para>
        /// </summary>
        public string P
        {
            get { return this._p; }
            set { this._p = value; }
        }

        // Check to see if P property is set
        internal bool IsSetP()
        {
            return this._p != null;
        }

    }
}