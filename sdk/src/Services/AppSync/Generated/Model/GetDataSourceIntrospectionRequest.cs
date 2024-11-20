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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Container for the parameters to the GetDataSourceIntrospection operation.
    /// Retrieves the record of an existing introspection. If the retrieval is successful,
    /// the result of the instrospection will also be returned. If the retrieval fails the
    /// operation, an error message will be returned instead.
    /// </summary>
    public partial class GetDataSourceIntrospectionRequest : AmazonAppSyncRequest
    {
        private bool? _includeModelsSDL;
        private string _introspectionId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property IncludeModelsSDL. 
        /// <para>
        /// A boolean flag that determines whether SDL should be generated for introspected types.
        /// If set to <c>true</c>, each model will contain an <c>sdl</c> property that contains
        /// the SDL for that type. The SDL only contains the type data and no additional metadata
        /// or directives. 
        /// </para>
        /// </summary>
        public bool? IncludeModelsSDL
        {
            get { return this._includeModelsSDL; }
            set { this._includeModelsSDL = value; }
        }

        // Check to see if IncludeModelsSDL property is set
        internal bool IsSetIncludeModelsSDL()
        {
            return this._includeModelsSDL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntrospectionId. 
        /// <para>
        /// The introspection ID. Each introspection contains a unique ID that can be used to
        /// reference the instrospection record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IntrospectionId
        {
            get { return this._introspectionId; }
            set { this._introspectionId = value; }
        }

        // Check to see if IntrospectionId property is set
        internal bool IsSetIntrospectionId()
        {
            return this._introspectionId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of introspected types that will be returned in a single response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
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
        /// Determines the number of types to be returned in a single response before paginating.
        /// This value is typically taken from <c>nextToken</c> value from the previous response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
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

    }
}