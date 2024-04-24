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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the ListRepositorySyncDefinitions operation.
    /// List repository sync definitions with detail data.
    /// </summary>
    public partial class ListRepositorySyncDefinitionsRequest : AmazonProtonRequest
    {
        private string _nextToken;
        private string _repositoryName;
        private RepositoryProvider _repositoryProvider;
        private SyncType _syncType;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the location of the next repository sync definition in the
        /// array of repository sync definitions, after the list of repository sync definitions
        /// previously requested.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=0)]
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
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryProvider. 
        /// <para>
        /// The repository provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RepositoryProvider RepositoryProvider
        {
            get { return this._repositoryProvider; }
            set { this._repositoryProvider = value; }
        }

        // Check to see if RepositoryProvider property is set
        internal bool IsSetRepositoryProvider()
        {
            return this._repositoryProvider != null;
        }

        /// <summary>
        /// Gets and sets the property SyncType. 
        /// <para>
        /// The sync type. The only supported value is <c>TEMPLATE_SYNC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SyncType SyncType
        {
            get { return this._syncType; }
            set { this._syncType = value; }
        }

        // Check to see if SyncType property is set
        internal bool IsSetSyncType()
        {
            return this._syncType != null;
        }

    }
}