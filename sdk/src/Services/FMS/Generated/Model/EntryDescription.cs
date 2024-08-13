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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Describes a single rule in a network ACL.
    /// </summary>
    public partial class EntryDescription
    {
        private NetworkAclEntry _entryDetail;
        private int? _entryRuleNumber;
        private EntryType _entryType;

        /// <summary>
        /// Gets and sets the property EntryDetail. 
        /// <para>
        /// Describes a rule in a network ACL.
        /// </para>
        ///  
        /// <para>
        /// Each network ACL has a set of numbered ingress rules and a separate set of numbered
        /// egress rules. When determining whether a packet should be allowed in or out of a subnet
        /// associated with the network ACL, Amazon Web Services processes the entries in the
        /// network ACL according to the rule numbers, in ascending order. 
        /// </para>
        ///  
        /// <para>
        /// When you manage an individual network ACL, you explicitly specify the rule numbers.
        /// When you specify the network ACL rules in a Firewall Manager policy, you provide the
        /// rules to run first, in the order that you want them to run, and the rules to run last,
        /// in the order that you want them to run. Firewall Manager assigns the rule numbers
        /// for you when you save the network ACL policy specification.
        /// </para>
        /// </summary>
        public NetworkAclEntry EntryDetail
        {
            get { return this._entryDetail; }
            set { this._entryDetail = value; }
        }

        // Check to see if EntryDetail property is set
        internal bool IsSetEntryDetail()
        {
            return this._entryDetail != null;
        }

        /// <summary>
        /// Gets and sets the property EntryRuleNumber. 
        /// <para>
        /// The rule number for the entry. ACL entries are processed in ascending order by rule
        /// number. In a Firewall Manager network ACL policy, Firewall Manager assigns rule numbers.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? EntryRuleNumber
        {
            get { return this._entryRuleNumber; }
            set { this._entryRuleNumber = value; }
        }

        // Check to see if EntryRuleNumber property is set
        internal bool IsSetEntryRuleNumber()
        {
            return this._entryRuleNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EntryType. 
        /// <para>
        /// Specifies whether the entry is managed by Firewall Manager or by a user, and, for
        /// Firewall Manager-managed entries, specifies whether the entry is among those that
        /// run first in the network ACL or those that run last. 
        /// </para>
        /// </summary>
        public EntryType EntryType
        {
            get { return this._entryType; }
            set { this._entryType = value; }
        }

        // Check to see if EntryType property is set
        internal bool IsSetEntryType()
        {
            return this._entryType != null;
        }

    }
}