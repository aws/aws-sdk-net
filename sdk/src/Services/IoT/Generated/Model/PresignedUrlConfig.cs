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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Configuration for pre-signed S3 URLs.
    /// </summary>
    public partial class PresignedUrlConfig
    {
        private long? _expiresInSec;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ExpiresInSec. 
        /// <para>
        /// How long (in seconds) pre-signed URLs are valid. Valid values are 60 - 3600, the default
        /// value is 3600 seconds. Pre-signed URLs are generated when Jobs receives an MQTT request
        /// for the job document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=3600)]
        public long? ExpiresInSec
        {
            get { return this._expiresInSec; }
            set { this._expiresInSec = value; }
        }

        // Check to see if ExpiresInSec property is set
        internal bool IsSetExpiresInSec()
        {
            return this._expiresInSec.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of an IAM role that grants permission to download files from the S3 bucket
        /// where the job data/updates are stored. The role must also grant permission for IoT
        /// to download the files.
        /// </para>
        ///  <important> 
        /// <para>
        /// For information about addressing the confused deputy problem, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/cross-service-confused-deputy-prevention.html">cross-service
        /// confused deputy prevention</a> in the <i>Amazon Web Services IoT Core developer guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}