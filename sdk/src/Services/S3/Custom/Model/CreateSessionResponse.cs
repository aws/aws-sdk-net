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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the CreateSession operation.
    /// </summary>
    public partial class CreateSessionResponse : AmazonWebServiceResponse
    {
        private SessionCredentials _credentials;

        /// <summary>
        /// Gets and sets the property Credentials.
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credential property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

    }
}