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
    /// Contains the output of CancelSpotFleetRequests.
    /// </summary>
    public partial class CancelSpotFleetRequestsResponse : AmazonWebServiceResponse
    {
        private List<CancelSpotFleetRequestsSuccessItem> _successfulFleetRequests = AWSConfigs.InitializeCollections ? new List<CancelSpotFleetRequestsSuccessItem>() : null;
        private List<CancelSpotFleetRequestsErrorItem> _unsuccessfulFleetRequests = AWSConfigs.InitializeCollections ? new List<CancelSpotFleetRequestsErrorItem>() : null;

        /// <summary>
        /// Gets and sets the property SuccessfulFleetRequests. 
        /// <para>
        /// Information about the Spot Fleet requests that are successfully canceled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CancelSpotFleetRequestsSuccessItem> SuccessfulFleetRequests
        {
            get { return this._successfulFleetRequests; }
            set { this._successfulFleetRequests = value; }
        }

        // Check to see if SuccessfulFleetRequests property is set
        internal bool IsSetSuccessfulFleetRequests()
        {
            return this._successfulFleetRequests != null && (this._successfulFleetRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnsuccessfulFleetRequests. 
        /// <para>
        /// Information about the Spot Fleet requests that are not successfully canceled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CancelSpotFleetRequestsErrorItem> UnsuccessfulFleetRequests
        {
            get { return this._unsuccessfulFleetRequests; }
            set { this._unsuccessfulFleetRequests = value; }
        }

        // Check to see if UnsuccessfulFleetRequests property is set
        internal bool IsSetUnsuccessfulFleetRequests()
        {
            return this._unsuccessfulFleetRequests != null && (this._unsuccessfulFleetRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}