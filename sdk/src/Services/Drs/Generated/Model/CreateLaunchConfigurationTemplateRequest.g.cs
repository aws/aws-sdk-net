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
    /// Container for the parameters to the CreateLaunchConfigurationTemplate operation. Creates
    /// a new Launch Configuration Template.
    /// </summary>
    public partial class CreateLaunchConfigurationTemplateRequest : AmazonDrsRequest
    {
        /// <summary>
        /// Gets and sets the property CopyPrivateIp. 
        /// <para>
        /// Copy private IP.
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
        /// Copy tags.
        /// </para>
        /// </summary>
        public bool? CopyTags { get; set; }

        /// <summary>
        /// Checks to see if the CopyTags property is set.
        /// </summary>
        internal bool IsSetCopyTags() => this.CopyTags.HasValue;

        /// <summary>
        /// Gets and sets the property ExportBucketArn. 
        /// <para>
        /// S3 bucket ARN to export Source Network templates.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExportBucketArn { get; set; }

        /// <summary>
        /// Checks to see if the ExportBucketArn property is set.
        /// </summary>
        internal bool IsSetExportBucketArn() => this.ExportBucketArn != null;

        /// <summary>
        /// Gets and sets the property LaunchDisposition. 
        /// <para>
        /// Launch disposition.
        /// </para>
        /// </summary>
        public LaunchDisposition LaunchDisposition { get; set; }

        /// <summary>
        /// Checks to see if the LaunchDisposition property is set.
        /// </summary>
        internal bool IsSetLaunchDisposition() => this.LaunchDisposition != null;

        /// <summary>
        /// Gets and sets the property LaunchIntoSourceInstance. 
        /// <para>
        /// DRS will set the 'launch into instance ID' of any source server when performing a
        /// drill, recovery or failback to the previous region or availability zone, using the
        /// instance ID of the source instance.
        /// </para>
        /// </summary>
        public bool? LaunchIntoSourceInstance { get; set; }

        /// <summary>
        /// Checks to see if the LaunchIntoSourceInstance property is set.
        /// </summary>
        internal bool IsSetLaunchIntoSourceInstance() => this.LaunchIntoSourceInstance.HasValue;

        /// <summary>
        /// Gets and sets the property Licensing. 
        /// <para>
        /// Licensing.
        /// </para>
        /// </summary>
        public Licensing Licensing { get; set; }

        /// <summary>
        /// Checks to see if the Licensing property is set.
        /// </summary>
        internal bool IsSetLicensing() => this.Licensing != null;

        /// <summary>
        /// Gets and sets the property PostLaunchEnabled. 
        /// <para>
        /// Whether we want to activate post-launch actions.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Request to associate tags during creation of a Launch Configuration Template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetInstanceTypeRightSizingMethod. 
        /// <para>
        /// Target instance type right-sizing method.
        /// </para>
        /// </summary>
        public TargetInstanceTypeRightSizingMethod TargetInstanceTypeRightSizingMethod { get; set; }

        /// <summary>
        /// Checks to see if the TargetInstanceTypeRightSizingMethod property is set.
        /// </summary>
        internal bool IsSetTargetInstanceTypeRightSizingMethod() => this.TargetInstanceTypeRightSizingMethod != null;
    }
}
