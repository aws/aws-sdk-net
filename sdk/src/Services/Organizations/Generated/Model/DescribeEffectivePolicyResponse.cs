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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// This is the response object from the DescribeEffectivePolicy operation.
    /// </summary>
    public partial class DescribeEffectivePolicyResponse : AmazonWebServiceResponse
    {
        private EffectivePolicy _effectivePolicy;

        /// <summary>
        /// Gets and sets the property EffectivePolicy. 
        /// <para>
        /// The contents of the effective policy.
        /// </para>
        /// </summary>
        public EffectivePolicy EffectivePolicy
        {
            get { return this._effectivePolicy; }
            set { this._effectivePolicy = value; }
        }

        // Check to see if EffectivePolicy property is set
        internal bool IsSetEffectivePolicy()
        {
            return this._effectivePolicy != null;
        }

    }
}