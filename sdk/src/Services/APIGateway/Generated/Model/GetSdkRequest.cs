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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetSdk operation.
    /// Generates a client SDK for a RestApi and Stage.
    /// </summary>
    public partial class GetSdkRequest : AmazonAPIGatewayRequest
    {
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _restApiId;
        private string _sdkType;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A string-to-string key-value map of query parameters <c>sdkType</c>-dependent properties
        /// of the SDK. For <c>sdkType</c> of <c>objectivec</c> or <c>swift</c>, a parameter named
        /// <c>classPrefix</c> is required. For <c>sdkType</c> of <c>android</c>, parameters named
        /// <c>groupId</c>, <c>artifactId</c>, <c>artifactVersion</c>, and <c>invokerPackage</c>
        /// are required. For <c>sdkType</c> of <c>java</c>, parameters named <c>serviceName</c>
        /// and <c>javaPackageName</c> are required. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The string identifier of the associated RestApi.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The language for the generated SDK. Currently <c>java</c>, <c>javascript</c>, <c>android</c>,
        /// <c>objectivec</c> (for iOS), <c>swift</c> (for iOS), and <c>ruby</c> are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The name of the Stage that the SDK will use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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