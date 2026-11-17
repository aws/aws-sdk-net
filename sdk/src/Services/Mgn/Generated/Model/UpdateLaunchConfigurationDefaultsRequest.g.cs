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
    /// Container for the parameters to the UpdateLaunchConfigurationDefaults operation. Updates
    /// the launch configuration defaults of a source server. They apply only to disk mappings
    /// created later in the source server's Amazon Elastic Compute Cloud (Amazon EC2) launch
    /// template, and members you omit keep their current values.
    /// </summary>
    public partial class UpdateLaunchConfigurationDefaultsRequest : AmazonMgnRequest
    {
        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// Request to update the launch configuration defaults by Account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountID { get; set; }

        /// <summary>
        /// Checks to see if the AccountID property is set.
        /// </summary>
        internal bool IsSetAccountID() => this.AccountID != null;

        /// <summary>
        /// Gets and sets the property LargeVolumeConfiguration. 
        /// <para>
        /// Volume configuration for disks larger than <c>smallVolumeMaxSize</c>. If you omit
        /// it, the current one is kept. If you send it, it replaces the current one: fields you
        /// omit are cleared, and an empty configuration, <c>{}</c>, clears all of them.
        /// </para>
        /// </summary>
        public SourceServerVolumeConfiguration LargeVolumeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LargeVolumeConfiguration property is set.
        /// </summary>
        internal bool IsSetLargeVolumeConfiguration() => this.LargeVolumeConfiguration != null;

        /// <summary>
        /// Gets and sets the property SmallVolumeConfiguration. 
        /// <para>
        /// Volume configuration for disks up to <c>smallVolumeMaxSize</c>. If you omit it, the
        /// current one is kept. If you send it, it replaces the current one: fields you omit
        /// are cleared, and an empty configuration, <c>{}</c>, clears all of them.
        /// </para>
        /// </summary>
        public SourceServerVolumeConfiguration SmallVolumeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SmallVolumeConfiguration property is set.
        /// </summary>
        internal bool IsSetSmallVolumeConfiguration() => this.SmallVolumeConfiguration != null;

        /// <summary>
        /// Gets and sets the property SmallVolumeMaxSize. 
        /// <para>
        /// Disks up to this size, in GiB, use the small volume configuration, and larger disks
        /// use the large one. <c>0</c> means every disk uses the large one. If you omit it, the
        /// current value is kept.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? SmallVolumeMaxSize { get; set; }

        /// <summary>
        /// Checks to see if the SmallVolumeMaxSize property is set.
        /// </summary>
        internal bool IsSetSmallVolumeMaxSize() => this.SmallVolumeMaxSize.HasValue;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Request to update the launch configuration defaults by Source Server ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;
    }
}
