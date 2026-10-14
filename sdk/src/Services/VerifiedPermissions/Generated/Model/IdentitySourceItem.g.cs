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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// A structure that defines an identity source.
    /// 
    ///  
    /// <para>
    /// This data type is a response parameter to the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ListIdentitySources.html">ListIdentitySources</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class IdentitySourceItem
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Contains configuration information about an identity source.
        /// </para>
        /// </summary>
        public ConfigurationItem Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time the identity source was originally created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// A structure that contains the details of the associated identity provider (IdP).
        /// </para>
        /// </summary>
        [Obsolete("This attribute has been replaced by configuration.cognitoUserPoolConfiguration")]
        public IdentitySourceItemDetails Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property IdentitySourceId. 
        /// <para>
        /// The unique identifier of the identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string IdentitySourceId { get; set; }

        /// <summary>
        /// Checks to see if the IdentitySourceId property is set.
        /// </summary>
        internal bool IsSetIdentitySourceId() => this.IdentitySourceId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date and time the identity source was most recently updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// The identifier of the policy store that contains the identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string PolicyStoreId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyStoreId property is set.
        /// </summary>
        internal bool IsSetPolicyStoreId() => this.PolicyStoreId != null;

        /// <summary>
        /// Gets and sets the property PrincipalEntityType. 
        /// <para>
        /// The Cedar entity type of the principals returned from the IdP associated with this
        /// identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 200)]
        public string PrincipalEntityType { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalEntityType property is set.
        /// </summary>
        internal bool IsSetPrincipalEntityType() => this.PrincipalEntityType != null;
    }
}
