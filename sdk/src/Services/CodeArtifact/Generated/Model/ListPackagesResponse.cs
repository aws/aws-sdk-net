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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// This is the response object from the ListPackages operation.
    /// </summary>
    public partial class ListPackagesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PackageSummary> _packages = new List<PackageSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  If there are additional results, this is the token for the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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
        /// Gets and sets the property Packages. 
        /// <para>
        ///  The list of returned <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageSummary.html">
        /// <code>PackageSummary</code> </a> objects. 
        /// </para>
        /// </summary>
        public List<PackageSummary> Packages
        {
            get { return this._packages; }
            set { this._packages = value; }
        }

        // Check to see if Packages property is set
        internal bool IsSetPackages()
        {
            return this._packages != null && this._packages.Count > 0; 
        }

    }
}