/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Deletes the specified ingress or egress entry (rule) from the specified network ACL.</para>
    /// </summary>
    public partial class DeleteNetworkAclEntryRequest : AmazonEC2Request
    {
        private string networkAclId;
        private int? ruleNumber;
        private bool? egress;


        /// <summary>
        /// The ID of the network ACL.
        ///  
        /// </summary>
        public string NetworkAclId
        {
            get { return this.networkAclId; }
            set { this.networkAclId = value; }
        }

        // Check to see if NetworkAclId property is set
        internal bool IsSetNetworkAclId()
        {
            return this.networkAclId != null;
        }

        /// <summary>
        /// The rule number of the entry to delete.
        ///  
        /// </summary>
        public int RuleNumber
        {
            get { return this.ruleNumber ?? default(int); }
            set { this.ruleNumber = value; }
        }

        // Check to see if RuleNumber property is set
        internal bool IsSetRuleNumber()
        {
            return this.ruleNumber.HasValue;
        }

        /// <summary>
        /// Indicates whether the rule is an egress rule.
        ///  
        /// </summary>
        public bool Egress
        {
            get { return this.egress ?? default(bool); }
            set { this.egress = value; }
        }

        // Check to see if Egress property is set
        internal bool IsSetEgress()
        {
            return this.egress.HasValue;
        }

    }
}
    
