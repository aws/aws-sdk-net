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
    /// Summary information about a partner relationship.
    /// </summary>
    public partial class RelationshipSummary
    {
        private string _arn;
        private string _associatedAccountId;
        private AssociationType _associationType;
        private string _catalog;
        private DateTime? _createdAt;
        private string _displayName;
        private string _id;
        private string _programManagementAccountId;
        private string _revision;
        private Sector _sector;
        private DateTime? _startDate;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedAccountId. 
        /// <para>
        /// The AWS account ID associated in this relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
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
        /// The type of association for the relationship.
        /// </para>
        /// </summary>
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
        /// The catalog identifier associated with the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the relationship was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=16)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramManagementAccountId. 
        /// <para>
        /// The identifier of the program management account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=17, Max=17)]
        public string ProgramManagementAccountId
        {
            get { return this._programManagementAccountId; }
            set { this._programManagementAccountId = value; }
        }

        // Check to see if ProgramManagementAccountId property is set
        internal bool IsSetProgramManagementAccountId()
        {
            return this._programManagementAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The current revision number of the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

        /// <summary>
        /// Gets and sets the property Sector. 
        /// <para>
        /// The business sector for the relationship.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date of the relationship.
        /// </para>
        /// </summary>
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the relationship was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}