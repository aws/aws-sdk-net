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
    /// Container for the parameters to the ListModels operation.
    /// Generates a list of all models in the account, including model name and ARN, dataset,
    /// and status.
    /// </summary>
    public partial class ListModelsRequest : AmazonLookoutEquipmentRequest
    {
        private string _datasetNameBeginsWith;
        private int? _maxResults;
        private string _modelNameBeginsWith;
        private string _nextToken;
        private ModelStatus _status;

        /// <summary>
        /// Gets and sets the property DatasetNameBeginsWith. 
        /// <para>
        /// The beginning of the name of the dataset of the machine learning models to be listed.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string DatasetNameBeginsWith
        {
            get { return this._datasetNameBeginsWith; }
            set { this._datasetNameBeginsWith = value; }
        }

        // Check to see if DatasetNameBeginsWith property is set
        internal bool IsSetDatasetNameBeginsWith()
        {
            return this._datasetNameBeginsWith != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Specifies the maximum number of machine learning models to list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelNameBeginsWith. 
        /// <para>
        /// The beginning of the name of the machine learning models being listed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ModelNameBeginsWith
        {
            get { return this._modelNameBeginsWith; }
            set { this._modelNameBeginsWith = value; }
        }

        // Check to see if ModelNameBeginsWith property is set
        internal bool IsSetModelNameBeginsWith()
        {
            return this._modelNameBeginsWith != null;
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the machine learning model. 
        /// </para>
        /// </summary>
        public ModelStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}