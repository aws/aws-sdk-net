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
    /// Summary information about a partner relationship.
    /// </summary>
    public partial class RelationshipSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociatedAccountId. 
        /// <para>
        /// The AWS account ID associated in this relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AssociatedAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedAccountId property is set.
        /// </summary>
        internal bool IsSetAssociatedAccountId() => this.AssociatedAccountId != null;

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of association for the relationship.
        /// </para>
        /// </summary>
        public AssociationType AssociationType { get; set; }

        /// <summary>
        /// Checks to see if the AssociationType property is set.
        /// </summary>
        internal bool IsSetAssociationType() => this.AssociationType != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier associated with the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the relationship was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 16)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ProgramManagementAccountId. 
        /// <para>
        /// The identifier of the program management account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 17, Max = 17)]
        public string ProgramManagementAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ProgramManagementAccountId property is set.
        /// </summary>
        internal bool IsSetProgramManagementAccountId() => this.ProgramManagementAccountId != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The current revision number of the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;

        /// <summary>
        /// Gets and sets the property Sector. 
        /// <para>
        /// The business sector for the relationship.
        /// </para>
        /// </summary>
        public Sector Sector { get; set; }

        /// <summary>
        /// Checks to see if the Sector property is set.
        /// </summary>
        internal bool IsSetSector() => this.Sector != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date of the relationship.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the relationship was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
