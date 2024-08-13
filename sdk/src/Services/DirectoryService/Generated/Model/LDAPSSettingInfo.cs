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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains general information about the LDAPS settings.
    /// </summary>
    public partial class LDAPSSettingInfo
    {
        private DateTime? _lastUpdatedDateTime;
        private LDAPSStatus _ldapsStatus;
        private string _ldapsStatusReason;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time when the LDAPS settings were last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LDAPSStatus. 
        /// <para>
        /// The state of the LDAPS settings.
        /// </para>
        /// </summary>
        public LDAPSStatus LDAPSStatus
        {
            get { return this._ldapsStatus; }
            set { this._ldapsStatus = value; }
        }

        // Check to see if LDAPSStatus property is set
        internal bool IsSetLDAPSStatus()
        {
            return this._ldapsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LDAPSStatusReason. 
        /// <para>
        /// Describes a state change for LDAPS.
        /// </para>
        /// </summary>
        public string LDAPSStatusReason
        {
            get { return this._ldapsStatusReason; }
            set { this._ldapsStatusReason = value; }
        }

        // Check to see if LDAPSStatusReason property is set
        internal bool IsSetLDAPSStatusReason()
        {
            return this._ldapsStatusReason != null;
        }

    }
}