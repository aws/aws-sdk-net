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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// A snapshot of an Amazon Inspector assessment run that contains the findings of the
    /// assessment run .
    /// 
    ///  
    /// <para>
    /// Used as the response element in the <a>DescribeAssessmentRuns</a> action.
    /// </para>
    /// </summary>
    public partial class AssessmentRun
    {
        private string _arn;
        private string _assessmentTemplateArn;
        private DateTime? _completedAt;
        private DateTime? _createdAt;
        private bool? _dataCollected;
        private int? _durationInSeconds;
        private Dictionary<string, int> _findingCounts = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private string _name;
        private List<AssessmentRunNotification> _notifications = AWSConfigs.InitializeCollections ? new List<AssessmentRunNotification>() : null;
        private List<string> _rulesPackageArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _startedAt;
        private AssessmentRunState _state;
        private DateTime? _stateChangedAt;
        private List<AssessmentRunStateChange> _stateChanges = AWSConfigs.InitializeCollections ? new List<AssessmentRunStateChange>() : null;
        private List<Attribute> _userAttributesForFindings = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
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
        /// Gets and sets the property AssessmentTemplateArn. 
        /// <para>
        /// The ARN of the assessment template that is associated with the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string AssessmentTemplateArn
        {
            get { return this._assessmentTemplateArn; }
            set { this._assessmentTemplateArn = value; }
        }

        // Check to see if AssessmentTemplateArn property is set
        internal bool IsSetAssessmentTemplateArn()
        {
            return this._assessmentTemplateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The assessment run completion time that corresponds to the rules packages evaluation
        /// completion time or failure.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when <a>StartAssessmentRun</a> was called.
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
        /// Gets and sets the property DataCollected. 
        /// <para>
        /// A Boolean value (true or false) that specifies whether the process of collecting data
        /// from the agents is completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? DataCollected
        {
            get { return this._dataCollected; }
            set { this._dataCollected = value; }
        }

        // Check to see if DataCollected property is set
        internal bool IsSetDataCollected()
        {
            return this._dataCollected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The duration of the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=180, Max=86400)]
        public int? DurationInSeconds
        {
            get { return this._durationInSeconds; }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FindingCounts. 
        /// <para>
        /// Provides a total count of generated findings per severity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, int> FindingCounts
        {
            get { return this._findingCounts; }
            set { this._findingCounts = value; }
        }

        // Check to see if FindingCounts property is set
        internal bool IsSetFindingCounts()
        {
            return this._findingCounts != null && (this._findingCounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The auto-generated name for the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
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
        /// Gets and sets the property Notifications. 
        /// <para>
        /// A list of notifications for the event subscriptions. A notification about a particular
        /// generated finding is added to this list only once.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<AssessmentRunNotification> Notifications
        {
            get { return this._notifications; }
            set { this._notifications = value; }
        }

        // Check to see if Notifications property is set
        internal bool IsSetNotifications()
        {
            return this._notifications != null && (this._notifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RulesPackageArns. 
        /// <para>
        /// The rules packages selected for the assessment run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> RulesPackageArns
        {
            get { return this._rulesPackageArns; }
            set { this._rulesPackageArns = value; }
        }

        // Check to see if RulesPackageArns property is set
        internal bool IsSetRulesPackageArns()
        {
            return this._rulesPackageArns != null && (this._rulesPackageArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time when <a>StartAssessmentRun</a> was called.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssessmentRunState State
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
        /// Gets and sets the property StateChangedAt. 
        /// <para>
        /// The last time when the assessment run's state changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StateChangedAt
        {
            get { return this._stateChangedAt; }
            set { this._stateChangedAt = value; }
        }

        // Check to see if StateChangedAt property is set
        internal bool IsSetStateChangedAt()
        {
            return this._stateChangedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StateChanges. 
        /// <para>
        /// A list of the assessment run state changes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<AssessmentRunStateChange> StateChanges
        {
            get { return this._stateChanges; }
            set { this._stateChanges = value; }
        }

        // Check to see if StateChanges property is set
        internal bool IsSetStateChanges()
        {
            return this._stateChanges != null && (this._stateChanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserAttributesForFindings. 
        /// <para>
        /// The user-defined attributes that are assigned to every generated finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<Attribute> UserAttributesForFindings
        {
            get { return this._userAttributesForFindings; }
            set { this._userAttributesForFindings = value; }
        }

        // Check to see if UserAttributesForFindings property is set
        internal bool IsSetUserAttributesForFindings()
        {
            return this._userAttributesForFindings != null && (this._userAttributesForFindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}