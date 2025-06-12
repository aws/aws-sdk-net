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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Latest routing criteria on the contact.
    /// </summary>
    public partial class RoutingCriteria
    {
        private DateTime? _activationTimestamp;
        private int? _index;
        private List<Step> _steps = AWSConfigs.InitializeCollections ? new List<Step>() : null;

        /// <summary>
        /// Gets and sets the property ActivationTimestamp. 
        /// <para>
        /// The timestamp indicating when the routing criteria is set to active. A routing criteria
        /// is activated when contact is transferred to a queue. ActivationTimestamp will be set
        /// on routing criteria for contacts in agent queue even though Routing criteria is never
        /// activated for contacts in agent queue.
        /// </para>
        /// </summary>
        public DateTime? ActivationTimestamp
        {
            get { return this._activationTimestamp; }
            set { this._activationTimestamp = value; }
        }

        // Check to see if ActivationTimestamp property is set
        internal bool IsSetActivationTimestamp()
        {
            return this._activationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// Information about the index of the routing criteria.
        /// </para>
        /// </summary>
        public int? Index
        {
            get { return this._index; }
            set { this._index = value; }
        }

        // Check to see if Index property is set
        internal bool IsSetIndex()
        {
            return this._index.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// List of routing steps. When Amazon Connect does not find an available agent meeting
        /// the requirements in a step for a given step duration, the routing criteria will move
        /// on to the next step sequentially until a join is completed with an agent. When all
        /// steps are exhausted, the contact will be offered to any agent in the queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Step> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && (this._steps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}