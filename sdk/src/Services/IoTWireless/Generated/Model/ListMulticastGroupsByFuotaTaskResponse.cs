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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// This is the response object from the ListMulticastGroupsByFuotaTask operation.
    /// </summary>
    public partial class ListMulticastGroupsByFuotaTaskResponse : AmazonWebServiceResponse
    {
        private List<MulticastGroupByFuotaTask> _multicastGroupList = AWSConfigs.InitializeCollections ? new List<MulticastGroupByFuotaTask>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MulticastGroupList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MulticastGroupByFuotaTask> MulticastGroupList
        {
            get { return this._multicastGroupList; }
            set { this._multicastGroupList = value; }
        }

        // Check to see if MulticastGroupList property is set
        internal bool IsSetMulticastGroupList()
        {
            return this._multicastGroupList != null && (this._multicastGroupList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// To retrieve the next set of results, the <c>nextToken</c> value from a previous response;
        /// otherwise <b>null</b> to receive the first set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
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