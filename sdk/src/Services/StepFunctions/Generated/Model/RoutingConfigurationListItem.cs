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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
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
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains details about the routing configuration of a state machine alias. In a routing
    /// configuration, you define an array of objects that specify up to two state machine
    /// versions. You also specify the percentage of traffic to be routed to each version.
    /// </summary>
    public partial class RoutingConfigurationListItem
    {
        private string _stateMachineVersionArn;
        private int? _weight;

        /// <summary>
        /// Gets and sets the property StateMachineVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies one or two state machine versions defined
        /// in the routing configuration.
        /// </para>
        ///  
        /// <para>
        /// If you specify the ARN of a second version, it must belong to the same state machine
        /// as the first version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string StateMachineVersionArn
        {
            get { return this._stateMachineVersionArn; }
            set { this._stateMachineVersionArn = value; }
        }

        // Check to see if StateMachineVersionArn property is set
        internal bool IsSetStateMachineVersionArn()
        {
            return this._stateMachineVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The percentage of traffic you want to route to a state machine version. The sum of
        /// the weights in the routing configuration must be equal to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public int? Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}