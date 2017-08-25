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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The user-specified preferences for how AWS CloudFormation performs a stack set operation.
    /// 
    /// 
    ///  
    /// <para>
    /// For more information on maximum concurrent accounts and failure tolerance, see <a
    /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-concepts.html#stackset-ops-options">Stack
    /// set operation options</a>.
    /// </para>
    /// </summary>
    public partial class StackSetOperationPreferences
    {
        private int? _failureToleranceCount;
        private int? _failureTolerancePercentage;
        private int? _maxConcurrentCount;
        private int? _maxConcurrentPercentage;
        private List<string> _regionOrder = new List<string>();

        /// <summary>
        /// Gets and sets the property FailureToleranceCount. 
        /// <para>
        /// The number of accounts, per region, for which this operation can fail before AWS CloudFormation
        /// stops the operation in that region. If the operation is stopped in a region, AWS CloudFormation
        /// doesn't attempt the operation in any subsequent regions.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>FailureToleranceCount</code> or <code>FailureTolerancePercentage</code>
        /// (but not both).
        /// </para>
        /// </summary>
        public int FailureToleranceCount
        {
            get { return this._failureToleranceCount.GetValueOrDefault(); }
            set { this._failureToleranceCount = value; }
        }

        // Check to see if FailureToleranceCount property is set
        internal bool IsSetFailureToleranceCount()
        {
            return this._failureToleranceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureTolerancePercentage. 
        /// <para>
        /// The percentage of accounts, per region, for which this stack operation can fail before
        /// AWS CloudFormation stops the operation in that region. If the operation is stopped
        /// in a region, AWS CloudFormation doesn't attempt the operation in any subsequent regions.
        /// </para>
        ///  
        /// <para>
        /// When calculating the number of accounts based on the specified percentage, AWS CloudFormation
        /// rounds <i>down</i> to the next whole number.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>FailureToleranceCount</code> or <code>FailureTolerancePercentage</code>,
        /// but not both.
        /// </para>
        /// </summary>
        public int FailureTolerancePercentage
        {
            get { return this._failureTolerancePercentage.GetValueOrDefault(); }
            set { this._failureTolerancePercentage = value; }
        }

        // Check to see if FailureTolerancePercentage property is set
        internal bool IsSetFailureTolerancePercentage()
        {
            return this._failureTolerancePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrentCount. 
        /// <para>
        /// The maximum number of accounts in which to perform this operation at one time. This
        /// is dependent on the value of <code>FailureToleranceCount</code>—<code>MaxConcurrentCount</code>
        /// is at most one more than the <code>FailureToleranceCount</code> .
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>MaxConcurrentCount</code> or <code>MaxConcurrentPercentage</code>,
        /// but not both.
        /// </para>
        /// </summary>
        public int MaxConcurrentCount
        {
            get { return this._maxConcurrentCount.GetValueOrDefault(); }
            set { this._maxConcurrentCount = value; }
        }

        // Check to see if MaxConcurrentCount property is set
        internal bool IsSetMaxConcurrentCount()
        {
            return this._maxConcurrentCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrentPercentage. 
        /// <para>
        /// The maximum percentage of accounts in which to perform this operation at one time.
        /// </para>
        ///  
        /// <para>
        /// When calculating the number of accounts based on the specified percentage, AWS CloudFormation
        /// rounds down to the next whole number. This is true except in cases where rounding
        /// down would result is zero. In this case, CloudFormation sets the number as one instead.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>MaxConcurrentCount</code> or <code>MaxConcurrentPercentage</code>,
        /// but not both.
        /// </para>
        /// </summary>
        public int MaxConcurrentPercentage
        {
            get { return this._maxConcurrentPercentage.GetValueOrDefault(); }
            set { this._maxConcurrentPercentage = value; }
        }

        // Check to see if MaxConcurrentPercentage property is set
        internal bool IsSetMaxConcurrentPercentage()
        {
            return this._maxConcurrentPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegionOrder. 
        /// <para>
        /// The order of the regions in where you want to perform the stack operation.
        /// </para>
        /// </summary>
        public List<string> RegionOrder
        {
            get { return this._regionOrder; }
            set { this._regionOrder = value; }
        }

        // Check to see if RegionOrder property is set
        internal bool IsSetRegionOrder()
        {
            return this._regionOrder != null && this._regionOrder.Count > 0; 
        }

    }
}