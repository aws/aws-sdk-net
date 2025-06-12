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
    /// A pillar difference return object.
    /// </summary>
    public partial class PillarDifference
    {
        private DifferenceStatus _differenceStatus;
        private string _pillarId;
        private string _pillarName;
        private List<QuestionDifference> _questionDifferences = AWSConfigs.InitializeCollections ? new List<QuestionDifference>() : null;

        /// <summary>
        /// Gets and sets the property DifferenceStatus. 
        /// <para>
        /// Indicates the type of change to the pillar.
        /// </para>
        /// </summary>
        public DifferenceStatus DifferenceStatus
        {
            get { return this._differenceStatus; }
            set { this._differenceStatus = value; }
        }

        // Check to see if DifferenceStatus property is set
        internal bool IsSetDifferenceStatus()
        {
            return this._differenceStatus != null;
        }

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
        /// Gets and sets the property PillarName.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PillarName
        {
            get { return this._pillarName; }
            set { this._pillarName = value; }
        }

        // Check to see if PillarName property is set
        internal bool IsSetPillarName()
        {
            return this._pillarName != null;
        }

        /// <summary>
        /// Gets and sets the property QuestionDifferences. 
        /// <para>
        /// List of question differences.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QuestionDifference> QuestionDifferences
        {
            get { return this._questionDifferences; }
            set { this._questionDifferences = value; }
        }

        // Check to see if QuestionDifferences property is set
        internal bool IsSetQuestionDifferences()
        {
            return this._questionDifferences != null && (this._questionDifferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}