/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Deletes an ingress or egress entry (i.e., rule) from a network ACL.
    /// </summary>
    /// <remarks>
    /// For more information about network ACLs, go to Network ACLs
    /// in the Amazon Virtual Private Cloud User Guide.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DeleteNetworkAclEntryRequest
    {    
        private string networkAclIdField;
        private Decimal? ruleNumberField;
        private bool? egressField;

        /// <summary>
        /// ID of the network ACL.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkAclId")]
        public string NetworkAclId
        {
            get { return this.networkAclIdField; }
            set { this.networkAclIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the network ACL.
        /// </summary>
        /// <param name="networkAclId">ID of the network ACL.</param>
        /// <returns>this instance</returns>
        public DeleteNetworkAclEntryRequest WithNetworkAclId(string networkAclId)
        {
            this.networkAclIdField = networkAclId;
            return this;
        }

        /// <summary>
        /// Checks if NetworkAclId property is set
        /// </summary>
        /// <returns>true if NetworkAclId property is set</returns>
        public bool IsSetNetworkAclId()
        {
            return this.networkAclIdField != null;
        }

        /// <summary>
        /// Rule number for the entry to delete.
        /// </summary>
        [XmlElementAttribute(ElementName = "RuleNumber")]
        public Decimal RuleNumber
        {
            get { return this.ruleNumberField.GetValueOrDefault(); }
            set { this.ruleNumberField = value; }
        }

        /// <summary>
        /// Sets the rule number for the entry to delete.
        /// </summary>
        /// <param name="ruleNumber">Rule number for the entry to delete.</param>
        /// <returns>this instance</returns>
        public DeleteNetworkAclEntryRequest WithRuleNumber(Decimal ruleNumber)
        {
            this.ruleNumberField = ruleNumber;
            return this;
        }

        /// <summary>
        /// Checks if RuleNumber property is set
        /// </summary>
        /// <returns>true if RuleNumber property is set</returns>
        public bool IsSetRuleNumber()
        {
            return this.ruleNumberField.HasValue;
        }

        /// <summary>
        /// Whether the rule to delete is an egress rule (true) or 
        /// ingress rule (false).
        /// </summary>
        [XmlElementAttribute(ElementName = "Egress")]
        public bool Egress
        {
            get { return this.egressField.GetValueOrDefault(); }
            set { this.egressField = value; }
        }

        /// <summary>
        /// Sets whether the rule to delete is an egress rule (true) or 
        /// ingress rule (false).
        /// </summary>
        /// <param name="egress">Whether the rule to delete is an egress rule (true) or 
        /// ingress rule (false).</param>
        /// <returns>this instance</returns>
        public DeleteNetworkAclEntryRequest WithEgress(bool egress)
        {
            this.egressField = egress;
            return this;
        }

        /// <summary>
        /// Checks if Egress property is set
        /// </summary>
        /// <returns>true if Egress property is set</returns>
        public bool IsSetEgress()
        {
            return this.egressField.HasValue;
        }

    }
}
