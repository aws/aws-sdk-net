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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
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
namespace Amazon.DirectoryServiceData.Model
{
    /// <summary>
    /// A structure containing a subset of fields of a group object from a directory.
    /// </summary>
    public partial class GroupSummary
    {
        private GroupScope _groupScope;
        private GroupType _groupType;
        private string _samAccountName;
        private string _sid;

        /// <summary>
        /// Gets and sets the property GroupScope. 
        /// <para>
        /// The scope of the AD group. For details, see <a href="https://learn.microsoft.com/en-us/windows-server/identity/ad-ds/manage/understand-security-groups#group-scope">Active
        /// Directory security groups</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GroupScope GroupScope
        {
            get { return this._groupScope; }
            set { this._groupScope = value; }
        }

        // Check to see if GroupScope property is set
        internal bool IsSetGroupScope()
        {
            return this._groupScope != null;
        }

        /// <summary>
        /// Gets and sets the property GroupType. 
        /// <para>
        /// The AD group type. For details, see <a href="https://learn.microsoft.com/en-us/windows-server/identity/ad-ds/manage/understand-security-groups#how-active-directory-security-groups-work">Active
        /// Directory security group type</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GroupType GroupType
        {
            get { return this._groupType; }
            set { this._groupType = value; }
        }

        // Check to see if GroupType property is set
        internal bool IsSetGroupType()
        {
            return this._groupType != null;
        }

        /// <summary>
        /// Gets and sets the property SAMAccountName. 
        /// <para>
        /// The name of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string SAMAccountName
        {
            get { return this._samAccountName; }
            set { this._samAccountName = value; }
        }

        // Check to see if SAMAccountName property is set
        internal bool IsSetSAMAccountName()
        {
            return this._samAccountName != null;
        }

        /// <summary>
        /// Gets and sets the property SID. 
        /// <para>
        /// The unique security identifier (SID) of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SID
        {
            get { return this._sid; }
            set { this._sid = value; }
        }

        // Check to see if SID property is set
        internal bool IsSetSID()
        {
            return this._sid != null;
        }

    }
}