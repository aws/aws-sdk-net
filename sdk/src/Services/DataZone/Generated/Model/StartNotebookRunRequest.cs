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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the StartNotebookRun operation.
    /// Starts a notebook run in an Amazon DataZone domain. A notebook run represents the
    /// execution of a Amazon DataZone notebook within a project. You can configure compute,
    /// network, timeout, and environment settings for the run.
    /// </summary>
    public partial class StartNotebookRunRequest : AmazonDataZoneRequest
    {
        private string _clientToken;
        private ComputeConfig _computeConfiguration;
        private string _domainIdentifier;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private NetworkConfig _networkConfiguration;
        private string _notebookIdentifier;
        private string _owningProjectIdentifier;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _scheduleIdentifier;
        private TimeoutConfig _timeoutConfiguration;
        private TriggerSource _triggerSource;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request. This field
        /// is automatically populated if not provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        /// The compute configuration for the notebook run, including instance type and environment
        /// version.
        /// </para>
        /// </summary>
        public ComputeConfig ComputeConfiguration
        {
            get { return this._computeConfiguration; }
            set { this._computeConfiguration = value; }
        }

        // Check to see if ComputeConfiguration property is set
        internal bool IsSetComputeConfiguration()
        {
            return this._computeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which the notebook run is started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata for the notebook run, specified as key-value pairs. You can specify up
        /// to 50 entries, with keys up to 128 characters and values up to 1024 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the notebook run, including network access type and
        /// optional VPC settings.
        /// </para>
        /// </summary>
        public NetworkConfig NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookIdentifier. 
        /// <para>
        /// The identifier of the notebook to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NotebookIdentifier
        {
            get { return this._notebookIdentifier; }
            set { this._notebookIdentifier = value; }
        }

        // Check to see if NotebookIdentifier property is set
        internal bool IsSetNotebookIdentifier()
        {
            return this._notebookIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property OwningProjectIdentifier. 
        /// <para>
        /// The identifier of the project that owns the notebook run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OwningProjectIdentifier
        {
            get { return this._owningProjectIdentifier; }
            set { this._owningProjectIdentifier = value; }
        }

        // Check to see if OwningProjectIdentifier property is set
        internal bool IsSetOwningProjectIdentifier()
        {
            return this._owningProjectIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The sensitive parameters for the notebook run, specified as key-value pairs. You can
        /// specify up to 50 entries, with keys up to 128 characters and values up to 1024 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScheduleIdentifier. 
        /// <para>
        /// The identifier of the schedule associated with the notebook run.
        /// </para>
        /// </summary>
        public string ScheduleIdentifier
        {
            get { return this._scheduleIdentifier; }
            set { this._scheduleIdentifier = value; }
        }

        // Check to see if ScheduleIdentifier property is set
        internal bool IsSetScheduleIdentifier()
        {
            return this._scheduleIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutConfiguration. 
        /// <para>
        /// The timeout configuration for the notebook run. The default timeout is 720 minutes
        /// (12 hours) and the maximum is 1440 minutes (24 hours).
        /// </para>
        /// </summary>
        public TimeoutConfig TimeoutConfiguration
        {
            get { return this._timeoutConfiguration; }
            set { this._timeoutConfiguration = value; }
        }

        // Check to see if TimeoutConfiguration property is set
        internal bool IsSetTimeoutConfiguration()
        {
            return this._timeoutConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerSource. 
        /// <para>
        /// The source that triggered the notebook run.
        /// </para>
        /// </summary>
        public TriggerSource TriggerSource
        {
            get { return this._triggerSource; }
            set { this._triggerSource = value; }
        }

        // Check to see if TriggerSource property is set
        internal bool IsSetTriggerSource()
        {
            return this._triggerSource != null;
        }

    }
}