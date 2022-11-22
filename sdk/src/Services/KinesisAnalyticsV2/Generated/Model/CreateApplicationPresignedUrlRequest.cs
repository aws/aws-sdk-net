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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplicationPresignedUrl operation.
    /// Creates and returns a URL that you can use to connect to an application's extension.
    /// 
    ///  
    /// <para>
    /// The IAM role or user used to call this API defines the permissions to access the extension.
    /// After the presigned URL is created, no additional permission is required to access
    /// this URL. IAM authorization policies for this API are also enforced for every HTTP
    /// request that attempts to connect to the extension. 
    /// </para>
    ///  
    /// <para>
    /// You control the amount of time that the URL will be valid using the <code>SessionExpirationDurationInSeconds</code>
    /// parameter. If you do not provide this parameter, the returned URL is valid for twelve
    /// hours.
    /// </para>
    ///  <note> 
    /// <para>
    /// The URL that you get from a call to CreateApplicationPresignedUrl must be used within
    /// 3 minutes to be valid. If you first try to use the URL after the 3-minute limit expires,
    /// the service returns an HTTP 403 Forbidden error.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateApplicationPresignedUrlRequest : AmazonKinesisAnalyticsV2Request
    {
        private string _applicationName;
        private long? _sessionExpirationDurationInSeconds;
        private UrlType _urlType;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property SessionExpirationDurationInSeconds. 
        /// <para>
        /// The duration in seconds for which the returned URL will be valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1800, Max=43200)]
        public long SessionExpirationDurationInSeconds
        {
            get { return this._sessionExpirationDurationInSeconds.GetValueOrDefault(); }
            set { this._sessionExpirationDurationInSeconds = value; }
        }

        // Check to see if SessionExpirationDurationInSeconds property is set
        internal bool IsSetSessionExpirationDurationInSeconds()
        {
            return this._sessionExpirationDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UrlType. 
        /// <para>
        /// The type of the extension for which to create and return a URL. Currently, the only
        /// valid extension URL type is <code>FLINK_DASHBOARD_URL</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UrlType UrlType
        {
            get { return this._urlType; }
            set { this._urlType = value; }
        }

        // Check to see if UrlType property is set
        internal bool IsSetUrlType()
        {
            return this._urlType != null;
        }

    }
}