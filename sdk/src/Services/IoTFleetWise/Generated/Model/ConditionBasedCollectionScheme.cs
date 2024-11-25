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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Information about a collection scheme that uses a simple logical expression to recognize
    /// what data to collect.
    /// </summary>
    public partial class ConditionBasedCollectionScheme
    {
        private int? _conditionLanguageVersion;
        private string _expression;
        private long? _minimumTriggerIntervalMs;
        private TriggerMode _triggerMode;

        /// <summary>
        /// Gets and sets the property ConditionLanguageVersion. 
        /// <para>
        /// Specifies the version of the conditional expression language.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public int? ConditionLanguageVersion
        {
            get { return this._conditionLanguageVersion; }
            set { this._conditionLanguageVersion = value; }
        }

        // Check to see if ConditionLanguageVersion property is set
        internal bool IsSetConditionLanguageVersion()
        {
            return this._conditionLanguageVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The logical expression used to recognize what data to collect. For example, <c>$variable.`Vehicle.OutsideAirTemperature`
        /// &gt;= 105.0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2048)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumTriggerIntervalMs. 
        /// <para>
        /// The minimum duration of time between two triggering events to collect data, in milliseconds.
        /// </para>
        ///  <note> 
        /// <para>
        /// If a signal changes often, you might want to collect data at a slower rate.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=4294967295)]
        public long? MinimumTriggerIntervalMs
        {
            get { return this._minimumTriggerIntervalMs; }
            set { this._minimumTriggerIntervalMs = value; }
        }

        // Check to see if MinimumTriggerIntervalMs property is set
        internal bool IsSetMinimumTriggerIntervalMs()
        {
            return this._minimumTriggerIntervalMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TriggerMode. 
        /// <para>
        /// Whether to collect data for all triggering events (<c>ALWAYS</c>). Specify (<c>RISING_EDGE</c>),
        /// or specify only when the condition first evaluates to false. For example, triggering
        /// on "AirbagDeployed"; Users aren't interested on triggering when the airbag is already
        /// exploded; they only care about the change from not deployed =&gt; deployed.
        /// </para>
        /// </summary>
        public TriggerMode TriggerMode
        {
            get { return this._triggerMode; }
            set { this._triggerMode = value; }
        }

        // Check to see if TriggerMode property is set
        internal bool IsSetTriggerMode()
        {
            return this._triggerMode != null;
        }

    }
}