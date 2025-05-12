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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the StartSandbox operation.
    /// </summary>
    public partial class StartSandboxResponse : AmazonWebServiceResponse
    {
        private Sandbox _sandbox;

        /// <summary>
        /// Gets and sets the property Sandbox. 
        /// <para>
        /// Information about the requested sandbox.
        /// </para>
        /// </summary>
        public Sandbox Sandbox
        {
            get { return this._sandbox; }
            set { this._sandbox = value; }
        }

        // Check to see if Sandbox property is set
        internal bool IsSetSandbox()
        {
            return this._sandbox != null;
        }

    }
}