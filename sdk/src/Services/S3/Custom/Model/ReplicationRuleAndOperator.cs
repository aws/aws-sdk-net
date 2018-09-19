/*
 * Copyright 2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.S3.Model.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// </summary>
    public class ReplicationRuleAndOperator
    {
        private string prefix;
        private List<Tag> tags = new List<Tag>();

        /// <summary>
        /// Object keyname prefix that identifies subset of objects to which the rule applies.
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
        /// All of these tags must exist in the object's tag set in order for the rule to apply.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        /// <summary>
        /// Checks to see if Tags property is set.
        /// </summary>
        /// <returns>true if Tags property is set.</returns>
        internal bool IsSetTags()
        {
            return this.tags != null && this.tags.Count > 0;
        }
    }
}
