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
    /// The properties of a custom SMS sender Lambda trigger.
    /// </summary>
    public partial class CustomSMSLambdaVersionConfigType
    {
        private string _lambdaArn;
        private CustomSMSSenderLambdaVersionType _lambdaVersion;

        /// <summary>
        /// Gets and sets the property LambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function that you want to assign to your Lambda
        /// trigger.
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
        /// The user pool trigger version of the request that Amazon Cognito sends to your Lambda
        /// function. Higher-numbered versions add fields that support new features.
        /// </para>
        ///  
        /// <para>
        /// You must use a <c>LambdaVersion</c> of <c>V1_0</c> with a custom sender function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomSMSSenderLambdaVersionType LambdaVersion
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