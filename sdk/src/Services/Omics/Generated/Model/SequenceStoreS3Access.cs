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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// The S3 access metadata of the sequence store.
    /// </summary>
    public partial class SequenceStoreS3Access
    {
        private string _accessLogLocation;
        private string _s3AccessPointArn;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property AccessLogLocation. 
        /// <para>
        /// Location of the access logs.
        /// </para>
        /// </summary>
        public string AccessLogLocation
        {
            get { return this._accessLogLocation; }
            set { this._accessLogLocation = value; }
        }

        // Check to see if AccessLogLocation property is set
        internal bool IsSetAccessLogLocation()
        {
            return this._accessLogLocation != null;
        }

        /// <summary>
        /// Gets and sets the property S3AccessPointArn. 
        /// <para>
        /// This is ARN of the access point associated with the S3 bucket storing read sets.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string S3AccessPointArn
        {
            get { return this._s3AccessPointArn; }
            set { this._s3AccessPointArn = value; }
        }

        // Check to see if S3AccessPointArn property is set
        internal bool IsSetS3AccessPointArn()
        {
            return this._s3AccessPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The S3 URI of the sequence store.
        /// </para>
        /// </summary>
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}