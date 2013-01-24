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
    /// Describes the specified Amazon EBS volumes that you own.
    /// </summary>
    /// <remarks>
    /// If you do not specify one or more volume IDs, Amazon EBS
    /// describes all volumes that you own.
    /// For more information about Amazon EBS, go to the Amazon
    /// Elastic Compute Cloud Developer Guide.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeVolumesRequest
    {    
        private List<string> volumeIdField;
        private List<Filter> filterField;

        /// <summary>
        /// One or more volume IDs.
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
        /// Sets volume IDs.
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

        /// <summary>
        /// A list of filters used to match system-defined properties and user-defined tags associated 
        /// with the specified Volumes.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.
        /// </summary>
        [XmlElementAttribute(ElementName = "Filter")]
        public List<Filter> Filter
        {
            get
            {
                if (this.filterField == null)
                {
                    this.filterField = new List<Filter>();
                }
                return this.filterField;
            }
            set { this.filterField = value; }
        }

        /// <summary>
        /// Sets filters used to match system-defined properties and user-defined tags associated 
        /// with the specified Volumes.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags associated 
        /// with the specified Volumes.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        public DescribeVolumesRequest WithFilter(params Filter[] list)
        {
            foreach (Filter item in list)
            {
                Filter.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Filter property is set
        /// </summary>
        /// <returns>true if Filter property is set</returns>
        public bool IsSetFilter()
        {
            return (Filter.Count > 0);
        }

    }
}
