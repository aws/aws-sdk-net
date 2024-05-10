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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateThirdPartyFirewall operation.
    /// Disassociates a Firewall Manager policy administrator from a third-party firewall
    /// tenant. When you call <c>DisassociateThirdPartyFirewall</c>, the third-party firewall
    /// vendor deletes all of the firewalls that are associated with the account.
    /// </summary>
    public partial class DisassociateThirdPartyFirewallRequest : AmazonFMSRequest
    {
        private ThirdPartyFirewall _thirdPartyFirewall;

        /// <summary>
        /// Gets and sets the property ThirdPartyFirewall. 
        /// <para>
        /// The name of the third-party firewall vendor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ThirdPartyFirewall ThirdPartyFirewall
        {
            get { return this._thirdPartyFirewall; }
            set { this._thirdPartyFirewall = value; }
        }

        // Check to see if ThirdPartyFirewall property is set
        internal bool IsSetThirdPartyFirewall()
        {
            return this._thirdPartyFirewall != null;
        }

    }
}