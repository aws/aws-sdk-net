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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyClientVpnEndpointAuthorizationPolicy operation.
    /// Creates or updates the authorization policy for a Client VPN endpoint. A Client VPN
    /// endpoint can have one authorization policy. If a policy already exists for the endpoint,
    /// the values that you specify replace the corresponding values in the existing policy,
    /// and values that you do not specify remain unchanged.
    /// </summary>
    public partial class ModifyClientVpnEndpointAuthorizationPolicyRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientVpnEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the ClientVpnEndpointId property is set.
        /// </summary>
        internal bool IsSetClientVpnEndpointId() => this.ClientVpnEndpointId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the authorization policy.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The authorization policy document, written in the Cedar policy language. This parameter
        /// is required when you create the authorization policy for a Client VPN endpoint that
        /// does not already have one.
        /// </para>
        /// </summary>
        public string PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDocument property is set.
        /// </summary>
        internal bool IsSetPolicyDocument() => this.PolicyDocument != null;

        /// <summary>
        /// Gets and sets the property ShadowMode. 
        /// <para>
        /// Specifies whether the authorization policy is evaluated in shadow mode. Possible values
        /// include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>enabled</c> - The authorization policy is evaluated and the results are logged,
        /// but access is not enforced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disabled</c> - The authorization policy is enforced.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default value is <c>disabled</c>.
        /// </para>
        /// </summary>
        public ClientVpnAuthorizationPolicyShadowMode ShadowMode { get; set; }

        /// <summary>
        /// Checks to see if the ShadowMode property is set.
        /// </summary>
        internal bool IsSetShadowMode() => this.ShadowMode != null;
    }
}
