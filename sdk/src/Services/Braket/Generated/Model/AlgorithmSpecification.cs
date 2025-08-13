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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Defines the Amazon Braket hybrid job to be created. Specifies the container image
    /// the job uses and the paths to the Python scripts used for entry and training.
    /// </summary>
    public partial class AlgorithmSpecification
    {
        private ContainerImage _containerImage;
        private ScriptModeConfig _scriptModeConfig;

        /// <summary>
        /// Gets and sets the property ContainerImage. 
        /// <para>
        /// The container image used to create an Amazon Braket hybrid job.
        /// </para>
        /// </summary>
        public ContainerImage ContainerImage
        {
            get { return this._containerImage; }
            set { this._containerImage = value; }
        }

        // Check to see if ContainerImage property is set
        internal bool IsSetContainerImage()
        {
            return this._containerImage != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptModeConfig. 
        /// <para>
        /// Configures the paths to the Python scripts used for entry and training.
        /// </para>
        /// </summary>
        public ScriptModeConfig ScriptModeConfig
        {
            get { return this._scriptModeConfig; }
            set { this._scriptModeConfig = value; }
        }

        // Check to see if ScriptModeConfig property is set
        internal bool IsSetScriptModeConfig()
        {
            return this._scriptModeConfig != null;
        }

    }
}