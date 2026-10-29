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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorkspacesPool operation. <note> <para>
    /// End of support notice: On December 31, 2027, Amazon Web Services will end support
    /// for Amazon WorkSpaces Pools. After December 31, 2027, you will no longer be able to
    /// access the Amazon WorkSpaces Pools console or Amazon WorkSpaces Pools resources. For
    /// more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/wsp-pools-end-of-support.html">Amazon
    /// WorkSpaces Pools end of support</a>. </para> </note> <para> Updates the specified
    /// pool. </para>
    /// </summary>
    public partial class UpdateWorkspacesPoolRequest : AmazonWorkSpacesRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationSettings. 
        /// <para>
        /// The persistent application settings for users in the pool.
        /// </para>
        /// </summary>
        public ApplicationSettingsRequest ApplicationSettings { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationSettings property is set.
        /// </summary>
        internal bool IsSetApplicationSettings() => this.ApplicationSettings != null;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The identifier of the bundle.
        /// </para>
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The desired capacity for the pool.
        /// </para>
        /// </summary>
        public Capacity Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes the specified pool to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 65)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The identifier of the specified pool to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PoolId property is set.
        /// </summary>
        internal bool IsSetPoolId() => this.PoolId != null;

        /// <summary>
        /// Gets and sets the property RunningMode. 
        /// <para>
        /// The desired running mode for the pool. The running mode can only be updated when the
        /// pool is in a stopped state.
        /// </para>
        /// </summary>
        public PoolsRunningMode RunningMode { get; set; }

        /// <summary>
        /// Checks to see if the RunningMode property is set.
        /// </summary>
        internal bool IsSetRunningMode() => this.RunningMode != null;

        /// <summary>
        /// Gets and sets the property TimeoutSettings. 
        /// <para>
        /// Indicates the timeout settings of the specified pool.
        /// </para>
        /// </summary>
        public TimeoutSettings TimeoutSettings { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutSettings property is set.
        /// </summary>
        internal bool IsSetTimeoutSettings() => this.TimeoutSettings != null;
    }
}
