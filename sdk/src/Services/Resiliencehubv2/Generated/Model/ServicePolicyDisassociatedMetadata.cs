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
    /// Metadata for a service policy disassociated event.
    /// </summary>
    public partial class ServicePolicyDisassociatedMetadata
    {
        private string _policyArn;
        private string _policyName;
        private string _policyOwnerAccountId;
        private PolicyValueSource _policySource;
        private PolicyDisassociationReason _reason;

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        [AWSProperty(Min=31)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the disassociated policy.
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyOwnerAccountId. 
        /// <para>
        /// The account that owns the policy.
        /// </para>
        /// </summary>
        public string PolicyOwnerAccountId
        {
            get { return this._policyOwnerAccountId; }
            set { this._policyOwnerAccountId = value; }
        }

        // Check to see if PolicyOwnerAccountId property is set
        internal bool IsSetPolicyOwnerAccountId()
        {
            return this._policyOwnerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicySource. 
        /// <para>
        /// The source of the policy.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SELF — the policy belongs to the account that owns the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CROSS_ACCOUNT — the policy belongs to another account and was shared with the organization.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PolicyValueSource PolicySource
        {
            get { return this._policySource; }
            set { this._policySource = value; }
        }

        // Check to see if PolicySource property is set
        internal bool IsSetPolicySource()
        {
            return this._policySource != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason the policy was disassociated from the service.
        /// </para>
        /// </summary>
        public PolicyDisassociationReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}