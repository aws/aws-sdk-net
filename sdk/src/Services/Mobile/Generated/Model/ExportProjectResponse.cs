/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mobile-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mobile.Model
{
    /// <summary>
    /// Result structure used for requests to export project configuration details.
    /// </summary>
    public partial class ExportProjectResponse : AmazonWebServiceResponse
    {
        private string _downloadUrl;
        private string _shareUrl;
        private string _snapshotId;

        /// <summary>
        /// Gets and sets the property DownloadUrl. 
        /// <para>
        ///  URL which can be used to download the exported project configuation file(s). 
        /// </para>
        /// </summary>
        public string DownloadUrl
        {
            get { return this._downloadUrl; }
            set { this._downloadUrl = value; }
        }

        // Check to see if DownloadUrl property is set
        internal bool IsSetDownloadUrl()
        {
            return this._downloadUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ShareUrl. 
        /// <para>
        ///  URL which can be shared to allow other AWS users to create their own project in AWS
        /// Mobile Hub with the same configuration as the specified project. This URL pertains
        /// to a snapshot in time of the project configuration that is created when this API is
        /// called. If you want to share additional changes to your project configuration, then
        /// you will need to create and share a new snapshot by calling this method again. 
        /// </para>
        /// </summary>
        public string ShareUrl
        {
            get { return this._shareUrl; }
            set { this._shareUrl = value; }
        }

        // Check to see if ShareUrl property is set
        internal bool IsSetShareUrl()
        {
            return this._shareUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        ///  Unique identifier for the exported snapshot of the project configuration. This snapshot
        /// identifier is included in the share URL. 
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

    }
}