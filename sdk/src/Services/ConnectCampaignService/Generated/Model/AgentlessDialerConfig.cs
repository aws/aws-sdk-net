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
    /// Agentless Dialer config
    /// </summary>
    public partial class AgentlessDialerConfig
    {
        private double? _dialingCapacity;

        /// <summary>
        /// Gets and sets the property DialingCapacity.
        /// </summary>
        [AWSProperty(Max=1)]
        public double? DialingCapacity
        {
            get { return this._dialingCapacity; }
            set { this._dialingCapacity = value; }
        }

        // Check to see if DialingCapacity property is set
        internal bool IsSetDialingCapacity()
        {
            return this._dialingCapacity.HasValue; 
        }

    }
}