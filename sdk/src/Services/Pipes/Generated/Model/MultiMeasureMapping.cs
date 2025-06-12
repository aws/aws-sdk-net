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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
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
namespace Amazon.Pipes.Model
{
    /// <summary>
    /// Maps multiple measures from the source event to the same Timestream for LiveAnalytics
    /// record.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/concepts.html">Amazon
    /// Timestream for LiveAnalytics concepts</a> 
    /// </para>
    /// </summary>
    public partial class MultiMeasureMapping
    {
        private List<MultiMeasureAttributeMapping> _multiMeasureAttributeMappings = AWSConfigs.InitializeCollections ? new List<MultiMeasureAttributeMapping>() : null;
        private string _multiMeasureName;

        /// <summary>
        /// Gets and sets the property MultiMeasureAttributeMappings. 
        /// <para>
        /// Mappings that represent multiple source event fields mapped to measures in the same
        /// Timestream for LiveAnalytics record.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public List<MultiMeasureAttributeMapping> MultiMeasureAttributeMappings
        {
            get { return this._multiMeasureAttributeMappings; }
            set { this._multiMeasureAttributeMappings = value; }
        }

        // Check to see if MultiMeasureAttributeMappings property is set
        internal bool IsSetMultiMeasureAttributeMappings()
        {
            return this._multiMeasureAttributeMappings != null && (this._multiMeasureAttributeMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MultiMeasureName. 
        /// <para>
        /// The name of the multiple measurements per record (multi-measure).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string MultiMeasureName
        {
            get { return this._multiMeasureName; }
            set { this._multiMeasureName = value; }
        }

        // Check to see if MultiMeasureName property is set
        internal bool IsSetMultiMeasureName()
        {
            return this._multiMeasureName != null;
        }

    }
}