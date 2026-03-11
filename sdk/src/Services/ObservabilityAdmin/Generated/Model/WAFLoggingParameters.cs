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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Configuration parameters for WAF logging, including redacted fields and logging filters.
    /// </summary>
    public partial class WAFLoggingParameters
    {
        private LoggingFilter _loggingFilter;
        private WAFLogType _logType;
        private List<FieldToMatch> _redactedFields = AWSConfigs.InitializeCollections ? new List<FieldToMatch>() : null;

        /// <summary>
        /// Gets and sets the property LoggingFilter. 
        /// <para>
        ///  A filter configuration that determines which WAF log records to include or exclude.
        /// 
        /// </para>
        /// </summary>
        public LoggingFilter LoggingFilter
        {
            get { return this._loggingFilter; }
            set { this._loggingFilter = value; }
        }

        // Check to see if LoggingFilter property is set
        internal bool IsSetLoggingFilter()
        {
            return this._loggingFilter != null;
        }

        /// <summary>
        /// Gets and sets the property LogType. 
        /// <para>
        ///  The type of WAF logs to collect (currently supports WAF_LOGS). 
        /// </para>
        /// </summary>
        public WAFLogType LogType
        {
            get { return this._logType; }
            set { this._logType = value; }
        }

        // Check to see if LogType property is set
        internal bool IsSetLogType()
        {
            return this._logType != null;
        }

        /// <summary>
        /// Gets and sets the property RedactedFields. 
        /// <para>
        ///  The fields to redact from WAF logs to protect sensitive information. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<FieldToMatch> RedactedFields
        {
            get { return this._redactedFields; }
            set { this._redactedFields = value; }
        }

        // Check to see if RedactedFields property is set
        internal bool IsSetRedactedFields()
        {
            return this._redactedFields != null && (this._redactedFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}