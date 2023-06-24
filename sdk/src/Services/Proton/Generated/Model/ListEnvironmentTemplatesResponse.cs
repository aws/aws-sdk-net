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
    /// This is the response object from the ListEnvironmentTemplates operation.
    /// </summary>
    public partial class ListEnvironmentTemplatesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<EnvironmentTemplateSummary> _templates = new List<EnvironmentTemplateSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the location of the next environment template in the array
        /// of environment templates, after the current requested list of environment templates.
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
        /// Gets and sets the property Templates. 
        /// <para>
        /// An array of environment templates with detail data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EnvironmentTemplateSummary> Templates
        {
            get { return this._templates; }
            set { this._templates = value; }
        }

        // Check to see if Templates property is set
        internal bool IsSetTemplates()
        {
            return this._templates != null && this._templates.Count > 0; 
        }

    }
}