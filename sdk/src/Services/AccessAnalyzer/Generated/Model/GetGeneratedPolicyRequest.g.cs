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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the GetGeneratedPolicy operation. Retrieves the policy
    /// that was generated using <c>StartPolicyGeneration</c>.
    /// </summary>
    public partial class GetGeneratedPolicyRequest : AmazonAccessAnalyzerRequest
    {
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
        /// as <c>"Resource":"arn:aws:s3:::${BucketName}"</c> instead of <c>"*"</c>.
        /// </para>
        /// </summary>
        public bool? IncludeResourcePlaceholders { get; set; }

        /// <summary>
        /// Checks to see if the IncludeResourcePlaceholders property is set.
        /// </summary>
        internal bool IsSetIncludeResourcePlaceholders() => this.IncludeResourcePlaceholders.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeServiceLevelTemplate. 
        /// <para>
        /// The level of detail that you want to generate. You can specify whether to generate
        /// service-level policies. 
        /// </para>
        ///  
        /// <para>
        /// IAM Access Analyzer uses <c>iam:servicelastaccessed</c> to identify services that
        /// have been used recently to create this service-level template.
        /// </para>
        /// </summary>
        public bool? IncludeServiceLevelTemplate { get; set; }

        /// <summary>
        /// Checks to see if the IncludeServiceLevelTemplate property is set.
        /// </summary>
        internal bool IsSetIncludeServiceLevelTemplate() => this.IncludeServiceLevelTemplate.HasValue;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The <c>JobId</c> that is returned by the <c>StartPolicyGeneration</c> operation. The
        /// <c>JobId</c> can be used with <c>GetGeneratedPolicy</c> to retrieve the generated
        /// policies or used with <c>CancelPolicyGeneration</c> to cancel the policy generation
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;
    }
}
