/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a region.</para>
    /// </summary>
    public class Region
    {
        
        private string regionName;
        private string endpoint;


        /// <summary>
        /// The name of the region.
        ///  
        /// </summary>
        public string RegionName
        {
            get { return this.regionName; }
            set { this.regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this.regionName != null;
        }

        /// <summary>
        /// The region service endpoint.
        ///  
        /// </summary>
        public string Endpoint
        {
            get { return this.endpoint; }
            set { this.endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this.endpoint != null;
        }
    }
}
