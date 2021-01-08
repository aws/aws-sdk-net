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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for response returned by <code> <a>DescribePackages</a> </code> operation.
    /// </summary>
    public partial class DescribePackagesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PackageDetails> _packageDetailsList = new List<PackageDetails>();

        /// <summary>
        /// Gets and sets the property NextToken.
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
        /// Gets and sets the property PackageDetailsList. 
        /// <para>
        /// List of <code>PackageDetails</code> objects.
        /// </para>
        /// </summary>
        public List<PackageDetails> PackageDetailsList
        {
            get { return this._packageDetailsList; }
            set { this._packageDetailsList = value; }
        }

        // Check to see if PackageDetailsList property is set
        internal bool IsSetPackageDetailsList()
        {
            return this._packageDetailsList != null && this._packageDetailsList.Count > 0; 
        }

    }
}