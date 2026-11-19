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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// The chart for one tooth.
    /// </summary>
    public partial class PeriodontalTooth
    {
        /// <summary>
        /// Gets and sets the property Furcation. 
        /// <para>
        /// The furcation involvement class. The value ranges from 0 to 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public int? Furcation { get; set; }

        /// <summary>
        /// Checks to see if the Furcation property is set.
        /// </summary>
        internal bool IsSetFurcation() => this.Furcation.HasValue;

        /// <summary>
        /// Gets and sets the property Missing. 
        /// <para>
        /// Specifies whether the tooth is missing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Missing { get; set; }

        /// <summary>
        /// Checks to see if the Missing property is set.
        /// </summary>
        internal bool IsSetMissing() => this.Missing.HasValue;

        /// <summary>
        /// Gets and sets the property Mobility. 
        /// <para>
        /// The tooth mobility grade. The value ranges from 0 to 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public int? Mobility { get; set; }

        /// <summary>
        /// Checks to see if the Mobility property is set.
        /// </summary>
        internal bool IsSetMobility() => this.Mobility.HasValue;

        /// <summary>
        /// Gets and sets the property Sites. 
        /// <para>
        /// The probing sites that have a recorded measurement, in the order <c>MB</c>, <c>B</c>,
        /// <c>DB</c>, <c>ML</c>, <c>L</c>, <c>DL</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 6)]
        public List<PeriodontalSite> Sites { get; set; } = AWSConfigs.InitializeCollections ? new List<PeriodontalSite>() : null;

        /// <summary>
        /// Checks to see if the Sites property is set.
        /// </summary>
        internal bool IsSetSites() => this.Sites != null && (this.Sites.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ToothNumber. 
        /// <para>
        /// The tooth number in the Universal Numbering System. The value ranges from 1 to 32.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public int? ToothNumber { get; set; }

        /// <summary>
        /// Checks to see if the ToothNumber property is set.
        /// </summary>
        internal bool IsSetToothNumber() => this.ToothNumber.HasValue;
    }
}
