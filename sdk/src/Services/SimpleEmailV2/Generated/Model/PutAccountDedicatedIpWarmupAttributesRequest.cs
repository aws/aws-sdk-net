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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutAccountDedicatedIpWarmupAttributes operation.
    /// Enable or disable the automatic warm-up feature for dedicated IP addresses.
    /// </summary>
    public partial class PutAccountDedicatedIpWarmupAttributesRequest : AmazonSimpleEmailServiceV2Request
    {
        private bool? _autoWarmupEnabled;

        /// <summary>
        /// Gets and sets the property AutoWarmupEnabled. 
        /// <para>
        /// Enables or disables the automatic warm-up feature for dedicated IP addresses that
        /// are associated with your Amazon SES account in the current AWS Region. Set to <code>true</code>
        /// to enable the automatic warm-up feature, or set to <code>false</code> to disable it.
        /// </para>
        /// </summary>
        public bool AutoWarmupEnabled
        {
            get { return this._autoWarmupEnabled.GetValueOrDefault(); }
            set { this._autoWarmupEnabled = value; }
        }

        // Check to see if AutoWarmupEnabled property is set
        internal bool IsSetAutoWarmupEnabled()
        {
            return this._autoWarmupEnabled.HasValue; 
        }

    }
}