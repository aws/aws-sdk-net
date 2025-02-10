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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Provides detailed information about the dimensions used for aggregation.
    /// </summary>
    public partial class AggregationDetail
    {
        private List<SummarizationDimensionDetail> _summarizationDimensions = AWSConfigs.InitializeCollections ? new List<SummarizationDimensionDetail>() : null;

        /// <summary>
        /// Gets and sets the property SummarizationDimensions. 
        /// <para>
        /// Properties used to summarize aggregated events.
        /// </para>
        /// </summary>
        public List<SummarizationDimensionDetail> SummarizationDimensions
        {
            get { return this._summarizationDimensions; }
            set { this._summarizationDimensions = value; }
        }

        // Check to see if SummarizationDimensions property is set
        internal bool IsSetSummarizationDimensions()
        {
            return this._summarizationDimensions != null && (this._summarizationDimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}