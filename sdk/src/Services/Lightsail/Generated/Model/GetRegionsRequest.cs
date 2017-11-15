/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetRegions operation.
    /// Returns a list of all valid regions for Amazon Lightsail. Use the <code>include availability
    /// zones</code> parameter to also return the availability zones in a region.
    /// </summary>
    public partial class GetRegionsRequest : AmazonLightsailRequest
    {
        private bool? _includeAvailabilityZones;

        /// <summary>
        /// Gets and sets the property IncludeAvailabilityZones. 
        /// <para>
        /// A Boolean value indicating whether to also include Availability Zones in your get
        /// regions request. Availability Zones are indicated with a letter: e.g., <code>us-east-2a</code>.
        /// </para>
        /// </summary>
        public bool IncludeAvailabilityZones
        {
            get { return this._includeAvailabilityZones.GetValueOrDefault(); }
            set { this._includeAvailabilityZones = value; }
        }

        // Check to see if IncludeAvailabilityZones property is set
        internal bool IsSetIncludeAvailabilityZones()
        {
            return this._includeAvailabilityZones.HasValue; 
        }

    }
}