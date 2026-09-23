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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the GetSamplingTargets operation. Requests a sampling
    /// quota for rules that the service is using to sample requests.
    /// </summary>
    public partial class GetSamplingTargetsRequest : AmazonXRayRequest
    {
        /// <summary>
        /// Gets and sets the property SamplingBoostStatisticsDocuments. 
        /// <para>
        /// Information about rules that the service is using to boost sampling rate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public List<SamplingBoostStatisticsDocument> SamplingBoostStatisticsDocuments { get; set; } = AWSConfigs.InitializeCollections ? new List<SamplingBoostStatisticsDocument>() : null;

        /// <summary>
        /// Checks to see if the SamplingBoostStatisticsDocuments property is set.
        /// </summary>
        internal bool IsSetSamplingBoostStatisticsDocuments() => this.SamplingBoostStatisticsDocuments != null && (this.SamplingBoostStatisticsDocuments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SamplingStatisticsDocuments. 
        /// <para>
        /// Information about rules that the service is using to sample requests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 25)]
        public List<SamplingStatisticsDocument> SamplingStatisticsDocuments { get; set; } = AWSConfigs.InitializeCollections ? new List<SamplingStatisticsDocument>() : null;

        /// <summary>
        /// Checks to see if the SamplingStatisticsDocuments property is set.
        /// </summary>
        internal bool IsSetSamplingStatisticsDocuments() => this.SamplingStatisticsDocuments != null && (this.SamplingStatisticsDocuments.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
