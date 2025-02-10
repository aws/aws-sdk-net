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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The CPU performance to consider, using an instance family as the baseline reference.
    /// </summary>
    public partial class CpuPerformanceFactorRequest
    {
        private List<PerformanceFactorReferenceRequest> _references = AWSConfigs.InitializeCollections ? new List<PerformanceFactorReferenceRequest>() : null;

        /// <summary>
        /// Gets and sets the property References. 
        /// <para>
        /// Specify an instance family to use as the baseline reference for CPU performance. All
        /// instance types that match your specified attributes will be compared against the CPU
        /// performance of the referenced instance family, regardless of CPU manufacturer or architecture
        /// differences.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, only one instance family can be specified in the list.
        /// </para>
        ///  </note>
        /// </summary>
        public List<PerformanceFactorReferenceRequest> References
        {
            get { return this._references; }
            set { this._references = value; }
        }

        // Check to see if References property is set
        internal bool IsSetReferences()
        {
            return this._references != null && (this._references.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}