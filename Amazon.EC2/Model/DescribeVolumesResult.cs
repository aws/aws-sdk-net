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
    /// Describe Volumes Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeVolumesResult
    {
        private List<Volume> volumeField;
        /// <summary>
        /// Gets and sets the Volume property.
        /// List of volumes
        /// </summary>
        [XmlElementAttribute(ElementName = "Volume")]
        public List<Volume> Volume
        {
            get
            {
                if (this.volumeField == null)
                {
                    this.volumeField = new List<Volume>();
                }
                return this.volumeField;
            }
            set { this.volumeField = value; }
        }

        /// <summary>
        /// Sets the Volume property
        /// </summary>
        /// <param name="list">List of volumes</param>
        /// <returns>this instance</returns>
        public DescribeVolumesResult WithVolume(params Volume[] list)
        {
            foreach (Volume item in list)
            {
                Volume.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Volume property is set
        /// </summary>
        /// <returns>true if Volume property is set</returns>
        public bool IsSetVolume()
        {
            return (Volume.Count > 0);
        }

    }
}
