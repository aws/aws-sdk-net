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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents a single step from a DataBrew recipe to be performed.
    /// </summary>
    public partial class RecipeStep
    {
        private RecipeAction _action;
        private List<ConditionExpression> _conditionExpressions = AWSConfigs.InitializeCollections ? new List<ConditionExpression>() : null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The particular action to be performed in the recipe step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecipeAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ConditionExpressions. 
        /// <para>
        /// One or more conditions that must be met for the recipe step to succeed.
        /// </para>
        ///  <note> 
        /// <para>
        /// All of the conditions in the array must be met. In other words, all of the conditions
        /// must be combined using a logical AND operation.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConditionExpression> ConditionExpressions
        {
            get { return this._conditionExpressions; }
            set { this._conditionExpressions = value; }
        }

        // Check to see if ConditionExpressions property is set
        internal bool IsSetConditionExpressions()
        {
            return this._conditionExpressions != null && (this._conditionExpressions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}