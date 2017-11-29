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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The task placement strategy for a task or service. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-strategies.html">Task
    /// Placement Strategies</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class PlacementStrategy
    {
        private string _field;
        private PlacementStrategyType _type;

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The field to apply the placement strategy against. For the <code>spread</code> placement
        /// strategy, valid values are <code>instanceId</code> (or <code>host</code>, which has
        /// the same effect), or any platform or custom attribute that is applied to a container
        /// instance, such as <code>attribute:ecs.availability-zone</code>. For the <code>binpack</code>
        /// placement strategy, valid values are <code>cpu</code> and <code>memory</code>. For
        /// the <code>random</code> placement strategy, this field is not used.
        /// </para>
        /// </summary>
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of placement strategy. The <code>random</code> placement strategy randomly
        /// places tasks on available candidates. The <code>spread</code> placement strategy spreads
        /// placement across available candidates evenly based on the <code>field</code> parameter.
        /// The <code>binpack</code> strategy places tasks on available candidates that have the
        /// least available amount of the resource that is specified with the <code>field</code>
        /// parameter. For example, if you binpack on memory, a task is placed on the instance
        /// with the least amount of remaining memory (but still enough to run the task).
        /// </para>
        /// </summary>
        public PlacementStrategyType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}