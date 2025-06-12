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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// A list of the log types whose configuration is still pending. In other words, these
    /// log types are in the process of being activated or deactivated.
    /// </summary>
    public partial class PendingCloudwatchLogsExports
    {
        private List<string> _logTypesToDisable = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _logTypesToEnable = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property LogTypesToDisable. 
        /// <para>
        /// Log types that are in the process of being enabled. After they are enabled, these
        /// log types are exported to CloudWatch Logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogTypesToDisable
        {
            get { return this._logTypesToDisable; }
            set { this._logTypesToDisable = value; }
        }

        // Check to see if LogTypesToDisable property is set
        internal bool IsSetLogTypesToDisable()
        {
            return this._logTypesToDisable != null && (this._logTypesToDisable.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogTypesToEnable. 
        /// <para>
        /// Log types that are in the process of being deactivated. After they are deactivated,
        /// these log types aren't exported to CloudWatch Logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogTypesToEnable
        {
            get { return this._logTypesToEnable; }
            set { this._logTypesToEnable = value; }
        }

        // Check to see if LogTypesToEnable property is set
        internal bool IsSetLogTypesToEnable()
        {
            return this._logTypesToEnable != null && (this._logTypesToEnable.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}