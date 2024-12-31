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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Source of the campaign
    /// </summary>
    public partial class Source
    {
        private string _customerProfilesSegmentArn;
        private EventTrigger _eventTrigger;

        /// <summary>
        /// Gets and sets the property CustomerProfilesSegmentArn.
        /// </summary>
        [AWSProperty(Min=20, Max=500)]
        public string CustomerProfilesSegmentArn
        {
            get { return this._customerProfilesSegmentArn; }
            set { this._customerProfilesSegmentArn = value; }
        }

        // Check to see if CustomerProfilesSegmentArn property is set
        internal bool IsSetCustomerProfilesSegmentArn()
        {
            return this._customerProfilesSegmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property EventTrigger.
        /// </summary>
        public EventTrigger EventTrigger
        {
            get { return this._eventTrigger; }
            set { this._eventTrigger = value; }
        }

        // Check to see if EventTrigger property is set
        internal bool IsSetEventTrigger()
        {
            return this._eventTrigger != null;
        }

    }
}