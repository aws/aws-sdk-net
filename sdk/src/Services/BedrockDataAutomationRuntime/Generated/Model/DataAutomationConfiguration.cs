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
 * Do not modify this file. This file is generated from the bedrock-data-automation-runtime-2024-06-13.normal.json service model.
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
namespace Amazon.BedrockDataAutomationRuntime.Model
{
    /// <summary>
    /// Data automation configuration.
    /// </summary>
    public partial class DataAutomationConfiguration
    {
        private string _dataAutomationProjectArn;
        private DataAutomationStage _stage;

        /// <summary>
        /// Gets and sets the property DataAutomationProjectArn. 
        /// <para>
        /// Data automation project arn.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DataAutomationProjectArn
        {
            get { return this._dataAutomationProjectArn; }
            set { this._dataAutomationProjectArn = value; }
        }

        // Check to see if DataAutomationProjectArn property is set
        internal bool IsSetDataAutomationProjectArn()
        {
            return this._dataAutomationProjectArn != null;
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// Data automation stage.
        /// </para>
        /// </summary>
        public DataAutomationStage Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

    }
}