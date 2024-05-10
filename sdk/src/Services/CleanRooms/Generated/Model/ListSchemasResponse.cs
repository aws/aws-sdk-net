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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// This is the response object from the ListSchemas operation.
    /// </summary>
    public partial class ListSchemasResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SchemaSummary> _schemaSummaries = AWSConfigs.InitializeCollections ? new List<SchemaSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token value retrieved from a previous call to access the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10240)]
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
        /// Gets and sets the property SchemaSummaries. 
        /// <para>
        /// The retrieved list of schemas.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SchemaSummary> SchemaSummaries
        {
            get { return this._schemaSummaries; }
            set { this._schemaSummaries = value; }
        }

        // Check to see if SchemaSummaries property is set
        internal bool IsSetSchemaSummaries()
        {
            return this._schemaSummaries != null && (this._schemaSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}