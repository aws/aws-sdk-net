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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// A custom email sender Lambda configuration type.
    /// </summary>
    public partial class CustomEmailLambdaVersionConfigType
    {
        private string _lambdaArn;
        private CustomEmailSenderLambdaVersionType _lambdaVersion;

        /// <summary>
        /// Gets and sets the property LambdaArn. 
        /// <para>
        /// The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers
        /// to send email notifications to users.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string LambdaArn
        {
            get { return this._lambdaArn; }
            set { this._lambdaArn = value; }
        }

        // Check to see if LambdaArn property is set
        internal bool IsSetLambdaArn()
        {
            return this._lambdaArn != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaVersion. 
        /// <para>
        /// The Lambda version represents the signature of the "request" attribute in the "event"
        /// information Amazon Cognito passes to your custom email Lambda function. The only supported
        /// value is <code>V1_0</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomEmailSenderLambdaVersionType LambdaVersion
        {
            get { return this._lambdaVersion; }
            set { this._lambdaVersion = value; }
        }

        // Check to see if LambdaVersion property is set
        internal bool IsSetLambdaVersion()
        {
            return this._lambdaVersion != null;
        }

    }
}