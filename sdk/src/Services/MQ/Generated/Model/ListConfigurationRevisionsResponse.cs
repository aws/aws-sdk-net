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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
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
namespace Amazon.MQ.Model
{
    /// <summary>
    /// This is the response object from the ListConfigurationRevisions operation.
    /// </summary>
    public partial class ListConfigurationRevisionsResponse : AmazonWebServiceResponse
    {
        private string _configurationId;
        private int? _maxResults;
        private string _nextToken;
        private List<ConfigurationRevision> _revisions = AWSConfigs.InitializeCollections ? new List<ConfigurationRevision>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationId. 
        /// <para>
        /// The unique ID that Amazon MQ generates for the configuration.
        /// </para>
        /// </summary>
        public string ConfigurationId
        {
            get { return this._configurationId; }
            set { this._configurationId = value; }
        }

        // Check to see if ConfigurationId property is set
        internal bool IsSetConfigurationId()
        {
            return this._configurationId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of configuration revisions that can be returned per page (20 by
        /// default). This value must be an integer from 5 to 100.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that specifies the next page of results Amazon MQ should return. To request
        /// the first page, leave nextToken empty.
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
        /// Gets and sets the property Revisions. 
        /// <para>
        /// The list of all revisions for the specified configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigurationRevision> Revisions
        {
            get { return this._revisions; }
            set { this._revisions = value; }
        }

        // Check to see if Revisions property is set
        internal bool IsSetRevisions()
        {
            return this._revisions != null && (this._revisions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}