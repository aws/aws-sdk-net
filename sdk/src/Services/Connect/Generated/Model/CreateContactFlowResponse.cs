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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the CreateContactFlow operation.
    /// </summary>
    public partial class CreateContactFlowResponse : AmazonWebServiceResponse
    {
        private string _contactFlowArn;
        private string _contactFlowId;
        private string _flowContentSha256;

        /// <summary>
        /// Gets and sets the property ContactFlowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow.
        /// </para>
        /// </summary>
        public string ContactFlowArn
        {
            get { return this._contactFlowArn; }
            set { this._contactFlowArn = value; }
        }

        // Check to see if ContactFlowArn property is set
        internal bool IsSetContactFlowArn()
        {
            return this._contactFlowArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContactFlowId. 
        /// <para>
        /// The identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string ContactFlowId
        {
            get { return this._contactFlowId; }
            set { this._contactFlowId = value; }
        }

        // Check to see if ContactFlowId property is set
        internal bool IsSetContactFlowId()
        {
            return this._contactFlowId != null;
        }

        /// <summary>
        /// Gets and sets the property FlowContentSha256. 
        /// <para>
        /// Indicates the checksum value of the latest published flow content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string FlowContentSha256
        {
            get { return this._flowContentSha256; }
            set { this._flowContentSha256 = value; }
        }

        // Check to see if FlowContentSha256 property is set
        internal bool IsSetFlowContentSha256()
        {
            return this._flowContentSha256 != null;
        }

    }
}