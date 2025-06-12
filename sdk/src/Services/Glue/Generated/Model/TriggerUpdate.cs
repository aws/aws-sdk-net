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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure used to provide information used to update a trigger. This object updates
    /// the previous trigger definition by overwriting it completely.
    /// </summary>
    public partial class TriggerUpdate
    {
        private List<Action> _actions = AWSConfigs.InitializeCollections ? new List<Action>() : null;
        private string _description;
        private EventBatchingCondition _eventBatchingCondition;
        private string _name;
        private Predicate _predicate;
        private string _schedule;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions initiated by this trigger.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Action> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of this trigger.
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
        /// Gets and sets the property EventBatchingCondition. 
        /// <para>
        /// Batch condition that must be met (specified number of events received or batch time
        /// window expired) before EventBridge event trigger fires.
        /// </para>
        /// </summary>
        public EventBatchingCondition EventBatchingCondition
        {
            get { return this._eventBatchingCondition; }
            set { this._eventBatchingCondition = value; }
        }

        // Check to see if EventBatchingCondition property is set
        internal bool IsSetEventBatchingCondition()
        {
            return this._eventBatchingCondition != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The predicate of this trigger, which defines when it will fire.
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
        /// A <c>cron</c> expression used to specify the schedule (see <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-data-warehouse-schedule.html">Time-Based
        /// Schedules for Jobs and Crawlers</a>. For example, to run something every day at 12:15
        /// UTC, you would specify: <c>cron(15 12 * * ? *)</c>.
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

    }
}