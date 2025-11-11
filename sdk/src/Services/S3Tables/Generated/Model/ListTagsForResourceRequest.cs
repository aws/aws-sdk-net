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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// Lists all of the tags applied to a specified Amazon S3 Tables resource. Each tag is
    /// a label consisting of a key and value pair. Tags can help you organize, track costs
    /// for, and control access to resources. 
    /// 
    ///  <note> 
    /// <para>
    /// For a list of S3 resources that support tagging, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html#manage-tags">Managing
    /// tags for Amazon S3 resources</a>.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// For tables and table buckets, you must have the <c>s3tables:ListTagsForResource</c>
    /// permission to use this operation.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonS3TablesRequest
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 Tables resource that you want to list
        /// tags for. The tagged resource can be a table bucket or a table. For a list of all
        /// S3 resources that support tagging, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html#manage-tags">Managing
        /// tags for Amazon S3 resources</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}