/*
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2012-06-15
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
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2012-06-15/", IsNullable = false)]
    public class InstanceStatusDetail
    {
        private string statusField;
        private List<InstanceStatusDetailType> instanceStatusDetailTypeField;

        /// <summary>
        /// Gets and sets the Status property.
        /// Valid Values: ok | impaired | insufficient-data
        /// </summary>
        [XmlElement(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the Status property.
        /// </summary>
        /// <param name="status">
        /// Valid Values: ok | impaired | insufficient-data
        /// </param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the detail property.
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
        /// Sets the Detail property.
        /// </summary>
        /// <param name="list">Set of InstanceStatusDetailType instances</param>
        /// <returns>this instance</returns>
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
