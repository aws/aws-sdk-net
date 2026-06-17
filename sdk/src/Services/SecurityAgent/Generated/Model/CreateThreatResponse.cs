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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Output for the CreateThreat operation.
    /// </summary>
    public partial class CreateThreatResponse : AmazonWebServiceResponse
    {
        private ThreatAnchorShape _anchor;
        private string _comments;
        private DateTime? _createdAt;
        private ThreatActor _createdBy;
        private List<ThreatEvidenceShape> _evidence = AWSConfigs.InitializeCollections ? new List<ThreatEvidenceShape>() : null;
        private List<string> _impactedAssets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _impactedGoal = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _prerequisites;
        private string _recommendation;
        private ThreatSeverity _severity;
        private string _statement;
        private ThreatStatus _status;
        private List<string> _stride = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _threatAction;
        private string _threatId;
        private string _threatImpact;
        private string _threatJobId;
        private string _threatSource;
        private string _title;
        private DateTime? _updatedAt;
        private ThreatActor _updatedBy;

        /// <summary>
        /// Gets and sets the property Anchor. 
        /// <para>
        /// The DFD element this threat is anchored to.
        /// </para>
        /// </summary>
        public ThreatAnchorShape Anchor
        {
            get { return this._anchor; }
            set { this._anchor = value; }
        }

        // Check to see if Anchor property is set
        internal bool IsSetAnchor()
        {
            return this._anchor != null;
        }

        /// <summary>
        /// Gets and sets the property Comments. 
        /// <para>
        /// Optional customer comment on the threat.
        /// </para>
        /// </summary>
        public string Comments
        {
            get { return this._comments; }
            set { this._comments = value; }
        }

        // Check to see if Comments property is set
        internal bool IsSetComments()
        {
            return this._comments != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the threat was created, in UTC format.
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Who created this threat.
        /// </para>
        /// </summary>
        public ThreatActor CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Evidence. 
        /// <para>
        /// The source code files supporting the threat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ThreatEvidenceShape> Evidence
        {
            get { return this._evidence; }
            set { this._evidence = value; }
        }

        // Check to see if Evidence property is set
        internal bool IsSetEvidence()
        {
            return this._evidence != null && (this._evidence.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImpactedAssets. 
        /// <para>
        /// The specific assets affected by the threat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImpactedAssets
        {
            get { return this._impactedAssets; }
            set { this._impactedAssets = value; }
        }

        // Check to see if ImpactedAssets property is set
        internal bool IsSetImpactedAssets()
        {
            return this._impactedAssets != null && (this._impactedAssets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImpactedGoal. 
        /// <para>
        /// The security goals affected by the threat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImpactedGoal
        {
            get { return this._impactedGoal; }
            set { this._impactedGoal = value; }
        }

        // Check to see if ImpactedGoal property is set
        internal bool IsSetImpactedGoal()
        {
            return this._impactedGoal != null && (this._impactedGoal.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Prerequisites. 
        /// <para>
        /// The conditions required for the threat to be exploitable.
        /// </para>
        /// </summary>
        public string Prerequisites
        {
            get { return this._prerequisites; }
            set { this._prerequisites = value; }
        }

        // Check to see if Prerequisites property is set
        internal bool IsSetPrerequisites()
        {
            return this._prerequisites != null;
        }

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// The recommended mitigation guidance for this threat.
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
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity level of the threat.
        /// </para>
        /// </summary>
        public ThreatSeverity Severity
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
        /// Gets and sets the property Statement. 
        /// <para>
        /// The natural-language threat statement.
        /// </para>
        /// </summary>
        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        // Check to see if Statement property is set
        internal bool IsSetStatement()
        {
            return this._statement != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the threat.
        /// </para>
        /// </summary>
        public ThreatStatus Status
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
        /// Gets and sets the property Stride. 
        /// <para>
        /// The STRIDE categories applicable to this threat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Stride
        {
            get { return this._stride; }
            set { this._stride = value; }
        }

        // Check to see if Stride property is set
        internal bool IsSetStride()
        {
            return this._stride != null && (this._stride.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThreatAction. 
        /// <para>
        /// What the threat source can do.
        /// </para>
        /// </summary>
        public string ThreatAction
        {
            get { return this._threatAction; }
            set { this._threatAction = value; }
        }

        // Check to see if ThreatAction property is set
        internal bool IsSetThreatAction()
        {
            return this._threatAction != null;
        }

        /// <summary>
        /// Gets and sets the property ThreatId. 
        /// <para>
        /// The unique identifier of the created threat.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ThreatId
        {
            get { return this._threatId; }
            set { this._threatId = value; }
        }

        // Check to see if ThreatId property is set
        internal bool IsSetThreatId()
        {
            return this._threatId != null;
        }

        /// <summary>
        /// Gets and sets the property ThreatImpact. 
        /// <para>
        /// The direct consequence of the threat action.
        /// </para>
        /// </summary>
        public string ThreatImpact
        {
            get { return this._threatImpact; }
            set { this._threatImpact = value; }
        }

        // Check to see if ThreatImpact property is set
        internal bool IsSetThreatImpact()
        {
            return this._threatImpact != null;
        }

        /// <summary>
        /// Gets and sets the property ThreatJobId. 
        /// <para>
        /// The unique identifier of the threat model job the threat belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ThreatJobId
        {
            get { return this._threatJobId; }
            set { this._threatJobId = value; }
        }

        // Check to see if ThreatJobId property is set
        internal bool IsSetThreatJobId()
        {
            return this._threatJobId != null;
        }

        /// <summary>
        /// Gets and sets the property ThreatSource. 
        /// <para>
        /// The actor or origin of the threat.
        /// </para>
        /// </summary>
        public string ThreatSource
        {
            get { return this._threatSource; }
            set { this._threatSource = value; }
        }

        // Check to see if ThreatSource property is set
        internal bool IsSetThreatSource()
        {
            return this._threatSource != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short title summarizing the threat.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the threat was last updated, in UTC format.
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

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// Who last updated this threat.
        /// </para>
        /// </summary>
        public ThreatActor UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}