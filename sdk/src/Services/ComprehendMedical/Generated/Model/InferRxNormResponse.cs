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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComprehendMedical.Model
{
    /// <summary>
    /// This is the response object from the InferRxNorm operation.
    /// </summary>
    public partial class InferRxNormResponse : AmazonWebServiceResponse
    {
        private List<RxNormEntity> _entities = new List<RxNormEntity>();
        private string _modelVersion;
        private string _paginationToken;

        /// <summary>
        /// Gets and sets the property Entities. 
        /// <para>
        /// The medication entities detected in the text linked to RxNorm concepts. If the action
        /// is successful, the service sends back an HTTP 200 response, as well as the entities
        /// detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RxNormEntity> Entities
        {
            get { return this._entities; }
            set { this._entities = value; }
        }

        // Check to see if Entities property is set
        internal bool IsSetEntities()
        {
            return this._entities != null && this._entities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model used to analyze the documents, in the format <i>n</i>.<i>n</i>.<i>n</i>
        /// You can use this information to track the model used for a particular batch of documents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PaginationToken. 
        /// <para>
        /// If the result of the previous request to <code>InferRxNorm</code> was truncated, include
        /// the <code>PaginationToken</code> to fetch the next page of medication entities.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string PaginationToken
        {
            get { return this._paginationToken; }
            set { this._paginationToken = value; }
        }

        // Check to see if PaginationToken property is set
        internal bool IsSetPaginationToken()
        {
            return this._paginationToken != null;
        }

    }
}