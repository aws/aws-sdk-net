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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// This is the response object from the ListMobileDeviceAccessRules operation.
    /// </summary>
    public partial class ListMobileDeviceAccessRulesResponse : AmazonWebServiceResponse
    {
        private List<MobileDeviceAccessRule> _rules = new List<MobileDeviceAccessRule>();

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The list of mobile device access rules that exist under the specified WorkMail organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<MobileDeviceAccessRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

    }
}