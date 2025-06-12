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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
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
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Configuration information for the AWS IoT Greengrass component created in a model
    /// packaging job. For more information, see <a>StartModelPackagingJob</a>. 
    /// 
    ///  <note> 
    /// <para>
    /// You can't specify a component with the same <c>ComponentName</c> and <c>Componentversion</c>
    /// as an existing component with the same component name and component version.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GreengrassConfiguration
    {
        private string _compilerOptions;
        private string _componentDescription;
        private string _componentName;
        private string _componentVersion;
        private S3Location _s3OutputLocation;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TargetDevice _targetDevice;
        private TargetPlatform _targetPlatform;

        /// <summary>
        /// Gets and sets the property CompilerOptions. 
        /// <para>
        /// Additional compiler options for the Greengrass component. Currently, only NVIDIA Graphics
        /// Processing Units (GPU) and CPU accelerators are supported. If you specify <c>TargetDevice</c>,
        /// don't specify <c>CompilerOptions</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <i>Compiler options</i> in the Amazon Lookout for Vision
        /// Developer Guide. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=1024)]
        public string CompilerOptions
        {
            get { return this._compilerOptions; }
            set { this._compilerOptions = value; }
        }

        // Check to see if CompilerOptions property is set
        internal bool IsSetCompilerOptions()
        {
            return this._compilerOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentDescription. 
        /// <para>
        ///  A description for the AWS IoT Greengrass component. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ComponentDescription
        {
            get { return this._componentDescription; }
            set { this._componentDescription = value; }
        }

        // Check to see if ComponentDescription property is set
        internal bool IsSetComponentDescription()
        {
            return this._componentDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        ///  A name for the AWS IoT Greengrass component. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentVersion. 
        /// <para>
        /// A Version for the AWS IoT Greengrass component. If you don't provide a value, a default
        /// value of <c> <i>Model Version</i>.0.0</c> is used. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ComponentVersion
        {
            get { return this._componentVersion; }
            set { this._componentVersion = value; }
        }

        // Check to see if ComponentVersion property is set
        internal bool IsSetComponentVersion()
        {
            return this._componentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property S3OutputLocation. 
        /// <para>
        ///  An S3 location in which Lookout for Vision stores the component artifacts. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Location S3OutputLocation
        {
            get { return this._s3OutputLocation; }
            set { this._s3OutputLocation = value; }
        }

        // Check to see if S3OutputLocation property is set
        internal bool IsSetS3OutputLocation()
        {
            return this._s3OutputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A set of tags (key-value pairs) that you want to attach to the AWS IoT Greengrass
        /// component. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
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
        /// Gets and sets the property TargetDevice. 
        /// <para>
        /// The target device for the model. Currently the only supported value is <c>jetson_xavier</c>.
        /// If you specify <c>TargetDevice</c>, you can't specify <c>TargetPlatform</c>. 
        /// </para>
        /// </summary>
        public TargetDevice TargetDevice
        {
            get { return this._targetDevice; }
            set { this._targetDevice = value; }
        }

        // Check to see if TargetDevice property is set
        internal bool IsSetTargetDevice()
        {
            return this._targetDevice != null;
        }

        /// <summary>
        /// Gets and sets the property TargetPlatform. 
        /// <para>
        /// The target platform for the model. If you specify <c>TargetPlatform</c>, you can't
        /// specify <c>TargetDevice</c>. 
        /// </para>
        /// </summary>
        public TargetPlatform TargetPlatform
        {
            get { return this._targetPlatform; }
            set { this._targetPlatform = value; }
        }

        // Check to see if TargetPlatform property is set
        internal bool IsSetTargetPlatform()
        {
            return this._targetPlatform != null;
        }

    }
}