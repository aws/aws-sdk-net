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
    /// This is the response object from the ListSuiteDefinitions operation.
    /// </summary>
    public partial class ListSuiteDefinitionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SuiteDefinitionInformation> _suiteDefinitionInformationList = new List<SuiteDefinitionInformation>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Creates a Device Advisor test suite.
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
        /// Gets and sets the property SuiteDefinitionInformationList. 
        /// <para>
        /// Lists test suite information using List suite definition.
        /// </para>
        /// </summary>
        public List<SuiteDefinitionInformation> SuiteDefinitionInformationList
        {
            get { return this._suiteDefinitionInformationList; }
            set { this._suiteDefinitionInformationList = value; }
        }

        // Check to see if SuiteDefinitionInformationList property is set
        internal bool IsSetSuiteDefinitionInformationList()
        {
            return this._suiteDefinitionInformationList != null && this._suiteDefinitionInformationList.Count > 0; 
        }

    }
}