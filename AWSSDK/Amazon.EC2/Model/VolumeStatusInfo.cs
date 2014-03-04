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
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Volume Status Info
    /// </summary>
    public class VolumeStatusInfo
    {
        private string statusField;
        private List<VolumeStatusDetail> volumeStatusDetailField;

        /// <summary>
        /// The status of the volume
        /// </summary>
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }
        /// <summary>
        /// Checks if Status property is set
        /// </summary>
        /// <returns>true if Status property is set</returns>
        public bool IsSetStatus()
        {
            return this.statusField != null;
        }
        /// <summary>
        /// Sets the status of the volume
        /// </summary>
        /// <param name="status">The new status</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeStatusInfo WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }

        /// <summary>
        /// Details of the volume status
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeStatusDetail")]
        public List<VolumeStatusDetail> VolumeStatusDetail
        {
            get
            {
                if (this.volumeStatusDetailField == null)
                {
                    this.volumeStatusDetailField = new List<VolumeStatusDetail>();
                }
                return this.volumeStatusDetailField;
            }
            set { this.volumeStatusDetailField = value; }
        }
        /// <summary>
        /// Checks if VolumeStatusDetail property is set
        /// </summary>
        /// <returns>true if VolumeStatusDetail property is set</returns>
        public bool IsSetVolumeStatusDetail()
        {
            return this.volumeStatusDetailField != null;
        }
        /// <summary>
        /// Sets the details of the volume status
        /// </summary>
        /// <param name="list">The new details</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeStatusInfo WithVolumeStatusDetail(params VolumeStatusDetail[] list)
        {
            foreach (VolumeStatusDetail item in list)
            {
                this.volumeStatusDetailField.Add(item);
            }
            return this;
        }
    }
}
