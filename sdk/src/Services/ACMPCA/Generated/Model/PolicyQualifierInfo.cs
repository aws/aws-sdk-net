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

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Modifies the <code>CertPolicyId</code> of a <code>PolicyInformation</code> object
    /// with a qualifier. Amazon Web Services Private CA supports the certification practice
    /// statement (CPS) qualifier.
    /// </summary>
    public partial class PolicyQualifierInfo
    {
        private PolicyQualifierId _policyQualifierId;
        private Qualifier _qualifier;

        /// <summary>
        /// Gets and sets the property PolicyQualifierId. 
        /// <para>
        /// Identifies the qualifier modifying a <code>CertPolicyId</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyQualifierId PolicyQualifierId
        {
            get { return this._policyQualifierId; }
            set { this._policyQualifierId = value; }
        }

        // Check to see if PolicyQualifierId property is set
        internal bool IsSetPolicyQualifierId()
        {
            return this._policyQualifierId != null;
        }

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// Defines the qualifier type. Amazon Web Services Private CA supports the use of a URI
        /// for a CPS qualifier in this field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Qualifier Qualifier
        {
            get { return this._qualifier; }
            set { this._qualifier = value; }
        }

        // Check to see if Qualifier property is set
        internal bool IsSetQualifier()
        {
            return this._qualifier != null;
        }

    }
}