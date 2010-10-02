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
 *  API Version: 2010-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes regions that are currently available to
    /// the account.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-06-15/", IsNullable = false)]
    public class DescribeRegionsRequest
    {    
        private List<string> regionNameField;

        /// <summary>
        /// Gets and sets the RegionName property.
        /// Name of a region.
        /// </summary>
        [XmlElementAttribute(ElementName = "RegionName")]
        public List<string> RegionName
        {
            get
            {
                if (this.regionNameField == null)
                {
                    this.regionNameField = new List<string>();
                }
                return this.regionNameField;
            }
            set { this.regionNameField = value; }
        }

        /// <summary>
        /// Sets the RegionName property
        /// </summary>
        /// <param name="list">Name of a region.</param>
        /// <returns>this instance</returns>
        public DescribeRegionsRequest WithRegionName(params string[] list)
        {
            foreach (string item in list)
            {
                RegionName.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if RegionName property is set
        /// </summary>
        /// <returns>true if RegionName property is set</returns>
        public bool IsSetRegionName()
        {
            return (RegionName.Count > 0);
        }

    }
}
