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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the StartPolicyPreviewJob operation.
    /// Creates a policy preview analysis job to evaluate the impact of Service Control Policies
    /// (SCPs) before deployment. The analysis uses historical CloudTrail authorization events
    /// to identify potential access denials, helping you prevent service disruptions.
    /// 
    ///  
    /// <para>
    /// The job analyzes CloudTrail events within a specified time window and generates a
    /// report identifying which events would be denied by the proposed policy. The report
    /// is stored in the specified Amazon S3 location.
    /// </para>
    /// </summary>
    public partial class StartPolicyPreviewJobRequest : AmazonAccessAnalyzerRequest
    {
        private string _clientToken;
        private DateTime? _endTime;
        private string _outputs3Uri;
        private List<PolicyConfiguration> _policyConfigurations = AWSConfigs.InitializeCollections ? new List<PolicyConfiguration>() : null;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. Idempotency ensures that an API request completes only once. With an
        /// idempotent request, if the original request completes successfully, subsequent retries
        /// with the same client token return the result from the original successful request
        /// and have no additional effect.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the analysis window. If not specified, defaults to the time of the request.
        /// The analysis will evaluate CloudTrail events up to this time.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputS3Uri. 
        /// <para>
        /// The Amazon S3 URI where the completed analysis report will be stored. The Amazon S3
        /// bucket must grant access to the IAM Access Analyzer service principal in its resource
        /// policy. The report will be stored at the path: <c>outputS3Uri/jobId/timestamp/</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutputS3Uri
        {
            get { return this._outputs3Uri; }
            set { this._outputs3Uri = value; }
        }

        // Check to see if OutputS3Uri property is set
        internal bool IsSetOutputS3Uri()
        {
            return this._outputs3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyConfigurations. 
        /// <para>
        /// A list of policy configurations to analyze. Currently limited to one configuration
        /// per request. Each configuration specifies the job type, target ID, and policy documents
        /// to test.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PolicyConfiguration> PolicyConfigurations
        {
            get { return this._policyConfigurations; }
            set { this._policyConfigurations = value; }
        }

        // Check to see if PolicyConfigurations property is set
        internal bool IsSetPolicyConfigurations()
        {
            return this._policyConfigurations != null && (this._policyConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the CloudTrail event analysis window. The analysis will evaluate events
        /// from this time forward.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}