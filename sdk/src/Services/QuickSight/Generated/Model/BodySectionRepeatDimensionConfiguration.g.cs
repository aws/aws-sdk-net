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
    /// Describes the dataset column and constraints for the dynamic values used to repeat
    /// the contents of a section. The dataset column is either <b>Category</b> or <b>Numeric</b>
    /// column configuration
    /// </summary>
    public partial class BodySectionRepeatDimensionConfiguration
    {
        /// <summary>
        /// Gets and sets the property DynamicCategoryDimensionConfiguration. 
        /// <para>
        /// Describes the <b>Category</b> dataset column and constraints around the dynamic values
        /// that will be used in repeating the section contents.
        /// </para>
        /// </summary>
        public BodySectionDynamicCategoryDimensionConfiguration DynamicCategoryDimensionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DynamicCategoryDimensionConfiguration property is set.
        /// </summary>
        internal bool IsSetDynamicCategoryDimensionConfiguration() => this.DynamicCategoryDimensionConfiguration != null;

        /// <summary>
        /// Gets and sets the property DynamicNumericDimensionConfiguration. 
        /// <para>
        /// Describes the <b>Numeric</b> dataset column and constraints around the dynamic values
        /// used to repeat the contents of a section.
        /// </para>
        /// </summary>
        public BodySectionDynamicNumericDimensionConfiguration DynamicNumericDimensionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DynamicNumericDimensionConfiguration property is set.
        /// </summary>
        internal bool IsSetDynamicNumericDimensionConfiguration() => this.DynamicNumericDimensionConfiguration != null;
    }
}
