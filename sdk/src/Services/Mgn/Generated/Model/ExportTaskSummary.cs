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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Export task summary.
    /// </summary>
    public partial class ExportTaskSummary
    {
        private long? _applicationsCount;
        private long? _serversCount;
        private long? _wavesCount;

        /// <summary>
        /// Gets and sets the property ApplicationsCount. 
        /// <para>
        /// Export task summary applications count.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long ApplicationsCount
        {
            get { return this._applicationsCount.GetValueOrDefault(); }
            set { this._applicationsCount = value; }
        }

        // Check to see if ApplicationsCount property is set
        internal bool IsSetApplicationsCount()
        {
            return this._applicationsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServersCount. 
        /// <para>
        /// Export task summary servers count.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long ServersCount
        {
            get { return this._serversCount.GetValueOrDefault(); }
            set { this._serversCount = value; }
        }

        // Check to see if ServersCount property is set
        internal bool IsSetServersCount()
        {
            return this._serversCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WavesCount. 
        /// <para>
        /// Export task summary waves count.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long WavesCount
        {
            get { return this._wavesCount.GetValueOrDefault(); }
            set { this._wavesCount = value; }
        }

        // Check to see if WavesCount property is set
        internal bool IsSetWavesCount()
        {
            return this._wavesCount.HasValue; 
        }

    }
}