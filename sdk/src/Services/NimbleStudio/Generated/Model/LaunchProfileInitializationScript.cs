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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// The launch profile initialization script is used when start streaming session runs.
    /// </summary>
    public partial class LaunchProfileInitializationScript
    {
        private string _runtimeRoleArn;
        private string _script;
        private string _secureInitializationRoleArn;
        private string _studioComponentId;
        private string _studioComponentName;

        /// <summary>
        /// Gets and sets the property RuntimeRoleArn. 
        /// <para>
        /// An IAM role attached to a Studio Component that gives the studio component access
        /// to Amazon Web Services resources at anytime while the instance is running. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string RuntimeRoleArn
        {
            get { return this._runtimeRoleArn; }
            set { this._runtimeRoleArn = value; }
        }

        // Check to see if RuntimeRoleArn property is set
        internal bool IsSetRuntimeRoleArn()
        {
            return this._runtimeRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Script. 
        /// <para>
        /// The initialization script.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5120)]
        public string Script
        {
            get { return this._script; }
            set { this._script = value; }
        }

        // Check to see if Script property is set
        internal bool IsSetScript()
        {
            return this._script != null;
        }

        /// <summary>
        /// Gets and sets the property SecureInitializationRoleArn. 
        /// <para>
        /// An IAM role attached to Studio Component when the system initialization script runs
        /// which give the studio component access to Amazon Web Services resources when the system
        /// initialization script runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string SecureInitializationRoleArn
        {
            get { return this._secureInitializationRoleArn; }
            set { this._secureInitializationRoleArn = value; }
        }

        // Check to see if SecureInitializationRoleArn property is set
        internal bool IsSetSecureInitializationRoleArn()
        {
            return this._secureInitializationRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StudioComponentId. 
        /// <para>
        /// The unique identifier for a studio component resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=22)]
        public string StudioComponentId
        {
            get { return this._studioComponentId; }
            set { this._studioComponentId = value; }
        }

        // Check to see if StudioComponentId property is set
        internal bool IsSetStudioComponentId()
        {
            return this._studioComponentId != null;
        }

        /// <summary>
        /// Gets and sets the property StudioComponentName. 
        /// <para>
        /// The name for the studio component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string StudioComponentName
        {
            get { return this._studioComponentName; }
            set { this._studioComponentName = value; }
        }

        // Check to see if StudioComponentName property is set
        internal bool IsSetStudioComponentName()
        {
            return this._studioComponentName != null;
        }

    }
}