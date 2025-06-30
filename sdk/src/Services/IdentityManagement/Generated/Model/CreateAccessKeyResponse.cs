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
    /// Contains the response to a successful <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateAccessKey.html">CreateAccessKey</a>
    /// request.
    /// </summary>
    public partial class CreateAccessKeyResponse : AmazonWebServiceResponse
    {
        private AccessKey _accessKey;

        /// <summary>
        /// Gets and sets the property AccessKey. 
        /// <para>
        /// A structure with details about the access key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessKey AccessKey
        {
            get { return this._accessKey; }
            set { this._accessKey = value; }
        }

        // Check to see if AccessKey property is set
        internal bool IsSetAccessKey()
        {
            return this._accessKey != null;
        }

    }
}