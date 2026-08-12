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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Summary of an agent optimization recommendation returned by list operations.
    /// </summary>
    public partial class AgentRecommendationSummary
    {
        private List<string> _applications = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _awsServices = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _businessUnits = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private Effort _effort;
        private ImpactCategory _impact;
        private DateTime? _lastModifiedAt;
        private string _lastModifiedBy;
        private int? _numberOfResources;
        private Pillar _pillar;
        private Priority _priority;
        private string _profileArn;
        private string _recommendationArn;
        private Roi _roi;
        private RecommendationState _state;
        private RecommendationStatus _status;
        private string _title;
        private RecommendationType _type;
        private string _updateReason;

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// The applications that the recommendation targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Applications
        {
            get { return this._applications; }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications != null && (this._applications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AwsServices. 
        /// <para>
        /// The Amazon Web Services services that the recommendation applies to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsServices
        {
            get { return this._awsServices; }
            set { this._awsServices = value; }
        }

        // Check to see if AwsServices property is set
        internal bool IsSetAwsServices()
        {
            return this._awsServices != null && (this._awsServices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BusinessUnits. 
        /// <para>
        /// The business units that own the affected resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BusinessUnits
        {
            get { return this._businessUnits; }
            set { this._businessUnits = value; }
        }

        // Check to see if BusinessUnits property is set
        internal bool IsSetBusinessUnits()
        {
            return this._businessUnits != null && (this._businessUnits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the recommendation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The identifier of the user or system that created this recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string CreatedBy
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=80, Max=500)]
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
        /// Gets and sets the property Effort. 
        /// <para>
        /// The effort required to implement the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Effort Effort
        {
            get { return this._effort; }
            set { this._effort = value; }
        }

        // Check to see if Effort property is set
        internal bool IsSetEffort()
        {
            return this._effort != null;
        }

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// The severity of the recommendation's impact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImpactCategory Impact
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
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The timestamp when the recommendation was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAt
        {
            get { return this._lastModifiedAt; }
            set { this._lastModifiedAt = value; }
        }

        // Check to see if LastModifiedAt property is set
        internal bool IsSetLastModifiedAt()
        {
            return this._lastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The identifier of the user or system that last modified this recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfResources. 
        /// <para>
        /// The number of Amazon Web Services resources this recommendation affects.
        /// </para>
        /// </summary>
        public int? NumberOfResources
        {
            get { return this._numberOfResources; }
            set { this._numberOfResources = value; }
        }

        // Check to see if NumberOfResources property is set
        internal bool IsSetNumberOfResources()
        {
            return this._numberOfResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pillar. 
        /// <para>
        /// The Well-Architected Tool Framework pillar that the recommendation addresses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Pillar Pillar
        {
            get { return this._pillar; }
            set { this._pillar = value; }
        }

        // Check to see if Pillar property is set
        internal bool IsSetPillar()
        {
            return this._pillar != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Priority Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the associated profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string ProfileArn
        {
            get { return this._profileArn; }
            set { this._profileArn = value; }
        }

        // Check to see if ProfileArn property is set
        internal bool IsSetProfileArn()
        {
            return this._profileArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string RecommendationArn
        {
            get { return this._recommendationArn; }
            set { this._recommendationArn = value; }
        }

        // Check to see if RecommendationArn property is set
        internal bool IsSetRecommendationArn()
        {
            return this._recommendationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Roi. 
        /// <para>
        /// The return on investment estimate for the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Roi Roi
        {
            get { return this._roi; }
            set { this._roi = value; }
        }

        // Check to see if Roi property is set
        internal bool IsSetRoi()
        {
            return this._roi != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationStatus Status
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
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=3, Max=120)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateReason. 
        /// <para>
        /// The free-text reason associated with the recommendation's most recent status update.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string UpdateReason
        {
            get { return this._updateReason; }
            set { this._updateReason = value; }
        }

        // Check to see if UpdateReason property is set
        internal bool IsSetUpdateReason()
        {
            return this._updateReason != null;
        }

    }
}