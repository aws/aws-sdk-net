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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Contains the event-specific metadata for a policy event. Exactly one member is populated,
    /// according to the event type.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// policyAttachedToService — a service started using the policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// policyDetachedFromService — a service stopped using the policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// policySharingRevoked — cross-account sharing was disabled for the policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// policyDeleted — the policy was deleted.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PolicyEventMetadata
    {
        private PolicyAttachedToServiceMetadata _policyAttachedToService;
        private PolicyDeletedMetadata _policyDeleted;
        private PolicyDetachedFromServiceMetadata _policyDetachedFromService;
        private PolicySharingRevokedMetadata _policySharingRevoked;

        /// <summary>
        /// Gets and sets the property PolicyAttachedToService. 
        /// <para>
        /// Contains details about the service that started using the policy, such as the account
        /// that owns the service.
        /// </para>
        /// </summary>
        public PolicyAttachedToServiceMetadata PolicyAttachedToService
        {
            get { return this._policyAttachedToService; }
            set { this._policyAttachedToService = value; }
        }

        // Check to see if PolicyAttachedToService property is set
        internal bool IsSetPolicyAttachedToService()
        {
            return this._policyAttachedToService != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDeleted. 
        /// <para>
        /// Contains details about a policy that was deleted, including the number of services
        /// that were affected.
        /// </para>
        /// </summary>
        public PolicyDeletedMetadata PolicyDeleted
        {
            get { return this._policyDeleted; }
            set { this._policyDeleted = value; }
        }

        // Check to see if PolicyDeleted property is set
        internal bool IsSetPolicyDeleted()
        {
            return this._policyDeleted != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDetachedFromService. 
        /// <para>
        /// Contains details about the service that stopped using the policy, such as the account
        /// that owns the service.
        /// </para>
        /// </summary>
        public PolicyDetachedFromServiceMetadata PolicyDetachedFromService
        {
            get { return this._policyDetachedFromService; }
            set { this._policyDetachedFromService = value; }
        }

        // Check to see if PolicyDetachedFromService property is set
        internal bool IsSetPolicyDetachedFromService()
        {
            return this._policyDetachedFromService != null;
        }

        /// <summary>
        /// Gets and sets the property PolicySharingRevoked. 
        /// <para>
        /// Contains details about a policy for which organization sharing was revoked, including
        /// the number of services that were affected.
        /// </para>
        /// </summary>
        public PolicySharingRevokedMetadata PolicySharingRevoked
        {
            get { return this._policySharingRevoked; }
            set { this._policySharingRevoked = value; }
        }

        // Check to see if PolicySharingRevoked property is set
        internal bool IsSetPolicySharingRevoked()
        {
            return this._policySharingRevoked != null;
        }

    }
}