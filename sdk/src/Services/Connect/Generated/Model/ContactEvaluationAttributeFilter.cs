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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private ContactEvaluationAttributeAndCondition _andCondition;
        private ContactEvaluationAttributeCondition _contactEvaluationAttributeCondition;
        private List<ContactEvaluationAttributeAndCondition> _orConditions = AWSConfigs.InitializeCollections ? new List<ContactEvaluationAttributeAndCondition>() : null;
        private TagCondition _tagCondition;

        /// <summary>
        /// Gets and sets the property AndCondition. 
        /// <para>
        /// A list of conditions which would be applied together with an <c>AND</c> condition.
        /// </para>
        /// </summary>
        public ContactEvaluationAttributeAndCondition AndCondition
        {
            get { return this._andCondition; }
            set { this._andCondition = value; }
        }

        // Check to see if AndCondition property is set
        internal bool IsSetAndCondition()
        {
            return this._andCondition != null;
        }

        /// <summary>
        /// Gets and sets the property ContactEvaluationAttributeCondition. 
        /// <para>
        /// An attribute condition to apply.
        /// </para>
        /// </summary>
        public ContactEvaluationAttributeCondition ContactEvaluationAttributeCondition
        {
            get { return this._contactEvaluationAttributeCondition; }
            set { this._contactEvaluationAttributeCondition = value; }
        }

        // Check to see if ContactEvaluationAttributeCondition property is set
        internal bool IsSetContactEvaluationAttributeCondition()
        {
            return this._contactEvaluationAttributeCondition != null;
        }

        /// <summary>
        /// Gets and sets the property OrConditions. 
        /// <para>
        /// A list of conditions which would be applied together with an <c>OR</c> condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContactEvaluationAttributeAndCondition> OrConditions
        {
            get { return this._orConditions; }
            set { this._orConditions = value; }
        }

        // Check to see if OrConditions property is set
        internal bool IsSetOrConditions()
        {
            return this._orConditions != null && (this._orConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagCondition. 
        /// <para>
        /// A tag condition to apply.
        /// </para>
        /// </summary>
        public TagCondition TagCondition
        {
            get { return this._tagCondition; }
            set { this._tagCondition = value; }
        }

        // Check to see if TagCondition property is set
        internal bool IsSetTagCondition()
        {
            return this._tagCondition != null;
        }

    }
}