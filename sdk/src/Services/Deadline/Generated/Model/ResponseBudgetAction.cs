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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The details of a budget action.
    /// </summary>
    public partial class ResponseBudgetAction
    {
        private string _description;
        private float? _thresholdPercentage;
        private BudgetActionType _type;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The budget action description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=100)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ThresholdPercentage. 
        /// <para>
        /// The percentage threshold for the budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public float ThresholdPercentage
        {
            get { return this._thresholdPercentage.GetValueOrDefault(); }
            set { this._thresholdPercentage = value; }
        }

        // Check to see if ThresholdPercentage property is set
        internal bool IsSetThresholdPercentage()
        {
            return this._thresholdPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The action taken on the budget once scheduling stops.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BudgetActionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}