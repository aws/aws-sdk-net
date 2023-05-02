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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OSIS.Model
{
    /// <summary>
    /// Container for information about an OpenSearch Ingestion blueprint.
    /// </summary>
    public partial class PipelineBlueprint
    {
        private string _blueprintName;
        private string _pipelineConfigurationBody;

        /// <summary>
        /// Gets and sets the property BlueprintName. 
        /// <para>
        /// The name of the blueprint.
        /// </para>
        /// </summary>
        public string BlueprintName
        {
            get { return this._blueprintName; }
            set { this._blueprintName = value; }
        }

        // Check to see if BlueprintName property is set
        internal bool IsSetBlueprintName()
        {
            return this._blueprintName != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineConfigurationBody. 
        /// <para>
        /// The YAML configuration of the blueprint.
        /// </para>
        /// </summary>
        public string PipelineConfigurationBody
        {
            get { return this._pipelineConfigurationBody; }
            set { this._pipelineConfigurationBody = value; }
        }

        // Check to see if PipelineConfigurationBody property is set
        internal bool IsSetPipelineConfigurationBody()
        {
            return this._pipelineConfigurationBody != null;
        }

    }
}