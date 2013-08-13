/*
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
    /// Instance Status Detail
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceStatusDetail
    {
        private string statusField;
        private List<InstanceStatusDetailType> instanceStatusDetailTypeField;

        /// <summary>
        /// The status.
        /// Valid Values: ok | impaired | insufficient-data
        /// </summary>
        [XmlElement(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the status.
        /// </summary>
        /// <param name="status">
        /// Valid Values: ok | impaired | insufficient-data
        /// </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatusDetail WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }

        /// <summary>
        /// Checks if the Status property is set.
        /// </summary>
        /// <returns>true if the Status property is set</returns>
        public bool IsSetStatus()
        {
            return !string.IsNullOrEmpty(this.statusField);
        }

        /// <summary>
        /// Specific information about system instance health or application instance health.
        /// </summary>
        [XmlElement(ElementName = "InstanceStatusDetailType")]
        public List<InstanceStatusDetailType> Detail
        {
            get
            {
                if (this.instanceStatusDetailTypeField == null)
                {
                    this.instanceStatusDetailTypeField = new List<InstanceStatusDetailType>();
                }
                return this.instanceStatusDetailTypeField;
            }
            set { this.instanceStatusDetailTypeField = value; }
        }

        /// <summary>
        /// Sets the specific information about system instance health or application instance health.
        /// </summary>
        /// <param name="list">Set of InstanceStatusDetailType instances</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatusDetail WithDetail(params InstanceStatusDetailType[] list)
        {
            foreach (InstanceStatusDetailType detail in list)
            {
                Detail.Add(detail);
            }
            return this;
        }

        /// <summary>
        /// Checks if the Detail property is set.
        /// </summary>
        /// <returns>true if the Detail property is set</returns>
        public bool IsSetDetail()
        {
            return (Detail.Count > 0);
        }
    }
}
