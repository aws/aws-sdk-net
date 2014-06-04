/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Contains the result of a successful call to the <a>GetSessionToken</a> action, including
    ///      temporary AWS credentials that can be used to make AWS requests.
    /// </summary>
    public partial class GetSessionTokenResult
    {
        private Credentials _credentials;


        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The session credentials for API authentication. 
        /// </para>
        /// </summary>
        public Credentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }


        /// <summary>
        /// Sets the Credentials property
        /// </summary>
        /// <param name="credentials">The value to set for the Credentials property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetSessionTokenResult WithCredentials(Credentials credentials)
        {
            this._credentials = credentials;
            return this;
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

    }
}