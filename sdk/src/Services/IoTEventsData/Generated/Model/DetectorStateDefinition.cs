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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
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
namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// The new state, variable values, and timer settings of the detector (instance).
    /// </summary>
    public partial class DetectorStateDefinition
    {
        private string _stateName;
        private List<TimerDefinition> _timers = AWSConfigs.InitializeCollections ? new List<TimerDefinition>() : null;
        private List<VariableDefinition> _variables = AWSConfigs.InitializeCollections ? new List<VariableDefinition>() : null;

        /// <summary>
        /// Gets and sets the property StateName. 
        /// <para>
        /// The name of the new state of the detector (instance).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string StateName
        {
            get { return this._stateName; }
            set { this._stateName = value; }
        }

        // Check to see if StateName property is set
        internal bool IsSetStateName()
        {
            return this._stateName != null;
        }

        /// <summary>
        /// Gets and sets the property Timers. 
        /// <para>
        /// The new values of the detector's timers. Any timer whose value isn't specified is
        /// cleared, and its timeout event won't occur.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TimerDefinition> Timers
        {
            get { return this._timers; }
            set { this._timers = value; }
        }

        // Check to see if Timers property is set
        internal bool IsSetTimers()
        {
            return this._timers != null && (this._timers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// The new values of the detector's variables. Any variable whose value isn't specified
        /// is cleared.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<VariableDefinition> Variables
        {
            get { return this._variables; }
            set { this._variables = value; }
        }

        // Check to see if Variables property is set
        internal bool IsSetVariables()
        {
            return this._variables != null && (this._variables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}