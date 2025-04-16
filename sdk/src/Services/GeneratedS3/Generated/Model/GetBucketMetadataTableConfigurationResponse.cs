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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the GetBucketMetadataTableConfiguration operation.
    /// </summary>
    public partial class GetBucketMetadataTableConfigurationResponse : AmazonWebServiceResponse
    {
        private GetBucketMetadataTableConfigurationResult _getBucketMetadataTableConfigurationResult;

        /// <summary>
        /// Gets and sets the property GetBucketMetadataTableConfigurationResult. 
        /// <para>
        ///  The metadata table configuration for the general purpose bucket. 
        /// </para>
        /// </summary>
        public GetBucketMetadataTableConfigurationResult GetBucketMetadataTableConfigurationResult
        {
            get { return this._getBucketMetadataTableConfigurationResult; }
            set { this._getBucketMetadataTableConfigurationResult = value; }
        }

        // Check to see if GetBucketMetadataTableConfigurationResult property is set
        internal bool IsSetGetBucketMetadataTableConfigurationResult()
        {
            return this._getBucketMetadataTableConfigurationResult != null;
        }

    }
}