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
    /// Instance Communication limits config
    /// </summary>
    public partial class InstanceCommunicationLimitsConfig
    {
        private CommunicationLimits _allChannelSubtypes;

        /// <summary>
        /// Gets and sets the property AllChannelSubtypes.
        /// </summary>
        public CommunicationLimits AllChannelSubtypes
        {
            get { return this._allChannelSubtypes; }
            set { this._allChannelSubtypes = value; }
        }

        // Check to see if AllChannelSubtypes property is set
        internal bool IsSetAllChannelSubtypes()
        {
            return this._allChannelSubtypes != null;
        }

    }
}