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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// The channel-specific configurations for the journey.
    /// </summary>
    public partial class JourneyChannelSettings
    {
        private string _connectCampaignArn;
        private string _connectCampaignExecutionRoleArn;

        /// <summary>
        /// Gets and sets the property ConnectCampaignArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Connect Campaign.
        /// </para>
        /// </summary>
        public string ConnectCampaignArn
        {
            get { return this._connectCampaignArn; }
            set { this._connectCampaignArn = value; }
        }

        // Check to see if ConnectCampaignArn property is set
        internal bool IsSetConnectCampaignArn()
        {
            return this._connectCampaignArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectCampaignExecutionRoleArn. 
        /// <para>
        /// IAM role ARN to be assumed when invoking Connect campaign execution APIs for dialing.
        /// </para>
        /// </summary>
        public string ConnectCampaignExecutionRoleArn
        {
            get { return this._connectCampaignExecutionRoleArn; }
            set { this._connectCampaignExecutionRoleArn = value; }
        }

        // Check to see if ConnectCampaignExecutionRoleArn property is set
        internal bool IsSetConnectCampaignExecutionRoleArn()
        {
            return this._connectCampaignExecutionRoleArn != null;
        }

    }
}