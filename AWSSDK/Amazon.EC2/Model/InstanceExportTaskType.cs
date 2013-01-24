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
    /// Information about an instance being exported.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceExportTaskType
    {
        private string instanceIdField;
        private string targetEnvironmentField;

        /// <summary>
        /// The ID of the resource being exported.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Checks if the InstanceId property is set.
        /// </summary>
        /// <returns>True if the InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return !string.IsNullOrEmpty(this.instanceIdField);
        }

        /// <summary>
        /// The target virtualization environment.
        /// </summary>
        /// <remarks>
        /// Valid Values: vmware | citrix
        /// </remarks>
        [XmlElementAttribute(ElementName = "TargetEnvironment")]
        public string TargetEnvironment
        {
            get { return this.targetEnvironmentField; }
            set { this.targetEnvironmentField = value; }
        }

        /// <summary>
        /// Checks if the TargetEnvironment property is set.
        /// </summary>
        /// <returns>True if the TargetEnvironment property is set</returns>
        public bool IsSetTargetEnvironment()
        {
            return !string.IsNullOrEmpty(this.targetEnvironmentField);
        }
    }
}
