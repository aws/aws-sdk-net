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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
    /// Container for the parameters to the UpdateLaunchConfiguration operation.
    /// Updates multiple LaunchConfigurations by Source Server ID.
    /// 
    ///  <note> 
    /// <para>
    /// bootMode valid values are <c>LEGACY_BIOS | UEFI</c> 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateLaunchConfigurationRequest : AmazonMgnRequest
    {
        private string _accountid;
        private BootMode _bootMode;
        private bool? _copyPrivateIp;
        private bool? _copyTags;
        private bool? _enableMapAutoTagging;
        private LaunchDisposition _launchDisposition;
        private Licensing _licensing;
        private string _mapAutoTaggingMpeID;
        private string _name;
        private PostLaunchActions _postLaunchActions;
        private string _sourceServerID;
        private TargetInstanceTypeRightSizingMethod _targetInstanceTypeRightSizingMethod;

        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// Update Launch configuration Account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountID
        {
            get { return this._accountid; }
            set { this._accountid = value; }
        }

        // Check to see if AccountID property is set
        internal bool IsSetAccountID()
        {
            return this._accountid != null;
        }

        /// <summary>
        /// Gets and sets the property BootMode. 
        /// <para>
        /// Update Launch configuration boot mode request.
        /// </para>
        /// </summary>
        public BootMode BootMode
        {
            get { return this._bootMode; }
            set { this._bootMode = value; }
        }

        // Check to see if BootMode property is set
        internal bool IsSetBootMode()
        {
            return this._bootMode != null;
        }

        /// <summary>
        /// Gets and sets the property CopyPrivateIp. 
        /// <para>
        /// Update Launch configuration copy Private IP request.
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
        /// Update Launch configuration copy Tags request.
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
        /// Gets and sets the property EnableMapAutoTagging. 
        /// <para>
        /// Enable map auto tagging.
        /// </para>
        /// </summary>
        public bool? EnableMapAutoTagging
        {
            get { return this._enableMapAutoTagging; }
            set { this._enableMapAutoTagging = value; }
        }

        // Check to see if EnableMapAutoTagging property is set
        internal bool IsSetEnableMapAutoTagging()
        {
            return this._enableMapAutoTagging.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchDisposition. 
        /// <para>
        /// Update Launch configuration launch disposition request.
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
        /// Gets and sets the property Licensing. 
        /// <para>
        /// Update Launch configuration licensing request.
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
        /// Gets and sets the property MapAutoTaggingMpeID. 
        /// <para>
        /// Launch configuration map auto tagging MPE ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string MapAutoTaggingMpeID
        {
            get { return this._mapAutoTaggingMpeID; }
            set { this._mapAutoTaggingMpeID = value; }
        }

        // Check to see if MapAutoTaggingMpeID property is set
        internal bool IsSetMapAutoTaggingMpeID()
        {
            return this._mapAutoTaggingMpeID != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Update Launch configuration name request.
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
        /// Gets and sets the property PostLaunchActions.
        /// </summary>
        public PostLaunchActions PostLaunchActions
        {
            get { return this._postLaunchActions; }
            set { this._postLaunchActions = value; }
        }

        // Check to see if PostLaunchActions property is set
        internal bool IsSetPostLaunchActions()
        {
            return this._postLaunchActions != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Update Launch configuration by Source Server ID request.
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
        /// Update Launch configuration Target instance right sizing request.
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