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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLaunchConfiguration operation. Updates a
    /// LaunchConfiguration by Source Server ID.
    /// </summary>
    public partial class UpdateLaunchConfigurationRequest : AmazonDrsRequest
    {
        /// <summary>
        /// Gets and sets the property CopyPrivateIp. 
        /// <para>
        /// Whether we should copy the Private IP of the Source Server to the Recovery Instance.
        /// </para>
        /// </summary>
        public bool? CopyPrivateIp { get; set; }

        /// <summary>
        /// Checks to see if the CopyPrivateIp property is set.
        /// </summary>
        internal bool IsSetCopyPrivateIp() => this.CopyPrivateIp.HasValue;

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// Whether we want to copy the tags of the Source Server to the EC2 machine of the Recovery
        /// Instance.
        /// </para>
        /// </summary>
        public bool? CopyTags { get; set; }

        /// <summary>
        /// Checks to see if the CopyTags property is set.
        /// </summary>
        internal bool IsSetCopyTags() => this.CopyTags.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchDisposition. 
        /// <para>
        /// The state of the Recovery Instance in EC2 after the recovery operation.
        /// </para>
        /// </summary>
        public LaunchDisposition LaunchDisposition { get; set; }

        /// <summary>
        /// Checks to see if the LaunchDisposition property is set.
        /// </summary>
        internal bool IsSetLaunchDisposition() => this.LaunchDisposition != null;

        /// <summary>
        /// Gets and sets the property LaunchIntoInstanceProperties. 
        /// <para>
        /// Launch into existing instance properties.
        /// </para>
        /// </summary>
        public LaunchIntoInstanceProperties LaunchIntoInstanceProperties { get; set; }

        /// <summary>
        /// Checks to see if the LaunchIntoInstanceProperties property is set.
        /// </summary>
        internal bool IsSetLaunchIntoInstanceProperties() => this.LaunchIntoInstanceProperties != null;

        /// <summary>
        /// Gets and sets the property Licensing. 
        /// <para>
        /// The licensing configuration to be used for this launch configuration.
        /// </para>
        /// </summary>
        public Licensing Licensing { get; set; }

        /// <summary>
        /// Checks to see if the Licensing property is set.
        /// </summary>
        internal bool IsSetLicensing() => this.Licensing != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the launch configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PostLaunchEnabled. 
        /// <para>
        /// Whether we want to enable post-launch actions for the Source Server.
        /// </para>
        /// </summary>
        public bool? PostLaunchEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PostLaunchEnabled property is set.
        /// </summary>
        internal bool IsSetPostLaunchEnabled() => this.PostLaunchEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property RecoveryMode. 
        /// <para>
        /// Recovery mode.
        /// </para>
        /// </summary>
        public RecoveryMode RecoveryMode { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryMode property is set.
        /// </summary>
        internal bool IsSetRecoveryMode() => this.RecoveryMode != null;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// The ID of the Source Server that we want to retrieve a Launch Configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;

        /// <summary>
        /// Gets and sets the property TargetInstanceTypeRightSizingMethod. 
        /// <para>
        /// Whether Elastic Disaster Recovery should try to automatically choose the instance
        /// type that best matches the OS, CPU, and RAM of your Source Server.
        /// </para>
        /// </summary>
        public TargetInstanceTypeRightSizingMethod TargetInstanceTypeRightSizingMethod { get; set; }

        /// <summary>
        /// Checks to see if the TargetInstanceTypeRightSizingMethod property is set.
        /// </summary>
        internal bool IsSetTargetInstanceTypeRightSizingMethod() => this.TargetInstanceTypeRightSizingMethod != null;
    }
}
