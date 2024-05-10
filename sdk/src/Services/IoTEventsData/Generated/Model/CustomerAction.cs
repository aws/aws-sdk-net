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
    /// Contains information about the action that you can take to respond to the alarm.
    /// </summary>
    public partial class CustomerAction
    {
        private AcknowledgeActionConfiguration _acknowledgeActionConfiguration;
        private CustomerActionName _actionName;
        private DisableActionConfiguration _disableActionConfiguration;
        private EnableActionConfiguration _enableActionConfiguration;
        private ResetActionConfiguration _resetActionConfiguration;
        private SnoozeActionConfiguration _snoozeActionConfiguration;

        /// <summary>
        /// Gets and sets the property AcknowledgeActionConfiguration. 
        /// <para>
        /// Contains the configuration information of an acknowledge action.
        /// </para>
        /// </summary>
        public AcknowledgeActionConfiguration AcknowledgeActionConfiguration
        {
            get { return this._acknowledgeActionConfiguration; }
            set { this._acknowledgeActionConfiguration = value; }
        }

        // Check to see if AcknowledgeActionConfiguration property is set
        internal bool IsSetAcknowledgeActionConfiguration()
        {
            return this._acknowledgeActionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The name of the action. The action name can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SNOOZE</c> - When you snooze the alarm, the alarm state changes to <c>SNOOZE_DISABLED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENABLE</c> - When you enable the alarm, the alarm state changes to <c>NORMAL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLE</c> - When you disable the alarm, the alarm state changes to <c>DISABLED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACKNOWLEDGE</c> - When you acknowledge the alarm, the alarm state changes to <c>ACKNOWLEDGED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESET</c> - When you reset the alarm, the alarm state changes to <c>NORMAL</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see the <a href="https://docs.aws.amazon.com/iotevents/latest/apireference/API_iotevents-data_AlarmState.html">AlarmState</a>
        /// API.
        /// </para>
        /// </summary>
        public CustomerActionName ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property DisableActionConfiguration. 
        /// <para>
        /// Contains the configuration information of a disable action.
        /// </para>
        /// </summary>
        public DisableActionConfiguration DisableActionConfiguration
        {
            get { return this._disableActionConfiguration; }
            set { this._disableActionConfiguration = value; }
        }

        // Check to see if DisableActionConfiguration property is set
        internal bool IsSetDisableActionConfiguration()
        {
            return this._disableActionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EnableActionConfiguration. 
        /// <para>
        /// Contains the configuration information of an enable action.
        /// </para>
        /// </summary>
        public EnableActionConfiguration EnableActionConfiguration
        {
            get { return this._enableActionConfiguration; }
            set { this._enableActionConfiguration = value; }
        }

        // Check to see if EnableActionConfiguration property is set
        internal bool IsSetEnableActionConfiguration()
        {
            return this._enableActionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResetActionConfiguration. 
        /// <para>
        /// Contains the configuration information of a reset action.
        /// </para>
        /// </summary>
        public ResetActionConfiguration ResetActionConfiguration
        {
            get { return this._resetActionConfiguration; }
            set { this._resetActionConfiguration = value; }
        }

        // Check to see if ResetActionConfiguration property is set
        internal bool IsSetResetActionConfiguration()
        {
            return this._resetActionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SnoozeActionConfiguration. 
        /// <para>
        /// Contains the configuration information of a snooze action.
        /// </para>
        /// </summary>
        public SnoozeActionConfiguration SnoozeActionConfiguration
        {
            get { return this._snoozeActionConfiguration; }
            set { this._snoozeActionConfiguration = value; }
        }

        // Check to see if SnoozeActionConfiguration property is set
        internal bool IsSetSnoozeActionConfiguration()
        {
            return this._snoozeActionConfiguration != null;
        }

    }
}