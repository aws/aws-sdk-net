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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the GetFunction operation.
    /// </summary>
    public partial class GetFunctionResponse : AmazonWebServiceResponse
    {
        private FunctionCodeLocation _code;
        private Concurrency _concurrency;
        private FunctionConfiguration _configuration;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The deployment package of the function or version.
        /// </para>
        /// </summary>
        public FunctionCodeLocation Code
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
        /// Gets and sets the property Concurrency. 
        /// <para>
        /// The function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/concurrent-executions.html">reserved
        /// concurrency</a>.
        /// </para>
        /// </summary>
        public Concurrency Concurrency
        {
            get { return this._concurrency; }
            set { this._concurrency = value; }
        }

        // Check to see if Concurrency property is set
        internal bool IsSetConcurrency()
        {
            return this._concurrency != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration of the function or version.
        /// </para>
        /// </summary>
        public FunctionConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}