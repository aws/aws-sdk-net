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
    /// The application settings for a Code Editor space.
    /// </summary>
    public partial class SpaceCodeEditorAppSettings
    {
        private SpaceAppLifecycleManagement _appLifecycleManagement;
        private ResourceSpec _defaultResourceSpec;

        /// <summary>
        /// Gets and sets the property AppLifecycleManagement. 
        /// <para>
        /// Settings that are used to configure and manage the lifecycle of CodeEditor applications
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