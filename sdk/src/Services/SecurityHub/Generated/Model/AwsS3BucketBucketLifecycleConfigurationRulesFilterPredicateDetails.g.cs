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
    /// The configuration for the filter.
    /// </summary>
    public partial class AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateDetails
    {
        /// <summary>
        /// Gets and sets the property Operands. 
        /// <para>
        /// The values to use for the filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateOperandsDetails> Operands { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateOperandsDetails>() : null;

        /// <summary>
        /// Checks to see if the Operands property is set.
        /// </summary>
        internal bool IsSetOperands() => this.Operands != null && (this.Operands.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// A prefix filter.
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
        /// A tag filter.
        /// </para>
        /// </summary>
        public AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateTagDetails Tag { get; set; }

        /// <summary>
        /// Checks to see if the Tag property is set.
        /// </summary>
        internal bool IsSetTag() => this.Tag != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Whether to use <c>AND</c> or <c>OR</c> to join the operands. Valid values are <c>LifecycleAndOperator</c>
        /// or <c>LifecycleOrOperator</c>.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
