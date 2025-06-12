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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about alarms associated with a deployment or deployment group.
    /// </summary>
    public partial class AlarmConfiguration
    {
        private List<Alarm> _alarms = AWSConfigs.InitializeCollections ? new List<Alarm>() : null;
        private bool? _enabled;
        private bool? _ignorePollAlarmFailure;

        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// A list of alarms configured for the deployment or deployment group. A maximum of 10
        /// alarms can be added.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Alarm> Alarms
        {
            get { return this._alarms; }
            set { this._alarms = value; }
        }

        // Check to see if Alarms property is set
        internal bool IsSetAlarms()
        {
            return this._alarms != null && (this._alarms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the alarm configuration is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IgnorePollAlarmFailure. 
        /// <para>
        /// Indicates whether a deployment should continue if information about the current state
        /// of alarms cannot be retrieved from Amazon CloudWatch. The default value is false.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>true</c>: The deployment proceeds even if alarm status information can't be retrieved
        /// from Amazon CloudWatch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c>: The deployment stops if alarm status information can't be retrieved
        /// from Amazon CloudWatch.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? IgnorePollAlarmFailure
        {
            get { return this._ignorePollAlarmFailure; }
            set { this._ignorePollAlarmFailure = value; }
        }

        // Check to see if IgnorePollAlarmFailure property is set
        internal bool IsSetIgnorePollAlarmFailure()
        {
            return this._ignorePollAlarmFailure.HasValue; 
        }

    }
}