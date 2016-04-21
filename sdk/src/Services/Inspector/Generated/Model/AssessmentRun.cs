/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private string _name;
        private List<AssessmentRunNotification> _notifications = new List<AssessmentRunNotification>();
        private List<string> _rulesPackageArns = new List<string>();
        private DateTime? _startedAt;
        private AssessmentRunState _state;
        private DateTime? _stateChangedAt;
        private List<AssessmentRunStateChange> _stateChanges = new List<AssessmentRunStateChange>();
        private List<Attribute> _userAttributesForFindings = new List<Attribute>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the assessment run.
        /// </para>
        /// </summary>
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
        public DateTime CompletedAt
        {
            get { return this._completedAt.GetValueOrDefault(); }
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
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
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
        public bool DataCollected
        {
            get { return this._dataCollected.GetValueOrDefault(); }
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
        public int DurationInSeconds
        {
            get { return this._durationInSeconds.GetValueOrDefault(); }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The auto-generated name for the assessment run.
        /// </para>
        /// </summary>
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
        /// </summary>
        public List<AssessmentRunNotification> Notifications
        {
            get { return this._notifications; }
            set { this._notifications = value; }
        }

        // Check to see if Notifications property is set
        internal bool IsSetNotifications()
        {
            return this._notifications != null && this._notifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RulesPackageArns. 
        /// <para>
        /// The rules packages selected for the assessment run.
        /// </para>
        /// </summary>
        public List<string> RulesPackageArns
        {
            get { return this._rulesPackageArns; }
            set { this._rulesPackageArns = value; }
        }

        // Check to see if RulesPackageArns property is set
        internal bool IsSetRulesPackageArns()
        {
            return this._rulesPackageArns != null && this._rulesPackageArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time when <a>StartAssessmentRun</a> was called.
        /// </para>
        /// </summary>
        public DateTime StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
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
        public DateTime StateChangedAt
        {
            get { return this._stateChangedAt.GetValueOrDefault(); }
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
        /// </summary>
        public List<AssessmentRunStateChange> StateChanges
        {
            get { return this._stateChanges; }
            set { this._stateChanges = value; }
        }

        // Check to see if StateChanges property is set
        internal bool IsSetStateChanges()
        {
            return this._stateChanges != null && this._stateChanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserAttributesForFindings. 
        /// <para>
        /// The user-defined attributes that are assigned to every generated finding.
        /// </para>
        /// </summary>
        public List<Attribute> UserAttributesForFindings
        {
            get { return this._userAttributesForFindings; }
            set { this._userAttributesForFindings = value; }
        }

        // Check to see if UserAttributesForFindings property is set
        internal bool IsSetUserAttributesForFindings()
        {
            return this._userAttributesForFindings != null && this._userAttributesForFindings.Count > 0; 
        }

    }
}