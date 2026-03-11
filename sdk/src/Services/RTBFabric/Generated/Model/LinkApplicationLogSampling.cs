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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Describes a link application log sample.
    /// </summary>
    public partial class LinkApplicationLogSampling
    {
        private double? _errorLog;
        private double? _filterLog;

        /// <summary>
        /// Gets and sets the property ErrorLog. 
        /// <para>
        /// An error log entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public double? ErrorLog
        {
            get { return this._errorLog; }
            set { this._errorLog = value; }
        }

        // Check to see if ErrorLog property is set
        internal bool IsSetErrorLog()
        {
            return this._errorLog.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilterLog. 
        /// <para>
        /// A filter log entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public double? FilterLog
        {
            get { return this._filterLog; }
            set { this._filterLog = value; }
        }

        // Check to see if FilterLog property is set
        internal bool IsSetFilterLog()
        {
            return this._filterLog.HasValue; 
        }

    }
}