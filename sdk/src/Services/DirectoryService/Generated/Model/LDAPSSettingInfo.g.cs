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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property LDAPSStatus. 
        /// <para>
        /// The state of the LDAPS settings.
        /// </para>
        /// </summary>
        public LDAPSStatus LDAPSStatus { get; set; }

        /// <summary>
        /// Checks to see if the LDAPSStatus property is set.
        /// </summary>
        internal bool IsSetLDAPSStatus() => this.LDAPSStatus != null;

        /// <summary>
        /// Gets and sets the property LDAPSStatusReason. 
        /// <para>
        /// Describes a state change for LDAPS.
        /// </para>
        /// </summary>
        public string LDAPSStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the LDAPSStatusReason property is set.
        /// </summary>
        internal bool IsSetLDAPSStatusReason() => this.LDAPSStatusReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time when the LDAPS settings were last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;
    }
}
