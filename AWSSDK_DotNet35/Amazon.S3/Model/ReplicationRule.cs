/*
 * Copyright 2010-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.S3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Rule that specifies the replication configuration.
    /// </summary>
    public class ReplicationRule
    {
        private string id;
        private string prefix;
        private ReplicationRuleStatus status;
        private ReplicationDestination destination;

        /// <summary>
        /// Unique identifier for the rule. The value cannot be longer than 255 characters.
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Checks to see if Id property is set.
        /// </summary>
        /// <returns>true if Id property is set.</returns>
        internal bool IsSetId()
        {
            return !System.String.IsNullOrEmpty(this.id);
        }

        /// <summary>
        /// Prefix for the keys to be replicated.
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        /// <summary>
        /// Checks to see if Prefix property is set.
        /// </summary>
        /// <returns>true if Prefix property is set.</returns>
        internal bool IsSetPrefix()
        {
            return !System.String.IsNullOrEmpty(this.prefix);
        }

        /// <summary>
        /// Whether the rule is applied or ignored.
        /// </summary>
        public ReplicationRuleStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Checks to see if Status property is set.
        /// </summary>
        /// <returns>true if Status property is set.</returns>
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// Container for destination information.
        /// </summary>
        public ReplicationDestination Destination
        {
            get { return this.destination; }
            set { this.destination = value; }
        }

        /// <summary>
        /// Checks to see if Destination property is set.
        /// </summary>
        /// <returns>true if Destination property is set.</returns>
        internal bool IsSetDestination()
        {
            return this.destination != null;
        }
    }
}
