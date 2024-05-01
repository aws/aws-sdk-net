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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
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
namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// A structure that contains the information about whether the app monitor stores copies
    /// of the data that RUM collects in CloudWatch Logs. If it does, this structure also
    /// contains the name of the log group.
    /// </summary>
    public partial class CwLog
    {
        private bool? _cwLogEnabled;
        private string _cwLogGroup;

        /// <summary>
        /// Gets and sets the property CwLogEnabled. 
        /// <para>
        /// Indicated whether the app monitor stores copies of the data that RUM collects in CloudWatch
        /// Logs.
        /// </para>
        /// </summary>
        public bool? CwLogEnabled
        {
            get { return this._cwLogEnabled; }
            set { this._cwLogEnabled = value; }
        }

        // Check to see if CwLogEnabled property is set
        internal bool IsSetCwLogEnabled()
        {
            return this._cwLogEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CwLogGroup. 
        /// <para>
        /// The name of the log group where the copies are stored.
        /// </para>
        /// </summary>
        public string CwLogGroup
        {
            get { return this._cwLogGroup; }
            set { this._cwLogGroup = value; }
        }

        // Check to see if CwLogGroup property is set
        internal bool IsSetCwLogGroup()
        {
            return this._cwLogGroup != null;
        }

    }
}