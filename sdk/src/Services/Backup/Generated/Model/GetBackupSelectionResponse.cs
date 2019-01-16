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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the GetBackupSelection operation.
    /// </summary>
    public partial class GetBackupSelectionResponse : AmazonWebServiceResponse
    {
        private string _backupPlanId;
        private BackupSelection _backupSelection;
        private DateTime? _creationDate;
        private string _creatorRequestId;
        private string _selectionId;

        /// <summary>
        /// Gets and sets the property BackupPlanId. 
        /// <para>
        /// Uniquely identifies a backup plan.
        /// </para>
        /// </summary>
        public string BackupPlanId
        {
            get { return this._backupPlanId; }
            set { this._backupPlanId = value; }
        }

        // Check to see if BackupPlanId property is set
        internal bool IsSetBackupPlanId()
        {
            return this._backupPlanId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupSelection. 
        /// <para>
        /// Specifies the body of a request to assign a set of resources to a backup plan.
        /// </para>
        ///  
        /// <para>
        /// It includes an array of resources, an optional array of patterns to exclude resources,
        /// an optional role to provide access to the AWS service that the resource belongs to,
        /// and an optional array of tags used to identify a set of resources.
        /// </para>
        /// </summary>
        public BackupSelection BackupSelection
        {
            get { return this._backupSelection; }
            set { this._backupSelection = value; }
        }

        // Check to see if BackupSelection property is set
        internal bool IsSetBackupSelection()
        {
            return this._backupSelection != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time a backup selection is created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <code>CreationDate</code> is accurate to milliseconds. For
        /// example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and allows failed requests to be retried
        /// without the risk of executing the operation twice.
        /// </para>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property SelectionId. 
        /// <para>
        /// Uniquely identifies the body of a request to assign a set of resources to a backup
        /// plan.
        /// </para>
        /// </summary>
        public string SelectionId
        {
            get { return this._selectionId; }
            set { this._selectionId = value; }
        }

        // Check to see if SelectionId property is set
        internal bool IsSetSelectionId()
        {
            return this._selectionId != null;
        }

    }
}