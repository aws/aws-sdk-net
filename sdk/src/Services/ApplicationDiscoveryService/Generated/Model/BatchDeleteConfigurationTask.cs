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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// A metadata object that represents the deletion task being executed.
    /// </summary>
    public partial class BatchDeleteConfigurationTask
    {
        private DeletionConfigurationItemType _configurationType;
        private List<string> _deletedConfigurations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DeletionWarning> _deletionWarnings = AWSConfigs.InitializeCollections ? new List<DeletionWarning>() : null;
        private DateTime? _endTime;
        private List<FailedConfiguration> _failedConfigurations = AWSConfigs.InitializeCollections ? new List<FailedConfiguration>() : null;
        private List<string> _requestedConfigurations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _startTime;
        private BatchDeleteConfigurationTaskStatus _status;
        private string _taskId;

        /// <summary>
        /// Gets and sets the property ConfigurationType. 
        /// <para>
        ///  The type of configuration item to delete. Supported types are: SERVER. 
        /// </para>
        /// </summary>
        public DeletionConfigurationItemType ConfigurationType
        {
            get { return this._configurationType; }
            set { this._configurationType = value; }
        }

        // Check to see if ConfigurationType property is set
        internal bool IsSetConfigurationType()
        {
            return this._configurationType != null;
        }

        /// <summary>
        /// Gets and sets the property DeletedConfigurations. 
        /// <para>
        ///  The list of configuration IDs that were successfully deleted by the deletion task.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeletedConfigurations
        {
            get { return this._deletedConfigurations; }
            set { this._deletedConfigurations = value; }
        }

        // Check to see if DeletedConfigurations property is set
        internal bool IsSetDeletedConfigurations()
        {
            return this._deletedConfigurations != null && (this._deletedConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeletionWarnings. 
        /// <para>
        ///  A list of configuration IDs that produced warnings regarding their deletion, paired
        /// with a warning message. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeletionWarning> DeletionWarnings
        {
            get { return this._deletionWarnings; }
            set { this._deletionWarnings = value; }
        }

        // Check to see if DeletionWarnings property is set
        internal bool IsSetDeletionWarnings()
        {
            return this._deletionWarnings != null && (this._deletionWarnings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  An epoch seconds timestamp (UTC) of when the deletion task was completed or failed.
        /// 
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedConfigurations. 
        /// <para>
        ///  A list of configuration IDs that failed to delete during the deletion task, each
        /// paired with an error message. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedConfiguration> FailedConfigurations
        {
            get { return this._failedConfigurations; }
            set { this._failedConfigurations = value; }
        }

        // Check to see if FailedConfigurations property is set
        internal bool IsSetFailedConfigurations()
        {
            return this._failedConfigurations != null && (this._failedConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestedConfigurations. 
        /// <para>
        ///  The list of configuration IDs that were originally requested to be deleted by the
        /// deletion task. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RequestedConfigurations
        {
            get { return this._requestedConfigurations; }
            set { this._requestedConfigurations = value; }
        }

        // Check to see if RequestedConfigurations property is set
        internal bool IsSetRequestedConfigurations()
        {
            return this._requestedConfigurations != null && (this._requestedConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  An epoch seconds timestamp (UTC) of when the deletion task was started. 
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current execution status of the deletion task. Valid status are: INITIALIZING
        /// | VALIDATING | DELETING | COMPLETED | FAILED. 
        /// </para>
        /// </summary>
        public BatchDeleteConfigurationTaskStatus Status
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
        /// Gets and sets the property TaskId. 
        /// <para>
        ///  The deletion task's unique identifier. 
        /// </para>
        /// </summary>
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}