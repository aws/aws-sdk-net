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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The settings for the RTMP (Real-Time Messaging Protocol) source.
    /// </summary>
    public partial class RtmpPushSourceSettings
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the RTMP application. Together with the stream name, the application name
        /// forms the RTMP URL path, in the pattern <c>rtmp://ingestAddress/applicationName/streamName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property NamingType. 
        /// <para>
        /// The naming type that the source uses. With <c>AUTOMATIC</c> naming, MediaConnect generates
        /// the application and stream names.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RtmpPushNamingType NamingType { get; set; }

        /// <summary>
        /// Checks to see if the NamingType property is set.
        /// </summary>
        internal bool IsSetNamingType() => this.NamingType != null;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the RTMP stream. The stream name forms the final segment of the RTMP URL
        /// path.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;
    }
}
