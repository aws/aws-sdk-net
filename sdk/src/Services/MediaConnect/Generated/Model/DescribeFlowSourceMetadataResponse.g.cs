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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// This is the response object from the DescribeFlowSourceMetadata operation.
    /// </summary>
    public partial class DescribeFlowSourceMetadataResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The ARN of the flow that DescribeFlowSourceMetadata was performed on.
        /// </para>
        /// </summary>
        public string FlowArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowArn property is set.
        /// </summary>
        internal bool IsSetFlowArn() => this.FlowArn != null;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        ///  Provides a status code and message regarding issues found with the flow source metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MessageDetail> Messages { get; set; } = AWSConfigs.InitializeCollections ? new List<MessageDetail>() : null;

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null && (this.Messages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NdiInfo. 
        /// <para>
        ///  The NDI® specific information about the flow's source. This includes the current
        /// active NDI sender, a list of all discovered NDI senders, the associated media streams
        /// for the active NDI sender, and any relevant status messages. 
        /// </para>
        /// </summary>
        public NdiSourceMetadataInfo NdiInfo { get; set; }

        /// <summary>
        /// Checks to see if the NdiInfo property is set.
        /// </summary>
        internal bool IsSetNdiInfo() => this.NdiInfo != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        ///  The timestamp of the most recent change in metadata for this flow’s source.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TransportMediaInfo. 
        /// <para>
        ///  Information about the flow's transport media. 
        /// </para>
        /// </summary>
        public TransportMediaInfo TransportMediaInfo { get; set; }

        /// <summary>
        /// Checks to see if the TransportMediaInfo property is set.
        /// </summary>
        internal bool IsSetTransportMediaInfo() => this.TransportMediaInfo != null;
    }
}
