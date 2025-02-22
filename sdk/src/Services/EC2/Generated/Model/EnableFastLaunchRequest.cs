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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the EnableFastLaunch operation.
    /// When you enable Windows fast launch for a Windows AMI, images are pre-provisioned,
    /// using snapshots to launch instances up to 65% faster. To create the optimized Windows
    /// image, Amazon EC2 launches an instance and runs through Sysprep steps, rebooting as
    /// required. Then it creates a set of reserved snapshots that are used for subsequent
    /// launches. The reserved snapshots are automatically replenished as they are used, depending
    /// on your settings for launch frequency.
    /// 
    ///  <note> 
    /// <para>
    /// You can only change these settings for Windows AMIs that you own or that have been
    /// shared with you.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class EnableFastLaunchRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _imageId;
        private FastLaunchLaunchTemplateSpecificationRequest _launchTemplate;
        private int? _maxParallelLaunches;
        private string _resourceType;
        private FastLaunchSnapshotConfigurationRequest _snapshotConfiguration;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// Specify the ID of the image for which to enable Windows fast launch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template to use when launching Windows instances from pre-provisioned snapshots.
        /// Launch template parameters can include either the name or ID of the launch template,
        /// but not both.
        /// </para>
        /// </summary>
        public FastLaunchLaunchTemplateSpecificationRequest LaunchTemplate
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
        /// The maximum number of instances that Amazon EC2 can launch at the same time to create
        /// pre-provisioned snapshots for Windows fast launch. Value must be <c>6</c> or greater.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to use for pre-provisioning the AMI for Windows fast launch.
        /// Supported values include: <c>snapshot</c>, which is the default value.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotConfiguration. 
        /// <para>
        /// Configuration settings for creating and managing the snapshots that are used for pre-provisioning
        /// the AMI for Windows fast launch. The associated <c>ResourceType</c> must be <c>snapshot</c>.
        /// </para>
        /// </summary>
        public FastLaunchSnapshotConfigurationRequest SnapshotConfiguration
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