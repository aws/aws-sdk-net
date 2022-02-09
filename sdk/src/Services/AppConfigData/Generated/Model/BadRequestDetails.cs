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
 * Do not modify this file. This file is generated from the appconfigdata-2021-11-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfigData.Model
{
    /// <summary>
    /// Detailed information about the input that failed to satisfy the constraints specified
    /// by a call.
    /// </summary>
    public partial class BadRequestDetails
    {
        private Dictionary<string, InvalidParameterDetail> _invalidParameters = new Dictionary<string, InvalidParameterDetail>();

        /// <summary>
        /// Gets and sets the property InvalidParameters. 
        /// <para>
        /// One or more specified parameters are not valid for the call.
        /// </para>
        /// </summary>
        public Dictionary<string, InvalidParameterDetail> InvalidParameters
        {
            get { return this._invalidParameters; }
            set { this._invalidParameters = value; }
        }

        // Check to see if InvalidParameters property is set
        internal bool IsSetInvalidParameters()
        {
            return this._invalidParameters != null && this._invalidParameters.Count > 0; 
        }

    }
}