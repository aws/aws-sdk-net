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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Contains details about how to handle harmful content.
    /// </summary>
    public partial class AIGuardrailContentPolicyConfig
    {
        private List<GuardrailContentFilterConfig> _filtersConfig = AWSConfigs.InitializeCollections ? new List<GuardrailContentFilterConfig>() : null;

        /// <summary>
        /// Gets and sets the property FiltersConfig. 
        /// <para>
        /// Contains the type of the content filter and how strongly it should apply to prompts
        /// and model responses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6)]
        public List<GuardrailContentFilterConfig> FiltersConfig
        {
            get { return this._filtersConfig; }
            set { this._filtersConfig = value; }
        }

        // Check to see if FiltersConfig property is set
        internal bool IsSetFiltersConfig()
        {
            return this._filtersConfig != null && (this._filtersConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}