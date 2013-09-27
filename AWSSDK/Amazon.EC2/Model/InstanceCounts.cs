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
    /// Instance counts
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceCounts
    {
        private string stateField;
        private int? instanceCountField;

        /// <summary>
        /// The state of the listed Reserved Instances.
        /// </summary>
        /// <remarks>Possible values = "available", "sold", "cancelled" or "pending"</remarks>
        [XmlElementAttribute(ElementName = "State")]
        public string State
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <summary>
        /// Checks if the State property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetState()
        {
            return !string.IsNullOrEmpty(this.stateField);
        }

        /// <summary>
        /// The number of listed Reserved Instances in the state specified by the State property.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceCount")]
        public int InstanceCount
        {
            get { return this.instanceCountField.GetValueOrDefault(); }
            set { this.instanceCountField = value; }
        }

        /// <summary>
        /// Checks if the InstanceCount property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetInstanceCount()
        {
            return this.instanceCountField != null;
        }
    }
}
