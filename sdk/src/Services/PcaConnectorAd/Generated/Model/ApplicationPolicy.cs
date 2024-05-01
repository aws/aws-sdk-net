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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
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
namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Application policies describe what the certificate can be used for.
    /// </summary>
    public partial class ApplicationPolicy
    {
        private string _policyObjectIdentifier;
        private ApplicationPolicyType _policyType;

        /// <summary>
        /// Gets and sets the property PolicyObjectIdentifier. 
        /// <para>
        /// The object identifier (OID) of an application policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string PolicyObjectIdentifier
        {
            get { return this._policyObjectIdentifier; }
            set { this._policyObjectIdentifier = value; }
        }

        // Check to see if PolicyObjectIdentifier property is set
        internal bool IsSetPolicyObjectIdentifier()
        {
            return this._policyObjectIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of application policy
        /// </para>
        /// </summary>
        public ApplicationPolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

    }
}