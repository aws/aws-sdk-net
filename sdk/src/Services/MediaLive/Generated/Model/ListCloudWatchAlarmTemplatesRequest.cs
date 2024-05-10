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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the ListCloudWatchAlarmTemplates operation.
    /// Lists cloudwatch alarm templates.
    /// </summary>
    public partial class ListCloudWatchAlarmTemplatesRequest : AmazonMediaLiveRequest
    {
        private string _groupIdentifier;
        private int? _maxResults;
        private string _nextToken;
        private string _scope;
        private string _signalMapIdentifier;

        /// <summary>
        /// Gets and sets the property GroupIdentifier. A cloudwatch alarm template group's identifier.
        /// Can be either be its id or current name.
        /// </summary>
        public string GroupIdentifier
        {
            get { return this._groupIdentifier; }
            set { this._groupIdentifier = value; }
        }

        // Check to see if GroupIdentifier property is set
        internal bool IsSetGroupIdentifier()
        {
            return this._groupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property NextToken. A token used to retrieve the next set of results
        /// in paginated list responses.
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
        /// Gets and sets the property Scope. Represents the scope of a resource, with options
        /// for all scopes, AWS provided resources, or local resources.
        /// </summary>
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property SignalMapIdentifier. A signal map's identifier. Can be
        /// either be its id or current name.
        /// </summary>
        public string SignalMapIdentifier
        {
            get { return this._signalMapIdentifier; }
            set { this._signalMapIdentifier = value; }
        }

        // Check to see if SignalMapIdentifier property is set
        internal bool IsSetSignalMapIdentifier()
        {
            return this._signalMapIdentifier != null;
        }

    }
}