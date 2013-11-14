/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>Contains the result of a successful invocation of the CreateAccessKey action.</para>
    /// </summary>
    public partial class CreateAccessKeyResult : AmazonWebServiceResponse
    {
        
        private AccessKey accessKey;


        /// <summary>
        /// Information about the access key.
        ///  
        /// </summary>
        public AccessKey AccessKey
        {
            get { return this.accessKey; }
            set { this.accessKey = value; }
        }

        // Check to see if AccessKey property is set
        internal bool IsSetAccessKey()
        {
            return this.accessKey != null;
        }
    }
}
