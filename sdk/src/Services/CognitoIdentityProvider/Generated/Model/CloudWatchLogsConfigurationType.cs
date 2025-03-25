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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Configuration for the CloudWatch log group destination of user pool detailed activity
    /// logging, or of user activity log export with threat protection.
    /// </summary>
    public partial class CloudWatchLogsConfigurationType
    {
        private string _logGroupArn;

        /// <summary>
        /// Gets and sets the property LogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (arn) of a CloudWatch Logs log group where your user pool
        /// sends logs. The log group must not be encrypted with Key Management Service and must
        /// be in the same Amazon Web Services account as your user pool.
        /// </para>
        ///  
        /// <para>
        /// To send logs to log groups with a resource policy of a size greater than 5120 characters,
        /// configure a log group with a path that starts with <c>/aws/vendedlogs</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enabling
        /// logging from certain Amazon Web Services services</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string LogGroupArn
        {
            get { return this._logGroupArn; }
            set { this._logGroupArn = value; }
        }

        // Check to see if LogGroupArn property is set
        internal bool IsSetLogGroupArn()
        {
            return this._logGroupArn != null;
        }

    }
}