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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// The settings for the JupyterLab application.
    /// </summary>
    public partial class JupyterLabAppSettings
    {
        private List<CodeRepository> _codeRepositories = AWSConfigs.InitializeCollections ? new List<CodeRepository>() : null;
        private List<CustomImage> _customImages = AWSConfigs.InitializeCollections ? new List<CustomImage>() : null;
        private ResourceSpec _defaultResourceSpec;
        private List<string> _lifecycleConfigArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CodeRepositories. 
        /// <para>
        /// A list of Git repositories that SageMaker automatically displays to users for cloning
        /// in the JupyterLab application.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<CodeRepository> CodeRepositories
        {
            get { return this._codeRepositories; }
            set { this._codeRepositories = value; }
        }

        // Check to see if CodeRepositories property is set
        internal bool IsSetCodeRepositories()
        {
            return this._codeRepositories != null && (this._codeRepositories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomImages. 
        /// <para>
        /// A list of custom SageMaker images that are configured to run as a JupyterLab app.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<CustomImage> CustomImages
        {
            get { return this._customImages; }
            set { this._customImages = value; }
        }

        // Check to see if CustomImages property is set
        internal bool IsSetCustomImages()
        {
            return this._customImages != null && (this._customImages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultResourceSpec.
        /// </summary>
        public ResourceSpec DefaultResourceSpec
        {
            get { return this._defaultResourceSpec; }
            set { this._defaultResourceSpec = value; }
        }

        // Check to see if DefaultResourceSpec property is set
        internal bool IsSetDefaultResourceSpec()
        {
            return this._defaultResourceSpec != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleConfigArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the lifecycle configurations attached to the user
        /// profile or domain. To remove a lifecycle config, you must set <c>LifecycleConfigArns</c>
        /// to an empty list.
        /// </para>
        /// </summary>
        public List<string> LifecycleConfigArns
        {
            get { return this._lifecycleConfigArns; }
            set { this._lifecycleConfigArns = value; }
        }

        // Check to see if LifecycleConfigArns property is set
        internal bool IsSetLifecycleConfigArns()
        {
            return this._lifecycleConfigArns != null && (this._lifecycleConfigArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}