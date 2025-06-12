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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the DescribeDeliveryDestinations operation.
    /// </summary>
    public partial class DescribeDeliveryDestinationsResponse : AmazonWebServiceResponse
    {
        private List<DeliveryDestination> _deliveryDestinations = AWSConfigs.InitializeCollections ? new List<DeliveryDestination>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DeliveryDestinations. 
        /// <para>
        /// An array of structures. Each structure contains information about one delivery destination
        /// in the account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeliveryDestination> DeliveryDestinations
        {
            get { return this._deliveryDestinations; }
            set { this._deliveryDestinations = value; }
        }

        // Check to see if DeliveryDestinations property is set
        internal bool IsSetDeliveryDestinations()
        {
            return this._deliveryDestinations != null && (this._deliveryDestinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1)]
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