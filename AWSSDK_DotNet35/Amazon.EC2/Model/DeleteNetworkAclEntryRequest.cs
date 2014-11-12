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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteNetworkAclEntry operation.
    /// Deletes the specified ingress or egress entry (rule) from the specified network ACL.
    /// </summary>
    public partial class DeleteNetworkAclEntryRequest : AmazonEC2Request
    {
        private bool? _egress;
        private string _networkAclId;
        private int? _ruleNumber;

        /// <summary>
        /// Gets and sets the property Egress. 
        /// <para>
        /// Indicates whether the rule is an egress rule.
        /// </para>
        /// </summary>
        public bool Egress
        {
            get { return this._egress.GetValueOrDefault(); }
            set { this._egress = value; }
        }

        // Check to see if Egress property is set
        internal bool IsSetEgress()
        {
            return this._egress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkAclId. 
        /// <para>
        /// The ID of the network ACL.
        /// </para>
        /// </summary>
        public string NetworkAclId
        {
            get { return this._networkAclId; }
            set { this._networkAclId = value; }
        }

        // Check to see if NetworkAclId property is set
        internal bool IsSetNetworkAclId()
        {
            return this._networkAclId != null;
        }

        /// <summary>
        /// Gets and sets the property RuleNumber. 
        /// <para>
        /// The rule number of the entry to delete.
        /// </para>
        /// </summary>
        public int RuleNumber
        {
            get { return this._ruleNumber.GetValueOrDefault(); }
            set { this._ruleNumber = value; }
        }

        // Check to see if RuleNumber property is set
        internal bool IsSetRuleNumber()
        {
            return this._ruleNumber.HasValue; 
        }

    }
}