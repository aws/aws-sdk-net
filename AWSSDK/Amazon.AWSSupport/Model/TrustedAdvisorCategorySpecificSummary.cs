/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>JSON-formatted child object of TrustedAdvisorCheckResult objects. </para>
    /// </summary>
    public class TrustedAdvisorCategorySpecificSummary
    {
        
        private TrustedAdvisorCostOptimizingSummary costOptimizing;

        /// <summary>
        /// Corresponds to the <i>Cost Optimizing</i> tab on the AWS Support Center Trusted Advisor page. This field is only available to checks in the
        /// Cost Optimizing category.
        ///  
        /// </summary>
        public TrustedAdvisorCostOptimizingSummary CostOptimizing
        {
            get { return this.costOptimizing; }
            set { this.costOptimizing = value; }
        }

        /// <summary>
        /// Sets the CostOptimizing property
        /// </summary>
        /// <param name="costOptimizing">The value to set for the CostOptimizing property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCategorySpecificSummary WithCostOptimizing(TrustedAdvisorCostOptimizingSummary costOptimizing)
        {
            this.costOptimizing = costOptimizing;
            return this;
        }
            

        // Check to see if CostOptimizing property is set
        internal bool IsSetCostOptimizing()
        {
            return this.costOptimizing != null;
        }
    }
}
