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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// An object that can be used to specify tag conditions and attribute conditions inside
    /// the <c>SearchFilter</c> for contact evaluations. This accepts an <c>OR</c> or <c>AND</c>
    /// (List of List) input where:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The top level list specifies conditions that need to be applied with <c>OR</c> operator.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The inner list specifies conditions that need to be applied with <c>AND</c> operator.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ContactEvaluationAttributeFilter
    {
        /// <summary>
        /// Gets and sets the property AndCondition. 
        /// <para>
        /// A list of conditions which would be applied together with an <c>AND</c> condition.
        /// </para>
        /// </summary>
        public ContactEvaluationAttributeAndCondition AndCondition { get; set; }

        /// <summary>
        /// Checks to see if the AndCondition property is set.
        /// </summary>
        internal bool IsSetAndCondition() => this.AndCondition != null;

        /// <summary>
        /// Gets and sets the property ContactEvaluationAttributeCondition. 
        /// <para>
        /// An attribute condition to apply.
        /// </para>
        /// </summary>
        public ContactEvaluationAttributeCondition ContactEvaluationAttributeCondition { get; set; }

        /// <summary>
        /// Checks to see if the ContactEvaluationAttributeCondition property is set.
        /// </summary>
        internal bool IsSetContactEvaluationAttributeCondition() => this.ContactEvaluationAttributeCondition != null;

        /// <summary>
        /// Gets and sets the property OrConditions. 
        /// <para>
        /// A list of conditions which would be applied together with an <c>OR</c> condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContactEvaluationAttributeAndCondition> OrConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<ContactEvaluationAttributeAndCondition>() : null;

        /// <summary>
        /// Checks to see if the OrConditions property is set.
        /// </summary>
        internal bool IsSetOrConditions() => this.OrConditions != null && (this.OrConditions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagCondition. 
        /// <para>
        /// A tag condition to apply.
        /// </para>
        /// </summary>
        public TagCondition TagCondition { get; set; }

        /// <summary>
        /// Checks to see if the TagCondition property is set.
        /// </summary>
        internal bool IsSetTagCondition() => this.TagCondition != null;
    }
}
