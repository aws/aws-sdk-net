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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// The response from a describe changeset operation
    /// </summary>
    public partial class GetChangesetResponse : AmazonWebServiceResponse
    {
        private long? _activeFromTimestamp;
        private long? _activeUntilTimestamp;
        private string _changesetArn;
        private string _changesetId;
        private ChangeType _changeType;
        private long? _createTime;
        private string _datasetId;
        private ChangesetErrorInfo _errorInfo;
        private Dictionary<string, string> _formatParams = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _sourceParams = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private IngestionStatus _status;
        private string _updatedByChangesetId;
        private string _updatesChangesetId;

        /// <summary>
        /// Gets and sets the property ActiveFromTimestamp. 
        /// <para>
        /// Beginning time from which the Changeset is active. The value is determined as epoch
        /// time in milliseconds. For example, the value for Monday, November 1, 2021 12:00:00
        /// PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public long? ActiveFromTimestamp
        {
            get { return this._activeFromTimestamp; }
            set { this._activeFromTimestamp = value; }
        }

        // Check to see if ActiveFromTimestamp property is set
        internal bool IsSetActiveFromTimestamp()
        {
            return this._activeFromTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActiveUntilTimestamp. 
        /// <para>
        /// Time until which the Changeset is active. The value is determined as epoch time in
        /// milliseconds. For example, the value for Monday, November 1, 2021 12:00:00 PM UTC
        /// is specified as 1635768000000.
        /// </para>
        /// </summary>
        public long? ActiveUntilTimestamp
        {
            get { return this._activeUntilTimestamp; }
            set { this._activeUntilTimestamp = value; }
        }

        // Check to see if ActiveUntilTimestamp property is set
        internal bool IsSetActiveUntilTimestamp()
        {
            return this._activeUntilTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChangesetArn. 
        /// <para>
        /// The ARN identifier of the Changeset.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ChangesetId. 
        /// <para>
        /// The unique identifier for a Changeset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string ChangesetId
        {
            get { return this._changesetId; }
            set { this._changesetId = value; }
        }

        // Check to see if ChangesetId property is set
        internal bool IsSetChangesetId()
        {
            return this._changesetId != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// Type that indicates how a Changeset is applied to a Dataset.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REPLACE</c> – Changeset is considered as a replacement to all prior loaded Changesets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APPEND</c> – Changeset is considered as an addition to the end of all prior loaded
        /// Changesets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODIFY</c> – Changeset is considered as a replacement to a specific prior ingested
        /// Changeset.
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The timestamp at which the Changeset was created in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public long? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The unique identifier for the FinSpace Dataset where the Changeset is created.
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
        public ChangesetErrorInfo ErrorInfo
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> FormatParams
        {
            get { return this._formatParams; }
            set { this._formatParams = value; }
        }

        // Check to see if FormatParams property is set
        internal bool IsSetFormatParams()
        {
            return this._formatParams != null && (this._formatParams.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceParams. 
        /// <para>
        /// Options that define the location of the data being ingested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SourceParams
        {
            get { return this._sourceParams; }
            set { this._sourceParams = value; }
        }

        // Check to see if SourceParams property is set
        internal bool IsSetSourceParams()
        {
            return this._sourceParams != null && (this._sourceParams.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of Changeset creation operation.
        /// </para>
        /// </summary>
        public IngestionStatus Status
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
        /// The unique identifier of the updated Changeset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
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
        /// The unique identifier of the Changeset that is being updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
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