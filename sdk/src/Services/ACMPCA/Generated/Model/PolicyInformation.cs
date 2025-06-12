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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
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
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Defines the X.509 <c>CertificatePolicies</c> extension.
    /// </summary>
    public partial class PolicyInformation
    {
        private string _certPolicyId;
        private List<PolicyQualifierInfo> _policyQualifiers = AWSConfigs.InitializeCollections ? new List<PolicyQualifierInfo>() : null;

        /// <summary>
        /// Gets and sets the property CertPolicyId. 
        /// <para>
        /// Specifies the object identifier (OID) of the certificate policy under which the certificate
        /// was issued. For more information, see NIST's definition of <a href="https://csrc.nist.gov/glossary/term/Object_Identifier">Object
        /// Identifier (OID)</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
        public string CertPolicyId
        {
            get { return this._certPolicyId; }
            set { this._certPolicyId = value; }
        }

        // Check to see if CertPolicyId property is set
        internal bool IsSetCertPolicyId()
        {
            return this._certPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyQualifiers. 
        /// <para>
        /// Modifies the given <c>CertPolicyId</c> with a qualifier. Amazon Web Services Private
        /// CA supports the certification practice statement (CPS) qualifier.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<PolicyQualifierInfo> PolicyQualifiers
        {
            get { return this._policyQualifiers; }
            set { this._policyQualifiers = value; }
        }

        // Check to see if PolicyQualifiers property is set
        internal bool IsSetPolicyQualifiers()
        {
            return this._policyQualifiers != null && (this._policyQualifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}