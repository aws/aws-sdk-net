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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetRelationalDatabases operation.
    /// </summary>
    public partial class GetRelationalDatabasesResponse : AmazonWebServiceResponse
    {
        private string _nextPageToken;
        private List<RelationalDatabase> _relationalDatabases = AWSConfigs.InitializeCollections ? new List<RelationalDatabase>() : null;

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// A next page token is not returned if there are no more results to display.
        /// </para>
        ///  
        /// <para>
        /// To get the next page of results, perform another <c>GetRelationalDatabases</c> request
        /// and specify the next page token using the <c>pageToken</c> parameter.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabases. 
        /// <para>
        /// An object describing the result of your get relational databases request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RelationalDatabase> RelationalDatabases
        {
            get { return this._relationalDatabases; }
            set { this._relationalDatabases = value; }
        }

        // Check to see if RelationalDatabases property is set
        internal bool IsSetRelationalDatabases()
        {
            return this._relationalDatabases != null && (this._relationalDatabases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}