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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Defines the Amazon Web Services Regions that the specified Firewall Manager administrator
    /// can manage.
    /// </summary>
    public partial class RegionScope
    {
        private bool? _allRegionsEnabled;
        private List<string> _regions = new List<string>();

        /// <summary>
        /// Gets and sets the property AllRegionsEnabled. 
        /// <para>
        /// Allows the specified Firewall Manager administrator to manage all Amazon Web Services
        /// Regions.
        /// </para>
        /// </summary>
        public bool AllRegionsEnabled
        {
            get { return this._allRegionsEnabled.GetValueOrDefault(); }
            set { this._allRegionsEnabled = value; }
        }

        // Check to see if AllRegionsEnabled property is set
        internal bool IsSetAllRegionsEnabled()
        {
            return this._allRegionsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Amazon Web Services Regions that the specified Firewall Manager administrator
        /// can perform actions in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && this._regions.Count > 0; 
        }

    }
}