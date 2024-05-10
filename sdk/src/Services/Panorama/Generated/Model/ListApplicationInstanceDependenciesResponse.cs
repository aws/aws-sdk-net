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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// This is the response object from the ListApplicationInstanceDependencies operation.
    /// </summary>
    public partial class ListApplicationInstanceDependenciesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PackageObject> _packageObjects = AWSConfigs.InitializeCollections ? new List<PackageObject>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that's included if more results are available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property PackageObjects. 
        /// <para>
        /// A list of package objects.
        /// </para>
        /// </summary>
        public List<PackageObject> PackageObjects
        {
            get { return this._packageObjects; }
            set { this._packageObjects = value; }
        }

        // Check to see if PackageObjects property is set
        internal bool IsSetPackageObjects()
        {
            return this._packageObjects != null && (this._packageObjects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}