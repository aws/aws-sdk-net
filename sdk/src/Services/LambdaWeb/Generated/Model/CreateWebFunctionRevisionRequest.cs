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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
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
namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWebFunctionRevision operation.
    /// Creates an immutable revision for a web function. A revision represents a specific
    /// version of the function code and configuration.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must have the <c>CreateWebFunctionRevision</c> permission
    /// on the web function, not on the revision being created.
    /// </para>
    /// </summary>
    public partial class CreateWebFunctionRevisionRequest : AmazonLambdaWebRequest
    {
        private BuildConfig _buildConfig;
        private string _description;
        private string _functionName;
        private string _kmsKeyArn;
        private ServiceConfig _serviceConfig;

        /// <summary>
        /// Gets and sets the property BuildConfig. 
        /// <para>
        /// The build configuration for the revision, including code location and runtime settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BuildConfig BuildConfig
        {
            get { return this._buildConfig; }
            set { this._buildConfig = value; }
        }

        // Check to see if BuildConfig property is set
        internal bool IsSetBuildConfig()
        {
            return this._buildConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the revision.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the web function. You can specify the function name or the function ARN.
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Key Management Service (AWS KMS) key used
        /// to encrypt the revision's code and environment variables.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceConfig. 
        /// <para>
        /// The service configuration for the revision, including execution role, timeout, and
        /// concurrency settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceConfig ServiceConfig
        {
            get { return this._serviceConfig; }
            set { this._serviceConfig = value; }
        }

        // Check to see if ServiceConfig property is set
        internal bool IsSetServiceConfig()
        {
            return this._serviceConfig != null;
        }

    }
}