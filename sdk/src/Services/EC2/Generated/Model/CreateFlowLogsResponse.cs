/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains the output of CreateFlowLogs.
    /// </summary>
    public partial class CreateFlowLogsResponse : AmazonWebServiceResponse
    {
        private string _clientToken;
        private List<string> _flowLogIds = new List<string>();
        private List<UnsuccessfulItem> _unsuccessful = new List<UnsuccessfulItem>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property FlowLogIds. 
        /// <para>
        /// The IDs of the flow logs.
        /// </para>
        /// </summary>
        public List<string> FlowLogIds
        {
            get { return this._flowLogIds; }
            set { this._flowLogIds = value; }
        }

        // Check to see if FlowLogIds property is set
        internal bool IsSetFlowLogIds()
        {
            return this._flowLogIds != null && this._flowLogIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Unsuccessful. 
        /// <para>
        /// Information about the flow logs that could not be created successfully.
        /// </para>
        /// </summary>
        public List<UnsuccessfulItem> Unsuccessful
        {
            get { return this._unsuccessful; }
            set { this._unsuccessful = value; }
        }

        // Check to see if Unsuccessful property is set
        internal bool IsSetUnsuccessful()
        {
            return this._unsuccessful != null && this._unsuccessful.Count > 0; 
        }

    }
}