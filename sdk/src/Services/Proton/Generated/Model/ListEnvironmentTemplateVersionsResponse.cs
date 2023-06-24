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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// This is the response object from the ListEnvironmentTemplateVersions operation.
    /// </summary>
    public partial class ListEnvironmentTemplateVersionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<EnvironmentTemplateVersionSummary> _templateVersions = new List<EnvironmentTemplateVersionSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the location of the next major or minor version in the array
        /// of major or minor versions of an environment template, after the list of major or
        /// minor versions that was previously requested.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TemplateVersions. 
        /// <para>
        /// An array of major or minor versions of an environment template detail data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EnvironmentTemplateVersionSummary> TemplateVersions
        {
            get { return this._templateVersions; }
            set { this._templateVersions = value; }
        }

        // Check to see if TemplateVersions property is set
        internal bool IsSetTemplateVersions()
        {
            return this._templateVersions != null && this._templateVersions.Count > 0; 
        }

    }
}