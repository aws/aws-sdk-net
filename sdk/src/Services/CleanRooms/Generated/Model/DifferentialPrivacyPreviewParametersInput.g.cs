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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The epsilon and noise parameters that you want to preview.
    /// </summary>
    public partial class DifferentialPrivacyPreviewParametersInput
    {
        /// <summary>
        /// Gets and sets the property Epsilon. 
        /// <para>
        /// The epsilon value that you want to preview.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public int? Epsilon { get; set; }

        /// <summary>
        /// Checks to see if the Epsilon property is set.
        /// </summary>
        internal bool IsSetEpsilon() => this.Epsilon.HasValue;

        /// <summary>
        /// Gets and sets the property UsersNoisePerQuery. 
        /// <para>
        /// Noise added per query is measured in terms of the number of users whose contributions
        /// you want to obscure. This value governs the rate at which the privacy budget is depleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 100)]
        public int? UsersNoisePerQuery { get; set; }

        /// <summary>
        /// Checks to see if the UsersNoisePerQuery property is set.
        /// </summary>
        internal bool IsSetUsersNoisePerQuery() => this.UsersNoisePerQuery.HasValue;
    }
}
