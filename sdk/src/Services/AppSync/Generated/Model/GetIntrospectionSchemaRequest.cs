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
    /// Container for the parameters to the GetIntrospectionSchema operation.
    /// Retrieves the introspection schema for a GraphQL API.
    /// </summary>
    public partial class GetIntrospectionSchemaRequest : AmazonAppSyncRequest
    {
        private string _apiId;
        private OutputType _format;
        private bool? _includeDirectives;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The schema format: SDL or JSON.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputType Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeDirectives. 
        /// <para>
        /// A flag that specifies whether the schema introspection should contain directives.
        /// </para>
        /// </summary>
        public bool? IncludeDirectives
        {
            get { return this._includeDirectives; }
            set { this._includeDirectives = value; }
        }

        // Check to see if IncludeDirectives property is set
        internal bool IsSetIncludeDirectives()
        {
            return this._includeDirectives.HasValue; 
        }

    }
}