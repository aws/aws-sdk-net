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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// The container for the Outposts bucket lifecycle rule and operator.
    /// </summary>
    public partial class LifecycleRuleAndOperator
    {
        /// <summary>
        /// Gets and sets the property ObjectSizeGreaterThan. 
        /// <para>
        /// The non-inclusive minimum object size for the lifecycle rule. Setting this property
        /// to 7 means the rule applies to objects with a size that is greater than 7. 
        /// </para>
        /// </summary>
        public long? ObjectSizeGreaterThan { get; set; }

        /// <summary>
        /// Checks to see if the ObjectSizeGreaterThan property is set.
        /// </summary>
        internal bool IsSetObjectSizeGreaterThan() => this.ObjectSizeGreaterThan.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectSizeLessThan. 
        /// <para>
        /// The non-inclusive maximum object size for the lifecycle rule. Setting this property
        /// to 77 means the rule applies to objects with a size that is less than 77. 
        /// </para>
        /// </summary>
        public long? ObjectSizeLessThan { get; set; }

        /// <summary>
        /// Checks to see if the ObjectSizeLessThan property is set.
        /// </summary>
        internal bool IsSetObjectSizeLessThan() => this.ObjectSizeLessThan.HasValue;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Prefix identifying one or more objects to which the rule applies.
        /// </para>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// All of these tags must exist in the object's tag set in order for the rule to apply.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<S3Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
