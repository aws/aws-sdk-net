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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The endpoint assigned to a SIP media application.
    /// </summary>
    public partial class SipMediaApplicationEndpoint
    {
        /// <summary>
        /// Gets and sets the property LambdaArn. 
        /// <para>
        /// Valid Amazon Resource Name (ARN) of the Lambda function, version, or alias. The function
        /// must be created in the same AWS Region as the SIP media application.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 10000)]
        public string LambdaArn { get; set; }

        /// <summary>
        /// Checks to see if the LambdaArn property is set.
        /// </summary>
        internal bool IsSetLambdaArn() => this.LambdaArn != null;
    }
}
