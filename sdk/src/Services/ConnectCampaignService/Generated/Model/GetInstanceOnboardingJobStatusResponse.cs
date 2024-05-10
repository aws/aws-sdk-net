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
 * Do not modify this file. This file is generated from the connectcampaigns-2021-01-30.normal.json service model.
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
namespace Amazon.ConnectCampaignService.Model
{
    /// <summary>
    /// GetInstanceOnboardingJobStatusResponse
    /// </summary>
    public partial class GetInstanceOnboardingJobStatusResponse : AmazonWebServiceResponse
    {
        private InstanceOnboardingJobStatus _connectInstanceOnboardingJobStatus;

        /// <summary>
        /// Gets and sets the property ConnectInstanceOnboardingJobStatus.
        /// </summary>
        public InstanceOnboardingJobStatus ConnectInstanceOnboardingJobStatus
        {
            get { return this._connectInstanceOnboardingJobStatus; }
            set { this._connectInstanceOnboardingJobStatus = value; }
        }

        // Check to see if ConnectInstanceOnboardingJobStatus property is set
        internal bool IsSetConnectInstanceOnboardingJobStatus()
        {
            return this._connectInstanceOnboardingJobStatus != null;
        }

    }
}