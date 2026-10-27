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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterPullTimeUpdateExclusion operation. Adds
    /// an IAM principal to the pull time update exclusion list for a registry. Amazon ECR
    /// will not record the pull time if an excluded principal pulls an image.
    /// </summary>
    public partial class RegisterPullTimeUpdateExclusionRequest : AmazonECRRequest
    {
        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the IAM principal to exclude from having image pull times recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 200)]
        public string PrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalArn property is set.
        /// </summary>
        internal bool IsSetPrincipalArn() => this.PrincipalArn != null;
    }
}
