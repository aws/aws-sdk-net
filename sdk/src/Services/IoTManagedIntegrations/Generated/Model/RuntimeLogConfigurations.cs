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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// The different configurations for runtime logs.
    /// </summary>
    public partial class RuntimeLogConfigurations
    {
        private bool? _deleteLocalStoreAfterUpload;
        private int? _localStoreFileRotationMaxBytes;
        private int? _localStoreFileRotationMaxFiles;
        private string _localStoreLocation;
        private LogLevel _logFlushLevel;
        private LogLevel _logLevel;
        private bool? _uploadLog;
        private int? _uploadPeriodMinutes;

        /// <summary>
        /// Gets and sets the property DeleteLocalStoreAfterUpload. 
        /// <para>
        /// Configuration to enable or disable deleting of runtime logs in the device once uploaded
        /// to the cloud.
        /// </para>
        /// </summary>
        public bool? DeleteLocalStoreAfterUpload
        {
            get { return this._deleteLocalStoreAfterUpload; }
            set { this._deleteLocalStoreAfterUpload = value; }
        }

        // Check to see if DeleteLocalStoreAfterUpload property is set
        internal bool IsSetDeleteLocalStoreAfterUpload()
        {
            return this._deleteLocalStoreAfterUpload.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalStoreFileRotationMaxBytes. 
        /// <para>
        /// Configuration to set the maximum bytes of runtime logs that can be stored on the device
        /// before the oldest logs are deleted or overwritten.
        /// </para>
        /// </summary>
        public int? LocalStoreFileRotationMaxBytes
        {
            get { return this._localStoreFileRotationMaxBytes; }
            set { this._localStoreFileRotationMaxBytes = value; }
        }

        // Check to see if LocalStoreFileRotationMaxBytes property is set
        internal bool IsSetLocalStoreFileRotationMaxBytes()
        {
            return this._localStoreFileRotationMaxBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalStoreFileRotationMaxFiles. 
        /// <para>
        /// Configuration to set the maximum number of runtime log files that can be stored on
        /// the device before the oldest files are deleted or overwritten.
        /// </para>
        /// </summary>
        public int? LocalStoreFileRotationMaxFiles
        {
            get { return this._localStoreFileRotationMaxFiles; }
            set { this._localStoreFileRotationMaxFiles = value; }
        }

        // Check to see if LocalStoreFileRotationMaxFiles property is set
        internal bool IsSetLocalStoreFileRotationMaxFiles()
        {
            return this._localStoreFileRotationMaxFiles.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalStoreLocation. 
        /// <para>
        /// Configuration of where to store runtime logs in the device.
        /// </para>
        /// </summary>
        public string LocalStoreLocation
        {
            get { return this._localStoreLocation; }
            set { this._localStoreLocation = value; }
        }

        // Check to see if LocalStoreLocation property is set
        internal bool IsSetLocalStoreLocation()
        {
            return this._localStoreLocation != null;
        }

        /// <summary>
        /// Gets and sets the property LogFlushLevel. 
        /// <para>
        /// The different log levels available for configuration.
        /// </para>
        /// </summary>
        public LogLevel LogFlushLevel
        {
            get { return this._logFlushLevel; }
            set { this._logFlushLevel = value; }
        }

        // Check to see if LogFlushLevel property is set
        internal bool IsSetLogFlushLevel()
        {
            return this._logFlushLevel != null;
        }

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// The different log levels available for configuration.
        /// </para>
        /// </summary>
        public LogLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

        /// <summary>
        /// Gets and sets the property UploadLog. 
        /// <para>
        /// Configuration to enable or disable uploading of runtime logs to the cloud.
        /// </para>
        /// </summary>
        public bool? UploadLog
        {
            get { return this._uploadLog; }
            set { this._uploadLog = value; }
        }

        // Check to see if UploadLog property is set
        internal bool IsSetUploadLog()
        {
            return this._uploadLog.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadPeriodMinutes. 
        /// <para>
        /// Configuration to set the time interval in minutes between each batch of runtime logs
        /// that the device uploads to the cloud.
        /// </para>
        /// </summary>
        public int? UploadPeriodMinutes
        {
            get { return this._uploadPeriodMinutes; }
            set { this._uploadPeriodMinutes = value; }
        }

        // Check to see if UploadPeriodMinutes property is set
        internal bool IsSetUploadPeriodMinutes()
        {
            return this._uploadPeriodMinutes.HasValue; 
        }

    }
}