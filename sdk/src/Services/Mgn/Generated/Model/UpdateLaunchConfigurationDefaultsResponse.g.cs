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
    /// This is the response object from the UpdateLaunchConfigurationDefaults operation.
    /// </summary>
    public partial class UpdateLaunchConfigurationDefaultsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LargeVolumeConfiguration. 
        /// <para>
        /// Volume configuration for disks larger than <c>smallVolumeMaxSize</c>. Omitted when
        /// none of its fields is set.
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
        /// Volume configuration for disks up to <c>smallVolumeMaxSize</c>. Omitted when none
        /// of its fields is set.
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
        /// use the large one. <c>0</c> means every disk uses the large one.
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
        /// Source Server ID of the launch configuration defaults.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;
    }
}
