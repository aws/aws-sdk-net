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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// The configuration setting for the log types to be enabled for export to CloudWatch
    /// Logs for a specific DB instance or DB cluster.
    /// </summary>
    public partial class CloudwatchLogsExportConfiguration
    {
        private List<string> _disableLogTypes = new List<string>();
        private List<string> _enableLogTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property DisableLogTypes. 
        /// <para>
        /// The list of log types to disable.
        /// </para>
        /// </summary>
        public List<string> DisableLogTypes
        {
            get { return this._disableLogTypes; }
            set { this._disableLogTypes = value; }
        }

        // Check to see if DisableLogTypes property is set
        internal bool IsSetDisableLogTypes()
        {
            return this._disableLogTypes != null && this._disableLogTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableLogTypes. 
        /// <para>
        /// The list of log types to enable.
        /// </para>
        /// </summary>
        public List<string> EnableLogTypes
        {
            get { return this._enableLogTypes; }
            set { this._enableLogTypes = value; }
        }

        // Check to see if EnableLogTypes property is set
        internal bool IsSetEnableLogTypes()
        {
            return this._enableLogTypes != null && this._enableLogTypes.Count > 0; 
        }

    }
}