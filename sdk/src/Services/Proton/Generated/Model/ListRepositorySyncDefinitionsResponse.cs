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
    /// This is the response object from the ListRepositorySyncDefinitions operation.
    /// </summary>
    public partial class ListRepositorySyncDefinitionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RepositorySyncDefinition> _syncDefinitions = new List<RepositorySyncDefinition>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the location of the next repository sync definition in the
        /// array of repository sync definitions, after the current requested list of repository
        /// sync definitions.
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
        /// Gets and sets the property SyncDefinitions. 
        /// <para>
        /// An array of repository sync definitions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RepositorySyncDefinition> SyncDefinitions
        {
            get { return this._syncDefinitions; }
            set { this._syncDefinitions = value; }
        }

        // Check to see if SyncDefinitions property is set
        internal bool IsSetSyncDefinitions()
        {
            return this._syncDefinitions != null && this._syncDefinitions.Count > 0; 
        }

    }
}