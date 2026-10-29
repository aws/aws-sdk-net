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

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Contains information about a grant.
    /// </summary>
    public partial class GrantListEntry
    {
        /// <summary>
        /// Gets and sets the property Constraints. 
        /// <para>
        /// The constraints on the grant, such as encryption context pairs or a SourceArn, that
        /// restrict the subsequent operations the grant allows.
        /// </para>
        /// </summary>
        public GrantConstraints Constraints { get; set; }

        /// <summary>
        /// Checks to see if the Constraints property is set.
        /// </summary>
        internal bool IsSetConstraints() => this.Constraints != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the grant was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property GrantId. 
        /// <para>
        /// The unique identifier for the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string GrantId { get; set; }

        /// <summary>
        /// Checks to see if the GrantId property is set.
        /// </summary>
        internal bool IsSetGrantId() => this.GrantId != null;

        /// <summary>
        /// Gets and sets the property GranteePrincipal. 
        /// <para>
        /// The identity that gets the permissions in the grant.
        /// </para>
        ///  
        /// <para>
        /// When a grant is created with the <c>GranteePrincipal</c> field, the <c>ListGrants</c>
        /// response usually contains the user or role designated as the grantee principal in
        /// the grant. However, if the grantee principal is an Amazon Web Services service, the
        /// <c>GranteePrincipal</c> field contains an Amazon Web Services <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#principal-services">service
        /// principal</a>, which might correspond to several different grantee principals, such
        /// as an IAM user, IAM role, or Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string GranteePrincipal { get; set; }

        /// <summary>
        /// Checks to see if the GranteePrincipal property is set.
        /// </summary>
        internal bool IsSetGranteePrincipal() => this.GranteePrincipal != null;

        /// <summary>
        /// Gets and sets the property GranteeServicePrincipal. 
        /// <para>
        /// The Amazon Web Services <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#principal-services">service
        /// principal</a> that gets the permissions in the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string GranteeServicePrincipal { get; set; }

        /// <summary>
        /// Checks to see if the GranteeServicePrincipal property is set.
        /// </summary>
        internal bool IsSetGranteeServicePrincipal() => this.GranteeServicePrincipal != null;

        /// <summary>
        /// Gets and sets the property IssuingAccount. 
        /// <para>
        /// The Amazon Web Services account under which the grant was issued.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string IssuingAccount { get; set; }

        /// <summary>
        /// Checks to see if the IssuingAccount property is set.
        /// </summary>
        internal bool IsSetIssuingAccount() => this.IssuingAccount != null;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The unique identifier for the KMS key to which the grant applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name that identifies the grant. If a name was provided in the <a>CreateGrant</a>
        /// request, that name is returned. Otherwise this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Operations. 
        /// <para>
        /// The list of operations permitted by the grant.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Operations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Operations property is set.
        /// </summary>
        internal bool IsSetOperations() => this.Operations != null && (this.Operations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RetiringPrincipal. 
        /// <para>
        /// The principal that can retire the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RetiringPrincipal { get; set; }

        /// <summary>
        /// Checks to see if the RetiringPrincipal property is set.
        /// </summary>
        internal bool IsSetRetiringPrincipal() => this.RetiringPrincipal != null;

        /// <summary>
        /// Gets and sets the property RetiringServicePrincipal. 
        /// <para>
        /// The Amazon Web Services <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#principal-services">service
        /// principal</a> that can retire the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RetiringServicePrincipal { get; set; }

        /// <summary>
        /// Checks to see if the RetiringServicePrincipal property is set.
        /// </summary>
        internal bool IsSetRetiringServicePrincipal() => this.RetiringServicePrincipal != null;
    }
}
