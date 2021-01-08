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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the CopyBackupToRegion operation.
    /// Copy an AWS CloudHSM cluster backup to a different region.
    /// </summary>
    public partial class CopyBackupToRegionRequest : AmazonCloudHSMV2Request
    {
        private string _backupId;
        private string _destinationRegion;
        private List<Tag> _tagList = new List<Tag>();

        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        /// The ID of the backup that will be copied to the destination region. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupId
        {
            get { return this._backupId; }
            set { this._backupId = value; }
        }

        // Check to see if BackupId property is set
        internal bool IsSetBackupId()
        {
            return this._backupId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The AWS region that will contain your copied CloudHSM cluster backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationRegion
        {
            get { return this._destinationRegion; }
            set { this._destinationRegion = value; }
        }

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this._destinationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// Tags to apply to the destination backup during creation. If you specify tags, only
        /// these tags will be applied to the destination backup. If you do not specify tags,
        /// the service copies tags from the source backup to the destination backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && this._tagList.Count > 0; 
        }

    }
}