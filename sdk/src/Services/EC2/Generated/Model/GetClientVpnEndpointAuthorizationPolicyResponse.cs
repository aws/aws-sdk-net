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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// This is the response object from the GetClientVpnEndpointAuthorizationPolicy operation.
    /// </summary>
    public partial class GetClientVpnEndpointAuthorizationPolicyResponse : AmazonWebServiceResponse
    {
        private string _clientVpnEndpointId;
        private string _description;
        private string _policyDocument;
        private ClientVpnAuthorizationPolicyShadowMode _shadowMode;
        private ClientVpnAuthorizationPolicyStatus _status;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint.
        /// </para>
        /// </summary>
        public string ClientVpnEndpointId
        {
            get { return this._clientVpnEndpointId; }
            set { this._clientVpnEndpointId = value; }
        }

        // Check to see if ClientVpnEndpointId property is set
        internal bool IsSetClientVpnEndpointId()
        {
            return this._clientVpnEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the authorization policy.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The authorization policy document, written in the Cedar policy language.
        /// </para>
        /// </summary>
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

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
        /// </summary>
        public ClientVpnAuthorizationPolicyShadowMode ShadowMode
        {
            get { return this._shadowMode; }
            set { this._shadowMode = value; }
        }

        // Check to see if ShadowMode property is set
        internal bool IsSetShadowMode()
        {
            return this._shadowMode != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the authorization policy.
        /// </para>
        /// </summary>
        public ClientVpnAuthorizationPolicyStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}