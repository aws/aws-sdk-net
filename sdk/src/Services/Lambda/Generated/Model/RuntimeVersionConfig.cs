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
    /// The ARN of the runtime and any errors that occured.
    /// </summary>
    public partial class RuntimeVersionConfig
    {
        private RuntimeVersionError _error;
        private string _runtimeVersionArn;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error response when Lambda is unable to retrieve the runtime version for a function.
        /// </para>
        /// </summary>
        public RuntimeVersionError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeVersionArn. 
        /// <para>
        /// The ARN of the runtime version you want the function to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=26, Max=2048)]
        public string RuntimeVersionArn
        {
            get { return this._runtimeVersionArn; }
            set { this._runtimeVersionArn = value; }
        }

        // Check to see if RuntimeVersionArn property is set
        internal bool IsSetRuntimeVersionArn()
        {
            return this._runtimeVersionArn != null;
        }

    }
}