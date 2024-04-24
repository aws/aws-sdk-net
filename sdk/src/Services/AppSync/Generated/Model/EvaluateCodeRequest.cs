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
    /// Container for the parameters to the EvaluateCode operation.
    /// Evaluates the given code and returns the response. The code definition requirements
    /// depend on the specified runtime. For <c>APPSYNC_JS</c> runtimes, the code defines
    /// the request and response functions. The request function takes the incoming request
    /// after a GraphQL operation is parsed and converts it into a request configuration for
    /// the selected data source operation. The response function interprets responses from
    /// the data source and maps it to the shape of the GraphQL field output type.
    /// </summary>
    public partial class EvaluateCodeRequest : AmazonAppSyncRequest
    {
        private string _code;
        private string _context;
        private string _function;
        private AppSyncRuntime _runtime;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The code definition to be evaluated. Note that <c>code</c> and <c>runtime</c> are
        /// both required for this action. The <c>runtime</c> value must be <c>APPSYNC_JS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32768)]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// The map that holds all of the contextual information for your resolver invocation.
        /// A <c>context</c> is required for this action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=28000)]
        public string Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// The function within the code to be evaluated. If provided, the valid values are <c>request</c>
        /// and <c>response</c>.
        /// </para>
        /// </summary>
        public string Function
        {
            get { return this._function; }
            set { this._function = value; }
        }

        // Check to see if Function property is set
        internal bool IsSetFunction()
        {
            return this._function != null;
        }

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The runtime to be used when evaluating the code. Currently, only the <c>APPSYNC_JS</c>
        /// runtime is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AppSyncRuntime Runtime
        {
            get { return this._runtime; }
            set { this._runtime = value; }
        }

        // Check to see if Runtime property is set
        internal bool IsSetRuntime()
        {
            return this._runtime != null;
        }

    }
}