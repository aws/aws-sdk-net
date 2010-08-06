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
    /// Describes the specified Amazon EBS volumes that you own. If you do not specify one or
    /// more volume IDs, Amazon EBS describes all volumes that you own. For more information
    /// about Amazon EBS, go to the Amazon Elastic Compute Cloud Developer Guide.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeVolumesRequest
    {
        private List<string> volumeIdField;

        /// <summary>
        /// Gets and sets the VolumeId property.
        /// The ID of the volume to list.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeId")]
        public List<string> VolumeId
        {
            get
            {
                if (this.volumeIdField == null)
                {
                    this.volumeIdField = new List<string>();
                }
                return this.volumeIdField;
            }
            set { this.volumeIdField = value; }
        }

        /// <summary>
        /// Sets the VolumeId property
        /// </summary>
        /// <param name="list">The ID of the volume to list.</param>
        /// <returns>this instance</returns>
        public DescribeVolumesRequest WithVolumeId(params string[] list)
        {
            foreach (string item in list)
            {
                VolumeId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if VolumeId property is set
        /// </summary>
        /// <returns>true if VolumeId property is set</returns>
        public bool IsSetVolumeId()
        {
            return (VolumeId.Count > 0);
        }

    }
}
