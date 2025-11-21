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
    /// Container for the parameters to the PutStorageLensConfiguration operation.
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Puts an Amazon S3 Storage Lens configuration. For more information about S3 Storage
    /// Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Working
    /// with Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>. For a complete
    /// list of S3 Storage Lens metrics, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_metrics_glossary.html">S3
    /// Storage Lens metrics glossary</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// To use this action, you must have permission to perform the <c>s3:PutStorageLensConfiguration</c>
    /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
    /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutStorageLensConfigurationRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _configId;
        private StorageLensConfiguration _storageLensConfiguration;
        private List<StorageLensTag> _tags = AWSConfigs.InitializeCollections ? new List<StorageLensTag>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID of the requester.
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
        /// Gets and sets the property ConfigId. 
        /// <para>
        /// The ID of the S3 Storage Lens configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ConfigId
        {
            get { return this._configId; }
            set { this._configId = value; }
        }

        // Check to see if ConfigId property is set
        internal bool IsSetConfigId()
        {
            return this._configId != null;
        }

        /// <summary>
        /// Gets and sets the property StorageLensConfiguration. 
        /// <para>
        /// The S3 Storage Lens configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageLensConfiguration StorageLensConfiguration
        {
            get { return this._storageLensConfiguration; }
            set { this._storageLensConfiguration = value; }
        }

        // Check to see if StorageLensConfiguration property is set
        internal bool IsSetStorageLensConfiguration()
        {
            return this._storageLensConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag set of the S3 Storage Lens configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can set up to a maximum of 50 tags.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StorageLensTag> Tags
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