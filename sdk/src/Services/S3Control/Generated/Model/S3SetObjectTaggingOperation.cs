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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Contains the configuration parameters for a PUT Object Tagging operation. S3 Batch
    /// Operations passes every object to the underlying <c>PutObjectTagging</c> API operation.
    /// For more information about the parameters for this operation, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectPUTtagging.html">PutObjectTagging</a>.
    /// </summary>
    public partial class S3SetObjectTaggingOperation
    {
        private List<S3Tag> _tagSet = AWSConfigs.InitializeCollections ? new List<S3Tag>() : null;

        /// <summary>
        /// Gets and sets the property TagSet.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Tag> TagSet
        {
            get { return this._tagSet; }
            set { this._tagSet = value; }
        }

        // Check to see if TagSet property is set
        internal bool IsSetTagSet()
        {
            return this._tagSet != null && (this._tagSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}