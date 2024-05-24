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
    /// The output of a SageMaker Edge Manager deployable resource.
    /// </summary>
    public partial class EdgePresetDeploymentOutput
    {
        private string _artifact;
        private EdgePresetDeploymentStatus _status;
        private string _statusMessage;
        private EdgePresetDeploymentType _type;

        /// <summary>
        /// Gets and sets the property Artifact. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the generated deployable resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Artifact
        {
            get { return this._artifact; }
            set { this._artifact = value; }
        }

        // Check to see if Artifact property is set
        internal bool IsSetArtifact()
        {
            return this._artifact != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the deployable resource.
        /// </para>
        /// </summary>
        public EdgePresetDeploymentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Returns a message describing the status of the deployed resource.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The deployment type created by SageMaker Edge Manager. Currently only supports Amazon
        /// Web Services IoT Greengrass Version 2 components.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EdgePresetDeploymentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}