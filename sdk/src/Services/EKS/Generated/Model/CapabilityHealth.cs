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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Health information for a capability, including any issues that may be affecting its
    /// operation.
    /// </summary>
    public partial class CapabilityHealth
    {
        private List<CapabilityIssue> _issues = AWSConfigs.InitializeCollections ? new List<CapabilityIssue>() : null;

        /// <summary>
        /// Gets and sets the property Issues. 
        /// <para>
        /// A list of issues affecting the capability. If this list is empty, the capability is
        /// healthy.
        /// </para>
        /// </summary>
        public List<CapabilityIssue> Issues
        {
            get { return this._issues; }
            set { this._issues = value; }
        }

        // Check to see if Issues property is set
        internal bool IsSetIssues()
        {
            return this._issues != null && (this._issues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}