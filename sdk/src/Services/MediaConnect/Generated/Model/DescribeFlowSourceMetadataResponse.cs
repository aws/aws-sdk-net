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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
        private string _flowArn;
        private List<MessageDetail> _messages = AWSConfigs.InitializeCollections ? new List<MessageDetail>() : null;
        private NdiSourceMetadataInfo _ndiInfo;
        private DateTime? _timestamp;
        private TransportMediaInfo _transportMediaInfo;

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The ARN of the flow that DescribeFlowSourceMetadata was performed on.
        /// </para>
        /// </summary>
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        ///  Provides a status code and message regarding issues found with the flow source metadata.
        /// </para>
        /// </summary>
        public List<MessageDetail> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && (this._messages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NdiInfo. 
        /// <para>
        ///  The NDI® specific information about the flow's source. This includes the current
        /// active NDI sender, a list of all discovered NDI senders, the associated media streams
        /// for the active NDI sender, and any relevant status messages. 
        /// </para>
        /// </summary>
        public NdiSourceMetadataInfo NdiInfo
        {
            get { return this._ndiInfo; }
            set { this._ndiInfo = value; }
        }

        // Check to see if NdiInfo property is set
        internal bool IsSetNdiInfo()
        {
            return this._ndiInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        ///  The timestamp of the most recent change in metadata for this flow’s source.
        /// </para>
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransportMediaInfo. 
        /// <para>
        ///  Information about the flow's transport media. 
        /// </para>
        /// </summary>
        public TransportMediaInfo TransportMediaInfo
        {
            get { return this._transportMediaInfo; }
            set { this._transportMediaInfo = value; }
        }

        // Check to see if TransportMediaInfo property is set
        internal bool IsSetTransportMediaInfo()
        {
            return this._transportMediaInfo != null;
        }

    }
}