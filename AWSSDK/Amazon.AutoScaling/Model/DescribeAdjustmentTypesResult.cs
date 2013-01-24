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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> The output of the DescribeAdjustmentTypes action. </para>
    /// </summary>
    public class DescribeAdjustmentTypesResult  
    {
        
        private List<AdjustmentType> adjustmentTypes = new List<AdjustmentType>();

        /// <summary>
        /// A list of specific policy adjustment types.
        ///  
        /// </summary>
        public List<AdjustmentType> AdjustmentTypes
        {
            get { return this.adjustmentTypes; }
            set { this.adjustmentTypes = value; }
        }
        /// <summary>
        /// Adds elements to the AdjustmentTypes collection
        /// </summary>
        /// <param name="adjustmentTypes">The values to add to the AdjustmentTypes collection </param>
        /// <returns>this instance</returns>
        public DescribeAdjustmentTypesResult WithAdjustmentTypes(params AdjustmentType[] adjustmentTypes)
        {
            foreach (AdjustmentType element in adjustmentTypes)
            {
                this.adjustmentTypes.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the AdjustmentTypes collection
        /// </summary>
        /// <param name="adjustmentTypes">The values to add to the AdjustmentTypes collection </param>
        /// <returns>this instance</returns>
        public DescribeAdjustmentTypesResult WithAdjustmentTypes(IEnumerable<AdjustmentType> adjustmentTypes)
        {
            foreach (AdjustmentType element in adjustmentTypes)
            {
                this.adjustmentTypes.Add(element);
            }

            return this;
        }

        // Check to see if AdjustmentTypes property is set
        internal bool IsSetAdjustmentTypes()
        {
            return this.adjustmentTypes.Count > 0;       
        }
    }
}
