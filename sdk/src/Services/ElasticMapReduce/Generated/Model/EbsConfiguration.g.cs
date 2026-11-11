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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The Amazon EBS configuration of a cluster instance.
    /// </summary>
    public partial class EbsConfiguration
    {
        /// <summary>
        /// Gets and sets the property EbsBlockDeviceConfigs. 
        /// <para>
        /// An array of Amazon EBS volume specifications attached to a cluster instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EbsBlockDeviceConfig> EbsBlockDeviceConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<EbsBlockDeviceConfig>() : null;

        /// <summary>
        /// Checks to see if the EbsBlockDeviceConfigs property is set.
        /// </summary>
        internal bool IsSetEbsBlockDeviceConfigs() => this.EbsBlockDeviceConfigs != null && (this.EbsBlockDeviceConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Indicates whether an Amazon EBS volume is EBS-optimized. The default is false. You
        /// should explicitly set this value to true to enable the Amazon EBS-optimized setting
        /// for an EC2 instance.
        /// </para>
        /// </summary>
        public bool? EbsOptimized { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimized property is set.
        /// </summary>
        internal bool IsSetEbsOptimized() => this.EbsOptimized.HasValue;
    }
}
