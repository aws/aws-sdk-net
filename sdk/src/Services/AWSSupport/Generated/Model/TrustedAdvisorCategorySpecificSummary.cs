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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// The container for summary information that relates to the category of the Trusted
    /// Advisor check.
    /// </summary>
    public partial class TrustedAdvisorCategorySpecificSummary
    {
        private TrustedAdvisorCostOptimizingSummary _costOptimizing;

        /// <summary>
        /// Gets and sets the property CostOptimizing. 
        /// <para>
        /// The summary information about cost savings for a Trusted Advisor check that is in
        /// the Cost Optimizing category.
        /// </para>
        /// </summary>
        public TrustedAdvisorCostOptimizingSummary CostOptimizing
        {
            get { return this._costOptimizing; }
            set { this._costOptimizing = value; }
        }

        // Check to see if CostOptimizing property is set
        internal bool IsSetCostOptimizing()
        {
            return this._costOptimizing != null;
        }

    }
}