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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The zone awareness configuration for an Amazon OpenSearch Service domain.
    /// </summary>
    public partial class ZoneAwarenessConfig
    {
        private int? _availabilityZoneCount;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneCount. 
        /// <para>
        /// If you enabled multiple Availability Zones, this value is the number of zones that
        /// you want the domain to use. Valid values are <c>2</c> and <c>3</c>. If your domain
        /// is provisioned within a VPC, this value be equal to number of subnets.
        /// </para>
        /// </summary>
        public int? AvailabilityZoneCount
        {
            get { return this._availabilityZoneCount; }
            set { this._availabilityZoneCount = value; }
        }

        // Check to see if AvailabilityZoneCount property is set
        internal bool IsSetAvailabilityZoneCount()
        {
            return this._availabilityZoneCount.HasValue; 
        }

    }
}