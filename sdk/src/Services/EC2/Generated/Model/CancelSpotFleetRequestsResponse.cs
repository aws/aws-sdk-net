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
    /// Contains the output of CancelSpotFleetRequests.
    /// </summary>
    public partial class CancelSpotFleetRequestsResponse : AmazonWebServiceResponse
    {
        private List<CancelSpotFleetRequestsSuccessItem> _successfulFleetRequests = new List<CancelSpotFleetRequestsSuccessItem>();
        private List<CancelSpotFleetRequestsErrorItem> _unsuccessfulFleetRequests = new List<CancelSpotFleetRequestsErrorItem>();

        /// <summary>
        /// Gets and sets the property SuccessfulFleetRequests. 
        /// <para>
        /// Information about the Spot Fleet requests that are successfully canceled.
        /// </para>
        /// </summary>
        public List<CancelSpotFleetRequestsSuccessItem> SuccessfulFleetRequests
        {
            get { return this._successfulFleetRequests; }
            set { this._successfulFleetRequests = value; }
        }

        // Check to see if SuccessfulFleetRequests property is set
        internal bool IsSetSuccessfulFleetRequests()
        {
            return this._successfulFleetRequests != null && this._successfulFleetRequests.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnsuccessfulFleetRequests. 
        /// <para>
        /// Information about the Spot Fleet requests that are not successfully canceled.
        /// </para>
        /// </summary>
        public List<CancelSpotFleetRequestsErrorItem> UnsuccessfulFleetRequests
        {
            get { return this._unsuccessfulFleetRequests; }
            set { this._unsuccessfulFleetRequests = value; }
        }

        // Check to see if UnsuccessfulFleetRequests property is set
        internal bool IsSetUnsuccessfulFleetRequests()
        {
            return this._unsuccessfulFleetRequests != null && this._unsuccessfulFleetRequests.Count > 0; 
        }

    }
}