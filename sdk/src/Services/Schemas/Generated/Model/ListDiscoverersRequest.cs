/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Schemas.Model
{
    /// <summary>
    /// Container for the parameters to the ListDiscoverers operation.
    /// List the discoverers.
    /// </summary>
    public partial class ListDiscoverersRequest : AmazonSchemasRequest
    {
        private string _discovererIdPrefix;
        private int? _limit;
        private string _nextToken;
        private string _sourceArnPrefix;

        /// <summary>
        /// Gets and sets the property DiscovererIdPrefix.
        /// </summary>
        public string DiscovererIdPrefix
        {
            get { return this._discovererIdPrefix; }
            set { this._discovererIdPrefix = value; }
        }

        // Check to see if DiscovererIdPrefix property is set
        internal bool IsSetDiscovererIdPrefix()
        {
            return this._discovererIdPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Limit.
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
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
        /// Gets and sets the property SourceArnPrefix.
        /// </summary>
        public string SourceArnPrefix
        {
            get { return this._sourceArnPrefix; }
            set { this._sourceArnPrefix = value; }
        }

        // Check to see if SourceArnPrefix property is set
        internal bool IsSetSourceArnPrefix()
        {
            return this._sourceArnPrefix != null;
        }

    }
}