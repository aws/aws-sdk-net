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
    /// Describes a pool of WorkSpaces.
    /// </summary>
    public partial class WorkspacesPool
    {
        /// <summary>
        /// Gets and sets the property ApplicationSettings. 
        /// <para>
        /// The persistent application settings for users of the pool.
        /// </para>
        /// </summary>
        public ApplicationSettingsResponse ApplicationSettings { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationSettings property is set.
        /// </summary>
        internal bool IsSetApplicationSettings() => this.ApplicationSettings != null;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The identifier of the bundle used by the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;

        /// <summary>
        /// Gets and sets the property CapacityStatus. 
        /// <para>
        /// The capacity status for the pool
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapacityStatus CapacityStatus { get; set; }

        /// <summary>
        /// Checks to see if the CapacityStatus property is set.
        /// </summary>
        internal bool IsSetCapacityStatus() => this.CapacityStatus != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the pool was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the pool.
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
        /// The identifier of the directory used by the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 65)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// The pool errors.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WorkspacesPoolError> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<WorkspacesPoolError>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PoolArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PoolArn { get; set; }

        /// <summary>
        /// Checks to see if the PoolArn property is set.
        /// </summary>
        internal bool IsSetPoolArn() => this.PoolArn != null;

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The identifier of a pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PoolId property is set.
        /// </summary>
        internal bool IsSetPoolId() => this.PoolId != null;

        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// The name of the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PoolName { get; set; }

        /// <summary>
        /// Checks to see if the PoolName property is set.
        /// </summary>
        internal bool IsSetPoolName() => this.PoolName != null;

        /// <summary>
        /// Gets and sets the property RunningMode. 
        /// <para>
        /// The running mode of the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PoolsRunningMode RunningMode { get; set; }

        /// <summary>
        /// Checks to see if the RunningMode property is set.
        /// </summary>
        internal bool IsSetRunningMode() => this.RunningMode != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkspacesPoolState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TimeoutSettings. 
        /// <para>
        /// The amount of time that a pool session remains active after users disconnect. If they
        /// try to reconnect to the pool session after a disconnection or network interruption
        /// within this time interval, they are connected to their previous session. Otherwise,
        /// they are connected to a new session with a new pool instance.
        /// </para>
        /// </summary>
        public TimeoutSettings TimeoutSettings { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutSettings property is set.
        /// </summary>
        internal bool IsSetTimeoutSettings() => this.TimeoutSettings != null;
    }
}
