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
    /// This is the response object from the GetRuntimeManagementConfig operation.
    /// </summary>
    public partial class GetRuntimeManagementConfigResponse : AmazonWebServiceResponse
    {
        private string _functionArn;
        private string _runtimeVersionArn;
        private UpdateRuntimeOn _updateRuntimeOn;

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of your function.
        /// </para>
        /// </summary>
        public string FunctionArn
        {
            get { return this._functionArn; }
            set { this._functionArn = value; }
        }

        // Check to see if FunctionArn property is set
        internal bool IsSetFunctionArn()
        {
            return this._functionArn != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeVersionArn. 
        /// <para>
        /// The ARN of the runtime the function is configured to use. If the runtime update mode
        /// is <b>Manual</b>, the ARN is returned, otherwise <code>null</code> is returned.
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

        /// <summary>
        /// Gets and sets the property UpdateRuntimeOn. 
        /// <para>
        /// The current runtime update mode of the function.
        /// </para>
        /// </summary>
        public UpdateRuntimeOn UpdateRuntimeOn
        {
            get { return this._updateRuntimeOn; }
            set { this._updateRuntimeOn = value; }
        }

        // Check to see if UpdateRuntimeOn property is set
        internal bool IsSetUpdateRuntimeOn()
        {
            return this._updateRuntimeOn != null;
        }

    }
}