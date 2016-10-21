/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// This includes the options for getting the cost of a budget.
    /// </summary>
    public partial class CostTypes
    {
        private bool? _includeSubscription;
        private bool? _includeTax;
        private bool? _useBlended;

        /// <summary>
        /// Gets and sets the property IncludeSubscription.
        /// </summary>
        public bool IncludeSubscription
        {
            get { return this._includeSubscription.GetValueOrDefault(); }
            set { this._includeSubscription = value; }
        }

        // Check to see if IncludeSubscription property is set
        internal bool IsSetIncludeSubscription()
        {
            return this._includeSubscription.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeTax.
        /// </summary>
        public bool IncludeTax
        {
            get { return this._includeTax.GetValueOrDefault(); }
            set { this._includeTax = value; }
        }

        // Check to see if IncludeTax property is set
        internal bool IsSetIncludeTax()
        {
            return this._includeTax.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseBlended.
        /// </summary>
        public bool UseBlended
        {
            get { return this._useBlended.GetValueOrDefault(); }
            set { this._useBlended = value; }
        }

        // Check to see if UseBlended property is set
        internal bool IsSetUseBlended()
        {
            return this._useBlended.HasValue; 
        }

    }
}