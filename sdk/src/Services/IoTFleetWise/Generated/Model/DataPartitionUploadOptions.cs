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
    /// The upload options for the data partition. If upload options are specified, you must
    /// also specify storage options. See <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/APIReference/API_DataPartitionStorageOptions.html">DataPartitionStorageOptions</a>.
    /// 
    ///  <important> 
    /// <para>
    /// Access to certain Amazon Web Services IoT FleetWise features is currently gated. For
    /// more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleetwise-regions.html">Amazon
    /// Web Services Region and feature availability</a> in the <i>Amazon Web Services IoT
    /// FleetWise Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DataPartitionUploadOptions
    {
        private int? _conditionLanguageVersion;
        private string _expression;

        /// <summary>
        /// Gets and sets the property ConditionLanguageVersion. 
        /// <para>
        /// The version of the condition language. Defaults to the most recent condition language
        /// version.
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

    }
}