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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Source server properties.
    /// </summary>
    public partial class SourceProperties
    {
        /// <summary>
        /// Gets and sets the property Cpus. 
        /// <para>
        /// Source Server CPUs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<CPU> Cpus { get; set; } = AWSConfigs.InitializeCollections ? new List<CPU>() : null;

        /// <summary>
        /// Checks to see if the Cpus property is set.
        /// </summary>
        internal bool IsSetCpus() => this.Cpus != null && (this.Cpus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Disks. 
        /// <para>
        /// Source Server disks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<Disk> Disks { get; set; } = AWSConfigs.InitializeCollections ? new List<Disk>() : null;

        /// <summary>
        /// Checks to see if the Disks property is set.
        /// </summary>
        internal bool IsSetDisks() => this.Disks != null && (this.Disks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IdentificationHints. 
        /// <para>
        /// Source server identification hints.
        /// </para>
        /// </summary>
        public IdentificationHints IdentificationHints { get; set; }

        /// <summary>
        /// Checks to see if the IdentificationHints property is set.
        /// </summary>
        internal bool IsSetIdentificationHints() => this.IdentificationHints != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// Source server last update date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// Source server network interfaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public List<NetworkInterface> NetworkInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaces() => this.NetworkInterfaces != null && (this.NetworkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Os. 
        /// <para>
        /// Source server OS.
        /// </para>
        /// </summary>
        public OS Os { get; set; }

        /// <summary>
        /// Checks to see if the Os property is set.
        /// </summary>
        internal bool IsSetOs() => this.Os != null;

        /// <summary>
        /// Gets and sets the property RamBytes. 
        /// <para>
        /// Source server RAM in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? RamBytes { get; set; }

        /// <summary>
        /// Checks to see if the RamBytes property is set.
        /// </summary>
        internal bool IsSetRamBytes() => this.RamBytes.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendedInstanceType. 
        /// <para>
        /// Source server recommended instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string RecommendedInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedInstanceType property is set.
        /// </summary>
        internal bool IsSetRecommendedInstanceType() => this.RecommendedInstanceType != null;
    }
}
