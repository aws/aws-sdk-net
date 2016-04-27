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
    /// <summary>
    /// Contains information about a failed delete operation against a specific S3 object.
    /// </summary>
#if !PCL
    [Serializable]
#endif
    public class DeleteError
    {
        
        private string code;
        private string key;
        private string message;
        private string versionId;

        /// <summary>
        /// The key of the S3 object.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// The version of the S3 object.
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// The failure code for the delete error.
        /// </summary>
        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        /// <summary>
        /// The failure message for the delete error.
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }
    }
}
