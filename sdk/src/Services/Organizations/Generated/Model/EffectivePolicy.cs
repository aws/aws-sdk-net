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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains rules to be applied to the affected accounts. The effective policy is the
    /// aggregation of any policies the account inherits, plus any policy directly attached
    /// to the account.
    /// </summary>
    public partial class EffectivePolicy
    {
        private DateTime? _lastUpdatedTimestamp;
        private string _policyContent;
        private EffectivePolicyType _policyType;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The time of the last update to this policy.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyContent. 
        /// <para>
        /// The text content of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string PolicyContent
        {
            get { return this._policyContent; }
            set { this._policyContent = value; }
        }

        // Check to see if PolicyContent property is set
        internal bool IsSetPolicyContent()
        {
            return this._policyContent != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The policy type.
        /// </para>
        /// </summary>
        public EffectivePolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The account ID of the policy target. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

    }
}