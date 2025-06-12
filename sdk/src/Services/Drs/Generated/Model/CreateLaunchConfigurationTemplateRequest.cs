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
    /// Container for the parameters to the CreateLaunchConfigurationTemplate operation.
    /// Creates a new Launch Configuration Template.
    /// </summary>
    public partial class CreateLaunchConfigurationTemplateRequest : AmazonDrsRequest
    {
        private bool? _copyPrivateIp;
        private bool? _copyTags;
        private string _exportBucketArn;
        private LaunchDisposition _launchDisposition;
        private bool? _launchIntoSourceInstance;
        private Licensing _licensing;
        private bool? _postLaunchEnabled;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TargetInstanceTypeRightSizingMethod _targetInstanceTypeRightSizingMethod;

        /// <summary>
        /// Gets and sets the property CopyPrivateIp. 
        /// <para>
        /// Copy private IP.
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
        /// Copy tags.
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
        /// Gets and sets the property ExportBucketArn. 
        /// <para>
        /// S3 bucket ARN to export Source Network templates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExportBucketArn
        {
            get { return this._exportBucketArn; }
            set { this._exportBucketArn = value; }
        }

        // Check to see if ExportBucketArn property is set
        internal bool IsSetExportBucketArn()
        {
            return this._exportBucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchDisposition. 
        /// <para>
        /// Launch disposition.
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
        /// Gets and sets the property LaunchIntoSourceInstance. 
        /// <para>
        /// DRS will set the 'launch into instance ID' of any source server when performing a
        /// drill, recovery or failback to the previous region or availability zone, using the
        /// instance ID of the source instance.
        /// </para>
        /// </summary>
        public bool? LaunchIntoSourceInstance
        {
            get { return this._launchIntoSourceInstance; }
            set { this._launchIntoSourceInstance = value; }
        }

        // Check to see if LaunchIntoSourceInstance property is set
        internal bool IsSetLaunchIntoSourceInstance()
        {
            return this._launchIntoSourceInstance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Licensing. 
        /// <para>
        /// Licensing.
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
        /// Gets and sets the property PostLaunchEnabled. 
        /// <para>
        /// Whether we want to activate post-launch actions.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Request to associate tags during creation of a Launch Configuration Template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetInstanceTypeRightSizingMethod. 
        /// <para>
        /// Target instance type right-sizing method.
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