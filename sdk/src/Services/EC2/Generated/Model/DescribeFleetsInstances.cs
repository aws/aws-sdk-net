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
    /// Describes the instances that were launched by the fleet.
    /// </summary>
    public partial class DescribeFleetsInstances
    {
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private InstanceType _instanceType;
        private LaunchTemplateAndOverridesResponse _launchTemplateAndOverrides;
        private InstanceLifecycle _lifecycle;
        private PlatformValues _platform;

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The IDs of the instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && (this._instanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateAndOverrides. 
        /// <para>
        /// The launch templates and overrides that were used for launching the instances. The
        /// values that you specify in the Overrides replace the values in the launch template.
        /// </para>
        /// </summary>
        public LaunchTemplateAndOverridesResponse LaunchTemplateAndOverrides
        {
            get { return this._launchTemplateAndOverrides; }
            set { this._launchTemplateAndOverrides = value; }
        }

        // Check to see if LaunchTemplateAndOverrides property is set
        internal bool IsSetLaunchTemplateAndOverrides()
        {
            return this._launchTemplateAndOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// Indicates if the instance that was launched is a Spot Instance or On-Demand Instance.
        /// </para>
        /// </summary>
        public InstanceLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The value is <c>windows</c> for Windows instances in an EC2 Fleet. Otherwise, the
        /// value is blank.
        /// </para>
        /// </summary>
        public PlatformValues Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

    }
}