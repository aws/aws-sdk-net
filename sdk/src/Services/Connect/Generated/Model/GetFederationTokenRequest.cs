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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the GetFederationToken operation.
    /// Supports SAML sign-in for Amazon Connect. Retrieves a token for federation. The token
    /// is for the Amazon Connect user which corresponds to the IAM credentials that were
    /// used to invoke this action. 
    /// 
    ///  
    /// <para>
    /// For more information about how SAML sign-in works in Amazon Connect, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/configure-saml.html
    /// ">Configure SAML with IAM for Amazon Connect in the <i>Amazon Connect Administrator
    /// Guide</i>.</a> 
    /// </para>
    ///  <note> 
    /// <para>
    /// This API doesn't support root users. If you try to invoke GetFederationToken with
    /// root credentials, an error message similar to the following one appears: 
    /// </para>
    ///  
    /// <para>
    ///  <c>Provided identity: Principal: .... User: .... cannot be used for federation with
    /// Amazon Connect</c> 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetFederationTokenRequest : AmazonConnectRequest
    {
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}