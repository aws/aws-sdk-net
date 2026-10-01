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
    /// This is the response object from the GetGeneratedPolicy operation.
    /// </summary>
    public partial class GetGeneratedPolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property GeneratedPolicyResult. 
        /// <para>
        /// A <c>GeneratedPolicyResult</c> object that contains the generated policies and associated
        /// details.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GeneratedPolicyResult GeneratedPolicyResult { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedPolicyResult property is set.
        /// </summary>
        internal bool IsSetGeneratedPolicyResult() => this.GeneratedPolicyResult != null;

        /// <summary>
        /// Gets and sets the property JobDetails. 
        /// <para>
        /// A <c>GeneratedPolicyDetails</c> object that contains details about the generated policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobDetails JobDetails { get; set; }

        /// <summary>
        /// Checks to see if the JobDetails property is set.
        /// </summary>
        internal bool IsSetJobDetails() => this.JobDetails != null;
    }
}
