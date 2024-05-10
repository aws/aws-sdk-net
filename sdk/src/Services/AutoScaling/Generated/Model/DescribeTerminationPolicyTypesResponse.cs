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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// This is the response object from the DescribeTerminationPolicyTypes operation.
    /// </summary>
    public partial class DescribeTerminationPolicyTypesResponse : AmazonWebServiceResponse
    {
        private List<string> _terminationPolicyTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property TerminationPolicyTypes. 
        /// <para>
        /// The termination policies supported by Amazon EC2 Auto Scaling: <c>OldestInstance</c>,
        /// <c>OldestLaunchConfiguration</c>, <c>NewestInstance</c>, <c>ClosestToNextInstanceHour</c>,
        /// <c>Default</c>, <c>OldestLaunchTemplate</c>, and <c>AllocationStrategy</c>.
        /// </para>
        /// </summary>
        public List<string> TerminationPolicyTypes
        {
            get { return this._terminationPolicyTypes; }
            set { this._terminationPolicyTypes = value; }
        }

        // Check to see if TerminationPolicyTypes property is set
        internal bool IsSetTerminationPolicyTypes()
        {
            return this._terminationPolicyTypes != null && (this._terminationPolicyTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}