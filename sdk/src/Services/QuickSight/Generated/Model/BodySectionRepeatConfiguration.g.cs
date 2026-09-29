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
    /// Describes the configurations that are required to declare a section as repeating.
    /// </summary>
    public partial class BodySectionRepeatConfiguration
    {
        /// <summary>
        /// Gets and sets the property DimensionConfigurations. 
        /// <para>
        /// List of <c>BodySectionRepeatDimensionConfiguration</c> values that describe the dataset
        /// column and constraints for the column used to repeat the contents of a section.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<BodySectionRepeatDimensionConfiguration> DimensionConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<BodySectionRepeatDimensionConfiguration>() : null;

        /// <summary>
        /// Checks to see if the DimensionConfigurations property is set.
        /// </summary>
        internal bool IsSetDimensionConfigurations() => this.DimensionConfigurations != null && (this.DimensionConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NonRepeatingVisuals. 
        /// <para>
        /// List of visuals to exclude from repetition in repeating sections. The visuals will
        /// render identically, and ignore the repeating configurations in all repeating instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> NonRepeatingVisuals { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NonRepeatingVisuals property is set.
        /// </summary>
        internal bool IsSetNonRepeatingVisuals() => this.NonRepeatingVisuals != null && (this.NonRepeatingVisuals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PageBreakConfiguration. 
        /// <para>
        /// Page break configuration to apply for each repeating instance.
        /// </para>
        /// </summary>
        public BodySectionRepeatPageBreakConfiguration PageBreakConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PageBreakConfiguration property is set.
        /// </summary>
        internal bool IsSetPageBreakConfiguration() => this.PageBreakConfiguration != null;
    }
}
