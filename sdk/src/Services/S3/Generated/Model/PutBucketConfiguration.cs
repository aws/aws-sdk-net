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
    /// The configuration information for the bucket.
    /// </summary>
    public partial class PutBucketConfiguration
    {
        private BucketInfo _bucketInfo;
        private LocationInfo _location;
        private BucketLocationConstraint _locationConstraint;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property BucketInfo. 
        /// <para>
        /// Specifies the information about the bucket that will be created.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is only supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public BucketInfo BucketInfo
        {
            get { return this._bucketInfo; }
            set { this._bucketInfo = value; }
        }

        // Check to see if BucketInfo property is set
        internal bool IsSetBucketInfo()
        {
            return this._bucketInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Specifies the location where the bucket will be created.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets </b> - The location type is Availability Zone or Local Zone.
        /// To use the Local Zone location type, your account must be enabled for Local Zones.
        /// Otherwise, you get an HTTP <c>403 Forbidden</c> error with the error code <c>AccessDenied</c>.
        /// To learn more, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/opt-in-directory-bucket-lz.html">Enable
        /// accounts for Local Zones</a> in the <i>Amazon S3 User Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is only supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public LocationInfo Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property LocationConstraint. 
        /// <para>
        /// Specifies the Region where the bucket will be created. You might choose a Region to
        /// optimize latency, minimize costs, or address regulatory requirements. For example,
        /// if you reside in Europe, you will probably find it advantageous to create buckets
        /// in the Europe (Ireland) Region.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a Region, the bucket is created in the US East (N. Virginia)
        /// Region (us-east-1) by default. Configurations using the value <c>EU</c> will create
        /// a bucket in <c>eu-west-1</c>.
        /// </para>
        ///  
        /// <para>
        /// For a list of the valid values for all of the Amazon Web Services Regions, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
        /// and Endpoints</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public BucketLocationConstraint LocationConstraint
        {
            get { return this._locationConstraint; }
            set { this._locationConstraint = value; }
        }

        // Check to see if LocationConstraint property is set
        internal bool IsSetLocationConstraint()
        {
            return this._locationConstraint != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tags that you can apply to the bucket that you're creating. Tags are key-value
        /// pairs of metadata used to categorize and organize your buckets, track costs, and control
        /// access. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only supported for S3 directory buckets. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-tagging.html">Using
        /// tags with directory buckets</a>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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