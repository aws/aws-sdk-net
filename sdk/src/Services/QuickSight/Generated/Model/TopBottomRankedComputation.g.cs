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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The top ranked and bottom ranked computation configuration.
    /// </summary>
    public partial class TopBottomRankedComputation
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category field that is used in a computation.
        /// </para>
        /// </summary>
        public DimensionField Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property ComputationId. 
        /// <para>
        /// The ID for a computation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ComputationId { get; set; }

        /// <summary>
        /// Checks to see if the ComputationId property is set.
        /// </summary>
        internal bool IsSetComputationId() => this.ComputationId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a computation.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResultSize. 
        /// <para>
        /// The result size of a top and bottom ranked computation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? ResultSize { get; set; }

        /// <summary>
        /// Checks to see if the ResultSize property is set.
        /// </summary>
        internal bool IsSetResultSize() => this.ResultSize.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The computation type. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// TOP: A top ranked computation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BOTTOM: A bottom ranked computation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public TopBottomComputationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value field that is used in a computation.
        /// </para>
        /// </summary>
        public MeasureField Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
