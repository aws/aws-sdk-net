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
    /// Default SMS Outbound config
    /// </summary>
    public partial class SmsOutboundConfig
    {
        private string _connectSourcePhoneNumberArn;
        private string _wisdomTemplateArn;

        /// <summary>
        /// Gets and sets the property ConnectSourcePhoneNumberArn.
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=500)]
        public string ConnectSourcePhoneNumberArn
        {
            get { return this._connectSourcePhoneNumberArn; }
            set { this._connectSourcePhoneNumberArn = value; }
        }

        // Check to see if ConnectSourcePhoneNumberArn property is set
        internal bool IsSetConnectSourcePhoneNumberArn()
        {
            return this._connectSourcePhoneNumberArn != null;
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