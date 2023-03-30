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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// The codes to use when checking for a successful response from a target for health
    /// checks.
    /// </summary>
    public partial class Matcher
    {
        private string _httpCode;

        /// <summary>
        /// Gets and sets the property HttpCode. 
        /// <para>
        /// The HTTP code to use when checking for a successful response from a target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
        public string HttpCode
        {
            get { return this._httpCode; }
            set { this._httpCode = value; }
        }

        // Check to see if HttpCode property is set
        internal bool IsSetHttpCode()
        {
            return this._httpCode != null;
        }

    }
}