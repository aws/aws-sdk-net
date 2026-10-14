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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The Code Editor application settings.
    /// 
    ///  
    /// <para>
    /// For more information about Code Editor, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/code-editor.html">Get
    /// started with Code Editor in Amazon SageMaker</a>.
    /// </para>
    /// </summary>
    public partial class CodeEditorAppSettings
    {
        /// <summary>
        /// Gets and sets the property AppLifecycleManagement. 
        /// <para>
        /// Settings that are used to configure and manage the lifecycle of CodeEditor applications.
        /// </para>
        /// </summary>
        public AppLifecycleManagement AppLifecycleManagement { get; set; }

        /// <summary>
        /// Checks to see if the AppLifecycleManagement property is set.
        /// </summary>
        internal bool IsSetAppLifecycleManagement() => this.AppLifecycleManagement != null;

        /// <summary>
        /// Gets and sets the property BuiltInLifecycleConfigArn. 
        /// <para>
        /// The lifecycle configuration that runs before the default lifecycle configuration.
        /// It can override changes made in the default lifecycle configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string BuiltInLifecycleConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the BuiltInLifecycleConfigArn property is set.
        /// </summary>
        internal bool IsSetBuiltInLifecycleConfigArn() => this.BuiltInLifecycleConfigArn != null;

        /// <summary>
        /// Gets and sets the property CustomImages. 
        /// <para>
        /// A list of custom SageMaker images that are configured to run as a Code Editor app.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<CustomImage> CustomImages { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomImage>() : null;

        /// <summary>
        /// Checks to see if the CustomImages property is set.
        /// </summary>
        internal bool IsSetCustomImages() => this.CustomImages != null && (this.CustomImages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultResourceSpec.
        /// </summary>
        public ResourceSpec DefaultResourceSpec { get; set; }

        /// <summary>
        /// Checks to see if the DefaultResourceSpec property is set.
        /// </summary>
        internal bool IsSetDefaultResourceSpec() => this.DefaultResourceSpec != null;

        /// <summary>
        /// Gets and sets the property LifecycleConfigArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Code Editor application lifecycle configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LifecycleConfigArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LifecycleConfigArns property is set.
        /// </summary>
        internal bool IsSetLifecycleConfigArns() => this.LifecycleConfigArns != null && (this.LifecycleConfigArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
