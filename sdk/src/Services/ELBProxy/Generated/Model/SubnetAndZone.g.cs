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

namespace Amazon.ELBProxy.Model
{
    /// <summary>
    /// A subnet and its associated Availability Zone.
    /// </summary>
    public partial class SubnetAndZone
    {
        /// <summary>
        /// Gets and sets the property SubnetId. The ID of the subnet.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property ZoneId. The ID of the Availability Zone.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ZoneId { get; set; }

        /// <summary>
        /// Checks to see if the ZoneId property is set.
        /// </summary>
        internal bool IsSetZoneId() => this.ZoneId != null;

        /// <summary>
        /// Gets and sets the property ZoneName. The name of the Availability Zone (for example,
        /// `us-east-1a`).
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// Checks to see if the ZoneName property is set.
        /// </summary>
        internal bool IsSetZoneName() => this.ZoneName != null;
    }
}
