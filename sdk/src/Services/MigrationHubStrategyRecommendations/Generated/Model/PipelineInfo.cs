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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Detailed information of the pipeline.
    /// </summary>
    public partial class PipelineInfo
    {
        private string _pipelineConfigurationTimeStamp;
        private PipelineType _pipelineType;

        /// <summary>
        /// Gets and sets the property PipelineConfigurationTimeStamp. 
        /// <para>
        /// The time when the pipeline info was configured.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string PipelineConfigurationTimeStamp
        {
            get { return this._pipelineConfigurationTimeStamp; }
            set { this._pipelineConfigurationTimeStamp = value; }
        }

        // Check to see if PipelineConfigurationTimeStamp property is set
        internal bool IsSetPipelineConfigurationTimeStamp()
        {
            return this._pipelineConfigurationTimeStamp != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineType. 
        /// <para>
        /// The type of pipeline.
        /// </para>
        /// </summary>
        public PipelineType PipelineType
        {
            get { return this._pipelineType; }
            set { this._pipelineType = value; }
        }

        // Check to see if PipelineType property is set
        internal bool IsSetPipelineType()
        {
            return this._pipelineType != null;
        }

    }
}