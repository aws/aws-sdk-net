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
    /// Details about generative data.
    /// </summary>
    public partial class GenerativeDataDetails
    {
        private string _completion;
        private RankingData _rankingData;
        private List<DataSummary> _references = AWSConfigs.InitializeCollections ? new List<DataSummary>() : null;

        /// <summary>
        /// Gets and sets the property Completion. 
        /// <para>
        /// The LLM response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Completion
        {
            get { return this._completion; }
            set { this._completion = value; }
        }

        // Check to see if Completion property is set
        internal bool IsSetCompletion()
        {
            return this._completion != null;
        }

        /// <summary>
        /// Gets and sets the property RankingData. 
        /// <para>
        /// Details about the generative content ranking data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RankingData RankingData
        {
            get { return this._rankingData; }
            set { this._rankingData = value; }
        }

        // Check to see if RankingData property is set
        internal bool IsSetRankingData()
        {
            return this._rankingData != null;
        }

        /// <summary>
        /// Gets and sets the property References. 
        /// <para>
        /// The references used to generative the LLM response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DataSummary> References
        {
            get { return this._references; }
            set { this._references = value; }
        }

        // Check to see if References property is set
        internal bool IsSetReferences()
        {
            return this._references != null && (this._references.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}