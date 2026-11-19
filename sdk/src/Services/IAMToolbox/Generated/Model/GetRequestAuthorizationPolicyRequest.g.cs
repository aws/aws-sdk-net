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

namespace Amazon.IAMToolbox.Model
{
    /// <summary>
    /// Container for the parameters to the GetRequestAuthorizationPolicy operation. Retrieves
    /// a policy that was evaluated for a specific access denied request. The operation returns
    /// the structured JSON document of the policy that was captured with the original authorization
    /// request. It doesn't retrieve the current version of the policy. <para> For some AWS
    /// services and policy types, the returned policy document includes all actions relevant
    /// to the service that processed the denied request, but might omit actions for other
    /// services. </para> <para> Specify the authorization ID from the access denied error
    /// message and the policy URI returned by <c>GetRequestAuthorizationDetails</c> for the
    /// same authorization ID. </para> <para> Access depends on the account and organization
    /// recorded for the principal that made the denied request. If an organization was recorded,
    /// the calling principal must belong to that organization. Otherwise, the calling principal
    /// must belong to the recorded account. </para> <para> To use this operation, you must
    /// have the <c>iam:GetRequestAuthorizationPolicy</c> permission. </para>
    /// </summary>
    public partial class GetRequestAuthorizationPolicyRequest : AmazonIAMToolboxRequest
    {
        /// <summary>
        /// Gets and sets the property AuthorizationId. 
        /// <para>
        /// The authorization ID received in the access denied error message. This ID identifies
        /// the request whose evaluated policy you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 256)]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationId property is set.
        /// </summary>
        internal bool IsSetAuthorizationId() => this.AuthorizationId != null;

        /// <summary>
        /// Gets and sets the property PolicyUri. 
        /// <para>
        /// The URI of the policy to retrieve. Use the <c>uri</c> value from the <c>policies</c>
        /// list returned by <c>GetRequestAuthorizationDetails</c> for the same authorization
        /// ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PolicyUri { get; set; }

        /// <summary>
        /// Checks to see if the PolicyUri property is set.
        /// </summary>
        internal bool IsSetPolicyUri() => this.PolicyUri != null;
    }
}
