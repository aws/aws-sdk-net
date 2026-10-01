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
    /// Container for the parameters to the UpdateLaunchConfiguration operation. Updates multiple
    /// LaunchConfigurations by Source Server ID. <note> <para> bootMode valid values are
    /// <c>LEGACY_BIOS | UEFI | USE_SOURCE</c> </para> </note>
    /// </summary>
    public partial class UpdateLaunchConfigurationRequest : AmazonMgnRequest
    {
        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// Update Launch configuration Account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountID { get; set; }

        /// <summary>
        /// Checks to see if the AccountID property is set.
        /// </summary>
        internal bool IsSetAccountID() => this.AccountID != null;

        /// <summary>
        /// Gets and sets the property BootMode. 
        /// <para>
        /// Update Launch configuration boot mode request.
        /// </para>
        /// </summary>
        public BootMode BootMode { get; set; }

        /// <summary>
        /// Checks to see if the BootMode property is set.
        /// </summary>
        internal bool IsSetBootMode() => this.BootMode != null;

        /// <summary>
        /// Gets and sets the property CopyPrivateIp. 
        /// <para>
        /// Update Launch configuration copy Private IP request.
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
        /// Update Launch configuration copy Tags request.
        /// </para>
        /// </summary>
        public bool? CopyTags { get; set; }

        /// <summary>
        /// Checks to see if the CopyTags property is set.
        /// </summary>
        internal bool IsSetCopyTags() => this.CopyTags.HasValue;

        /// <summary>
        /// Gets and sets the property EnableMapAutoTagging. 
        /// <para>
        /// Enable map auto tagging.
        /// </para>
        /// </summary>
        public bool? EnableMapAutoTagging { get; set; }

        /// <summary>
        /// Checks to see if the EnableMapAutoTagging property is set.
        /// </summary>
        internal bool IsSetEnableMapAutoTagging() => this.EnableMapAutoTagging.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchDisposition. 
        /// <para>
        /// Update Launch configuration launch disposition request.
        /// </para>
        /// </summary>
        public LaunchDisposition LaunchDisposition { get; set; }

        /// <summary>
        /// Checks to see if the LaunchDisposition property is set.
        /// </summary>
        internal bool IsSetLaunchDisposition() => this.LaunchDisposition != null;

        /// <summary>
        /// Gets and sets the property Licensing. 
        /// <para>
        /// Update Launch configuration licensing request.
        /// </para>
        /// </summary>
        public Licensing Licensing { get; set; }

        /// <summary>
        /// Checks to see if the Licensing property is set.
        /// </summary>
        internal bool IsSetLicensing() => this.Licensing != null;

        /// <summary>
        /// Gets and sets the property MapAutoTaggingMpeID. 
        /// <para>
        /// Launch configuration map auto tagging MPE ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string MapAutoTaggingMpeID { get; set; }

        /// <summary>
        /// Checks to see if the MapAutoTaggingMpeID property is set.
        /// </summary>
        internal bool IsSetMapAutoTaggingMpeID() => this.MapAutoTaggingMpeID != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Update Launch configuration name request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PostLaunchActions.
        /// </summary>
        public PostLaunchActions PostLaunchActions { get; set; }

        /// <summary>
        /// Checks to see if the PostLaunchActions property is set.
        /// </summary>
        internal bool IsSetPostLaunchActions() => this.PostLaunchActions != null;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Update Launch configuration by Source Server ID request.
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
        /// Update Launch configuration Target instance right sizing request.
        /// </para>
        /// </summary>
        public TargetInstanceTypeRightSizingMethod TargetInstanceTypeRightSizingMethod { get; set; }

        /// <summary>
        /// Checks to see if the TargetInstanceTypeRightSizingMethod property is set.
        /// </summary>
        internal bool IsSetTargetInstanceTypeRightSizingMethod() => this.TargetInstanceTypeRightSizingMethod != null;
    }
}
