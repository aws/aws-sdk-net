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
    /// Represents an AWS account that is associated with Amazon API Gateway.
    /// </summary>
    public partial class UpdateAccountResponse : AmazonWebServiceResponse
    {
        private string _cloudwatchRoleArn;
        private ThrottleSettings _throttleSettings;

        /// <summary>
        /// Gets and sets the property CloudwatchRoleArn. 
        /// <para>
        /// Specifies the Amazon resource name (ARN) of an Amazon CloudWatch role for the current
        /// <a>Account</a> resource.
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
        /// Gets and sets the property ThrottleSettings. 
        /// <para>
        /// Specifies the application programming interface (API) throttle settings for the current
        /// <a>Account</a> resource.
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