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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the StartImport operation.
    /// Start import.
    /// </summary>
    public partial class StartImportRequest : AmazonMgnRequest
    {
        private string _clientToken;
        private S3BucketSource _s3BucketSource;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Start import request client token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketSource. 
        /// <para>
        /// Start import request s3 bucket source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3BucketSource S3BucketSource
        {
            get { return this._s3BucketSource; }
            set { this._s3BucketSource = value; }
        }

        // Check to see if S3BucketSource property is set
        internal bool IsSetS3BucketSource()
        {
            return this._s3BucketSource != null;
        }

    }
}