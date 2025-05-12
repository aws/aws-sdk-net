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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The deduplication strategy details.
    /// </summary>
    public partial class DataIntegrationFlowDedupeStrategy
    {
        private DataIntegrationFlowFieldPriorityDedupeStrategyConfiguration _fieldPriority;
        private DataIntegrationFlowDedupeStrategyType _type;

        /// <summary>
        /// Gets and sets the property FieldPriority. 
        /// <para>
        /// The field priority deduplication strategy.
        /// </para>
        /// </summary>
        public DataIntegrationFlowFieldPriorityDedupeStrategyConfiguration FieldPriority
        {
            get { return this._fieldPriority; }
            set { this._fieldPriority = value; }
        }

        // Check to see if FieldPriority property is set
        internal bool IsSetFieldPriority()
        {
            return this._fieldPriority != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the deduplication strategy.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>FIELD_PRIORITY</b> - Field priority configuration for the deduplication strategy
        /// specifies an ordered list of fields used to tie-break the data records sharing the
        /// same primary key values. Fields earlier in the list have higher priority for evaluation.
        /// For each field, the sort order determines whether to retain data record with larger
        /// or smaller field value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataIntegrationFlowDedupeStrategyType Type
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