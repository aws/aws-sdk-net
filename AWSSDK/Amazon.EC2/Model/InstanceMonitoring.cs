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
    /// Instance Monitoring
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceMonitoring
    {    
        private string instanceIdField;
        private Monitoring monitoringField;

        /// <summary>
        /// Instance ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the instance ID.
        /// </summary>
        /// <param name="instanceId">Instance ID.</param>
        /// <returns>this instance</returns>
        public InstanceMonitoring WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// State of monitoring for the instance.
        /// 
        /// Valid Values:
        /// monitoring-enabled (enabled) | monitoring-pending
        /// (pending) | monitoring-disabled (disabled)
        /// </summary>
        [XmlElementAttribute(ElementName = "Monitoring")]
        public Monitoring Monitoring
        {
            get { return this.monitoringField; }
            set { this.monitoringField = value; }
        }

        /// <summary>
        /// Sets the State of monitoring for the instance.
        /// </summary>
        /// <param name="monitoring">State of monitoring for the instance.
        /// Valid Values: monitoring-enabled (enabled) | monitoring-pending
        /// (pending) | monitoring-disabled (disabled)</param>
        /// <returns>this instance</returns>
        public InstanceMonitoring WithMonitoring(Monitoring monitoring)
        {
            this.monitoringField = monitoring;
            return this;
        }

        /// <summary>
        /// Checks if Monitoring property is set
        /// </summary>
        /// <returns>true if Monitoring property is set</returns>
        public bool IsSetMonitoring()
        {
            return this.monitoringField != null;
        }

    }
}
