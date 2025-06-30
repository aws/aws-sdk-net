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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the response to a successful <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetAccessKeyLastUsed.html">GetAccessKeyLastUsed</a>
    /// request. It is also returned as a member of the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AccessKeyMetaData.html">AccessKeyMetaData</a>
    /// structure returned by the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListAccessKeys.html">ListAccessKeys</a>
    /// action.
    /// </summary>
    public partial class GetAccessKeyLastUsedResponse : AmazonWebServiceResponse
    {
        private AccessKeyLastUsed _accessKeyLastUsed;
        private string _userName;

        /// <summary>
        /// Gets and sets the property AccessKeyLastUsed. 
        /// <para>
        /// Contains information about the last time the access key was used.
        /// </para>
        /// </summary>
        public AccessKeyLastUsed AccessKeyLastUsed
        {
            get { return this._accessKeyLastUsed; }
            set { this._accessKeyLastUsed = value; }
        }

        // Check to see if AccessKeyLastUsed property is set
        internal bool IsSetAccessKeyLastUsed()
        {
            return this._accessKeyLastUsed != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the IAM user that owns this access key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}