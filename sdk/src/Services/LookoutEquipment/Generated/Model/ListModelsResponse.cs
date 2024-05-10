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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the ListModels operation.
    /// </summary>
    public partial class ListModelsResponse : AmazonWebServiceResponse
    {
        private List<ModelSummary> _modelSummaries = AWSConfigs.InitializeCollections ? new List<ModelSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ModelSummaries. 
        /// <para>
        /// Provides information on the specified model, including created time, model and dataset
        /// ARNs, and status. 
        /// </para>
        /// </summary>
        public List<ModelSummary> ModelSummaries
        {
            get { return this._modelSummaries; }
            set { this._modelSummaries = value; }
        }

        // Check to see if ModelSummaries property is set
        internal bool IsSetModelSummaries()
        {
            return this._modelSummaries != null && (this._modelSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An opaque pagination token indicating where to continue the listing of machine learning
        /// models. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}