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
    /// This is the response object from the GetIntrospectionSchema operation.
    /// </summary>
    public partial class GetIntrospectionSchemaResponse : AmazonWebServiceResponse
    {
        private MemoryStream _schema;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema, in GraphQL Schema Definition Language (SDL) format.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <a href="http://graphql.org/learn/schema/">GraphQL SDL
        /// documentation</a>.
        /// </para>
        /// </summary>
        public MemoryStream Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

    }
}