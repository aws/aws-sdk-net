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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// This is the response object from the ListFHIRImportJobs operation.
    /// </summary>
    public partial class ListFHIRImportJobsResponse : AmazonWebServiceResponse
    {
        private List<ImportJobProperties> _importJobPropertiesList = AWSConfigs.InitializeCollections ? new List<ImportJobProperties>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ImportJobPropertiesList. 
        /// <para>
        ///  The properties of a listed FHIR import jobs, including the ID, ARN, name, the status
        /// of the job, and the progress report of the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ImportJobProperties> ImportJobPropertiesList
        {
            get { return this._importJobPropertiesList; }
            set { this._importJobPropertiesList = value; }
        }

        // Check to see if ImportJobPropertiesList property is set
        internal bool IsSetImportJobPropertiesList()
        {
            return this._importJobPropertiesList != null && (this._importJobPropertiesList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A pagination token used to identify the next page of results to return for a ListFHIRImportJobs
        /// query. 
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