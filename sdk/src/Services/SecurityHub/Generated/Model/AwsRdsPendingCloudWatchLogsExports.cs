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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Identifies the log types to enable and disable.
    /// </summary>
    public partial class AwsRdsPendingCloudWatchLogsExports
    {
        private List<string> _logTypesToDisable = new List<string>();
        private List<string> _logTypesToEnable = new List<string>();

        /// <summary>
        /// Gets and sets the property LogTypesToDisable. 
        /// <para>
        /// A list of log types that are being disabled.
        /// </para>
        /// </summary>
        public List<string> LogTypesToDisable
        {
            get { return this._logTypesToDisable; }
            set { this._logTypesToDisable = value; }
        }

        // Check to see if LogTypesToDisable property is set
        internal bool IsSetLogTypesToDisable()
        {
            return this._logTypesToDisable != null && this._logTypesToDisable.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LogTypesToEnable. 
        /// <para>
        /// A list of log types that are being enabled.
        /// </para>
        /// </summary>
        public List<string> LogTypesToEnable
        {
            get { return this._logTypesToEnable; }
            set { this._logTypesToEnable = value; }
        }

        // Check to see if LogTypesToEnable property is set
        internal bool IsSetLogTypesToEnable()
        {
            return this._logTypesToEnable != null && this._logTypesToEnable.Count > 0; 
        }

    }
}