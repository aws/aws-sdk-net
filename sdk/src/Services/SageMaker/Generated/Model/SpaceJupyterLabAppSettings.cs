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
    /// The settings for the JupyterLab application within a space.
    /// </summary>
    public partial class SpaceJupyterLabAppSettings
    {
        private SpaceAppLifecycleManagement _appLifecycleManagement;
        private List<CodeRepository> _codeRepositories = AWSConfigs.InitializeCollections ? new List<CodeRepository>() : null;
        private ResourceSpec _defaultResourceSpec;

        /// <summary>
        /// Gets and sets the property AppLifecycleManagement. 
        /// <para>
        /// Settings that are used to configure and manage the lifecycle of JupyterLab applications
        /// in a space.
        /// </para>
        /// </summary>
        public SpaceAppLifecycleManagement AppLifecycleManagement
        {
            get { return this._appLifecycleManagement; }
            set { this._appLifecycleManagement = value; }
        }

        // Check to see if AppLifecycleManagement property is set
        internal bool IsSetAppLifecycleManagement()
        {
            return this._appLifecycleManagement != null;
        }

        /// <summary>
        /// Gets and sets the property CodeRepositories. 
        /// <para>
        /// A list of Git repositories that SageMaker automatically displays to users for cloning
        /// in the JupyterLab application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
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

    }
}