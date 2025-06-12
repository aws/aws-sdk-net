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
    /// The configuration of the first and last rules for the network ACL policy, and the
    /// remediation settings for each.
    /// </summary>
    public partial class NetworkAclEntrySet
    {
        private List<NetworkAclEntry> _firstEntries = AWSConfigs.InitializeCollections ? new List<NetworkAclEntry>() : null;
        private bool? _forceRemediateForFirstEntries;
        private bool? _forceRemediateForLastEntries;
        private List<NetworkAclEntry> _lastEntries = AWSConfigs.InitializeCollections ? new List<NetworkAclEntry>() : null;

        /// <summary>
        /// Gets and sets the property FirstEntries. 
        /// <para>
        /// The rules that you want to run first in the Firewall Manager managed network ACLs.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Provide these in the order in which you want them to run. Firewall Manager will assign
        /// the specific rule numbers for you, in the network ACLs that it creates. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You must specify at least one first entry or one last entry in any network ACL policy.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkAclEntry> FirstEntries
        {
            get { return this._firstEntries; }
            set { this._firstEntries = value; }
        }

        // Check to see if FirstEntries property is set
        internal bool IsSetFirstEntries()
        {
            return this._firstEntries != null && (this._firstEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ForceRemediateForFirstEntries. 
        /// <para>
        /// Applies only when remediation is enabled for the policy as a whole. Firewall Manager
        /// uses this setting when it finds policy violations that involve conflicts between the
        /// custom entries and the policy entries. 
        /// </para>
        ///  
        /// <para>
        /// If forced remediation is disabled, Firewall Manager marks the network ACL as noncompliant
        /// and does not try to remediate. For more information about the remediation behavior,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/network-acl-policies.html#network-acls-remediation">Remediation
        /// for managed network ACLs</a> in the <i>Firewall Manager Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ForceRemediateForFirstEntries
        {
            get { return this._forceRemediateForFirstEntries; }
            set { this._forceRemediateForFirstEntries = value; }
        }

        // Check to see if ForceRemediateForFirstEntries property is set
        internal bool IsSetForceRemediateForFirstEntries()
        {
            return this._forceRemediateForFirstEntries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForceRemediateForLastEntries. 
        /// <para>
        /// Applies only when remediation is enabled for the policy as a whole. Firewall Manager
        /// uses this setting when it finds policy violations that involve conflicts between the
        /// custom entries and the policy entries. 
        /// </para>
        ///  
        /// <para>
        /// If forced remediation is disabled, Firewall Manager marks the network ACL as noncompliant
        /// and does not try to remediate. For more information about the remediation behavior,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/network-acl-policies.html#network-acls-remediation">Remediation
        /// for managed network ACLs</a> in the <i>Firewall Manager Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ForceRemediateForLastEntries
        {
            get { return this._forceRemediateForLastEntries; }
            set { this._forceRemediateForLastEntries = value; }
        }

        // Check to see if ForceRemediateForLastEntries property is set
        internal bool IsSetForceRemediateForLastEntries()
        {
            return this._forceRemediateForLastEntries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastEntries. 
        /// <para>
        /// The rules that you want to run last in the Firewall Manager managed network ACLs.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Provide these in the order in which you want them to run. Firewall Manager will assign
        /// the specific rule numbers for you, in the network ACLs that it creates. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You must specify at least one first entry or one last entry in any network ACL policy.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkAclEntry> LastEntries
        {
            get { return this._lastEntries; }
            set { this._lastEntries = value; }
        }

        // Check to see if LastEntries property is set
        internal bool IsSetLastEntries()
        {
            return this._lastEntries != null && (this._lastEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}