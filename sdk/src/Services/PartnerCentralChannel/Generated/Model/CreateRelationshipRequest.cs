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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
    /// Container for the parameters to the CreateRelationship operation.
    /// Creates a new partner relationship between accounts.
    /// </summary>
    public partial class CreateRelationshipRequest : AmazonPartnerCentralChannelRequest
    {
        private string _associatedAccountId;
        private AssociationType _associationType;
        private string _catalog;
        private string _clientToken;
        private string _displayName;
        private string _programManagementAccountIdentifier;
        private SupportPlan _requestedSupportPlan;
        private ResaleAccountModel _resaleAccountModel;
        private Sector _sector;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedAccountId. 
        /// <para>
        /// The AWS account ID to associate in this relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AssociatedAccountId
        {
            get { return this._associatedAccountId; }
            set { this._associatedAccountId = value; }
        }

        // Check to see if AssociatedAccountId property is set
        internal bool IsSetAssociatedAccountId()
        {
            return this._associatedAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of association for the relationship (e.g., reseller, distributor).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssociationType AssociationType
        {
            get { return this._associationType; }
            set { this._associationType = value; }
        }

        // Check to see if AssociationType property is set
        internal bool IsSetAssociationType()
        {
            return this._associationType != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier for the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A human-readable name for the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramManagementAccountIdentifier. 
        /// <para>
        /// The identifier of the program management account for this relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=1011)]
        public string ProgramManagementAccountIdentifier
        {
            get { return this._programManagementAccountIdentifier; }
            set { this._programManagementAccountIdentifier = value; }
        }

        // Check to see if ProgramManagementAccountIdentifier property is set
        internal bool IsSetProgramManagementAccountIdentifier()
        {
            return this._programManagementAccountIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedSupportPlan. 
        /// <para>
        /// The support plan requested for this relationship.
        /// </para>
        /// </summary>
        public SupportPlan RequestedSupportPlan
        {
            get { return this._requestedSupportPlan; }
            set { this._requestedSupportPlan = value; }
        }

        // Check to see if RequestedSupportPlan property is set
        internal bool IsSetRequestedSupportPlan()
        {
            return this._requestedSupportPlan != null;
        }

        /// <summary>
        /// Gets and sets the property ResaleAccountModel. 
        /// <para>
        /// The resale account model for the relationship.
        /// </para>
        /// </summary>
        public ResaleAccountModel ResaleAccountModel
        {
            get { return this._resaleAccountModel; }
            set { this._resaleAccountModel = value; }
        }

        // Check to see if ResaleAccountModel property is set
        internal bool IsSetResaleAccountModel()
        {
            return this._resaleAccountModel != null;
        }

        /// <summary>
        /// Gets and sets the property Sector. 
        /// <para>
        /// The business sector for the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Sector Sector
        {
            get { return this._sector; }
            set { this._sector = value; }
        }

        // Check to see if Sector property is set
        internal bool IsSetSector()
        {
            return this._sector != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs to associate with the relationship.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}