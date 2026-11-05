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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetRegions operation. Returns a list of all valid
    /// regions for Amazon Lightsail. Use the <c>include availability zones</c> parameter
    /// to also return the Availability Zones in a region.
    /// </summary>
    public partial class GetRegionsRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property IncludeAvailabilityZones. 
        /// <para>
        /// A Boolean value indicating whether to also include Availability Zones in your get
        /// regions request. Availability Zones are indicated with a letter: <c>us-east-2a</c>.
        /// </para>
        /// </summary>
        public bool? IncludeAvailabilityZones { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAvailabilityZones property is set.
        /// </summary>
        internal bool IsSetIncludeAvailabilityZones() => this.IncludeAvailabilityZones.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeRelationalDatabaseAvailabilityZones. 
        /// <para>
        /// A Boolean value indicating whether to also include Availability Zones for databases
        /// in your get regions request. Availability Zones are indicated with a letter (<c>us-east-2a</c>).
        /// </para>
        /// </summary>
        public bool? IncludeRelationalDatabaseAvailabilityZones { get; set; }

        /// <summary>
        /// Checks to see if the IncludeRelationalDatabaseAvailabilityZones property is set.
        /// </summary>
        internal bool IsSetIncludeRelationalDatabaseAvailabilityZones() => this.IncludeRelationalDatabaseAvailabilityZones.HasValue;
    }
}
