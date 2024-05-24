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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Container for the parameters to the PutConfiguredAudienceModelPolicy operation.
    /// Create or update the resource policy for a configured audience model.
    /// </summary>
    public partial class PutConfiguredAudienceModelPolicyRequest : AmazonCleanRoomsMLRequest
    {
        private string _configuredAudienceModelArn;
        private string _configuredAudienceModelPolicy;
        private PolicyExistenceCondition _policyExistenceCondition;
        private string _previousPolicyHash;

        /// <summary>
        /// Gets and sets the property ConfiguredAudienceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configured audience model that the resource
        /// policy will govern.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ConfiguredAudienceModelArn
        {
            get { return this._configuredAudienceModelArn; }
            set { this._configuredAudienceModelArn = value; }
        }

        // Check to see if ConfiguredAudienceModelArn property is set
        internal bool IsSetConfiguredAudienceModelArn()
        {
            return this._configuredAudienceModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredAudienceModelPolicy. 
        /// <para>
        /// The IAM resource policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20480)]
        public string ConfiguredAudienceModelPolicy
        {
            get { return this._configuredAudienceModelPolicy; }
            set { this._configuredAudienceModelPolicy = value; }
        }

        // Check to see if ConfiguredAudienceModelPolicy property is set
        internal bool IsSetConfiguredAudienceModelPolicy()
        {
            return this._configuredAudienceModelPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyExistenceCondition. 
        /// <para>
        /// Use this to prevent unexpected concurrent modification of the policy.
        /// </para>
        /// </summary>
        public PolicyExistenceCondition PolicyExistenceCondition
        {
            get { return this._policyExistenceCondition; }
            set { this._policyExistenceCondition = value; }
        }

        // Check to see if PolicyExistenceCondition property is set
        internal bool IsSetPolicyExistenceCondition()
        {
            return this._policyExistenceCondition != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousPolicyHash. 
        /// <para>
        /// A cryptographic hash of the contents of the policy used to prevent unexpected concurrent
        /// modification of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=64, Max=128)]
        public string PreviousPolicyHash
        {
            get { return this._previousPolicyHash; }
            set { this._previousPolicyHash = value; }
        }

        // Check to see if PreviousPolicyHash property is set
        internal bool IsSetPreviousPolicyHash()
        {
            return this._previousPolicyHash != null;
        }

    }
}