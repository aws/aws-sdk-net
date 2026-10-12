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

namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRelationship operation. Creates a new partner
    /// relationship between accounts.
    /// </summary>
    public partial class CreateRelationshipRequest : AmazonPartnerCentralChannelRequest
    {
        /// <summary>
        /// Gets and sets the property AssociatedAccountId. 
        /// <para>
        /// The AWS account ID to associate in this relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AssociatedAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedAccountId property is set.
        /// </summary>
        internal bool IsSetAssociatedAccountId() => this.AssociatedAccountId != null;

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of association for the relationship (e.g., reseller, distributor).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssociationType AssociationType { get; set; }

        /// <summary>
        /// Checks to see if the AssociationType property is set.
        /// </summary>
        internal bool IsSetAssociationType() => this.AssociationType != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier for the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A human-readable name for the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property ProgramManagementAccountIdentifier. 
        /// <para>
        /// The identifier of the program management account for this relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 1011)]
        public string ProgramManagementAccountIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProgramManagementAccountIdentifier property is set.
        /// </summary>
        internal bool IsSetProgramManagementAccountIdentifier() => this.ProgramManagementAccountIdentifier != null;

        /// <summary>
        /// Gets and sets the property RequestedSupportPlan. 
        /// <para>
        /// The support plan requested for this relationship.
        /// </para>
        /// </summary>
        public SupportPlan RequestedSupportPlan { get; set; }

        /// <summary>
        /// Checks to see if the RequestedSupportPlan property is set.
        /// </summary>
        internal bool IsSetRequestedSupportPlan() => this.RequestedSupportPlan != null;

        /// <summary>
        /// Gets and sets the property ResaleAccountModel. 
        /// <para>
        /// The resale account model for the relationship.
        /// </para>
        /// </summary>
        public ResaleAccountModel ResaleAccountModel { get; set; }

        /// <summary>
        /// Checks to see if the ResaleAccountModel property is set.
        /// </summary>
        internal bool IsSetResaleAccountModel() => this.ResaleAccountModel != null;

        /// <summary>
        /// Gets and sets the property Sector. 
        /// <para>
        /// The business sector for the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Sector Sector { get; set; }

        /// <summary>
        /// Checks to see if the Sector property is set.
        /// </summary>
        internal bool IsSetSector() => this.Sector != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs to associate with the relationship.
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
