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

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Modifies the <c>CertPolicyId</c> of a <c>PolicyInformation</c> object with a qualifier.
    /// Amazon Web Services Private CA supports the certification practice statement (CPS)
    /// qualifier.
    /// </summary>
    public partial class PolicyQualifierInfo
    {
        /// <summary>
        /// Gets and sets the property PolicyQualifierId. 
        /// <para>
        /// Identifies the qualifier modifying a <c>CertPolicyId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyQualifierId PolicyQualifierId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyQualifierId property is set.
        /// </summary>
        internal bool IsSetPolicyQualifierId() => this.PolicyQualifierId != null;

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// Defines the qualifier type. Amazon Web Services Private CA supports the use of a URI
        /// for a CPS qualifier in this field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Qualifier Qualifier { get; set; }

        /// <summary>
        /// Checks to see if the Qualifier property is set.
        /// </summary>
        internal bool IsSetQualifier() => this.Qualifier != null;
    }
}
