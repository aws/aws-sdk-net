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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGrant operation. Creates a grant for the
    /// specified license. A grant shares the use of license entitlements with a specific
    /// Amazon Web Services account, an organization, or an organizational unit (OU). For
    /// more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/granted-licenses.html">Granted
    /// licenses in License Manager</a> in the <i>License Manager User Guide</i>. <para> Set
    /// the type of grant with the <c>GrantType</c> field: </para> <ul> <li> <para> <c>BuyerGrant</c>
    /// - The default grant type, created by the seller when a customer subscribes to a product.
    /// The seller creates a license for the subscription and a buyer grant for the customer.
    /// With a buyer grant, the customer can use, consume, and distribute the license, according
    /// to the permissions the seller sets in the product contract. </para> </li> <li> <para>
    /// <c>DelegateGrant</c> - A delegate grant gives the grantee read-only visibility into
    /// the licenses and grants that you have distributed to buyers for a product. The grantee
    /// can monitor that activity on your behalf, and can also listen for the related Amazon
    /// EventBridge events. A delegate grant conveys no entitlement to use the licenses, and
    /// its only allowed operation is <c>ListReceivedLicenses</c>. You must create the delegate
    /// grant, and its license, from the same Amazon Web Services account that you used to
    /// create those buyer licenses and grants. </para> </li> </ul>
    /// </summary>
    public partial class CreateGrantRequest : AmazonLicenseManagerRequest
    {
        /// <summary>
        /// Gets and sets the property AllowedOperations. 
        /// <para>
        /// Allowed operations for the grant.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8)]
        public List<string> AllowedOperations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedOperations property is set.
        /// </summary>
        internal bool IsSetAllowedOperations() => this.AllowedOperations != null && (this.AllowedOperations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property GrantName. 
        /// <para>
        /// Grant name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GrantName { get; set; }

        /// <summary>
        /// Checks to see if the GrantName property is set.
        /// </summary>
        internal bool IsSetGrantName() => this.GrantName != null;

        /// <summary>
        /// Gets and sets the property GrantType. 
        /// <para>
        /// The type of grant to create. For more information about each type, see the preceding
        /// description of this operation. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BuyerGrant</c> - The default grant type if you don't specify a value. Conveys
        /// the entitlement to use the license.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DelegateGrant</c> - Gives the grantee read-only visibility into the licenses and
        /// grants that you have distributed to buyers, with no entitlement to use them.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GrantType GrantType { get; set; }

        /// <summary>
        /// Checks to see if the GrantType property is set.
        /// </summary>
        internal bool IsSetGrantType() => this.GrantType != null;

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// Home Region of the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HomeRegion { get; set; }

        /// <summary>
        /// Checks to see if the HomeRegion property is set.
        /// </summary>
        internal bool IsSetHomeRegion() => this.HomeRegion != null;

        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string LicenseArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseArn property is set.
        /// </summary>
        internal bool IsSetLicenseArn() => this.LicenseArn != null;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The options for the grant: the status to set after creation, and how activating the
        /// grant affects other active grants for the same product.
        /// </para>
        /// </summary>
        public Options Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property Principals. 
        /// <para>
        /// The grant principals. You can specify one of the following as an Amazon Resource Name
        /// (ARN):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Web Services account, which includes only the account specified.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// An organizational unit (OU), which includes all accounts in the OU.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// An organization, which will include all accounts across your organization.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> Principals { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Principals property is set.
        /// </summary>
        internal bool IsSetPrincipals() => this.Principals != null && (this.Principals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to add to the grant. For more information about tagging support in License Manager,
        /// see the <a href="https://docs.aws.amazon.com/license-manager/latest/APIReference/API_TagResource.html">TagResource</a>
        /// operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
