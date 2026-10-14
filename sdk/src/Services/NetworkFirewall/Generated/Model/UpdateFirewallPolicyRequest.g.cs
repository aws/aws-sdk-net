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
    /// Container for the parameters to the UpdateFirewallPolicy operation. Updates the properties
    /// of the specified firewall policy.
    /// </summary>
    public partial class UpdateFirewallPolicyRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the firewall policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Indicates whether you want Network Firewall to just check the validity of the request,
        /// rather than run the request. 
        /// </para>
        ///  
        /// <para>
        /// If set to <c>TRUE</c>, Network Firewall checks whether the request can run successfully,
        /// but doesn't actually make the requested changes. The call returns the value that the
        /// request would return if you ran it with dry run set to <c>FALSE</c>, but doesn't make
        /// additions or changes to your resources. This option allows you to make sure that you
        /// have the required permissions to run the request and that your request parameters
        /// are valid. 
        /// </para>
        ///  
        /// <para>
        /// If set to <c>FALSE</c>, Network Firewall makes the requested changes to your resources.
        /// 
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A complex type that contains settings for encryption of your firewall policy resources.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicy. 
        /// <para>
        /// The updated firewall policy to use for the firewall. You can't add or remove a <a>TLSInspectionConfiguration</a>
        /// after you create a firewall policy. However, you can replace an existing TLS inspection
        /// configuration with another <c>TLSInspectionConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FirewallPolicy FirewallPolicy { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicy property is set.
        /// </summary>
        internal bool IsSetFirewallPolicy() => this.FirewallPolicy != null;

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

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic locking. Network Firewall returns a token to your requests
        /// that access the firewall policy. The token marks the state of the policy resource
        /// at the time of the request. 
        /// </para>
        ///  
        /// <para>
        /// To make changes to the policy, you provide the token in your request. Network Firewall
        /// uses the token to ensure that the policy hasn't changed since you last retrieved it.
        /// If it has changed, the operation fails with an <c>InvalidTokenException</c>. If this
        /// happens, retrieve the firewall policy again to get a current copy of it with current
        /// token. Reapply your changes as needed, then try the operation again using the new
        /// token. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string UpdateToken { get; set; }

        /// <summary>
        /// Checks to see if the UpdateToken property is set.
        /// </summary>
        internal bool IsSetUpdateToken() => this.UpdateToken != null;
    }
}
