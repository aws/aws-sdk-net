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

namespace Amazon.SageMakerRuntimeHTTP2.Model
{
    /// <summary>
    /// Request payload part structure.
    /// </summary>
    public partial class RequestPayloadPart : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// The payload bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public MemoryStream Bytes { get; set; }

        /// <summary>
        /// Checks to see if the Bytes property is set.
        /// </summary>
        internal bool IsSetBytes() => this.Bytes != null;

        /// <summary>
        /// Gets and sets the property CompletionState. 
        /// <para>
        /// Completion state header. Can be one of these possible values: "PARTIAL", "COMPLETE".
        /// </para>
        /// </summary>
        public string CompletionState { get; set; }

        /// <summary>
        /// Checks to see if the CompletionState property is set.
        /// </summary>
        internal bool IsSetCompletionState() => this.CompletionState != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// Data type header. Can be one of these possible values: "UTF8", "BINARY".
        /// </para>
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property P. 
        /// <para>
        /// Padding string for alignment.
        /// </para>
        /// </summary>
        public string P { get; set; }

        /// <summary>
        /// Checks to see if the P property is set.
        /// </summary>
        internal bool IsSetP() => this.P != null;
    }
}
