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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Describes the additional objective for the solution, such as maximizing streaming
    /// minutes or increasing revenue. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/optimizing-solution-for-objective.html">Optimizing
    /// a solution</a>.
    /// </summary>
    public partial class OptimizationObjective
    {
        private string _itemAttribute;
        private ObjectiveSensitivity _objectiveSensitivity;

        /// <summary>
        /// Gets and sets the property ItemAttribute. 
        /// <para>
        /// The numerical metadata column in an Items dataset related to the optimization objective.
        /// For example, VIDEO_LENGTH (to maximize streaming minutes), or PRICE (to maximize revenue).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=150)]
        public string ItemAttribute
        {
            get { return this._itemAttribute; }
            set { this._itemAttribute = value; }
        }

        // Check to see if ItemAttribute property is set
        internal bool IsSetItemAttribute()
        {
            return this._itemAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectiveSensitivity. 
        /// <para>
        /// Specifies how Amazon Personalize balances the importance of your optimization objective
        /// versus relevance.
        /// </para>
        /// </summary>
        public ObjectiveSensitivity ObjectiveSensitivity
        {
            get { return this._objectiveSensitivity; }
            set { this._objectiveSensitivity = value; }
        }

        // Check to see if ObjectiveSensitivity property is set
        internal bool IsSetObjectiveSensitivity()
        {
            return this._objectiveSensitivity != null;
        }

    }
}