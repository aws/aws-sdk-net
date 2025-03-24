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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// The strategy used for performing context enrichment.
    /// </summary>
    public partial class EnrichmentStrategyConfiguration
    {
        private EnrichmentStrategyMethod _method;

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// The method used for the context enrichment strategy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnrichmentStrategyMethod Method
        {
            get { return this._method; }
            set { this._method = value; }
        }

        // Check to see if Method property is set
        internal bool IsSetMethod()
        {
            return this._method != null;
        }

    }
}