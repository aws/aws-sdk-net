/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the GetEffectivePolicies operation.
    /// </summary>
    public partial class GetEffectivePoliciesResponse : AmazonWebServiceResponse
    {
        private List<EffectivePolicy> _effectivePolicies = new List<EffectivePolicy>();

        /// <summary>
        /// Gets and sets the property EffectivePolicies. 
        /// <para>
        /// The effective policies.
        /// </para>
        /// </summary>
        public List<EffectivePolicy> EffectivePolicies
        {
            get { return this._effectivePolicies; }
            set { this._effectivePolicies = value; }
        }

        // Check to see if EffectivePolicies property is set
        internal bool IsSetEffectivePolicies()
        {
            return this._effectivePolicies != null && this._effectivePolicies.Count > 0; 
        }

    }
}