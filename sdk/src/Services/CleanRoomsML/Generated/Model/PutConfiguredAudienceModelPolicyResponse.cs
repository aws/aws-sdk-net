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
    /// This is the response object from the PutConfiguredAudienceModelPolicy operation.
    /// </summary>
    public partial class PutConfiguredAudienceModelPolicyResponse : AmazonWebServiceResponse
    {
        private string _configuredAudienceModelPolicy;
        private string _policyHash;

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
        /// Gets and sets the property PolicyHash. 
        /// <para>
        /// A cryptographic hash of the contents of the policy used to prevent unexpected concurrent
        /// modification of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=64, Max=128)]
        public string PolicyHash
        {
            get { return this._policyHash; }
            set { this._policyHash = value; }
        }

        // Check to see if PolicyHash property is set
        internal bool IsSetPolicyHash()
        {
            return this._policyHash != null;
        }

    }
}