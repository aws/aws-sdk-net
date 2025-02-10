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
    /// Container for the parameters to the ListPluginTypeActions operation.
    /// Lists configured Amazon Q Business actions for any plugin type—both built-in and custom.
    /// </summary>
    public partial class ListPluginTypeActionsRequest : AmazonQBusinessRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private PluginType _pluginType;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of plugins to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// If the number of plugins returned exceeds <c>maxResults</c>, Amazon Q Business returns
        /// a next token as a pagination token to retrieve the next set of plugins.
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
        /// Gets and sets the property PluginType. 
        /// <para>
        /// The type of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PluginType PluginType
        {
            get { return this._pluginType; }
            set { this._pluginType = value; }
        }

        // Check to see if PluginType property is set
        internal bool IsSetPluginType()
        {
            return this._pluginType != null;
        }

    }
}