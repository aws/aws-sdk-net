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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the ListRegistries operation.
    /// </summary>
    public partial class ListRegistriesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RegistryListItem> _registries = AWSConfigs.InitializeCollections ? new List<RegistryListItem>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token for paginating the returned list of tokens, returned if the current
        /// segment of the list is not the last.
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
        /// Gets and sets the property Registries. 
        /// <para>
        /// An array of <c>RegistryDetailedListItem</c> objects containing minimal details of
        /// each registry.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RegistryListItem> Registries
        {
            get { return this._registries; }
            set { this._registries = value; }
        }

        // Check to see if Registries property is set
        internal bool IsSetRegistries()
        {
            return this._registries != null && (this._registries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}