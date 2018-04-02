/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetSdk operation.
    /// Generates a client SDK for a <a>RestApi</a> and <a>Stage</a>.
    /// </summary>
    public partial class GetSdkRequest : AmazonAPIGatewayRequest
    {
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private string _restApiId;
        private string _sdkType;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A string-to-string key-value map of query parameters <code>sdkType</code>-dependent
        /// properties of the SDK. For <code>sdkType</code> of <code>objectivec</code> or <code>swift</code>,
        /// a parameter named <code>classPrefix</code> is required. For <code>sdkType</code> of
        /// <code>android</code>, parameters named <code>groupId</code>, <code>artifactId</code>,
        /// <code>artifactVersion</code>, and <code>invokerPackage</code> are required. For <code>sdkType</code>
        /// of <code>java</code>, parameters named <code>serviceName</code> and <code>javaPackageName</code>
        /// are required. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// [Required] The string identifier of the associated <a>RestApi</a>.
        /// </para>
        /// </summary>
        public string RestApiId
        {
            get { return this._restApiId; }
            set { this._restApiId = value; }
        }

        // Check to see if RestApiId property is set
        internal bool IsSetRestApiId()
        {
            return this._restApiId != null;
        }

        /// <summary>
        /// Gets and sets the property SdkType. 
        /// <para>
        /// [Required] The language for the generated SDK. Currently <code>java</code>, <code>javascript</code>,
        /// <code>android</code>, <code>objectivec</code> (for iOS), <code>swift</code> (for iOS),
        /// and <code>ruby</code> are supported.
        /// </para>
        /// </summary>
        public string SdkType
        {
            get { return this._sdkType; }
            set { this._sdkType = value; }
        }

        // Check to see if SdkType property is set
        internal bool IsSetSdkType()
        {
            return this._sdkType != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// [Required] The name of the <a>Stage</a> that the SDK will use.
        /// </para>
        /// </summary>
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

    }
}