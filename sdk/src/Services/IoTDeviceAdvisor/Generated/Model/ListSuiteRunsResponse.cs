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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// This is the response object from the ListSuiteRuns operation.
    /// </summary>
    public partial class ListSuiteRunsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SuiteRunInformation> _suiteRunsList = new List<SuiteRunInformation>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Next pagination token for list suite run response.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2000)]
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
        /// Gets and sets the property SuiteRunsList. 
        /// <para>
        /// Lists the runs of the specified Device Advisor test suite.
        /// </para>
        /// </summary>
        public List<SuiteRunInformation> SuiteRunsList
        {
            get { return this._suiteRunsList; }
            set { this._suiteRunsList = value; }
        }

        // Check to see if SuiteRunsList property is set
        internal bool IsSetSuiteRunsList()
        {
            return this._suiteRunsList != null && this._suiteRunsList.Count > 0; 
        }

    }
}