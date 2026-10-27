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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains details about a failure that occurred while Image Builder distributed the
    /// image or applied configuration to the distributed image.
    /// </summary>
    public partial class DistributionFailureContext
    {
        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message for the distribution failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 384000)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property RegionFailures. 
        /// <para>
        /// The details about the failure for each Region where the image didn't finish distribution
        /// or configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public List<RegionFailure> RegionFailures { get; set; } = AWSConfigs.InitializeCollections ? new List<RegionFailure>() : null;

        /// <summary>
        /// Checks to see if the RegionFailures property is set.
        /// </summary>
        internal bool IsSetRegionFailures() => this.RegionFailures != null && (this.RegionFailures.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
