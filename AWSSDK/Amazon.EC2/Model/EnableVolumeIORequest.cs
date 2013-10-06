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
    /// Enables I/O operations for a volume that had I/O operations disabled
    /// because the data on the volume was potentially inconsistent.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class EnableVolumeIORequest : EC2Request
    {
        private string volumeIdField;

        /// <summary>
        /// The volume on which to turn on IO
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeId")]
        public string VolumeId
        {
            get { return this.volumeIdField; }
            set { this.volumeIdField = value; }
        }

        /// <summary>
        /// Checks if VolumeId property is set
        /// </summary>
        /// <returns>true if VolumeId property is set</returns>
        public bool IsSetVolumeId()
        {
            return this.volumeIdField != null;
        }

        /// <summary>
        /// Sets the volume on which to turn on IO
        /// </summary>
        /// <param name="volumeId">The new volume id</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableVolumeIORequest WithVolumeId(string volumeId)
        {
            this.volumeIdField = volumeId;
            return this;
        }
    }
}
