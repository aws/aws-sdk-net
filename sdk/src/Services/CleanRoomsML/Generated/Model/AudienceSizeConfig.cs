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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Configure the list of audience output sizes that can be created. A request to <a>StartAudienceGenerationJob</a>
    /// that uses this configured audience model must have an <c>audienceSize</c> selected
    /// from this list. You can use the <c>ABSOLUTE</c> <a>AudienceSize</a> to configure out
    /// audience sizes using the count of identifiers in the output. You can use the <c>Percentage</c>
    /// <a>AudienceSize</a> to configure sizes in the range 1-100 percent.
    /// </summary>
    public partial class AudienceSizeConfig
    {
        private List<int> _audienceSizeBins = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private AudienceSizeType _audienceSizeType;

        /// <summary>
        /// Gets and sets the property AudienceSizeBins. 
        /// <para>
        /// An array of the different audience output sizes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<int> AudienceSizeBins
        {
            get { return this._audienceSizeBins; }
            set { this._audienceSizeBins = value; }
        }

        // Check to see if AudienceSizeBins property is set
        internal bool IsSetAudienceSizeBins()
        {
            return this._audienceSizeBins != null && (this._audienceSizeBins.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AudienceSizeType. 
        /// <para>
        /// Whether the audience output sizes are defined as an absolute number or a percentage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AudienceSizeType AudienceSizeType
        {
            get { return this._audienceSizeType; }
            set { this._audienceSizeType = value; }
        }

        // Check to see if AudienceSizeType property is set
        internal bool IsSetAudienceSizeType()
        {
            return this._audienceSizeType != null;
        }

    }
}