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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes the persistent application settings for users of a stack.
    /// </summary>
    public partial class ApplicationSettingsResponse
    {
        private bool? _enabled;
        private string _s3BucketName;
        private string _settingsGroup;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether persistent application settings are enabled for users during their
        /// streaming sessions.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The S3 bucket where users’ persistent application settings are stored. When persistent
        /// application settings are enabled for the first time for an account in an AWS Region,
        /// an S3 bucket is created. The bucket is unique to the AWS account and the Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property SettingsGroup. 
        /// <para>
        /// The path prefix for the S3 bucket where users’ persistent application settings are
        /// stored.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string SettingsGroup
        {
            get { return this._settingsGroup; }
            set { this._settingsGroup = value; }
        }

        // Check to see if SettingsGroup property is set
        internal bool IsSetSettingsGroup()
        {
            return this._settingsGroup != null;
        }

    }
}