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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Contains the GraphQL operation to be parsed and executed, if the event target is an
    /// AppSync API.
    /// </summary>
    public partial class AppSyncParameters
    {
        private string _graphQLOperation;

        /// <summary>
        /// Gets and sets the property GraphQLOperation. 
        /// <para>
        /// The GraphQL operation; that is, the query, mutation, or subscription to be parsed
        /// and executed by the GraphQL service.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/appsync/latest/devguide/graphql-architecture.html#graphql-operations">Operations</a>
        /// in the <i>AppSync User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1048576)]
        public string GraphQLOperation
        {
            get { return this._graphQLOperation; }
            set { this._graphQLOperation = value; }
        }

        // Check to see if GraphQLOperation property is set
        internal bool IsSetGraphQLOperation()
        {
            return this._graphQLOperation != null;
        }

    }
}