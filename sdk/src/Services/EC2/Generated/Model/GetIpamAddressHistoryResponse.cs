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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetIpamAddressHistory operation.
    /// </summary>
    public partial class GetIpamAddressHistoryResponse : AmazonWebServiceResponse
    {
        private List<IpamAddressHistoryRecord> _historyRecords = AWSConfigs.InitializeCollections ? new List<IpamAddressHistoryRecord>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property HistoryRecords. 
        /// <para>
        /// A historical record for a CIDR within an IPAM scope. If the CIDR is associated with
        /// an EC2 instance, you will see an object in the response for the instance and one for
        /// the network interface.
        /// </para>
        /// </summary>
        public List<IpamAddressHistoryRecord> HistoryRecords
        {
            get { return this._historyRecords; }
            set { this._historyRecords = value; }
        }

        // Check to see if HistoryRecords property is set
        internal bool IsSetHistoryRecords()
        {
            return this._historyRecords != null && (this._historyRecords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is <c>null</c> when
        /// there are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}