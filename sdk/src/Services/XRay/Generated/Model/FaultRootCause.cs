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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// The root cause information for a trace summary fault.
    /// </summary>
    public partial class FaultRootCause
    {
        private bool? _clientImpacting;
        private List<FaultRootCauseService> _services = new List<FaultRootCauseService>();

        /// <summary>
        /// Gets and sets the property ClientImpacting. 
        /// <para>
        /// A flag that denotes that the root cause impacts the trace client.
        /// </para>
        /// </summary>
        public bool ClientImpacting
        {
            get { return this._clientImpacting.GetValueOrDefault(); }
            set { this._clientImpacting = value; }
        }

        // Check to see if ClientImpacting property is set
        internal bool IsSetClientImpacting()
        {
            return this._clientImpacting.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// A list of corresponding services. A service identifies a segment and it contains a
        /// name, account ID, type, and inferred flag.
        /// </para>
        /// </summary>
        public List<FaultRootCauseService> Services
        {
            get { return this._services; }
            set { this._services = value; }
        }

        // Check to see if Services property is set
        internal bool IsSetServices()
        {
            return this._services != null && this._services.Count > 0; 
        }

    }
}