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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// The configuration details required to delete the connection of the stream from the
    /// Edge Agent.
    /// </summary>
    public partial class DeletionConfig
    {
        /// <summary>
        /// Gets and sets the property DeleteAfterUpload. 
        /// <para>
        /// The <c>boolean</c> value used to indicate whether or not you want to mark the media
        /// for deletion, once it has been uploaded to the Kinesis Video Stream cloud. The media
        /// files can be deleted if any of the deletion configuration values are set to <c>true</c>,
        /// such as when the limit for the <c>EdgeRetentionInHours</c>, or the <c>MaxLocalMediaSizeInMB</c>,
        /// has been reached. 
        /// </para>
        ///  
        /// <para>
        /// Since the default value is set to <c>true</c>, configure the uploader schedule such
        /// that the media files are not being deleted before they are initially uploaded to the
        /// Amazon Web Services cloud.
        /// </para>
        /// </summary>
        public bool? DeleteAfterUpload { get; set; }

        /// <summary>
        /// Checks to see if the DeleteAfterUpload property is set.
        /// </summary>
        internal bool IsSetDeleteAfterUpload() => this.DeleteAfterUpload.HasValue;

        /// <summary>
        /// Gets and sets the property EdgeRetentionInHours. 
        /// <para>
        /// The number of hours that you want to retain the data in the stream on the Edge Agent.
        /// The default value of the retention time is 720 hours, which translates to 30 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 720)]
        public int? EdgeRetentionInHours { get; set; }

        /// <summary>
        /// Checks to see if the EdgeRetentionInHours property is set.
        /// </summary>
        internal bool IsSetEdgeRetentionInHours() => this.EdgeRetentionInHours.HasValue;

        /// <summary>
        /// Gets and sets the property LocalSizeConfig. 
        /// <para>
        /// The value of the local size required in order to delete the edge configuration.
        /// </para>
        /// </summary>
        public LocalSizeConfig LocalSizeConfig { get; set; }

        /// <summary>
        /// Checks to see if the LocalSizeConfig property is set.
        /// </summary>
        internal bool IsSetLocalSizeConfig() => this.LocalSizeConfig != null;
    }
}
