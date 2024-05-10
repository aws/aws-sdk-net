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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// The predicted high and low fault count. This is used to determine if a service has
    /// become anomalous and if an insight should be created.
    /// </summary>
    public partial class ForecastStatistics
    {
        private long? _faultCountHigh;
        private long? _faultCountLow;

        /// <summary>
        /// Gets and sets the property FaultCountHigh. 
        /// <para>
        /// The upper limit of fault counts for a service.
        /// </para>
        /// </summary>
        public long? FaultCountHigh
        {
            get { return this._faultCountHigh; }
            set { this._faultCountHigh = value; }
        }

        // Check to see if FaultCountHigh property is set
        internal bool IsSetFaultCountHigh()
        {
            return this._faultCountHigh.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FaultCountLow. 
        /// <para>
        /// The lower limit of fault counts for a service.
        /// </para>
        /// </summary>
        public long? FaultCountLow
        {
            get { return this._faultCountLow; }
            set { this._faultCountLow = value; }
        }

        // Check to see if FaultCountLow property is set
        internal bool IsSetFaultCountLow()
        {
            return this._faultCountLow.HasValue; 
        }

    }
}