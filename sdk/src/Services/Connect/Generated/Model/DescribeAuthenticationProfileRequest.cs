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
    /// Container for the parameters to the DescribeAuthenticationProfile operation.
    /// This API is in preview release for Amazon Connect and is subject to change. To request
    /// access to this API, contact Amazon Web Services Support.
    /// 
    ///  
    /// <para>
    /// Describes the target authentication profile.
    /// </para>
    /// </summary>
    public partial class DescribeAuthenticationProfileRequest : AmazonConnectRequest
    {
        private string _authenticationProfileId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property AuthenticationProfileId. 
        /// <para>
        /// A unique identifier for the authentication profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string AuthenticationProfileId
        {
            get { return this._authenticationProfileId; }
            set { this._authenticationProfileId = value; }
        }

        // Check to see if AuthenticationProfileId property is set
        internal bool IsSetAuthenticationProfileId()
        {
            return this._authenticationProfileId != null;
        }

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