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
    /// Part of <c>ListStorageLensConfigurationResult</c>. Each entry includes the description
    /// of the S3 Storage Lens configuration, its home Region, whether it is enabled, its
    /// Amazon Resource Name (ARN), and config ID.
    /// </summary>
    public partial class ListStorageLensConfigurationEntry
    {
        private string _homeRegion;
        private string _id;
        private bool? _isEnabled;
        private string _storageLensArn;

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// A container for the S3 Storage Lens home Region. Your metrics data is stored and retained
        /// in your designated S3 Storage Lens home Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=30)]
        public string HomeRegion
        {
            get { return this._homeRegion; }
            set { this._homeRegion = value; }
        }

        // Check to see if HomeRegion property is set
        internal bool IsSetHomeRegion()
        {
            return this._homeRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A container for the S3 Storage Lens configuration ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// A container for whether the S3 Storage Lens configuration is enabled. This property
        /// is required.
        /// </para>
        /// </summary>
        public bool? IsEnabled
        {
            get { return this._isEnabled; }
            set { this._isEnabled = value; }
        }

        // Check to see if IsEnabled property is set
        internal bool IsSetIsEnabled()
        {
            return this._isEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageLensArn. 
        /// <para>
        /// The ARN of the S3 Storage Lens configuration. This property is read-only.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string StorageLensArn
        {
            get { return this._storageLensArn; }
            set { this._storageLensArn = value; }
        }

        // Check to see if StorageLensArn property is set
        internal bool IsSetStorageLensArn()
        {
            return this._storageLensArn != null;
        }

    }
}