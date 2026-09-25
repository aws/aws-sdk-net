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

namespace Amazon.DirectoryServiceData.Model
{
    /// <summary>
    /// A group object that contains identifying information and attributes for a specified
    /// group.
    /// </summary>
    public partial class Group
    {
        /// <summary>
        /// Gets and sets the property DistinguishedName. 
        /// <para>
        /// The <a href="https://learn.microsoft.com/en-us/windows/win32/ad/object-names-and-identities#distinguished-name">distinguished
        /// name</a> of the object. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// Checks to see if the DistinguishedName property is set.
        /// </summary>
        internal bool IsSetDistinguishedName() => this.DistinguishedName != null;

        /// <summary>
        /// Gets and sets the property GroupScope. 
        /// <para>
        ///  The scope of the AD group. For details, see <a href="https://learn.microsoft.com/en-us/windows-server/identity/ad-ds/manage/understand-security-groups#group-scope">Active
        /// Directory security groups</a> 
        /// </para>
        /// </summary>
        public GroupScope GroupScope { get; set; }

        /// <summary>
        /// Checks to see if the GroupScope property is set.
        /// </summary>
        internal bool IsSetGroupScope() => this.GroupScope != null;

        /// <summary>
        /// Gets and sets the property GroupType. 
        /// <para>
        ///  The AD group type. For details, see <a href="https://learn.microsoft.com/en-us/windows-server/identity/ad-ds/manage/understand-security-groups#how-active-directory-security-groups-work">Active
        /// Directory security group type</a>. 
        /// </para>
        /// </summary>
        public GroupType GroupType { get; set; }

        /// <summary>
        /// Checks to see if the GroupType property is set.
        /// </summary>
        internal bool IsSetGroupType() => this.GroupType != null;

        /// <summary>
        /// Gets and sets the property OtherAttributes. 
        /// <para>
        ///  An expression of one or more attributes, data types, and the values of a group. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public Dictionary<string, AttributeValue> OtherAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;

        /// <summary>
        /// Checks to see if the OtherAttributes property is set.
        /// </summary>
        internal bool IsSetOtherAttributes() => this.OtherAttributes != null && (this.OtherAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SAMAccountName. 
        /// <para>
        ///  The name of the group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SAMAccountName { get; set; }

        /// <summary>
        /// Checks to see if the SAMAccountName property is set.
        /// </summary>
        internal bool IsSetSAMAccountName() => this.SAMAccountName != null;

        /// <summary>
        /// Gets and sets the property SID. 
        /// <para>
        ///  The unique security identifier (SID) of the group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SID { get; set; }

        /// <summary>
        /// Checks to see if the SID property is set.
        /// </summary>
        internal bool IsSetSID() => this.SID != null;
    }
}
