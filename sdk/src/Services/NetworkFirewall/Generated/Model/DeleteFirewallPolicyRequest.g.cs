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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFirewallPolicy operation. Deletes the specified
    /// <a>FirewallPolicy</a>.
    /// </summary>
    public partial class DeleteFirewallPolicyRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property FirewallPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall policy.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FirewallPolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyArn property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyArn() => this.FirewallPolicyArn != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyName. 
        /// <para>
        /// The descriptive name of the firewall policy. You can't change the name of a firewall
        /// policy after you create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FirewallPolicyName { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyName property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyName() => this.FirewallPolicyName != null;
    }
}
