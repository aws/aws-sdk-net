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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// Details about a generated code job.
    /// </summary>
    public partial class GeneratedCodeJobDetails
    {
        private string _description;
        private DateTime? _expirationTime;
        private string _generatedCodeJobId;
        private string _s3Url;
        private GeneratedCodeJobState _status;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the generated code job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The expiration date and time for the download URL.
        /// </para>
        ///  
        /// <para>
        ///  The download URL us guaranteed to be available until at least this time. 
        /// </para>
        /// </summary>
        public DateTime ExpirationTime
        {
            get { return this._expirationTime.GetValueOrDefault(); }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GeneratedCodeJobId. 
        /// <para>
        /// The identifier for the generated code job.
        /// </para>
        /// </summary>
        public string GeneratedCodeJobId
        {
            get { return this._generatedCodeJobId; }
            set { this._generatedCodeJobId = value; }
        }

        // Check to see if GeneratedCodeJobId property is set
        internal bool IsSetGeneratedCodeJobId()
        {
            return this._generatedCodeJobId != null;
        }

        /// <summary>
        /// Gets and sets the property S3Url. 
        /// <para>
        /// A presigned URL that can be used to download the generated code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=2048)]
        public string S3Url
        {
            get { return this._s3Url; }
            set { this._s3Url = value; }
        }

        // Check to see if S3Url property is set
        internal bool IsSetS3Url()
        {
            return this._s3Url != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the generated code job
        /// </para>
        /// </summary>
        public GeneratedCodeJobState Status
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