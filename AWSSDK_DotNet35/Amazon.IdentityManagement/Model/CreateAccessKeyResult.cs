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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the result of a successful invocation of the <a>CreateAccessKey</a> action.
    /// </summary>
    public partial class CreateAccessKeyResult : AmazonWebServiceResponse
    {
        private AccessKey _accessKey;


        /// <summary>
        /// Gets and sets the property AccessKey. 
        /// <para>
        /// Information about the access key.
        /// </para>
        /// </summary>
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