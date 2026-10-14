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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure that describes the attachment of a row-level security policy to a resource
    /// for a principal.
    /// </summary>
    public partial class RLSPolicyAttachment
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The identifier for the Data Catalog that contains the attachment. By default, the
        /// account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// A Lake Formation condition, which applies to the row-level security policy attachment
        /// and contains an expression.
        /// </para>
        /// </summary>
        public Condition Condition { get; set; }

        /// <summary>
        /// Checks to see if the Condition property is set.
        /// </summary>
        internal bool IsSetCondition() => this.Condition != null;

        /// <summary>
        /// Gets and sets the property DefaultRLSPolicy. 
        /// <para>
        /// Indicates whether this attachment is the default row-level security policy for the
        /// resource.
        /// </para>
        /// </summary>
        public bool? DefaultRLSPolicy { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRLSPolicy property is set.
        /// </summary>
        internal bool IsSetDefaultRLSPolicy() => this.DefaultRLSPolicy.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the attached row-level security policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal to which the attached policy applies.
        /// </para>
        /// </summary>
        public DataLakePrincipal Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource to which the policy is attached.
        /// </para>
        /// </summary>
        public Resource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;
    }
}
