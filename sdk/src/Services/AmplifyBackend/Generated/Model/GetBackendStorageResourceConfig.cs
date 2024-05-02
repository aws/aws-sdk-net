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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
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
namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// The details for a backend storage resource.
    /// </summary>
    public partial class GetBackendStorageResourceConfig
    {
        private string _bucketName;
        private bool? _imported;
        private BackendStoragePermissions _permissions;
        private ServiceName _serviceName;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the S3 bucket.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property Imported. 
        /// <para>
        /// Returns True if the storage resource has been imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Imported
        {
            get { return this._imported; }
            set { this._imported = value; }
        }

        // Check to see if Imported property is set
        internal bool IsSetImported()
        {
            return this._imported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The authorization configuration for the storage S3 bucket.
        /// </para>
        /// </summary>
        public BackendStoragePermissions Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the storage service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceName ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}