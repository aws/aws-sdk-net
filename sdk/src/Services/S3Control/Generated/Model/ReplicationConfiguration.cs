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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container for one or more replication rules. A replication configuration must have
    /// at least one rule and you can add up to 100 rules. The maximum size of a replication
    /// configuration is 128 KB.
    /// </summary>
    public partial class ReplicationConfiguration
    {
        private string _role;
        private List<ReplicationRule> _rules = new List<ReplicationRule>();

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// S3 on Outposts assumes when replicating objects. For information about S3 replication
        /// on Outposts configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/outposts-replication-how-setup.html">Setting
        /// up replication</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// A container for one or more replication rules. A replication configuration must have
        /// at least one rule and can contain an array of 100 rules at the most. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ReplicationRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

    }
}