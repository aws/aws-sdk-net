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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrigger operation.
    /// Creates a new trigger.
    /// </summary>
    public partial class CreateTriggerRequest : AmazonGlueRequest
    {
        private List<Action> _actions = new List<Action>();
        private string _description;
        private string _name;
        private Predicate _predicate;
        private string _schedule;
        private bool? _startOnCreation;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private TriggerType _type;
        private string _workflowName;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions initiated by this trigger when it fires.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Action> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the new trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property Predicate. 
        /// <para>
        /// A predicate to specify when the new trigger should fire.
        /// </para>
        ///  
        /// <para>
        /// This field is required when the trigger type is <code>CONDITIONAL</code>.
        /// </para>
        /// </summary>
        public Predicate Predicate
        {
            get { return this._predicate; }
            set { this._predicate = value; }
        }

        // Check to see if Predicate property is set
        internal bool IsSetPredicate()
        {
            return this._predicate != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// A <code>cron</code> expression used to specify the schedule (see <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-data-warehouse-schedule.html">Time-Based
        /// Schedules for Jobs and Crawlers</a>. For example, to run something every day at 12:15
        /// UTC, you would specify: <code>cron(15 12 * * ? *)</code>.
        /// </para>
        ///  
        /// <para>
        /// This field is required when the trigger type is SCHEDULED.
        /// </para>
        /// </summary>
        public string Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property StartOnCreation. 
        /// <para>
        /// Set to <code>true</code> to start <code>SCHEDULED</code> and <code>CONDITIONAL</code>
        /// triggers when created. True is not supported for <code>ON_DEMAND</code> triggers.
        /// </para>
        /// </summary>
        public bool StartOnCreation
        {
            get { return this._startOnCreation.GetValueOrDefault(); }
            set { this._startOnCreation = value; }
        }

        // Check to see if StartOnCreation property is set
        internal bool IsSetStartOnCreation()
        {
            return this._startOnCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to use with this trigger. You may use tags to limit access to the trigger.
        /// For more information about tags in AWS Glue, see <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-tags.html">AWS
        /// Tags in AWS Glue</a> in the developer guide. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the new trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TriggerType Type
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
        /// Gets and sets the property WorkflowName. 
        /// <para>
        /// The name of the workflow associated with the trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string WorkflowName
        {
            get { return this._workflowName; }
            set { this._workflowName = value; }
        }

        // Check to see if WorkflowName property is set
        internal bool IsSetWorkflowName()
        {
            return this._workflowName != null;
        }

    }
}