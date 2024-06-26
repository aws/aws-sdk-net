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
    /// Information on the identity that created the file.
    /// </summary>
    public partial class CreatedByInfo
    {
        private string _awsIdentityArn;
        private string _connectUserArn;

        /// <summary>
        /// Gets and sets the property AWSIdentityArn. 
        /// <para>
        /// STS or IAM ARN representing the identity of API Caller. SDK users cannot populate
        /// this and this value is calculated automatically if <c>ConnectUserArn</c> is not provided.
        /// </para>
        /// </summary>
        public string AWSIdentityArn
        {
            get { return this._awsIdentityArn; }
            set { this._awsIdentityArn = value; }
        }

        // Check to see if AWSIdentityArn property is set
        internal bool IsSetAWSIdentityArn()
        {
            return this._awsIdentityArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectUserArn. 
        /// <para>
        /// An agent ARN representing a <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_amazonconnect.html#amazonconnect-resources-for-iam-policies">connect
        /// user</a>.
        /// </para>
        /// </summary>
        public string ConnectUserArn
        {
            get { return this._connectUserArn; }
            set { this._connectUserArn = value; }
        }

        // Check to see if ConnectUserArn property is set
        internal bool IsSetConnectUserArn()
        {
            return this._connectUserArn != null;
        }

    }
}