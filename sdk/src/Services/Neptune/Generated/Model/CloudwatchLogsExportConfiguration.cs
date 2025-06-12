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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// The configuration setting for the log types to be enabled for export to CloudWatch
    /// Logs for a specific DB instance or DB cluster.
    /// 
    ///  
    /// <para>
    /// The <c>EnableLogTypes</c> and <c>DisableLogTypes</c> arrays determine which logs will
    /// be exported (or not exported) to CloudWatch Logs.
    /// </para>
    ///  
    /// <para>
    /// Valid log types are: <c>audit</c> (to publish audit logs) and <c>slowquery</c> (to
    /// publish slow-query logs). See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/cloudwatch-logs.html">Publishing
    /// Neptune logs to Amazon CloudWatch logs</a>.
    /// </para>
    /// </summary>
    public partial class CloudwatchLogsExportConfiguration
    {
        private List<string> _disableLogTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _enableLogTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DisableLogTypes. 
        /// <para>
        /// The list of log types to disable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DisableLogTypes
        {
            get { return this._disableLogTypes; }
            set { this._disableLogTypes = value; }
        }

        // Check to see if DisableLogTypes property is set
        internal bool IsSetDisableLogTypes()
        {
            return this._disableLogTypes != null && (this._disableLogTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnableLogTypes. 
        /// <para>
        /// The list of log types to enable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnableLogTypes
        {
            get { return this._enableLogTypes; }
            set { this._enableLogTypes = value; }
        }

        // Check to see if EnableLogTypes property is set
        internal bool IsSetEnableLogTypes()
        {
            return this._enableLogTypes != null && (this._enableLogTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}