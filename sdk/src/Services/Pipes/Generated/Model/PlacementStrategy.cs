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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The task placement strategy for a task or service. To learn more, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-strategies.html">Task
    /// Placement Strategies</a> in the Amazon Elastic Container Service Service Developer
    /// Guide.
    /// </summary>
    public partial class PlacementStrategy
    {
        private string _field;
        private PlacementStrategyType _type;

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The field to apply the placement strategy against. For the spread placement strategy,
        /// valid values are instanceId (or host, which has the same effect), or any platform
        /// or custom attribute that is applied to a container instance, such as attribute:ecs.availability-zone.
        /// For the binpack placement strategy, valid values are cpu and memory. For the random
        /// placement strategy, this field is not used. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=255)]
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
        /// The type of placement strategy. The random placement strategy randomly places tasks
        /// on available candidates. The spread placement strategy spreads placement across available
        /// candidates evenly based on the field parameter. The binpack strategy places tasks
        /// on available candidates that have the least available amount of the resource that
        /// is specified with the field parameter. For example, if you binpack on memory, a task
        /// is placed on the instance with the least amount of remaining memory (but still enough
        /// to run the task). 
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