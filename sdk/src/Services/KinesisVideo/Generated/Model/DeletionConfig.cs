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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// The configuration details required to delete the connection of the stream from the
    /// Edge Agent.
    /// </summary>
    public partial class DeletionConfig
    {
        private bool? _deleteAfterUpload;
        private int? _edgeRetentionInHours;
        private LocalSizeConfig _localSizeConfig;

        /// <summary>
        /// Gets and sets the property DeleteAfterUpload. 
        /// <para>
        /// The <code>boolean</code> value used to indicate whether or not you want to mark the
        /// media for deletion, once it has been uploaded to the Kinesis Video Stream cloud. The
        /// media files can be deleted if any of the deletion configuration values are set to
        /// <code>true</code>, such as when the limit for the <code>EdgeRetentionInHours</code>,
        /// or the <code>MaxLocalMediaSizeInMB</code>, has been reached. 
        /// </para>
        ///  
        /// <para>
        /// Since the default value is set to <code>true</code>, configure the uploader schedule
        /// such that the media files are not being deleted before they are initially uploaded
        /// to AWS cloud.
        /// </para>
        /// </summary>
        public bool DeleteAfterUpload
        {
            get { return this._deleteAfterUpload.GetValueOrDefault(); }
            set { this._deleteAfterUpload = value; }
        }

        // Check to see if DeleteAfterUpload property is set
        internal bool IsSetDeleteAfterUpload()
        {
            return this._deleteAfterUpload.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgeRetentionInHours. 
        /// <para>
        /// The number of hours that you want to retain the data in the stream on the Edge Agent.
        /// The default value of the retention time is 720 hours, which translates to 30 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=720)]
        public int EdgeRetentionInHours
        {
            get { return this._edgeRetentionInHours.GetValueOrDefault(); }
            set { this._edgeRetentionInHours = value; }
        }

        // Check to see if EdgeRetentionInHours property is set
        internal bool IsSetEdgeRetentionInHours()
        {
            return this._edgeRetentionInHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalSizeConfig. 
        /// <para>
        /// The value of the local size required in order to delete the edge configuration.
        /// </para>
        /// </summary>
        public LocalSizeConfig LocalSizeConfig
        {
            get { return this._localSizeConfig; }
            set { this._localSizeConfig = value; }
        }

        // Check to see if LocalSizeConfig property is set
        internal bool IsSetLocalSizeConfig()
        {
            return this._localSizeConfig != null;
        }

    }
}