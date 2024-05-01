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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.S3.Model.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Abstract class that can be used over logical filter predicates,i.e. AND/OR.
    /// </summary>
    public abstract class AnalyticsNAryOperator : AnalyticsFilterPredicate
    {
        private readonly List<AnalyticsFilterPredicate> operands;

        /// <summary>
        /// Constructs an instance of AnalyticsNAryOperator
        /// </summary>
        /// <param name="operands"></param>
        protected AnalyticsNAryOperator(List<AnalyticsFilterPredicate> operands)
        {
            this.operands = operands;
        }

        /// <summary>
        /// The list of operands
        /// </summary>
        public List<AnalyticsFilterPredicate> Operands
        {
            get { return this.operands; }
        }
    }
}
