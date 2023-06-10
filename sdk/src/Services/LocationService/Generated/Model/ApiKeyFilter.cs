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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Options for filtering API keys.
    /// </summary>
    public partial class ApiKeyFilter
    {
        private Status _keyStatus;

        /// <summary>
        /// Gets and sets the property KeyStatus. 
        /// <para>
        /// Filter on <code>Active</code> or <code>Expired</code> API keys.
        /// </para>
        /// </summary>
        public Status KeyStatus
        {
            get { return this._keyStatus; }
            set { this._keyStatus = value; }
        }

        // Check to see if KeyStatus property is set
        internal bool IsSetKeyStatus()
        {
            return this._keyStatus != null;
        }

    }
}