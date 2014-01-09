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
using Amazon.Runtime;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> The output of the DescribeAdjustmentTypes action. </para>
    /// </summary>
    public partial class DescribeAdjustmentTypesResult : AmazonWebServiceResponse
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

        // Check to see if AdjustmentTypes property is set
        internal bool IsSetAdjustmentTypes()
        {
            return this.adjustmentTypes.Count > 0;
        }
    }
}
