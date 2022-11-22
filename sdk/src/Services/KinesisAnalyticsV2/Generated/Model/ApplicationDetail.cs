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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes the application, including the application Amazon Resource Name (ARN), status,
    /// latest version, and input and output configurations.
    /// </summary>
    public partial class ApplicationDetail
    {
        private string _applicationARN;
        private ApplicationConfigurationDescription _applicationConfigurationDescription;
        private string _applicationDescription;
        private ApplicationMaintenanceConfigurationDescription _applicationMaintenanceConfigurationDescription;
        private ApplicationMode _applicationMode;
        private string _applicationName;
        private ApplicationStatus _applicationStatus;
        private long? _applicationVersionId;
        private long? _applicationVersionRolledBackFrom;
        private long? _applicationVersionRolledBackTo;
        private long? _applicationVersionUpdatedFrom;
        private List<CloudWatchLoggingOptionDescription> _cloudWatchLoggingOptionDescriptions = new List<CloudWatchLoggingOptionDescription>();
        private string _conditionalToken;
        private DateTime? _createTimestamp;
        private DateTime? _lastUpdateTimestamp;
        private RuntimeEnvironment _runtimeEnvironment;
        private string _serviceExecutionRole;

        /// <summary>
        /// Gets and sets the property ApplicationARN. 
        /// <para>
        /// The ARN of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ApplicationARN
        {
            get { return this._applicationARN; }
            set { this._applicationARN = value; }
        }

        // Check to see if ApplicationARN property is set
        internal bool IsSetApplicationARN()
        {
            return this._applicationARN != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationConfigurationDescription. 
        /// <para>
        /// Describes details about the application code and starting parameters for a Kinesis
        /// Data Analytics application.
        /// </para>
        /// </summary>
        public ApplicationConfigurationDescription ApplicationConfigurationDescription
        {
            get { return this._applicationConfigurationDescription; }
            set { this._applicationConfigurationDescription = value; }
        }

        // Check to see if ApplicationConfigurationDescription property is set
        internal bool IsSetApplicationConfigurationDescription()
        {
            return this._applicationConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationDescription. 
        /// <para>
        /// The description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ApplicationDescription
        {
            get { return this._applicationDescription; }
            set { this._applicationDescription = value; }
        }

        // Check to see if ApplicationDescription property is set
        internal bool IsSetApplicationDescription()
        {
            return this._applicationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationMaintenanceConfigurationDescription. 
        /// <para>
        /// The details of the maintenance configuration for the application.
        /// </para>
        /// </summary>
        public ApplicationMaintenanceConfigurationDescription ApplicationMaintenanceConfigurationDescription
        {
            get { return this._applicationMaintenanceConfigurationDescription; }
            set { this._applicationMaintenanceConfigurationDescription = value; }
        }

        // Check to see if ApplicationMaintenanceConfigurationDescription property is set
        internal bool IsSetApplicationMaintenanceConfigurationDescription()
        {
            return this._applicationMaintenanceConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationMode. 
        /// <para>
        /// To create a Kinesis Data Analytics Studio notebook, you must set the mode to <code>INTERACTIVE</code>.
        /// However, for a Kinesis Data Analytics for Apache Flink application, the mode is optional.
        /// </para>
        /// </summary>
        public ApplicationMode ApplicationMode
        {
            get { return this._applicationMode; }
            set { this._applicationMode = value; }
        }

        // Check to see if ApplicationMode property is set
        internal bool IsSetApplicationMode()
        {
            return this._applicationMode != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationStatus. 
        /// <para>
        /// The status of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationStatus ApplicationStatus
        {
            get { return this._applicationStatus; }
            set { this._applicationStatus = value; }
        }

        // Check to see if ApplicationStatus property is set
        internal bool IsSetApplicationStatus()
        {
            return this._applicationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationVersionId. 
        /// <para>
        /// Provides the current application version. Kinesis Data Analytics updates the <code>ApplicationVersionId</code>
        /// each time you update the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=999999999)]
        public long ApplicationVersionId
        {
            get { return this._applicationVersionId.GetValueOrDefault(); }
            set { this._applicationVersionId = value; }
        }

        // Check to see if ApplicationVersionId property is set
        internal bool IsSetApplicationVersionId()
        {
            return this._applicationVersionId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApplicationVersionRolledBackFrom. 
        /// <para>
        /// If you reverted the application using <a>RollbackApplication</a>, the application
        /// version when <code>RollbackApplication</code> was called.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=999999999)]
        public long ApplicationVersionRolledBackFrom
        {
            get { return this._applicationVersionRolledBackFrom.GetValueOrDefault(); }
            set { this._applicationVersionRolledBackFrom = value; }
        }

        // Check to see if ApplicationVersionRolledBackFrom property is set
        internal bool IsSetApplicationVersionRolledBackFrom()
        {
            return this._applicationVersionRolledBackFrom.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApplicationVersionRolledBackTo. 
        /// <para>
        /// The version to which you want to roll back the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=999999999)]
        public long ApplicationVersionRolledBackTo
        {
            get { return this._applicationVersionRolledBackTo.GetValueOrDefault(); }
            set { this._applicationVersionRolledBackTo = value; }
        }

        // Check to see if ApplicationVersionRolledBackTo property is set
        internal bool IsSetApplicationVersionRolledBackTo()
        {
            return this._applicationVersionRolledBackTo.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApplicationVersionUpdatedFrom. 
        /// <para>
        /// The previous application version before the latest application update. <a>RollbackApplication</a>
        /// reverts the application to this version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=999999999)]
        public long ApplicationVersionUpdatedFrom
        {
            get { return this._applicationVersionUpdatedFrom.GetValueOrDefault(); }
            set { this._applicationVersionUpdatedFrom = value; }
        }

        // Check to see if ApplicationVersionUpdatedFrom property is set
        internal bool IsSetApplicationVersionUpdatedFrom()
        {
            return this._applicationVersionUpdatedFrom.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptionDescriptions. 
        /// <para>
        /// Describes the application Amazon CloudWatch logging options.
        /// </para>
        /// </summary>
        public List<CloudWatchLoggingOptionDescription> CloudWatchLoggingOptionDescriptions
        {
            get { return this._cloudWatchLoggingOptionDescriptions; }
            set { this._cloudWatchLoggingOptionDescriptions = value; }
        }

        // Check to see if CloudWatchLoggingOptionDescriptions property is set
        internal bool IsSetCloudWatchLoggingOptionDescriptions()
        {
            return this._cloudWatchLoggingOptionDescriptions != null && this._cloudWatchLoggingOptionDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConditionalToken. 
        /// <para>
        /// A value you use to implement strong concurrency for application updates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ConditionalToken
        {
            get { return this._conditionalToken; }
            set { this._conditionalToken = value; }
        }

        // Check to see if ConditionalToken property is set
        internal bool IsSetConditionalToken()
        {
            return this._conditionalToken != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The current timestamp when the application was created.
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
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// The current timestamp when the application was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdateTimestamp
        {
            get { return this._lastUpdateTimestamp.GetValueOrDefault(); }
            set { this._lastUpdateTimestamp = value; }
        }

        // Check to see if LastUpdateTimestamp property is set
        internal bool IsSetLastUpdateTimestamp()
        {
            return this._lastUpdateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuntimeEnvironment. 
        /// <para>
        /// The runtime environment for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuntimeEnvironment RuntimeEnvironment
        {
            get { return this._runtimeEnvironment; }
            set { this._runtimeEnvironment = value; }
        }

        // Check to see if RuntimeEnvironment property is set
        internal bool IsSetRuntimeEnvironment()
        {
            return this._runtimeEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceExecutionRole. 
        /// <para>
        /// Specifies the IAM role that the application uses to access external resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ServiceExecutionRole
        {
            get { return this._serviceExecutionRole; }
            set { this._serviceExecutionRole = value; }
        }

        // Check to see if ServiceExecutionRole property is set
        internal bool IsSetServiceExecutionRole()
        {
            return this._serviceExecutionRole != null;
        }

    }
}