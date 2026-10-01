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
    /// Container for the parameters to the CreateCollaboration operation. Creates a new collaboration.
    /// </summary>
    public partial class CreateCollaborationRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property AllowedResultRegions. 
        /// <para>
        /// The Amazon Web Services Regions where collaboration query results can be stored. When
        /// specified, results can only be written to these Regions. This parameter enables you
        /// to meet your compliance and data governance requirements, and implement regional data
        /// governance policies.
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
        ///  The analytics engine.
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
        /// Gets and sets the property AutoApprovedChangeRequestTypes. 
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
        public List<string> AutoApprovedChangeRequestTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AutoApprovedChangeRequestTypes property is set.
        /// </summary>
        internal bool IsSetAutoApprovedChangeRequestTypes() => this.AutoApprovedChangeRequestTypes != null && (this.AutoApprovedChangeRequestTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatorDisplayName. 
        /// <para>
        /// The display name of the collaboration creator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string CreatorDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the CreatorDisplayName property is set.
        /// </summary>
        internal bool IsSetCreatorDisplayName() => this.CreatorDisplayName != null;

        /// <summary>
        /// Gets and sets the property CreatorMLMemberAbilities. 
        /// <para>
        /// The ML abilities granted to the collaboration creator.
        /// </para>
        /// </summary>
        public MLMemberAbilities CreatorMLMemberAbilities { get; set; }

        /// <summary>
        /// Checks to see if the CreatorMLMemberAbilities property is set.
        /// </summary>
        internal bool IsSetCreatorMLMemberAbilities() => this.CreatorMLMemberAbilities != null;

        /// <summary>
        /// Gets and sets the property CreatorMemberAbilities. 
        /// <para>
        /// The abilities granted to the collaboration creator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> CreatorMemberAbilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CreatorMemberAbilities property is set.
        /// </summary>
        internal bool IsSetCreatorMemberAbilities() => this.CreatorMemberAbilities != null && (this.CreatorMemberAbilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatorPaymentConfiguration. 
        /// <para>
        /// The collaboration creator's payment responsibilities set by the collaboration creator.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the collaboration creator hasn't specified anyone as the member paying for query
        /// compute costs, then the member who can query is the default payer.
        /// </para>
        /// </summary>
        public PaymentConfiguration CreatorPaymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CreatorPaymentConfiguration property is set.
        /// </summary>
        internal bool IsSetCreatorPaymentConfiguration() => this.CreatorPaymentConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataEncryptionMetadata. 
        /// <para>
        /// The settings for client-side encryption with Cryptographic Computing for Clean Rooms.
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
        /// Gets and sets the property IsMetricsEnabled. 
        /// <para>
        /// An indicator as to whether metrics have been enabled or disabled for the collaboration.
        /// </para>
        ///  
        /// <para>
        /// When <c>true</c>, collaboration members can opt in to Amazon CloudWatch metrics for
        /// their membership queries. The default value is <c>false</c>.
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
        /// Specifies whether job logs are enabled for this collaboration. 
        /// </para>
        ///  
        /// <para>
        /// When <c>ENABLED</c>, Clean Rooms logs details about jobs run within this collaboration;
        /// those logs can be viewed in Amazon CloudWatch Logs. The default value is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public CollaborationJobLogStatus JobLogStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobLogStatus property is set.
        /// </summary>
        internal bool IsSetJobLogStatus() => this.JobLogStatus != null;

        /// <summary>
        /// Gets and sets the property Members. 
        /// <para>
        /// A list of initial members, not including the creator. This list is immutable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public List<MemberSpecification> Members { get; set; } = AWSConfigs.InitializeCollections ? new List<MemberSpecification>() : null;

        /// <summary>
        /// Checks to see if the Members property is set.
        /// </summary>
        internal bool IsSetMembers() => this.Members != null && (this.Members.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name for a collaboration.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional label that you can assign to a resource when you create it. Each tag consists
        /// of a key and an optional value, both of which you define. When you use tagging, you
        /// can also use tag-based access control in IAM policies to control access to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
