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
    /// The output of a SageMaker Edge Manager deployable resource.
    /// </summary>
    public partial class EdgePresetDeploymentOutput
    {
        /// <summary>
        /// Gets and sets the property Artifact. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the generated deployable resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Artifact { get; set; }

        /// <summary>
        /// Checks to see if the Artifact property is set.
        /// </summary>
        internal bool IsSetArtifact() => this.Artifact != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the deployable resource.
        /// </para>
        /// </summary>
        public EdgePresetDeploymentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Returns a message describing the status of the deployed resource.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The deployment type created by SageMaker Edge Manager. Currently only supports Amazon
        /// Web Services IoT Greengrass Version 2 components.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EdgePresetDeploymentType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
