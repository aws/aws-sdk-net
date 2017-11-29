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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The type of the configuration to override the risk decision.
    /// </summary>
    public partial class RiskExceptionConfigurationType
    {
        private List<string> _blockedIPRangeList = new List<string>();
        private List<string> _skippedIPRangeList = new List<string>();

        /// <summary>
        /// Gets and sets the property BlockedIPRangeList. 
        /// <para>
        /// Overrides the risk decision to always block the pre-authentication requests. The IP
        /// range is in CIDR notation: a compact representation of an IP address and its associated
        /// routing prefix.
        /// </para>
        /// </summary>
        public List<string> BlockedIPRangeList
        {
            get { return this._blockedIPRangeList; }
            set { this._blockedIPRangeList = value; }
        }

        // Check to see if BlockedIPRangeList property is set
        internal bool IsSetBlockedIPRangeList()
        {
            return this._blockedIPRangeList != null && this._blockedIPRangeList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SkippedIPRangeList. 
        /// <para>
        /// Risk detection is not performed on the IP addresses in the range list. The IP range
        /// is in CIDR notation.
        /// </para>
        /// </summary>
        public List<string> SkippedIPRangeList
        {
            get { return this._skippedIPRangeList; }
            set { this._skippedIPRangeList = value; }
        }

        // Check to see if SkippedIPRangeList property is set
        internal bool IsSetSkippedIPRangeList()
        {
            return this._skippedIPRangeList != null && this._skippedIPRangeList.Count > 0; 
        }

    }
}