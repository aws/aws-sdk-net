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
    /// Container for the parameters to the CreateStorageLensGroup operation.
    /// Creates a new S3 Storage Lens group and associates it with the specified Amazon Web
    /// Services account ID. An S3 Storage Lens group is a custom grouping of objects based
    /// on prefix, suffix, object tags, object size, object age, or a combination of these
    /// filters. For each Storage Lens group that you’ve created, you can also optionally
    /// add Amazon Web Services resource tags. For more information about S3 Storage Lens
    /// groups, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-lens-groups-overview.html">Working
    /// with S3 Storage Lens groups</a>.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must have the permission to perform the <c>s3:CreateStorageLensGroup</c>
    /// action. If you’re trying to create a Storage Lens group with Amazon Web Services resource
    /// tags, you must also have permission to perform the <c>s3:TagResource</c> action. For
    /// more information about the required Storage Lens Groups permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_iam_permissions.html#storage_lens_groups_permissions">Setting
    /// account permissions to use S3 Storage Lens groups</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about Storage Lens groups errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#S3LensErrorCodeList">List
    /// of Amazon S3 Storage Lens error codes</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateStorageLensGroupRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private StorageLensGroup _storageLensGroup;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID that the Storage Lens group is created from and
        /// associated with. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property StorageLensGroup. 
        /// <para>
        ///  The Storage Lens group configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageLensGroup StorageLensGroup
        {
            get { return this._storageLensGroup; }
            set { this._storageLensGroup = value; }
        }

        // Check to see if StorageLensGroup property is set
        internal bool IsSetStorageLensGroup()
        {
            return this._storageLensGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The Amazon Web Services resource tags that you're adding to your Storage Lens group.
        /// This parameter is optional. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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