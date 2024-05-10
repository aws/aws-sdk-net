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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the sorting criteria used in the coverage statistics.
    /// </summary>
    public partial class CoverageSortCriteria
    {
        private CoverageSortKey _attributeName;
        private OrderBy _orderBy;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// Represents the field name used to sort the coverage details.
        /// </para>
        ///  <note> 
        /// <para>
        /// Replace the enum value <c>CLUSTER_NAME</c> with <c>EKS_CLUSTER_NAME</c>. <c>CLUSTER_NAME</c>
        /// has been deprecated.
        /// </para>
        ///  </note>
        /// </summary>
        public CoverageSortKey AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// The order in which the sorted findings are to be displayed.
        /// </para>
        /// </summary>
        public OrderBy OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        // Check to see if OrderBy property is set
        internal bool IsSetOrderBy()
        {
            return this._orderBy != null;
        }

    }
}