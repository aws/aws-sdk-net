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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Limits settings on protections for your subscription.
    /// </summary>
    public partial class ProtectionLimits
    {
        private List<Limit> _protectedResourceTypeLimits = new List<Limit>();

        /// <summary>
        /// Gets and sets the property ProtectedResourceTypeLimits. 
        /// <para>
        /// The maximum number of resource types that you can specify in a protection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Limit> ProtectedResourceTypeLimits
        {
            get { return this._protectedResourceTypeLimits; }
            set { this._protectedResourceTypeLimits = value; }
        }

        // Check to see if ProtectedResourceTypeLimits property is set
        internal bool IsSetProtectedResourceTypeLimits()
        {
            return this._protectedResourceTypeLimits != null && this._protectedResourceTypeLimits.Count > 0; 
        }

    }
}