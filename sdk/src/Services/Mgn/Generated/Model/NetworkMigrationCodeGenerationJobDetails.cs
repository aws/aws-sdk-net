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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Details about a network migration code generation job.
    /// </summary>
    public partial class NetworkMigrationCodeGenerationJobDetails
    {
        private Dictionary<string, CodeGenerationOutputFormatStatusDetails> _codeGenerationOutputFormatStatusDetailsMap = AWSConfigs.InitializeCollections ? new Dictionary<string, CodeGenerationOutputFormatStatusDetails>() : null;
        private DateTime? _createdAt;
        private DateTime? _endedAt;
        private string _jobid;
        private string _networkMigrationDefinitionID;
        private string _networkMigrationExecutionID;
        private NetworkMigrationJobStatus _status;
        private string _statusDetails;

        /// <summary>
        /// Gets and sets the property CodeGenerationOutputFormatStatusDetailsMap. 
        /// <para>
        /// A map of output format types to their status details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, CodeGenerationOutputFormatStatusDetails> CodeGenerationOutputFormatStatusDetailsMap
        {
            get { return this._codeGenerationOutputFormatStatusDetailsMap; }
            set { this._codeGenerationOutputFormatStatusDetailsMap = value; }
        }

        // Check to see if CodeGenerationOutputFormatStatusDetailsMap property is set
        internal bool IsSetCodeGenerationOutputFormatStatusDetailsMap()
        {
            return this._codeGenerationOutputFormatStatusDetailsMap != null && (this._codeGenerationOutputFormatStatusDetailsMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the job completed or failed.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The unique identifier of the code generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string JobID
        {
            get { return this._jobid; }
            set { this._jobid = value; }
        }

        // Check to see if JobID property is set
        internal bool IsSetJobID()
        {
            return this._jobid != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkMigrationDefinitionID. 
        /// <para>
        /// The unique identifier of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string NetworkMigrationDefinitionID
        {
            get { return this._networkMigrationDefinitionID; }
            set { this._networkMigrationDefinitionID = value; }
        }

        // Check to see if NetworkMigrationDefinitionID property is set
        internal bool IsSetNetworkMigrationDefinitionID()
        {
            return this._networkMigrationDefinitionID != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkMigrationExecutionID. 
        /// <para>
        /// The unique identifier of the network migration execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string NetworkMigrationExecutionID
        {
            get { return this._networkMigrationExecutionID; }
            set { this._networkMigrationExecutionID = value; }
        }

        // Check to see if NetworkMigrationExecutionID property is set
        internal bool IsSetNetworkMigrationExecutionID()
        {
            return this._networkMigrationExecutionID != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the code generation job.
        /// </para>
        /// </summary>
        public NetworkMigrationJobStatus Status
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
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Detailed status information about the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public string StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

    }
}