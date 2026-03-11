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
    /// This is the response object from the GetSamplingTargets operation.
    /// </summary>
    public partial class GetSamplingTargetsResponse : AmazonWebServiceResponse
    {
        private DateTime? _lastRuleModification;
        private List<SamplingTargetDocument> _samplingTargetDocuments = AWSConfigs.InitializeCollections ? new List<SamplingTargetDocument>() : null;
        private List<UnprocessedStatistics> _unprocessedBoostStatistics = AWSConfigs.InitializeCollections ? new List<UnprocessedStatistics>() : null;
        private List<UnprocessedStatistics> _unprocessedStatistics = AWSConfigs.InitializeCollections ? new List<UnprocessedStatistics>() : null;

        /// <summary>
        /// Gets and sets the property LastRuleModification. 
        /// <para>
        /// The last time a user changed the sampling rule configuration. If the sampling rule
        /// configuration changed since the service last retrieved it, the service should call
        /// <a href="https://docs.aws.amazon.com/xray/latest/api/API_GetSamplingRules.html">GetSamplingRules</a>
        /// to get the latest version.
        /// </para>
        /// </summary>
        public DateTime? LastRuleModification
        {
            get { return this._lastRuleModification; }
            set { this._lastRuleModification = value; }
        }

        // Check to see if LastRuleModification property is set
        internal bool IsSetLastRuleModification()
        {
            return this._lastRuleModification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SamplingTargetDocuments. 
        /// <para>
        /// Updated rules that the service should use to sample requests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SamplingTargetDocument> SamplingTargetDocuments
        {
            get { return this._samplingTargetDocuments; }
            set { this._samplingTargetDocuments = value; }
        }

        // Check to see if SamplingTargetDocuments property is set
        internal bool IsSetSamplingTargetDocuments()
        {
            return this._samplingTargetDocuments != null && (this._samplingTargetDocuments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedBoostStatistics. 
        /// <para>
        /// Information about <a href="https://docs.aws.amazon.com/xray/latest/api/API_SamplingBoostStatisticsDocument.html">SamplingBoostStatisticsDocument</a>
        /// that X-Ray could not process.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnprocessedStatistics> UnprocessedBoostStatistics
        {
            get { return this._unprocessedBoostStatistics; }
            set { this._unprocessedBoostStatistics = value; }
        }

        // Check to see if UnprocessedBoostStatistics property is set
        internal bool IsSetUnprocessedBoostStatistics()
        {
            return this._unprocessedBoostStatistics != null && (this._unprocessedBoostStatistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedStatistics. 
        /// <para>
        /// Information about <a href="https://docs.aws.amazon.com/xray/latest/api/API_SamplingStatisticsDocument.html">SamplingStatisticsDocument</a>
        /// that X-Ray could not process.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnprocessedStatistics> UnprocessedStatistics
        {
            get { return this._unprocessedStatistics; }
            set { this._unprocessedStatistics = value; }
        }

        // Check to see if UnprocessedStatistics property is set
        internal bool IsSetUnprocessedStatistics()
        {
            return this._unprocessedStatistics != null && (this._unprocessedStatistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}