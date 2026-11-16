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
    /// The measurements at one probing site of a tooth.
    /// </summary>
    public partial class PeriodontalSite
    {
        /// <summary>
        /// Gets and sets the property Bleeding. 
        /// <para>
        /// Specifies whether the site bled during probing.
        /// </para>
        /// </summary>
        public bool? Bleeding { get; set; }

        /// <summary>
        /// Checks to see if the Bleeding property is set.
        /// </summary>
        internal bool IsSetBleeding() => this.Bleeding.HasValue;

        /// <summary>
        /// Gets and sets the property ProbingDepth. 
        /// <para>
        /// The probing depth, in millimeters. The value ranges from 0 to 15.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public int? ProbingDepth { get; set; }

        /// <summary>
        /// Checks to see if the ProbingDepth property is set.
        /// </summary>
        internal bool IsSetProbingDepth() => this.ProbingDepth.HasValue;

        /// <summary>
        /// Gets and sets the property Recession. 
        /// <para>
        /// The gingival recession, in millimeters. The value ranges from -5 to 15. For example,
        /// <c>-1</c> represents "plus one."
        /// </para>
        /// </summary>
        [AWSProperty(Min = -5, Max = 15)]
        public int? Recession { get; set; }

        /// <summary>
        /// Checks to see if the Recession property is set.
        /// </summary>
        internal bool IsSetRecession() => this.Recession.HasValue;

        /// <summary>
        /// Gets and sets the property Site. 
        /// <para>
        /// The probing site. The following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DB</c>: Distobuccal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>B</c>: Buccal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MB</c>: Mesiobuccal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DL</c>: Distolingual.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>L</c>: Lingual.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ML</c>: Mesiolingual.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public PeriodontalSiteName Site { get; set; }

        /// <summary>
        /// Checks to see if the Site property is set.
        /// </summary>
        internal bool IsSetSite() => this.Site != null;

        /// <summary>
        /// Gets and sets the property Suppuration. 
        /// <para>
        /// Specifies whether suppuration was present at the site.
        /// </para>
        /// </summary>
        public bool? Suppuration { get; set; }

        /// <summary>
        /// Checks to see if the Suppuration property is set.
        /// </summary>
        internal bool IsSetSuppuration() => this.Suppuration.HasValue;
    }
}
