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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DeleteLocalStoreAfterUpload. 
        /// <para>
        /// Configuration to enable or disable deleting of runtime logs in the device once uploaded
        /// to the cloud.
        /// </para>
        /// </summary>
        public bool? DeleteLocalStoreAfterUpload { get; set; }

        /// <summary>
        /// Checks to see if the DeleteLocalStoreAfterUpload property is set.
        /// </summary>
        internal bool IsSetDeleteLocalStoreAfterUpload() => this.DeleteLocalStoreAfterUpload.HasValue;

        /// <summary>
        /// Gets and sets the property LocalStoreFileRotationMaxBytes. 
        /// <para>
        /// Configuration to set the maximum bytes of runtime logs that can be stored on the device
        /// before the oldest logs are deleted or overwritten.
        /// </para>
        /// </summary>
        public int? LocalStoreFileRotationMaxBytes { get; set; }

        /// <summary>
        /// Checks to see if the LocalStoreFileRotationMaxBytes property is set.
        /// </summary>
        internal bool IsSetLocalStoreFileRotationMaxBytes() => this.LocalStoreFileRotationMaxBytes.HasValue;

        /// <summary>
        /// Gets and sets the property LocalStoreFileRotationMaxFiles. 
        /// <para>
        /// Configuration to set the maximum number of runtime log files that can be stored on
        /// the device before the oldest files are deleted or overwritten.
        /// </para>
        /// </summary>
        public int? LocalStoreFileRotationMaxFiles { get; set; }

        /// <summary>
        /// Checks to see if the LocalStoreFileRotationMaxFiles property is set.
        /// </summary>
        internal bool IsSetLocalStoreFileRotationMaxFiles() => this.LocalStoreFileRotationMaxFiles.HasValue;

        /// <summary>
        /// Gets and sets the property LocalStoreLocation. 
        /// <para>
        /// Configuration of where to store runtime logs in the device.
        /// </para>
        /// </summary>
        public string LocalStoreLocation { get; set; }

        /// <summary>
        /// Checks to see if the LocalStoreLocation property is set.
        /// </summary>
        internal bool IsSetLocalStoreLocation() => this.LocalStoreLocation != null;

        /// <summary>
        /// Gets and sets the property LogFlushLevel. 
        /// <para>
        /// The different log levels available for configuration.
        /// </para>
        /// </summary>
        public LogLevel LogFlushLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogFlushLevel property is set.
        /// </summary>
        internal bool IsSetLogFlushLevel() => this.LogFlushLevel != null;

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// The different log levels available for configuration.
        /// </para>
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogLevel property is set.
        /// </summary>
        internal bool IsSetLogLevel() => this.LogLevel != null;

        /// <summary>
        /// Gets and sets the property UploadLog. 
        /// <para>
        /// Configuration to enable or disable uploading of runtime logs to the cloud.
        /// </para>
        /// </summary>
        public bool? UploadLog { get; set; }

        /// <summary>
        /// Checks to see if the UploadLog property is set.
        /// </summary>
        internal bool IsSetUploadLog() => this.UploadLog.HasValue;

        /// <summary>
        /// Gets and sets the property UploadPeriodMinutes. 
        /// <para>
        /// Configuration to set the time interval in minutes between each batch of runtime logs
        /// that the device uploads to the cloud.
        /// </para>
        /// </summary>
        public int? UploadPeriodMinutes { get; set; }

        /// <summary>
        /// Checks to see if the UploadPeriodMinutes property is set.
        /// </summary>
        internal bool IsSetUploadPeriodMinutes() => this.UploadPeriodMinutes.HasValue;
    }
}
