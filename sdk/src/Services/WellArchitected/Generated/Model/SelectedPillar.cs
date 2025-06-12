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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// The selected pillar.
    /// </summary>
    public partial class SelectedPillar
    {
        private string _pillarId;
        private List<string> _selectedQuestionIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property PillarId.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string PillarId
        {
            get { return this._pillarId; }
            set { this._pillarId = value; }
        }

        // Check to see if PillarId property is set
        internal bool IsSetPillarId()
        {
            return this._pillarId != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedQuestionIds. 
        /// <para>
        /// Selected question IDs in the selected pillar.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SelectedQuestionIds
        {
            get { return this._selectedQuestionIds; }
            set { this._selectedQuestionIds = value; }
        }

        // Check to see if SelectedQuestionIds property is set
        internal bool IsSetSelectedQuestionIds()
        {
            return this._selectedQuestionIds != null && (this._selectedQuestionIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}