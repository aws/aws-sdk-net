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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSession operation.
    /// 
    /// </summary>
    public partial class CreateSessionRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private SessionMode _sessionMode;

        /// <summary>
        /// Gets and sets the property BucketName.
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property SessionMode.
        /// </summary>
        public SessionMode SessionMode
        {
            get { return this._sessionMode; }
            set { this._sessionMode = value; }
        }

        // Check to see if SessionMode property is set
        internal bool IsSetSessionMode()
        {
            return this._sessionMode != null;
        }

    }
}