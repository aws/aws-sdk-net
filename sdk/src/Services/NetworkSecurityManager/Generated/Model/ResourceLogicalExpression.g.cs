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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// A logical expression that selects resources. Exactly one of <c>criteria</c>, <c>and</c>,
    /// <c>or</c>, or <c>not</c> is set.
    /// </summary>
    public partial class ResourceLogicalExpression
    {
        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        /// A list of subexpressions that must all match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<ResourceLogicalExpression> And { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceLogicalExpression>() : null;

        /// <summary>
        /// Checks to see if the And property is set.
        /// </summary>
        internal bool IsSetAnd() => this.And != null && (this.And.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// A leaf condition that matches resources by tag or by resource-type-specific configuration.
        /// </para>
        /// </summary>
        public ResourceCriteria Criteria { get; set; }

        /// <summary>
        /// Checks to see if the Criteria property is set.
        /// </summary>
        internal bool IsSetCriteria() => this.Criteria != null;

        /// <summary>
        /// Gets and sets the property Not. 
        /// <para>
        /// A subexpression that must not match.
        /// </para>
        /// </summary>
        public ResourceLogicalExpression Not { get; set; }

        /// <summary>
        /// Checks to see if the Not property is set.
        /// </summary>
        internal bool IsSetNot() => this.Not != null;

        /// <summary>
        /// Gets and sets the property Or. 
        /// <para>
        /// A list of subexpressions of which at least one must match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<ResourceLogicalExpression> Or { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceLogicalExpression>() : null;

        /// <summary>
        /// Checks to see if the Or property is set.
        /// </summary>
        internal bool IsSetOr() => this.Or != null && (this.Or.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
