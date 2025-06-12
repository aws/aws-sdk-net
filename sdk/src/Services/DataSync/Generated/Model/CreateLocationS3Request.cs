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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLocationS3 operation.
    /// Creates a transfer <i>location</i> for an Amazon S3 bucket. DataSync can use this
    /// location as a source or destination for transferring data.
    /// 
    ///  <important> 
    /// <para>
    /// Before you begin, make sure that you read the following topics:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
    /// class considerations with Amazon S3 locations</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">Evaluating
    /// S3 request costs when using DataSync</a> 
    /// </para>
    ///  </li> </ul> </important> 
    /// <para>
    ///  For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html">Configuring
    /// transfers with Amazon S3</a>.
    /// </para>
    /// </summary>
    public partial class CreateLocationS3Request : AmazonDataSyncRequest
    {
        private List<string> _agentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _s3BucketArn;
        private S3Config _s3Config;
        private S3StorageClass _s3StorageClass;
        private string _subdirectory;
        private List<TagListEntry> _tags = AWSConfigs.InitializeCollections ? new List<TagListEntry>() : null;

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// (Amazon S3 on Outposts only) Specifies the Amazon Resource Name (ARN) of the DataSync
        /// agent on your Outpost.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/deploy-agents.html#outposts-agent">Deploy
        /// your DataSync agent on Outposts</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> AgentArns
        {
            get { return this._agentArns; }
            set { this._agentArns = value; }
        }

        // Check to see if AgentArns property is set
        internal bool IsSetAgentArns()
        {
            return this._agentArns != null && (this._agentArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// Specifies the ARN of the S3 bucket that you want to use as a location. (When creating
        /// your DataSync task later, you specify whether this location is a transfer source or
        /// destination.) 
        /// </para>
        ///  
        /// <para>
        /// If your S3 bucket is located on an Outposts resource, you must specify an Amazon S3
        /// access point. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points.html">Managing
        /// data access with Amazon S3 access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=268)]
        public string S3BucketArn
        {
            get { return this._s3BucketArn; }
            set { this._s3BucketArn = value; }
        }

        // Check to see if S3BucketArn property is set
        internal bool IsSetS3BucketArn()
        {
            return this._s3BucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3Config.
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Config S3Config
        {
            get { return this._s3Config; }
            set { this._s3Config = value; }
        }

        // Check to see if S3Config property is set
        internal bool IsSetS3Config()
        {
            return this._s3Config != null;
        }

        /// <summary>
        /// Gets and sets the property S3StorageClass. 
        /// <para>
        /// Specifies the storage class that you want your objects to use when Amazon S3 is a
        /// transfer destination.
        /// </para>
        ///  
        /// <para>
        /// For buckets in Amazon Web Services Regions, the storage class defaults to <c>STANDARD</c>.
        /// For buckets on Outposts, the storage class defaults to <c>OUTPOSTS</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
        /// class considerations with Amazon S3 transfers</a>.
        /// </para>
        /// </summary>
        public S3StorageClass S3StorageClass
        {
            get { return this._s3StorageClass; }
            set { this._s3StorageClass = value; }
        }

        // Check to see if S3StorageClass property is set
        internal bool IsSetS3StorageClass()
        {
            return this._s3StorageClass != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// Specifies a prefix in the S3 bucket that DataSync reads from or writes to (depending
        /// on whether the bucket is a source or destination location).
        /// </para>
        ///  <note> 
        /// <para>
        /// DataSync can't transfer objects with a prefix that begins with a slash (<c>/</c>)
        /// or includes <c>//</c>, <c>/./</c>, or <c>/../</c> patterns. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>/photos</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>photos//2006/January</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>photos/./2006/February</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>photos/../2006/March</c> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string Subdirectory
        {
            get { return this._subdirectory; }
            set { this._subdirectory = value; }
        }

        // Check to see if Subdirectory property is set
        internal bool IsSetSubdirectory()
        {
            return this._subdirectory != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies labels that help you categorize, filter, and search for your Amazon Web
        /// Services resources. We recommend creating at least a name tag for your transfer location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TagListEntry> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}