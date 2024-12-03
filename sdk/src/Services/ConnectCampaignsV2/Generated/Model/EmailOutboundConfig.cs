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
    /// Default Email Outbound config
    /// </summary>
    public partial class EmailOutboundConfig
    {
        private string _connectSourceEmailAddress;
        private string _sourceEmailAddressDisplayName;
        private string _wisdomTemplateArn;

        /// <summary>
        /// Gets and sets the property ConnectSourceEmailAddress.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
        public string ConnectSourceEmailAddress
        {
            get { return this._connectSourceEmailAddress; }
            set { this._connectSourceEmailAddress = value; }
        }

        // Check to see if ConnectSourceEmailAddress property is set
        internal bool IsSetConnectSourceEmailAddress()
        {
            return this._connectSourceEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEmailAddressDisplayName.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string SourceEmailAddressDisplayName
        {
            get { return this._sourceEmailAddressDisplayName; }
            set { this._sourceEmailAddressDisplayName = value; }
        }

        // Check to see if SourceEmailAddressDisplayName property is set
        internal bool IsSetSourceEmailAddressDisplayName()
        {
            return this._sourceEmailAddressDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property WisdomTemplateArn.
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=500)]
        public string WisdomTemplateArn
        {
            get { return this._wisdomTemplateArn; }
            set { this._wisdomTemplateArn = value; }
        }

        // Check to see if WisdomTemplateArn property is set
        internal bool IsSetWisdomTemplateArn()
        {
            return this._wisdomTemplateArn != null;
        }

    }
}