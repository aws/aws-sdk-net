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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
    /// Container for the parameters to the GetSamplingTargets operation.
    /// Requests a sampling quota for rules that the service is using to sample requests.
    /// </summary>
    public partial class GetSamplingTargetsRequest : AmazonXRayRequest
    {
        private List<SamplingBoostStatisticsDocument> _samplingBoostStatisticsDocuments = AWSConfigs.InitializeCollections ? new List<SamplingBoostStatisticsDocument>() : null;
        private List<SamplingStatisticsDocument> _samplingStatisticsDocuments = AWSConfigs.InitializeCollections ? new List<SamplingStatisticsDocument>() : null;

        /// <summary>
        /// Gets and sets the property SamplingBoostStatisticsDocuments. 
        /// <para>
        /// Information about rules that the service is using to boost sampling rate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=25)]
        public List<SamplingBoostStatisticsDocument> SamplingBoostStatisticsDocuments
        {
            get { return this._samplingBoostStatisticsDocuments; }
            set { this._samplingBoostStatisticsDocuments = value; }
        }

        // Check to see if SamplingBoostStatisticsDocuments property is set
        internal bool IsSetSamplingBoostStatisticsDocuments()
        {
            return this._samplingBoostStatisticsDocuments != null && (this._samplingBoostStatisticsDocuments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SamplingStatisticsDocuments. 
        /// <para>
        /// Information about rules that the service is using to sample requests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=25)]
        public List<SamplingStatisticsDocument> SamplingStatisticsDocuments
        {
            get { return this._samplingStatisticsDocuments; }
            set { this._samplingStatisticsDocuments = value; }
        }

        // Check to see if SamplingStatisticsDocuments property is set
        internal bool IsSetSamplingStatisticsDocuments()
        {
            return this._samplingStatisticsDocuments != null && (this._samplingStatisticsDocuments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}