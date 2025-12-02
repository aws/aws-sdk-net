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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the GetDataExportConfiguration operation.
    /// </summary>
    public partial class GetDataExportConfigurationResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private EncryptionConfiguration _encryptionConfiguration;
        private bool? _isExportEnabled;
        private string _s3TableBucketArn;
        private ConfigurationStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp at which the data export configuration report was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration as part of the data export configuration details.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IsExportEnabled. 
        /// <para>
        /// Specifies whether the export is enabled.
        /// </para>
        /// </summary>
        public bool IsExportEnabled
        {
            get { return this._isExportEnabled.GetValueOrDefault(); }
            set { this._isExportEnabled = value; }
        }

        // Check to see if IsExportEnabled property is set
        internal bool IsSetIsExportEnabled()
        {
            return this._isExportEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3TableBucketArn. 
        /// <para>
        /// The Amazon S3 table bucket ARN as part of the data export configuration details.
        /// </para>
        /// </summary>
        public string S3TableBucketArn
        {
            get { return this._s3TableBucketArn; }
            set { this._s3TableBucketArn = value; }
        }

        // Check to see if S3TableBucketArn property is set
        internal bool IsSetS3TableBucketArn()
        {
            return this._s3TableBucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the data export configuration.
        /// </para>
        /// </summary>
        public ConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp at which the data export configuration report was updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}