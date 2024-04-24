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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// This is the response object from the GetRepositoryEndpoint operation.
    /// </summary>
    public partial class GetRepositoryEndpointResponse : AmazonWebServiceResponse
    {
        private string _repositoryEndpoint;

        /// <summary>
        /// Gets and sets the property RepositoryEndpoint. 
        /// <para>
        ///  A string that specifies the URL of the returned endpoint. 
        /// </para>
        /// </summary>
        public string RepositoryEndpoint
        {
            get { return this._repositoryEndpoint; }
            set { this._repositoryEndpoint = value; }
        }

        // Check to see if RepositoryEndpoint property is set
        internal bool IsSetRepositoryEndpoint()
        {
            return this._repositoryEndpoint != null;
        }

    }
}