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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Metrics that describe the quality of the generated audience.
    /// </summary>
    public partial class AudienceQualityMetrics
    {
        private List<RelevanceMetric> _relevanceMetrics = AWSConfigs.InitializeCollections ? new List<RelevanceMetric>() : null;

        /// <summary>
        /// Gets and sets the property RelevanceMetrics. 
        /// <para>
        /// The relevance scores of the generated audience.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RelevanceMetric> RelevanceMetrics
        {
            get { return this._relevanceMetrics; }
            set { this._relevanceMetrics = value; }
        }

        // Check to see if RelevanceMetrics property is set
        internal bool IsSetRelevanceMetrics()
        {
            return this._relevanceMetrics != null && (this._relevanceMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}