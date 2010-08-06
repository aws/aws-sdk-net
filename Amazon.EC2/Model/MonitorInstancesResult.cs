/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Monitor Instances Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class MonitorInstancesResult
    {
        private List<InstanceMonitoring> instanceMonitoringField;
        /// <summary>
        /// Gets and sets the InstanceMonitoring property.
        /// Instance monitoring information
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceMonitoring")]
        public List<InstanceMonitoring> InstanceMonitoring
        {
            get
            {
                if (this.instanceMonitoringField == null)
                {
                    this.instanceMonitoringField = new List<InstanceMonitoring>();
                }
                return this.instanceMonitoringField;
            }
            set { this.instanceMonitoringField = value; }
        }

        /// <summary>
        /// Sets the InstanceMonitoring property
        /// </summary>
        /// <param name="list">Instance monitoring information</param>
        /// <returns>this instance</returns>
        public MonitorInstancesResult WithInstanceMonitoring(params InstanceMonitoring[] list)
        {
            foreach (InstanceMonitoring item in list)
            {
                InstanceMonitoring.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if InstanceMonitoring property is set
        /// </summary>
        /// <returns>true if InstanceMonitoring property is set</returns>
        public bool IsSetInstanceMonitoring()
        {
            return (InstanceMonitoring.Count > 0);
        }

    }
}
