/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// This is the response object from the ListTestGridSessionArtifacts operation.
    /// </summary>
    public partial class ListTestGridSessionArtifactsResponse : AmazonWebServiceResponse
    {
        private List<TestGridSessionArtifact> _artifacts = new List<TestGridSessionArtifact>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Artifacts. 
        /// <para>
        /// A list of test grid session artifacts for a <a>TestGridSession</a>.
        /// </para>
        /// </summary>
        public List<TestGridSessionArtifact> Artifacts
        {
            get { return this._artifacts; }
            set { this._artifacts = value; }
        }

        // Check to see if Artifacts property is set
        internal bool IsSetArtifacts()
        {
            return this._artifacts != null && this._artifacts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
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