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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// A changeset is unit of data in a dataset.
    /// </summary>
    public partial class ChangesetInfo
    {
        private string _changesetArn;
        private Dictionary<string, string> _changesetLabels = new Dictionary<string, string>();
        private ChangeType _changeType;
        private DateTime? _createTimestamp;
        private string _datasetId;
        private ErrorInfo _errorInfo;
        private Dictionary<string, string> _formatParams = new Dictionary<string, string>();
        private FormatType _formatType;
        private string _id;
        private Dictionary<string, string> _sourceParams = new Dictionary<string, string>();
        private SourceType _sourceType;
        private ChangesetStatus _status;
        private string _updatedByChangesetId;
        private string _updatesChangesetId;

        /// <summary>
        /// Gets and sets the property ChangesetArn. 
        /// <para>
        /// The ARN identifier of the changeset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ChangesetArn
        {
            get { return this._changesetArn; }
            set { this._changesetArn = value; }
        }

        // Check to see if ChangesetArn property is set
        internal bool IsSetChangesetArn()
        {
            return this._changesetArn != null;
        }

        /// <summary>
        /// Gets and sets the property ChangesetLabels. 
        /// <para>
        /// Tags associated with the changeset.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ChangesetLabels
        {
            get { return this._changesetLabels; }
            set { this._changesetLabels = value; }
        }

        // Check to see if ChangesetLabels property is set
        internal bool IsSetChangesetLabels()
        {
            return this._changesetLabels != null && this._changesetLabels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// Change type indicates how a changeset is applied to a dataset.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>REPLACE</code> - Changeset is considered as a replacement to all prior loaded
        /// changesets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>APPEND</code> - Changeset is considered as an addition to the end of all prior
        /// loaded changesets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MODIFY</code> - Changeset is considered as a replacement to a specific prior
        /// ingested changeset.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ChangeType ChangeType
        {
            get { return this._changeType; }
            set { this._changeType = value; }
        }

        // Check to see if ChangeType property is set
        internal bool IsSetChangeType()
        {
            return this._changeType != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The timestamp at which the changeset was created in FinSpace.
        /// </para>
        /// </summary>
        public DateTime CreateTimestamp
        {
            get { return this._createTimestamp.GetValueOrDefault(); }
            set { this._createTimestamp = value; }
        }

        // Check to see if CreateTimestamp property is set
        internal bool IsSetCreateTimestamp()
        {
            return this._createTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The unique identifier for the FinSpace dataset in which the changeset is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// The structure with error messages.
        /// </para>
        /// </summary>
        public ErrorInfo ErrorInfo
        {
            get { return this._errorInfo; }
            set { this._errorInfo = value; }
        }

        // Check to see if ErrorInfo property is set
        internal bool IsSetErrorInfo()
        {
            return this._errorInfo != null;
        }

        /// <summary>
        /// Gets and sets the property FormatParams. 
        /// <para>
        /// Structure of the source file(s).
        /// </para>
        /// </summary>
        public Dictionary<string, string> FormatParams
        {
            get { return this._formatParams; }
            set { this._formatParams = value; }
        }

        // Check to see if FormatParams property is set
        internal bool IsSetFormatParams()
        {
            return this._formatParams != null && this._formatParams.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FormatType. 
        /// <para>
        /// Format type of the input files loaded into the changeset.
        /// </para>
        /// </summary>
        public FormatType FormatType
        {
            get { return this._formatType; }
            set { this._formatType = value; }
        }

        // Check to see if FormatType property is set
        internal bool IsSetFormatType()
        {
            return this._formatType != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Unique identifier for a changeset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property SourceParams. 
        /// <para>
        /// Source path from which the files to create the changeset are sourced.
        /// </para>
        /// </summary>
        public Dictionary<string, string> SourceParams
        {
            get { return this._sourceParams; }
            set { this._sourceParams = value; }
        }

        // Check to see if SourceParams property is set
        internal bool IsSetSourceParams()
        {
            return this._sourceParams != null && this._sourceParams.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Type of the data source from which the files to create the changeset are sourced.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>S3</code> - Amazon S3.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of changeset creation operation.
        /// </para>
        /// </summary>
        public ChangesetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedByChangesetId. 
        /// <para>
        /// Unique identifier of the changeset that is updated a changeset.
        /// </para>
        /// </summary>
        public string UpdatedByChangesetId
        {
            get { return this._updatedByChangesetId; }
            set { this._updatedByChangesetId = value; }
        }

        // Check to see if UpdatedByChangesetId property is set
        internal bool IsSetUpdatedByChangesetId()
        {
            return this._updatedByChangesetId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatesChangesetId. 
        /// <para>
        /// Unique identifier of the changeset that is updated.
        /// </para>
        /// </summary>
        public string UpdatesChangesetId
        {
            get { return this._updatesChangesetId; }
            set { this._updatesChangesetId = value; }
        }

        // Check to see if UpdatesChangesetId property is set
        internal bool IsSetUpdatesChangesetId()
        {
            return this._updatesChangesetId != null;
        }

    }
}