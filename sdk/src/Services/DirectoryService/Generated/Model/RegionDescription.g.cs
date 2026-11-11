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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// The replicated Region information for a directory.
    /// </summary>
    public partial class RegionDescription
    {
        /// <summary>
        /// Gets and sets the property DesiredNumberOfDomainControllers. 
        /// <para>
        /// The desired number of domain controllers in the specified Region for the specified
        /// directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2)]
        public int? DesiredNumberOfDomainControllers { get; set; }

        /// <summary>
        /// Checks to see if the DesiredNumberOfDomainControllers property is set.
        /// </summary>
        internal bool IsSetDesiredNumberOfDomainControllers() => this.DesiredNumberOfDomainControllers.HasValue;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory.
        /// </para>
        /// </summary>
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time that the Region description was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// Specifies when the Region replication began.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTime property is set.
        /// </summary>
        internal bool IsSetLaunchTime() => this.LaunchTime.HasValue;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The name of the Region. For example, <c>us-east-1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 32)]
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property RegionType. 
        /// <para>
        /// Specifies whether the Region is the primary Region or an additional Region.
        /// </para>
        /// </summary>
        public RegionType RegionType { get; set; }

        /// <summary>
        /// Checks to see if the RegionType property is set.
        /// </summary>
        internal bool IsSetRegionType() => this.RegionType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the replication process for the specified Region.
        /// </para>
        /// </summary>
        public DirectoryStage Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusLastUpdatedDateTime. 
        /// <para>
        /// The date and time that the Region status was last updated.
        /// </para>
        /// </summary>
        public DateTime? StatusLastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StatusLastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetStatusLastUpdatedDateTime() => this.StatusLastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property VpcSettings.
        /// </summary>
        public DirectoryVpcSettings VpcSettings { get; set; }

        /// <summary>
        /// Checks to see if the VpcSettings property is set.
        /// </summary>
        internal bool IsSetVpcSettings() => this.VpcSettings != null;
    }
}
