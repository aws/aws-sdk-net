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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the ListPlugins operation.
    /// </summary>
    public partial class ListPluginsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Plugin> _plugins = AWSConfigs.InitializeCollections ? new List<Plugin>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the <c>maxResults</c> response was incomplete because there is more data to retrieve,
        /// Amazon Q Business returns a pagination token in the response. You can use this pagination
        /// token to retrieve the next set of plugins.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=800)]
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
        /// Gets and sets the property Plugins. 
        /// <para>
        /// Information about a configured plugin.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Plugin> Plugins
        {
            get { return this._plugins; }
            set { this._plugins = value; }
        }

        // Check to see if Plugins property is set
        internal bool IsSetPlugins()
        {
            return this._plugins != null && (this._plugins.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}