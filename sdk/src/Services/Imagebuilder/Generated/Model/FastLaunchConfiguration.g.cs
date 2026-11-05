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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Defines and configures EC2 Fast Launch for output Windows AMIs.
    /// </summary>
    public partial class FastLaunchConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The owner account ID for the fast-launch enabled Windows AMI.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether to enable Windows fast launch on the output AMI during distribution.
        /// A value of <c>false</c> means Image Builder takes no fast-launch action for this configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template that the fast-launch enabled Windows AMI uses when it launches
        /// Windows instances to create pre-provisioned snapshots.
        /// </para>
        /// </summary>
        public FastLaunchLaunchTemplateSpecification LaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplate property is set.
        /// </summary>
        internal bool IsSetLaunchTemplate() => this.LaunchTemplate != null;

        /// <summary>
        /// Gets and sets the property MaxParallelLaunches. 
        /// <para>
        /// The maximum number of parallel instances that are launched for creating resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxParallelLaunches { get; set; }

        /// <summary>
        /// Checks to see if the MaxParallelLaunches property is set.
        /// </summary>
        internal bool IsSetMaxParallelLaunches() => this.MaxParallelLaunches.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotConfiguration. 
        /// <para>
        /// Configuration settings for managing the number of snapshots that are created from
        /// pre-provisioned instances for the Windows AMI when Windows fast launch is enabled.
        /// </para>
        /// </summary>
        public FastLaunchSnapshotConfiguration SnapshotConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotConfiguration property is set.
        /// </summary>
        internal bool IsSetSnapshotConfiguration() => this.SnapshotConfiguration != null;
    }
}
