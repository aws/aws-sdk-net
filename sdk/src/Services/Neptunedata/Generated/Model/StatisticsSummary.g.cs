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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Information about the characteristic sets generated in the statistics.
    /// </summary>
    public partial class StatisticsSummary
    {
        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The total number of characteristic-set instances.
        /// </para>
        /// </summary>
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property PredicateCount. 
        /// <para>
        /// The total number of unique predicates.
        /// </para>
        /// </summary>
        public int? PredicateCount { get; set; }

        /// <summary>
        /// Checks to see if the PredicateCount property is set.
        /// </summary>
        internal bool IsSetPredicateCount() => this.PredicateCount.HasValue;

        /// <summary>
        /// Gets and sets the property SignatureCount. 
        /// <para>
        /// The total number of signatures across all characteristic sets.
        /// </para>
        /// </summary>
        public int? SignatureCount { get; set; }

        /// <summary>
        /// Checks to see if the SignatureCount property is set.
        /// </summary>
        internal bool IsSetSignatureCount() => this.SignatureCount.HasValue;
    }
}
