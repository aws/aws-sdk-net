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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A value to use for the filter.
    /// </summary>
    public partial class AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateOperandsDetails
    {
        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Prefix text for matching objects.
        /// </para>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property Tag. 
        /// <para>
        /// A tag that is assigned to matching objects.
        /// </para>
        /// </summary>
        public AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateOperandsTagDetails Tag { get; set; }

        /// <summary>
        /// Checks to see if the Tag property is set.
        /// </summary>
        internal bool IsSetTag() => this.Tag != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of filter value. Valid values are <c>LifecyclePrefixPredicate</c> or <c>LifecycleTagPredicate</c>.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
