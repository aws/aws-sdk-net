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
    /// Represents an AWS account that is associated with API Gateway.
    /// </summary>
    public partial class UpdateAccountResponse : AmazonWebServiceResponse
    {
        private string _apiKeyVersion;
        private string _cloudwatchRoleArn;
        private List<string> _features = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ThrottleSettings _throttleSettings;

        /// <summary>
        /// Gets and sets the property ApiKeyVersion. 
        /// <para>
        /// The version of the API keys used for the account.
        /// </para>
        /// </summary>
        public string ApiKeyVersion
        {
            get { return this._apiKeyVersion; }
            set { this._apiKeyVersion = value; }
        }

        // Check to see if ApiKeyVersion property is set
        internal bool IsSetApiKeyVersion()
        {
            return this._apiKeyVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CloudwatchRoleArn. 
        /// <para>
        /// The ARN of an Amazon CloudWatch role for the current Account. 
        /// </para>
        /// </summary>
        public string CloudwatchRoleArn
        {
            get { return this._cloudwatchRoleArn; }
            set { this._cloudwatchRoleArn = value; }
        }

        // Check to see if CloudwatchRoleArn property is set
        internal bool IsSetCloudwatchRoleArn()
        {
            return this._cloudwatchRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// A list of features supported for the account. When usage plans are enabled, the features
        /// list will include an entry of <c>"UsagePlans"</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null && (this._features.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThrottleSettings. 
        /// <para>
        /// Specifies the API request limits configured for the current Account.
        /// </para>
        /// </summary>
        public ThrottleSettings ThrottleSettings
        {
            get { return this._throttleSettings; }
            set { this._throttleSettings = value; }
        }

        // Check to see if ThrottleSettings property is set
        internal bool IsSetThrottleSettings()
        {
            return this._throttleSettings != null;
        }

    }
}