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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private List<BodySectionRepeatDimensionConfiguration> _dimensionConfigurations = AWSConfigs.InitializeCollections ? new List<BodySectionRepeatDimensionConfiguration>() : null;
        private List<string> _nonRepeatingVisuals = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private BodySectionRepeatPageBreakConfiguration _pageBreakConfiguration;

        /// <summary>
        /// Gets and sets the property DimensionConfigurations. 
        /// <para>
        /// List of <c>BodySectionRepeatDimensionConfiguration</c> values that describe the dataset
        /// column and constraints for the column used to repeat the contents of a section.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=3)]
        public List<BodySectionRepeatDimensionConfiguration> DimensionConfigurations
        {
            get { return this._dimensionConfigurations; }
            set { this._dimensionConfigurations = value; }
        }

        // Check to see if DimensionConfigurations property is set
        internal bool IsSetDimensionConfigurations()
        {
            return this._dimensionConfigurations != null && (this._dimensionConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NonRepeatingVisuals. 
        /// <para>
        /// List of visuals to exclude from repetition in repeating sections. The visuals will
        /// render identically, and ignore the repeating configurations in all repeating instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=20)]
        public List<string> NonRepeatingVisuals
        {
            get { return this._nonRepeatingVisuals; }
            set { this._nonRepeatingVisuals = value; }
        }

        // Check to see if NonRepeatingVisuals property is set
        internal bool IsSetNonRepeatingVisuals()
        {
            return this._nonRepeatingVisuals != null && (this._nonRepeatingVisuals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PageBreakConfiguration. 
        /// <para>
        /// Page break configuration to apply for each repeating instance.
        /// </para>
        /// </summary>
        public BodySectionRepeatPageBreakConfiguration PageBreakConfiguration
        {
            get { return this._pageBreakConfiguration; }
            set { this._pageBreakConfiguration = value; }
        }

        // Check to see if PageBreakConfiguration property is set
        internal bool IsSetPageBreakConfiguration()
        {
            return this._pageBreakConfiguration != null;
        }

    }
}