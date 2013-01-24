/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Monitoring configuration.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class Monitoring
    {    
        private string monitoringStateField;

        /// <summary>
        /// State of monitoring for the instance.
        /// Valid Values: monitoring-enabled (enabled) | monitoring-pending (pending) | monitoring-disabled (disabled)
        /// </summary>
        [XmlElementAttribute(ElementName = "MonitoringState")]
        public string MonitoringState
        {
            get { return this.monitoringStateField; }
            set { this.monitoringStateField = value; }
        }

        /// <summary>
        /// Sets the state of monitoring for the instance.
        /// </summary>
        /// <param name="monitoringState">State of monitoring for the instance.
        /// Valid Values: monitoring-enabled (enabled) | monitoring-pending (pending) | monitoring-disabled (disabled)
        /// </param>
        /// <returns>this instance</returns>
        public Monitoring WithMonitoringState(string monitoringState)
        {
            this.monitoringStateField = monitoringState;
            return this;
        }

        /// <summary>
        /// Checks if MonitoringState property is set
        /// </summary>
        /// <returns>true if MonitoringState property is set</returns>
        public bool IsSetMonitoringState()
        {
            return this.monitoringStateField != null;
        }

    }
}
