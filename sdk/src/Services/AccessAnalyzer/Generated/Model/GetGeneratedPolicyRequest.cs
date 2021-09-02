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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the GetGeneratedPolicy operation.
    /// Retrieves the policy that was generated using <code>StartPolicyGeneration</code>.
    /// </summary>
    public partial class GetGeneratedPolicyRequest : AmazonAccessAnalyzerRequest
    {
        private bool? _includeResourcePlaceholders;
        private bool? _includeServiceLevelTemplate;
        private string _jobId;

        /// <summary>
        /// Gets and sets the property IncludeResourcePlaceholders. 
        /// <para>
        /// The level of detail that you want to generate. You can specify whether to generate
        /// policies with placeholders for resource ARNs for actions that support resource level
        /// granularity in policies.
        /// </para>
        ///  
        /// <para>
        /// For example, in the resource section of a policy, you can receive a placeholder such
        /// as <code>"Resource":"arn:aws:s3:::${BucketName}"</code> instead of <code>"*"</code>.
        /// </para>
        /// </summary>
        public bool IncludeResourcePlaceholders
        {
            get { return this._includeResourcePlaceholders.GetValueOrDefault(); }
            set { this._includeResourcePlaceholders = value; }
        }

        // Check to see if IncludeResourcePlaceholders property is set
        internal bool IsSetIncludeResourcePlaceholders()
        {
            return this._includeResourcePlaceholders.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeServiceLevelTemplate. 
        /// <para>
        /// The level of detail that you want to generate. You can specify whether to generate
        /// service-level policies. 
        /// </para>
        ///  
        /// <para>
        /// IAM Access Analyzer uses <code>iam:servicelastaccessed</code> to identify services
        /// that have been used recently to create this service-level template.
        /// </para>
        /// </summary>
        public bool IncludeServiceLevelTemplate
        {
            get { return this._includeServiceLevelTemplate.GetValueOrDefault(); }
            set { this._includeServiceLevelTemplate = value; }
        }

        // Check to see if IncludeServiceLevelTemplate property is set
        internal bool IsSetIncludeServiceLevelTemplate()
        {
            return this._includeServiceLevelTemplate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The <code>JobId</code> that is returned by the <code>StartPolicyGeneration</code>
        /// operation. The <code>JobId</code> can be used with <code>GetGeneratedPolicy</code>
        /// to retrieve the generated policies or used with <code>CancelPolicyGeneration</code>
        /// to cancel the policy generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

    }
}