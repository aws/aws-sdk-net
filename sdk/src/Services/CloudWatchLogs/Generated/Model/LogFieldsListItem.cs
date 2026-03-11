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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Represents a log field with its name and data type information for a specific data
    /// source.
    /// </summary>
    public partial class LogFieldsListItem
    {
        private string _logFieldName;
        private LogFieldType _logFieldType;

        /// <summary>
        /// Gets and sets the property LogFieldName. 
        /// <para>
        /// The name of the log field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string LogFieldName
        {
            get { return this._logFieldName; }
            set { this._logFieldName = value; }
        }

        // Check to see if LogFieldName property is set
        internal bool IsSetLogFieldName()
        {
            return this._logFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property LogFieldType. 
        /// <para>
        /// The data type information for the log field.
        /// </para>
        /// </summary>
        public LogFieldType LogFieldType
        {
            get { return this._logFieldType; }
            set { this._logFieldType = value; }
        }

        // Check to see if LogFieldType property is set
        internal bool IsSetLogFieldType()
        {
            return this._logFieldType != null;
        }

    }
}