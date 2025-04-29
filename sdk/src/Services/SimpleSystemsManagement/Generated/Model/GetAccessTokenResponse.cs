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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the GetAccessToken operation.
    /// </summary>
    public partial class GetAccessTokenResponse : AmazonWebServiceResponse
    {
        private AccessRequestStatus _accessRequestStatus;
        private Credentials _credentials;

        /// <summary>
        /// Gets and sets the property AccessRequestStatus. 
        /// <para>
        /// The status of the access request.
        /// </para>
        /// </summary>
        public AccessRequestStatus AccessRequestStatus
        {
            get { return this._accessRequestStatus; }
            set { this._accessRequestStatus = value; }
        }

        // Check to see if AccessRequestStatus property is set
        internal bool IsSetAccessRequestStatus()
        {
            return this._accessRequestStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The temporary security credentials which can be used to start just-in-time node access
        /// sessions.
        /// </para>
        /// </summary>
        public Credentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

    }
}