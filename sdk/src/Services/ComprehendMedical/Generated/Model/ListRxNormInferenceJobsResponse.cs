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
    /// This is the response object from the ListRxNormInferenceJobs operation.
    /// </summary>
    public partial class ListRxNormInferenceJobsResponse : AmazonWebServiceResponse
    {
        private List<ComprehendMedicalAsyncJobProperties> _comprehendMedicalAsyncJobPropertiesList = new List<ComprehendMedicalAsyncJobProperties>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ComprehendMedicalAsyncJobPropertiesList. 
        /// <para>
        /// The maximum number of results to return in each page. The default is 100.
        /// </para>
        /// </summary>
        public List<ComprehendMedicalAsyncJobProperties> ComprehendMedicalAsyncJobPropertiesList
        {
            get { return this._comprehendMedicalAsyncJobPropertiesList; }
            set { this._comprehendMedicalAsyncJobPropertiesList = value; }
        }

        // Check to see if ComprehendMedicalAsyncJobPropertiesList property is set
        internal bool IsSetComprehendMedicalAsyncJobPropertiesList()
        {
            return this._comprehendMedicalAsyncJobPropertiesList != null && this._comprehendMedicalAsyncJobPropertiesList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Identifies the next page of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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