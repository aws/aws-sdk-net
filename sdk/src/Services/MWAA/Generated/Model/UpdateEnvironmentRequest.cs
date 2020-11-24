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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnvironment operation.
    /// Update an MWAA environment.
    /// </summary>
    public partial class UpdateEnvironmentRequest : AmazonMWAARequest
    {
        private Dictionary<string, string> _airflowConfigurationOptions = new Dictionary<string, string>();
        private string _airflowVersion;
        private string _dagS3Path;
        private string _environmentClass;
        private string _executionRoleArn;
        private LoggingConfigurationInput _loggingConfiguration;
        private int? _maxWorkers;
        private string _name;
        private UpdateNetworkConfigurationInput _networkConfiguration;
        private string _pluginsS3ObjectVersion;
        private string _pluginsS3Path;
        private string _requirementsS3ObjectVersion;
        private string _requirementsS3Path;
        private string _sourceBucketArn;
        private WebserverAccessMode _webserverAccessMode;
        private string _weeklyMaintenanceWindowStart;

        /// <summary>
        /// Gets and sets the property AirflowConfigurationOptions. 
        /// <para>
        /// The Airflow Configuration Options to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AirflowConfigurationOptions
        {
            get { return this._airflowConfigurationOptions; }
            set { this._airflowConfigurationOptions = value; }
        }

        // Check to see if AirflowConfigurationOptions property is set
        internal bool IsSetAirflowConfigurationOptions()
        {
            return this._airflowConfigurationOptions != null && this._airflowConfigurationOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AirflowVersion. 
        /// <para>
        /// The Airflow Version to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string AirflowVersion
        {
            get { return this._airflowVersion; }
            set { this._airflowVersion = value; }
        }

        // Check to see if AirflowVersion property is set
        internal bool IsSetAirflowVersion()
        {
            return this._airflowVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DagS3Path. 
        /// <para>
        /// The Dags folder S3 Path to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DagS3Path
        {
            get { return this._dagS3Path; }
            set { this._dagS3Path = value; }
        }

        // Check to see if DagS3Path property is set
        internal bool IsSetDagS3Path()
        {
            return this._dagS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentClass. 
        /// <para>
        /// The Environment Class to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string EnvironmentClass
        {
            get { return this._environmentClass; }
            set { this._environmentClass = value; }
        }

        // Check to see if EnvironmentClass property is set
        internal bool IsSetEnvironmentClass()
        {
            return this._environmentClass != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Executio Role ARN to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The Logging Configuration to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        public LoggingConfigurationInput LoggingConfiguration
        {
            get { return this._loggingConfiguration; }
            set { this._loggingConfiguration = value; }
        }

        // Check to see if LoggingConfiguration property is set
        internal bool IsSetLoggingConfiguration()
        {
            return this._loggingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MaxWorkers. 
        /// <para>
        /// The Maximum Workers to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxWorkers
        {
            get { return this._maxWorkers.GetValueOrDefault(); }
            set { this._maxWorkers = value; }
        }

        // Check to see if MaxWorkers property is set
        internal bool IsSetMaxWorkers()
        {
            return this._maxWorkers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of your Amazon MWAA environment that you wish to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The Network Configuration to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        public UpdateNetworkConfigurationInput NetworkConfiguration
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
        /// Gets and sets the property PluginsS3ObjectVersion. 
        /// <para>
        /// The Plugins.zip S3 Object Version to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PluginsS3ObjectVersion
        {
            get { return this._pluginsS3ObjectVersion; }
            set { this._pluginsS3ObjectVersion = value; }
        }

        // Check to see if PluginsS3ObjectVersion property is set
        internal bool IsSetPluginsS3ObjectVersion()
        {
            return this._pluginsS3ObjectVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PluginsS3Path. 
        /// <para>
        /// The Plugins.zip S3 Path to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PluginsS3Path
        {
            get { return this._pluginsS3Path; }
            set { this._pluginsS3Path = value; }
        }

        // Check to see if PluginsS3Path property is set
        internal bool IsSetPluginsS3Path()
        {
            return this._pluginsS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property RequirementsS3ObjectVersion. 
        /// <para>
        /// The Requirements.txt S3 ObjectV ersion to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RequirementsS3ObjectVersion
        {
            get { return this._requirementsS3ObjectVersion; }
            set { this._requirementsS3ObjectVersion = value; }
        }

        // Check to see if RequirementsS3ObjectVersion property is set
        internal bool IsSetRequirementsS3ObjectVersion()
        {
            return this._requirementsS3ObjectVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RequirementsS3Path. 
        /// <para>
        /// The Requirements.txt S3 Path to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RequirementsS3Path
        {
            get { return this._requirementsS3Path; }
            set { this._requirementsS3Path = value; }
        }

        // Check to see if RequirementsS3Path property is set
        internal bool IsSetRequirementsS3Path()
        {
            return this._requirementsS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property SourceBucketArn. 
        /// <para>
        /// The S3 Source Bucket ARN to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string SourceBucketArn
        {
            get { return this._sourceBucketArn; }
            set { this._sourceBucketArn = value; }
        }

        // Check to see if SourceBucketArn property is set
        internal bool IsSetSourceBucketArn()
        {
            return this._sourceBucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property WebserverAccessMode. 
        /// <para>
        /// The Webserver Access Mode to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        public WebserverAccessMode WebserverAccessMode
        {
            get { return this._webserverAccessMode; }
            set { this._webserverAccessMode = value; }
        }

        // Check to see if WebserverAccessMode property is set
        internal bool IsSetWebserverAccessMode()
        {
            return this._webserverAccessMode != null;
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceWindowStart. 
        /// <para>
        /// The Weekly Maintenance Window Start to update of your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=9)]
        public string WeeklyMaintenanceWindowStart
        {
            get { return this._weeklyMaintenanceWindowStart; }
            set { this._weeklyMaintenanceWindowStart = value; }
        }

        // Check to see if WeeklyMaintenanceWindowStart property is set
        internal bool IsSetWeeklyMaintenanceWindowStart()
        {
            return this._weeklyMaintenanceWindowStart != null;
        }

    }
}