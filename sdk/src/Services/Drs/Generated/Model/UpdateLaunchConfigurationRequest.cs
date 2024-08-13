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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
    /// Container for the parameters to the UpdateLaunchConfiguration operation.
    /// Updates a LaunchConfiguration by Source Server ID.
    /// </summary>
    public partial class UpdateLaunchConfigurationRequest : AmazonDrsRequest
    {
        private bool? _copyPrivateIp;
        private bool? _copyTags;
        private LaunchDisposition _launchDisposition;
        private LaunchIntoInstanceProperties _launchIntoInstanceProperties;
        private Licensing _licensing;
        private string _name;
        private bool? _postLaunchEnabled;
        private string _sourceServerID;
        private TargetInstanceTypeRightSizingMethod _targetInstanceTypeRightSizingMethod;

        /// <summary>
        /// Gets and sets the property CopyPrivateIp. 
        /// <para>
        /// Whether we should copy the Private IP of the Source Server to the Recovery Instance.
        /// </para>
        /// </summary>
        public bool? CopyPrivateIp
        {
            get { return this._copyPrivateIp; }
            set { this._copyPrivateIp = value; }
        }

        // Check to see if CopyPrivateIp property is set
        internal bool IsSetCopyPrivateIp()
        {
            return this._copyPrivateIp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// Whether we want to copy the tags of the Source Server to the EC2 machine of the Recovery
        /// Instance.
        /// </para>
        /// </summary>
        public bool? CopyTags
        {
            get { return this._copyTags; }
            set { this._copyTags = value; }
        }

        // Check to see if CopyTags property is set
        internal bool IsSetCopyTags()
        {
            return this._copyTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchDisposition. 
        /// <para>
        /// The state of the Recovery Instance in EC2 after the recovery operation.
        /// </para>
        /// </summary>
        public LaunchDisposition LaunchDisposition
        {
            get { return this._launchDisposition; }
            set { this._launchDisposition = value; }
        }

        // Check to see if LaunchDisposition property is set
        internal bool IsSetLaunchDisposition()
        {
            return this._launchDisposition != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchIntoInstanceProperties. 
        /// <para>
        /// Launch into existing instance properties.
        /// </para>
        /// </summary>
        public LaunchIntoInstanceProperties LaunchIntoInstanceProperties
        {
            get { return this._launchIntoInstanceProperties; }
            set { this._launchIntoInstanceProperties = value; }
        }

        // Check to see if LaunchIntoInstanceProperties property is set
        internal bool IsSetLaunchIntoInstanceProperties()
        {
            return this._launchIntoInstanceProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Licensing. 
        /// <para>
        /// The licensing configuration to be used for this launch configuration.
        /// </para>
        /// </summary>
        public Licensing Licensing
        {
            get { return this._licensing; }
            set { this._licensing = value; }
        }

        // Check to see if Licensing property is set
        internal bool IsSetLicensing()
        {
            return this._licensing != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the launch configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PostLaunchEnabled. 
        /// <para>
        /// Whether we want to enable post-launch actions for the Source Server.
        /// </para>
        /// </summary>
        public bool? PostLaunchEnabled
        {
            get { return this._postLaunchEnabled; }
            set { this._postLaunchEnabled = value; }
        }

        // Check to see if PostLaunchEnabled property is set
        internal bool IsSetPostLaunchEnabled()
        {
            return this._postLaunchEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// The ID of the Source Server that we want to retrieve a Launch Configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string SourceServerID
        {
            get { return this._sourceServerID; }
            set { this._sourceServerID = value; }
        }

        // Check to see if SourceServerID property is set
        internal bool IsSetSourceServerID()
        {
            return this._sourceServerID != null;
        }

        /// <summary>
        /// Gets and sets the property TargetInstanceTypeRightSizingMethod. 
        /// <para>
        /// Whether Elastic Disaster Recovery should try to automatically choose the instance
        /// type that best matches the OS, CPU, and RAM of your Source Server.
        /// </para>
        /// </summary>
        public TargetInstanceTypeRightSizingMethod TargetInstanceTypeRightSizingMethod
        {
            get { return this._targetInstanceTypeRightSizingMethod; }
            set { this._targetInstanceTypeRightSizingMethod = value; }
        }

        // Check to see if TargetInstanceTypeRightSizingMethod property is set
        internal bool IsSetTargetInstanceTypeRightSizingMethod()
        {
            return this._targetInstanceTypeRightSizingMethod != null;
        }

    }
}