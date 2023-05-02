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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the resource for each individual EKS cluster.
    /// </summary>
    public partial class CoverageResourceDetails
    {
        private CoverageEksClusterDetails _eksClusterDetails;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property EksClusterDetails. 
        /// <para>
        /// EKS cluster details involved in the coverage statistics.
        /// </para>
        /// </summary>
        public CoverageEksClusterDetails EksClusterDetails
        {
            get { return this._eksClusterDetails; }
            set { this._eksClusterDetails = value; }
        }

        // Check to see if EksClusterDetails property is set
        internal bool IsSetEksClusterDetails()
        {
            return this._eksClusterDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}