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
    /// Password Data
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class PasswordData
    {    
        private string instanceIdField;
        private string timestampField;
        private string dataField;

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the instance.
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PasswordData WithInstanceId(string instanceId)
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
        /// The time the data was last updated.
        /// </summary>
        [XmlElementAttribute(ElementName = "Timestamp")]
        public string Timestamp
        {
            get { return this.timestampField; }
            set { this.timestampField = value; }
        }

        /// <summary>
        /// Sets the time the data was last updated.
        /// </summary>
        /// <param name="timestamp">The time the data was last updated.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PasswordData WithTimestamp(string timestamp)
        {
            this.timestampField = timestamp;
            return this;
        }

        /// <summary>
        /// Checks if Timestamp property is set
        /// </summary>
        /// <returns>true if Timestamp property is set</returns>
        public bool IsSetTimestamp()
        {
            return this.timestampField != null;
        }

        /// <summary>
        /// The password of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "Data")]
        public string Data
        {
            get { return this.dataField; }
            set { this.dataField = value; }
        }

        /// <summary>
        /// Sets the password of the instance.
        /// </summary>
        /// <param name="data">The password of the instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PasswordData WithData(string data)
        {
            this.dataField = data;
            return this;
        }

        /// <summary>
        /// Checks if Data property is set
        /// </summary>
        /// <returns>true if Data property is set</returns>
        public bool IsSetData()
        {
            return this.dataField != null;
        }

    }
}
