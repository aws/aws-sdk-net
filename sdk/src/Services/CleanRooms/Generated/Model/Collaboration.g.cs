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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The multi-party data share environment. The collaboration contains metadata about
    /// its purpose and participants.
    /// </summary>
    public partial class Collaboration
    {
        /// <summary>
        /// Gets and sets the property AllowedResultRegions. 
        /// <para>
        /// The Amazon Web Services Regions where collaboration query results can be stored. Returns
        /// the list of Region identifiers that were specified when the collaboration was created.
        /// This list is used to enforce regional storage policies and compliance requirements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedResultRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedResultRegions property is set.
        /// </summary>
        internal bool IsSetAllowedResultRegions() => this.AllowedResultRegions != null && (this.AllowedResultRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AnalyticsEngine. 
        /// <para>
        ///  The analytics engine for the collaboration.
        /// </para>
        ///  <note> 
        /// <para>
        /// After July 16, 2025, the <c>CLEAN_ROOMS_SQL</c> parameter will no longer be available.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public AnalyticsEngine AnalyticsEngine { get; set; }

        /// <summary>
        /// Checks to see if the AnalyticsEngine property is set.
        /// </summary>
        internal bool IsSetAnalyticsEngine() => this.AnalyticsEngine != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique ARN for the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AutoApprovedChangeTypes. 
        /// <para>
        /// The types of change requests that are automatically approved for this collaboration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoApprovedChangeTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AutoApprovedChangeTypes property is set.
        /// </summary>
        internal bool IsSetAutoApprovedChangeTypes() => this.AutoApprovedChangeTypes != null && (this.AutoApprovedChangeTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time when the collaboration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatorAccountId. 
        /// <para>
        /// The identifier used to reference members of the collaboration. Currently only supports
        /// Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string CreatorAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorAccountId property is set.
        /// </summary>
        internal bool IsSetCreatorAccountId() => this.CreatorAccountId != null;

        /// <summary>
        /// Gets and sets the property CreatorDisplayName. 
        /// <para>
        /// A display name of the collaboration creator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string CreatorDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the CreatorDisplayName property is set.
        /// </summary>
        internal bool IsSetCreatorDisplayName() => this.CreatorDisplayName != null;

        /// <summary>
        /// Gets and sets the property DataEncryptionMetadata. 
        /// <para>
        /// The settings for client-side encryption for cryptographic computing.
        /// </para>
        /// </summary>
        public DataEncryptionMetadata DataEncryptionMetadata { get; set; }

        /// <summary>
        /// Checks to see if the DataEncryptionMetadata property is set.
        /// </summary>
        internal bool IsSetDataEncryptionMetadata() => this.DataEncryptionMetadata != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the collaboration provided by the collaboration owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID for the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IsMetricsEnabled. 
        /// <para>
        /// An indicator as to whether metrics are enabled for the collaboration.
        /// </para>
        ///  
        /// <para>
        /// When <c>true</c>, collaboration members can opt in to Amazon CloudWatch metrics for
        /// their membership queries.
        /// </para>
        /// </summary>
        public bool? IsMetricsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsMetricsEnabled property is set.
        /// </summary>
        internal bool IsSetIsMetricsEnabled() => this.IsMetricsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property JobLogStatus. 
        /// <para>
        /// An indicator as to whether job logging has been enabled or disabled for the collaboration.
        /// 
        /// </para>
        ///  
        /// <para>
        /// When <c>ENABLED</c>, Clean Rooms logs details about jobs run within this collaboration
        /// and those logs can be viewed in Amazon CloudWatch Logs. The default value is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public CollaborationJobLogStatus JobLogStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobLogStatus property is set.
        /// </summary>
        internal bool IsSetJobLogStatus() => this.JobLogStatus != null;

        /// <summary>
        /// Gets and sets the property MemberStatus. 
        /// <para>
        /// The status of a member in a collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemberStatus MemberStatus { get; set; }

        /// <summary>
        /// Checks to see if the MemberStatus property is set.
        /// </summary>
        internal bool IsSetMemberStatus() => this.MemberStatus != null;

        /// <summary>
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// The unique ARN for your membership within the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public string MembershipArn { get; set; }

        /// <summary>
        /// Checks to see if the MembershipArn property is set.
        /// </summary>
        internal bool IsSetMembershipArn() => this.MembershipArn != null;

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// The unique ID for your membership within the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string MembershipId { get; set; }

        /// <summary>
        /// Checks to see if the MembershipId property is set.
        /// </summary>
        internal bool IsSetMembershipId() => this.MembershipId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A human-readable identifier provided by the collaboration owner. Display names are
        /// not unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property QueryLogStatus. 
        /// <para>
        /// An indicator as to whether query logging has been enabled or disabled for the collaboration.
        /// </para>
        ///  
        /// <para>
        /// When <c>ENABLED</c>, Clean Rooms logs details about queries run within this collaboration
        /// and those logs can be viewed in Amazon CloudWatch Logs. The default value is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CollaborationQueryLogStatus QueryLogStatus { get; set; }

        /// <summary>
        /// Checks to see if the QueryLogStatus property is set.
        /// </summary>
        internal bool IsSetQueryLogStatus() => this.QueryLogStatus != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the collaboration metadata was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
