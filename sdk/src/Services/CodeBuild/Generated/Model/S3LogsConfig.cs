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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about S3 logs for a build project.
    /// </summary>
    public partial class S3LogsConfig
    {
        private bool? _encryptionDisabled;
        private string _location;
        private LogsConfigStatusType _status;

        /// <summary>
        /// Gets and sets the property EncryptionDisabled. 
        /// <para>
        ///  Set to true if you do not want your S3 build log output encrypted. By default S3
        /// build logs are encrypted. 
        /// </para>
        /// </summary>
        public bool EncryptionDisabled
        {
            get { return this._encryptionDisabled.GetValueOrDefault(); }
            set { this._encryptionDisabled = value; }
        }

        // Check to see if EncryptionDisabled property is set
        internal bool IsSetEncryptionDisabled()
        {
            return this._encryptionDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  The ARN of an S3 bucket and the path prefix for S3 logs. If your Amazon S3 bucket
        /// name is <code>my-bucket</code>, and your path prefix is <code>build-log</code>, then
        /// acceptable formats are <code>my-bucket/build-log</code> or <code>arn:aws:s3:::my-bucket/build-log</code>.
        /// 
        /// </para>
        /// </summary>
        public string Location
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the S3 build logs. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENABLED</code>: S3 build logs are enabled for this build project.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED</code>: S3 build logs are not enabled for this build project.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public LogsConfigStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}