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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// One custom scope associated with a user pool resource server. This data type is a
    /// member of <c>ResourceServerScopeType</c>. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-define-resource-servers.html">
    /// Scopes, M2M, and API authorization with resource servers</a>.
    /// </summary>
    public partial class ResourceServerScopeType
    {
        /// <summary>
        /// Gets and sets the property ScopeDescription. 
        /// <para>
        /// A friendly description of a custom scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ScopeDescription { get; set; }

        /// <summary>
        /// Checks to see if the ScopeDescription property is set.
        /// </summary>
        internal bool IsSetScopeDescription() => this.ScopeDescription != null;

        /// <summary>
        /// Gets and sets the property ScopeName. 
        /// <para>
        /// The name of the scope. Amazon Cognito renders custom scopes in the format <c>resourceServerIdentifier/ScopeName</c>.
        /// For example, if this parameter is <c>exampleScope</c> in the resource server with
        /// the identifier <c>exampleResourceServer</c>, you request and receive the scope <c>exampleResourceServer/exampleScope</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ScopeName { get; set; }

        /// <summary>
        /// Checks to see if the ScopeName property is set.
        /// </summary>
        internal bool IsSetScopeName() => this.ScopeName != null;
    }
}
