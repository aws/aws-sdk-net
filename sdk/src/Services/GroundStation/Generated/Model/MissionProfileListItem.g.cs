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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Item in a list of mission profiles.
    /// </summary>
    public partial class MissionProfileListItem
    {
        /// <summary>
        /// Gets and sets the property MissionProfileArn. 
        /// <para>
        /// ARN of a mission profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 89, Max = 138)]
        public string MissionProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the MissionProfileArn property is set.
        /// </summary>
        internal bool IsSetMissionProfileArn() => this.MissionProfileArn != null;

        /// <summary>
        /// Gets and sets the property MissionProfileId. 
        /// <para>
        /// UUID of a mission profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string MissionProfileId { get; set; }

        /// <summary>
        /// Checks to see if the MissionProfileId property is set.
        /// </summary>
        internal bool IsSetMissionProfileId() => this.MissionProfileId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of a mission profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Region of a mission profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;
    }
}
