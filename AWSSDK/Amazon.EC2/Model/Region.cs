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
    /// Region
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class Region
    {    
        private string regionNameField;
        private string endpointField;

        /// <summary>
        /// Name of the region.
        /// </summary>
        [XmlElementAttribute(ElementName = "RegionName")]
        public string RegionName
        {
            get { return this.regionNameField; }
            set { this.regionNameField = value; }
        }

        /// <summary>
        /// Sets the name of the region.
        /// </summary>
        /// <param name="regionName">Name of the region.</param>
        /// <returns>this instance</returns>
        public Region WithRegionName(string regionName)
        {
            this.regionNameField = regionName;
            return this;
        }

        /// <summary>
        /// Checks if RegionName property is set
        /// </summary>
        /// <returns>true if RegionName property is set</returns>
        public bool IsSetRegionName()
        {
            return this.regionNameField != null;
        }

        /// <summary>
        /// Region service endpoint.
        /// </summary>
        [XmlElementAttribute(ElementName = "Endpoint")]
        public string Endpoint
        {
            get { return this.endpointField; }
            set { this.endpointField = value; }
        }

        /// <summary>
        /// Sets the region service endpoint.
        /// </summary>
        /// <param name="endpoint">Region service endpoint.</param>
        /// <returns>this instance</returns>
        public Region WithEndpoint(string endpoint)
        {
            this.endpointField = endpoint;
            return this;
        }

        /// <summary>
        /// Checks if Endpoint property is set
        /// </summary>
        /// <returns>true if Endpoint property is set</returns>
        public bool IsSetEndpoint()
        {
            return this.endpointField != null;
        }

    }
}
