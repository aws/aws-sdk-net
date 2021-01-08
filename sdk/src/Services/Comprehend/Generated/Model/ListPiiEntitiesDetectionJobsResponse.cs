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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the ListPiiEntitiesDetectionJobs operation.
    /// </summary>
    public partial class ListPiiEntitiesDetectionJobsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PiiEntitiesDetectionJobProperties> _piiEntitiesDetectionJobPropertiesList = new List<PiiEntitiesDetectionJobProperties>();

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

        /// <summary>
        /// Gets and sets the property PiiEntitiesDetectionJobPropertiesList. 
        /// <para>
        /// A list containing the properties of each job that is returned.
        /// </para>
        /// </summary>
        public List<PiiEntitiesDetectionJobProperties> PiiEntitiesDetectionJobPropertiesList
        {
            get { return this._piiEntitiesDetectionJobPropertiesList; }
            set { this._piiEntitiesDetectionJobPropertiesList = value; }
        }

        // Check to see if PiiEntitiesDetectionJobPropertiesList property is set
        internal bool IsSetPiiEntitiesDetectionJobPropertiesList()
        {
            return this._piiEntitiesDetectionJobPropertiesList != null && this._piiEntitiesDetectionJobPropertiesList.Count > 0; 
        }

    }
}