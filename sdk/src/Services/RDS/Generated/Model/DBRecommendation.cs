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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The recommendation for your DB instances, DB clusters, and DB parameter groups.
    /// </summary>
    public partial class DBRecommendation
    {
        private string _additionalInfo;
        private string _category;
        private DateTime? _createdTime;
        private string _description;
        private string _detection;
        private string _impact;
        private IssueDetails _issueDetails;
        private List<DocLink> _links = AWSConfigs.InitializeCollections ? new List<DocLink>() : null;
        private string _reason;
        private string _recommendation;
        private string _recommendationId;
        private List<RecommendedAction> _recommendedActions = AWSConfigs.InitializeCollections ? new List<RecommendedAction>() : null;
        private string _resourceArn;
        private string _severity;
        private string _source;
        private string _status;
        private string _typeDetection;
        private string _typeId;
        private string _typeRecommendation;
        private DateTime? _updatedTime;

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Additional information about the recommendation. The information might contain markdown.
        /// </para>
        /// </summary>
        public string AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the recommendation.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>performance efficiency</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>security</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>reliability</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cost optimization</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>operational excellence</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sustainability</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time when the recommendation was created. For example, <c>2023-09-28T01:13:53.931000+00:00</c>.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A detailed description of the recommendation. The description might contain markdown.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Detection. 
        /// <para>
        /// A short description of the issue identified for this recommendation. The description
        /// might contain markdown.
        /// </para>
        /// </summary>
        public string Detection
        {
            get { return this._detection; }
            set { this._detection = value; }
        }

        // Check to see if Detection property is set
        internal bool IsSetDetection()
        {
            return this._detection != null;
        }

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// A short description that explains the possible impact of an issue.
        /// </para>
        /// </summary>
        public string Impact
        {
            get { return this._impact; }
            set { this._impact = value; }
        }

        // Check to see if Impact property is set
        internal bool IsSetImpact()
        {
            return this._impact != null;
        }

        /// <summary>
        /// Gets and sets the property IssueDetails. 
        /// <para>
        /// Details of the issue that caused the recommendation.
        /// </para>
        /// </summary>
        public IssueDetails IssueDetails
        {
            get { return this._issueDetails; }
            set { this._issueDetails = value; }
        }

        // Check to see if IssueDetails property is set
        internal bool IsSetIssueDetails()
        {
            return this._issueDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Links. 
        /// <para>
        /// A link to documentation that provides additional information about the recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocLink> Links
        {
            get { return this._links; }
            set { this._links = value; }
        }

        // Check to see if Links property is set
        internal bool IsSetLinks()
        {
            return this._links != null && (this._links.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason why this recommendation was created. The information might contain markdown.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// A short description of the recommendation to resolve an issue. The description might
        /// contain markdown.
        /// </para>
        /// </summary>
        public string Recommendation
        {
            get { return this._recommendation; }
            set { this._recommendation = value; }
        }

        // Check to see if Recommendation property is set
        internal bool IsSetRecommendation()
        {
            return this._recommendation != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The unique identifier of the recommendation.
        /// </para>
        /// </summary>
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        // Check to see if RecommendationId property is set
        internal bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedActions. 
        /// <para>
        /// A list of recommended actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendedAction> RecommendedActions
        {
            get { return this._recommendedActions; }
            set { this._recommendedActions = value; }
        }

        // Check to see if RecommendedActions property is set
        internal bool IsSetRecommendedActions()
        {
            return this._recommendedActions != null && (this._recommendedActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the RDS resource associated with the recommendation.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity level of the recommendation. The severity level can help you decide the
        /// urgency with which to address the recommendation.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>high</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>medium</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>low</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>informational</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon Web Services service that generated the recommendations.
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the recommendation.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>active</c> - The recommendations which are ready for you to apply.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c> - The applied or scheduled recommendations which are in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resolved</c> - The recommendations which are completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dismissed</c> - The recommendations that you dismissed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TypeDetection. 
        /// <para>
        /// A short description of the recommendation type. The description might contain markdown.
        /// </para>
        /// </summary>
        public string TypeDetection
        {
            get { return this._typeDetection; }
            set { this._typeDetection = value; }
        }

        // Check to see if TypeDetection property is set
        internal bool IsSetTypeDetection()
        {
            return this._typeDetection != null;
        }

        /// <summary>
        /// Gets and sets the property TypeId. 
        /// <para>
        /// A value that indicates the type of recommendation. This value determines how the description
        /// is rendered.
        /// </para>
        /// </summary>
        public string TypeId
        {
            get { return this._typeId; }
            set { this._typeId = value; }
        }

        // Check to see if TypeId property is set
        internal bool IsSetTypeId()
        {
            return this._typeId != null;
        }

        /// <summary>
        /// Gets and sets the property TypeRecommendation. 
        /// <para>
        /// A short description that summarizes the recommendation to fix all the issues of the
        /// recommendation type. The description might contain markdown.
        /// </para>
        /// </summary>
        public string TypeRecommendation
        {
            get { return this._typeRecommendation; }
            set { this._typeRecommendation = value; }
        }

        // Check to see if TypeRecommendation property is set
        internal bool IsSetTypeRecommendation()
        {
            return this._typeRecommendation != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// The time when the recommendation was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTime
        {
            get { return this._updatedTime; }
            set { this._updatedTime = value; }
        }

        // Check to see if UpdatedTime property is set
        internal bool IsSetUpdatedTime()
        {
            return this._updatedTime.HasValue; 
        }

    }
}