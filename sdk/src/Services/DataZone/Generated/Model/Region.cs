/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Amazon Web Services Region.
    /// </summary>
    public partial class Region
    {
        private string _regionName;
        private string _regionNamePath;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Amazon Web Services Region name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=16)]
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

        /// <summary>
        /// Gets and sets the property RegionNamePath. 
        /// <para>
        /// The region name path.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RegionNamePath
        {
            get { return this._regionNamePath; }
            set { this._regionNamePath = value; }
        }

        // Check to see if RegionNamePath property is set
        internal bool IsSetRegionNamePath()
        {
            return this._regionNamePath != null;
        }

    }
}