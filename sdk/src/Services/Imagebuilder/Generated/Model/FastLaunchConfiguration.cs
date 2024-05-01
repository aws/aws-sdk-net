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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
    /// Define and configure faster launching for output Windows AMIs.
    /// </summary>
    public partial class FastLaunchConfiguration
    {
        private string _accountId;
        private bool? _enabled;
        private FastLaunchLaunchTemplateSpecification _launchTemplate;
        private int? _maxParallelLaunches;
        private FastLaunchSnapshotConfiguration _snapshotConfiguration;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The owner account ID for the fast-launch enabled Windows AMI.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// A Boolean that represents the current state of faster launching for the Windows AMI.
        /// Set to <c>true</c> to start using Windows faster launching, or <c>false</c> to stop
        /// using it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template that the fast-launch enabled Windows AMI uses when it launches
        /// Windows instances to create pre-provisioned snapshots.
        /// </para>
        /// </summary>
        public FastLaunchLaunchTemplateSpecification LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property MaxParallelLaunches. 
        /// <para>
        /// The maximum number of parallel instances that are launched for creating resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxParallelLaunches
        {
            get { return this._maxParallelLaunches; }
            set { this._maxParallelLaunches = value; }
        }

        // Check to see if MaxParallelLaunches property is set
        internal bool IsSetMaxParallelLaunches()
        {
            return this._maxParallelLaunches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotConfiguration. 
        /// <para>
        /// Configuration settings for managing the number of snapshots that are created from
        /// pre-provisioned instances for the Windows AMI when faster launching is enabled.
        /// </para>
        /// </summary>
        public FastLaunchSnapshotConfiguration SnapshotConfiguration
        {
            get { return this._snapshotConfiguration; }
            set { this._snapshotConfiguration = value; }
        }

        // Check to see if SnapshotConfiguration property is set
        internal bool IsSetSnapshotConfiguration()
        {
            return this._snapshotConfiguration != null;
        }

    }
}