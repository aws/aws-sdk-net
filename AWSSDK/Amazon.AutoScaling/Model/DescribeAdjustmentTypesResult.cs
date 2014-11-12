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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// The output of the <a>DescribeAdjustmentTypes</a> action.
    /// </summary>
    public partial class DescribeAdjustmentTypesResult
    {
        private List<AdjustmentType> _adjustmentTypes = new List<AdjustmentType>();


        /// <summary>
        /// Gets and sets the property AdjustmentTypes. 
        /// <para>
        ///             A list of specific policy adjustment types.        
        /// </para>
        /// </summary>
        public List<AdjustmentType> AdjustmentTypes
        {
            get { return this._adjustmentTypes; }
            set { this._adjustmentTypes = value; }
        }

        /// <summary>
        /// Sets the AdjustmentTypes property
        /// </summary>
        /// <param name="adjustmentTypes">The values to add to the AdjustmentTypes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAdjustmentTypesResult WithAdjustmentTypes(params AdjustmentType[] adjustmentTypes)
        {
            foreach (var element in adjustmentTypes)
            {
                this._adjustmentTypes.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the AdjustmentTypes property
        /// </summary>
        /// <param name="adjustmentTypes">The values to add to the AdjustmentTypes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAdjustmentTypesResult WithAdjustmentTypes(IEnumerable<AdjustmentType> adjustmentTypes)
        {
            foreach (var element in adjustmentTypes)
            {
                this._adjustmentTypes.Add(element);
            }
            return this;
        }
        // Check to see if AdjustmentTypes property is set
        internal bool IsSetAdjustmentTypes()
        {
            return this._adjustmentTypes != null && this._adjustmentTypes.Count > 0; 
        }

    }
}