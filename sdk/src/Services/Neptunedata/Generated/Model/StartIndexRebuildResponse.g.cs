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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// This is the response object from the StartIndexRebuild operation.
    /// </summary>
    public partial class StartIndexRebuildResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Concurrency. 
        /// <para>
        /// The effective concurrency used for this rebuild. This is the value supplied in the
        /// request, capped at the number of vCPUs on the writer instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Checks to see if the Concurrency property is set.
        /// </summary>
        internal bool IsSetConcurrency() => this.Concurrency.HasValue;

        /// <summary>
        /// Gets and sets the property RebuildId. 
        /// <para>
        /// The unique identifier for the index rebuild job. Use this ID with the GetIndexRebuildStatus
        /// operation to check the progress of the rebuild.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RebuildId { get; set; }

        /// <summary>
        /// Checks to see if the RebuildId property is set.
        /// </summary>
        internal bool IsSetRebuildId() => this.RebuildId != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of the rebuild operation that was requested. See <c>Scope</c> for possible
        /// values: <c>ALL</c>, <c>QUADS</c>, or <c>DICTIONARIES</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the rebuild operation. See <c>RebuildStatus</c> for possible
        /// values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RebuildStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WriteBufferSize. 
        /// <para>
        /// The <c>WriteBufferSize</c> applied to this rebuild. See the <c>WriteBufferSize</c>
        /// enum for possible values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WriteBufferSize WriteBufferSize { get; set; }

        /// <summary>
        /// Checks to see if the WriteBufferSize property is set.
        /// </summary>
        internal bool IsSetWriteBufferSize() => this.WriteBufferSize != null;
    }
}
