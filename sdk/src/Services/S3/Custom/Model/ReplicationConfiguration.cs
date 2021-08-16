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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// This class defines the configuration for replication.
    /// </summary>
    public class ReplicationConfiguration
    {
        private string role;
        private List<ReplicationRule> rules = new List<ReplicationRule>();

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// Amazon S3 assumes when replicating objects. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-how-setup.html">How
        /// to Set Up Replication</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        /// <summary>
        /// Check to see if the Role property is set.
        /// </summary>
        /// <returns>true if the Role property is set.</returns>
        internal bool IsSetRole()
        {
            return !System.String.IsNullOrEmpty(this.role);
        }

        /// <summary>
        /// Container for information about a particular replication rule.
        /// Replication configuration must have at least one rule and can contain up to 1,000 rules.
        /// </summary>
        public List<ReplicationRule> Rules
        {
            get { return this.rules; }
            set { this.rules = value; }
        }

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        /// <returns>true if the Rules property is set.</returns>
        internal bool IsSetRules()
        {
            return this.rules.Count > 0;
        }


    }
}
