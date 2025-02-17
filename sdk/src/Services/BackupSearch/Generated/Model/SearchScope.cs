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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
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
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// The search scope is all backup properties input into a search.
    /// </summary>
    public partial class SearchScope
    {
        private List<string> _backupResourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private BackupCreationTimeFilter _backupResourceCreationTime;
        private Dictionary<string, string> _backupResourceTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _backupResourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sourceResourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BackupResourceArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the backup resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> BackupResourceArns
        {
            get { return this._backupResourceArns; }
            set { this._backupResourceArns = value; }
        }

        // Check to see if BackupResourceArns property is set
        internal bool IsSetBackupResourceArns()
        {
            return this._backupResourceArns != null && (this._backupResourceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BackupResourceCreationTime. 
        /// <para>
        /// This is the time a backup resource was created.
        /// </para>
        /// </summary>
        public BackupCreationTimeFilter BackupResourceCreationTime
        {
            get { return this._backupResourceCreationTime; }
            set { this._backupResourceCreationTime = value; }
        }

        // Check to see if BackupResourceCreationTime property is set
        internal bool IsSetBackupResourceCreationTime()
        {
            return this._backupResourceCreationTime != null;
        }

        /// <summary>
        /// Gets and sets the property BackupResourceTags. 
        /// <para>
        /// These are one or more tags on the backup (recovery point).
        /// </para>
        /// </summary>
        public Dictionary<string, string> BackupResourceTags
        {
            get { return this._backupResourceTags; }
            set { this._backupResourceTags = value; }
        }

        // Check to see if BackupResourceTags property is set
        internal bool IsSetBackupResourceTags()
        {
            return this._backupResourceTags != null && (this._backupResourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BackupResourceTypes. 
        /// <para>
        /// The resource types included in a search.
        /// </para>
        ///  
        /// <para>
        /// Eligible resource types include S3 and EBS.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> BackupResourceTypes
        {
            get { return this._backupResourceTypes; }
            set { this._backupResourceTypes = value; }
        }

        // Check to see if BackupResourceTypes property is set
        internal bool IsSetBackupResourceTypes()
        {
            return this._backupResourceTypes != null && (this._backupResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceResourceArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the source resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> SourceResourceArns
        {
            get { return this._sourceResourceArns; }
            set { this._sourceResourceArns = value; }
        }

        // Check to see if SourceResourceArns property is set
        internal bool IsSetSourceResourceArns()
        {
            return this._sourceResourceArns != null && (this._sourceResourceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}