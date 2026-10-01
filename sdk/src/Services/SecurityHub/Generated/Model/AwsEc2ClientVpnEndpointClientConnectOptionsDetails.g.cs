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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The options for managing connection authorization for new client connections.
    /// </summary>
    public partial class AwsEc2ClientVpnEndpointClientConnectOptionsDetails
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        ///  Indicates whether client connect options are enabled. 
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property LambdaFunctionArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Lambda function used for connection authorization.
        /// 
        /// </para>
        /// </summary>
        public string LambdaFunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionArn property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionArn() => this.LambdaFunctionArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of any updates to the client connect options. 
        /// </para>
        /// </summary>
        public AwsEc2ClientVpnEndpointClientConnectOptionsStatusDetails Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
