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
    /// The configuration of the same-sheet target visuals that you want to be filtered.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class SameSheetTargetVisualConfiguration
    {
        private TargetVisualOptions _targetVisualOptions;
        private List<string> _targetVisuals = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property TargetVisualOptions. 
        /// <para>
        /// The options that choose the target visual in the same sheet.
        /// </para>
        ///  
        /// <para>
        /// Valid values are defined as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL_VISUALS</c>: Applies the filter operation to all visuals in the same sheet.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TargetVisualOptions TargetVisualOptions
        {
            get { return this._targetVisualOptions; }
            set { this._targetVisualOptions = value; }
        }

        // Check to see if TargetVisualOptions property is set
        internal bool IsSetTargetVisualOptions()
        {
            return this._targetVisualOptions != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVisuals. 
        /// <para>
        /// A list of the target visual IDs that are located in the same sheet of the analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> TargetVisuals
        {
            get { return this._targetVisuals; }
            set { this._targetVisuals = value; }
        }

        // Check to see if TargetVisuals property is set
        internal bool IsSetTargetVisuals()
        {
            return this._targetVisuals != null && (this._targetVisuals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}