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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
    /// Container for the parameters to the CreateCollaboration operation.
    /// Creates a new collaboration.
    /// </summary>
    public partial class CreateCollaborationRequest : AmazonCleanRoomsRequest
    {
        private AnalyticsEngine _analyticsEngine;
        private List<string> _autoApprovedChangeRequestTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _creatorDisplayName;
        private List<string> _creatorMemberAbilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MLMemberAbilities _creatormlMemberAbilities;
        private PaymentConfiguration _creatorPaymentConfiguration;
        private DataEncryptionMetadata _dataEncryptionMetadata;
        private string _description;
        private CollaborationJobLogStatus _jobLogStatus;
        private List<MemberSpecification> _members = AWSConfigs.InitializeCollections ? new List<MemberSpecification>() : null;
        private string _name;
        private CollaborationQueryLogStatus _queryLogStatus;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        public AnalyticsEngine AnalyticsEngine
        {
            get { return this._analyticsEngine; }
            set { this._analyticsEngine = value; }
        }

        // Check to see if AnalyticsEngine property is set
        internal bool IsSetAnalyticsEngine()
        {
            return this._analyticsEngine != null;
        }

        /// <summary>
        /// Gets and sets the property AutoApprovedChangeRequestTypes. 
        /// <para>
        /// The types of change requests that are automatically approved for this collaboration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoApprovedChangeRequestTypes
        {
            get { return this._autoApprovedChangeRequestTypes; }
            set { this._autoApprovedChangeRequestTypes = value; }
        }

        // Check to see if AutoApprovedChangeRequestTypes property is set
        internal bool IsSetAutoApprovedChangeRequestTypes()
        {
            return this._autoApprovedChangeRequestTypes != null && (this._autoApprovedChangeRequestTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatorDisplayName. 
        /// <para>
        /// The display name of the collaboration creator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string CreatorDisplayName
        {
            get { return this._creatorDisplayName; }
            set { this._creatorDisplayName = value; }
        }

        // Check to see if CreatorDisplayName property is set
        internal bool IsSetCreatorDisplayName()
        {
            return this._creatorDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatorMemberAbilities. 
        /// <para>
        /// The abilities granted to the collaboration creator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> CreatorMemberAbilities
        {
            get { return this._creatorMemberAbilities; }
            set { this._creatorMemberAbilities = value; }
        }

        // Check to see if CreatorMemberAbilities property is set
        internal bool IsSetCreatorMemberAbilities()
        {
            return this._creatorMemberAbilities != null && (this._creatorMemberAbilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatorMLMemberAbilities. 
        /// <para>
        /// The ML abilities granted to the collaboration creator.
        /// </para>
        /// </summary>
        public MLMemberAbilities CreatorMLMemberAbilities
        {
            get { return this._creatormlMemberAbilities; }
            set { this._creatormlMemberAbilities = value; }
        }

        // Check to see if CreatorMLMemberAbilities property is set
        internal bool IsSetCreatorMLMemberAbilities()
        {
            return this._creatormlMemberAbilities != null;
        }

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
        public PaymentConfiguration CreatorPaymentConfiguration
        {
            get { return this._creatorPaymentConfiguration; }
            set { this._creatorPaymentConfiguration = value; }
        }

        // Check to see if CreatorPaymentConfiguration property is set
        internal bool IsSetCreatorPaymentConfiguration()
        {
            return this._creatorPaymentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DataEncryptionMetadata. 
        /// <para>
        /// The settings for client-side encryption with Cryptographic Computing for Clean Rooms.
        /// </para>
        /// </summary>
        public DataEncryptionMetadata DataEncryptionMetadata
        {
            get { return this._dataEncryptionMetadata; }
            set { this._dataEncryptionMetadata = value; }
        }

        // Check to see if DataEncryptionMetadata property is set
        internal bool IsSetDataEncryptionMetadata()
        {
            return this._dataEncryptionMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the collaboration provided by the collaboration owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

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
        public CollaborationJobLogStatus JobLogStatus
        {
            get { return this._jobLogStatus; }
            set { this._jobLogStatus = value; }
        }

        // Check to see if JobLogStatus property is set
        internal bool IsSetJobLogStatus()
        {
            return this._jobLogStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Members. 
        /// <para>
        /// A list of initial members, not including the creator. This list is immutable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=9)]
        public List<MemberSpecification> Members
        {
            get { return this._members; }
            set { this._members = value; }
        }

        // Check to see if Members property is set
        internal bool IsSetMembers()
        {
            return this._members != null && (this._members.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name for a collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

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
        [AWSProperty(Required=true)]
        public CollaborationQueryLogStatus QueryLogStatus
        {
            get { return this._queryLogStatus; }
            set { this._queryLogStatus = value; }
        }

        // Check to see if QueryLogStatus property is set
        internal bool IsSetQueryLogStatus()
        {
            return this._queryLogStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional label that you can assign to a resource when you create it. Each tag consists
        /// of a key and an optional value, both of which you define. When you use tagging, you
        /// can also use tag-based access control in IAM policies to control access to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
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