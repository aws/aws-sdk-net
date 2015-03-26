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

namespace Amazon.S3.Model
{
    /// <summary>Grant
    /// </summary>
    public class S3Grant
    {
        
        private S3Grantee grantee;
        private S3Permission permission;

        /// <summary>
        /// The grantee details.
        /// </summary>
        public S3Grantee Grantee
        {
            get { return this.grantee; }
            set { this.grantee = value; }
        }

        // Check to see if Grantee property is set
        internal bool IsSetGrantee()
        {
            return this.grantee != null;
        }

        /// <summary>
        /// Specifies the permission given to the grantee.
        ///  
        /// </summary>
        public S3Permission Permission
        {
            get { return this.permission; }
            set { this.permission = value; }
        }

        // Check to see if Permission property is set
        internal bool IsSetPermission()
        {
            return this.permission != null;
        }
    }
}
