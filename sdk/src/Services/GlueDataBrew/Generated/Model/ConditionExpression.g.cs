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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents an individual condition that evaluates to true or false.
    /// 
    ///  
    /// <para>
    /// Conditions are used with recipe actions. The action is only performed for column values
    /// where the condition evaluates to true.
    /// </para>
    ///  
    /// <para>
    /// If a recipe requires more than one condition, then the recipe must specify multiple
    /// <c>ConditionExpression</c> elements. Each condition is applied to the rows in a dataset
    /// first, before the recipe action is performed.
    /// </para>
    /// </summary>
    public partial class ConditionExpression
    {
        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// A specific condition to apply to a recipe action. For more information, see <a href="https://docs.aws.amazon.com/databrew/latest/dg/recipes.html#recipes.structure">Recipe
        /// structure</a> in the <i>Glue DataBrew Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Condition { get; set; }

        /// <summary>
        /// Checks to see if the Condition property is set.
        /// </summary>
        internal bool IsSetCondition() => this.Condition != null;

        /// <summary>
        /// Gets and sets the property TargetColumn. 
        /// <para>
        /// A column to apply this condition to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TargetColumn { get; set; }

        /// <summary>
        /// Checks to see if the TargetColumn property is set.
        /// </summary>
        internal bool IsSetTargetColumn() => this.TargetColumn != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A value that the condition must evaluate to for the condition to succeed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
