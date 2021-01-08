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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// This is the response object from the DescribeLDAPSSettings operation.
    /// </summary>
    public partial class DescribeLDAPSSettingsResponse : AmazonWebServiceResponse
    {
        private List<LDAPSSettingInfo> _ldapsSettingsInfo = new List<LDAPSSettingInfo>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LDAPSSettingsInfo. 
        /// <para>
        /// Information about LDAP security for the specified directory, including status of enablement,
        /// state last updated date time, and the reason for the state.
        /// </para>
        /// </summary>
        public List<LDAPSSettingInfo> LDAPSSettingsInfo
        {
            get { return this._ldapsSettingsInfo; }
            set { this._ldapsSettingsInfo = value; }
        }

        // Check to see if LDAPSSettingsInfo property is set
        internal bool IsSetLDAPSSettingsInfo()
        {
            return this._ldapsSettingsInfo != null && this._ldapsSettingsInfo.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token used to retrieve the LDAPS settings if the number of setting types
        /// exceeds page limit and there is another page.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}