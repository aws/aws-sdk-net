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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Provides a description of the application, including the application Amazon Resource
    /// Name (ARN), status, latest version, and input and output configuration.
    /// </summary>
    public partial class ApplicationDetail
    {
        private string _applicationARN;
        private string _applicationCode;
        private string _applicationDescription;
        private string _applicationName;
        private ApplicationStatus _applicationStatus;
        private long? _applicationVersionId;
        private List<CloudWatchLoggingOptionDescription> _cloudWatchLoggingOptionDescriptions = new List<CloudWatchLoggingOptionDescription>();
        private DateTime? _createTimestamp;
        private List<InputDescription> _inputDescriptions = new List<InputDescription>();
        private DateTime? _lastUpdateTimestamp;
        private List<OutputDescription> _outputDescriptions = new List<OutputDescription>();
        private List<ReferenceDataSourceDescription> _referenceDataSourceDescriptions = new List<ReferenceDataSourceDescription>();

        /// <summary>
        /// Gets and sets the property ApplicationARN. 
        /// <para>
        /// ARN of the application.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ApplicationCode. 
        /// <para>
        /// Returns the application code that you provided to perform data analysis on any of
        /// the in-application streams in your application.
        /// </para>
        /// </summary>
        public string ApplicationCode
        {
            get { return this._applicationCode; }
            set { this._applicationCode = value; }
        }

        // Check to see if ApplicationCode property is set
        internal bool IsSetApplicationCode()
        {
            return this._applicationCode != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationDescription. 
        /// <para>
        /// Description of the application.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of the application.
        /// </para>
        /// </summary>
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
        /// Status of the application.
        /// </para>
        /// </summary>
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
        /// Provides the current application version.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CloudWatchLoggingOptionDescriptions. 
        /// <para>
        /// Describes the CloudWatch log streams configured to receive application messages. For
        /// more information about using CloudWatch log streams with Amazon Kinesis Analytics
        /// applications, see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/cloudwatch-monitor-configuration.html">Monitoring
        /// Configuration Errors</a>. 
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
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// Timestamp when the application version was created.
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
        /// Gets and sets the property InputDescriptions. 
        /// <para>
        /// Describes the application input configuration. For more information, see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
        /// Application Input</a>. 
        /// </para>
        /// </summary>
        public List<InputDescription> InputDescriptions
        {
            get { return this._inputDescriptions; }
            set { this._inputDescriptions = value; }
        }

        // Check to see if InputDescriptions property is set
        internal bool IsSetInputDescriptions()
        {
            return this._inputDescriptions != null && this._inputDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// Timestamp when the application was last updated.
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
        /// Gets and sets the property OutputDescriptions. 
        /// <para>
        /// Describes the application output configuration. For more information, see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-output.html">Configuring
        /// Application Output</a>. 
        /// </para>
        /// </summary>
        public List<OutputDescription> OutputDescriptions
        {
            get { return this._outputDescriptions; }
            set { this._outputDescriptions = value; }
        }

        // Check to see if OutputDescriptions property is set
        internal bool IsSetOutputDescriptions()
        {
            return this._outputDescriptions != null && this._outputDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReferenceDataSourceDescriptions. 
        /// <para>
        /// Describes reference data sources configured for the application. For more information,
        /// see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
        /// Application Input</a>. 
        /// </para>
        /// </summary>
        public List<ReferenceDataSourceDescription> ReferenceDataSourceDescriptions
        {
            get { return this._referenceDataSourceDescriptions; }
            set { this._referenceDataSourceDescriptions = value; }
        }

        // Check to see if ReferenceDataSourceDescriptions property is set
        internal bool IsSetReferenceDataSourceDescriptions()
        {
            return this._referenceDataSourceDescriptions != null && this._referenceDataSourceDescriptions.Count > 0; 
        }

    }
}