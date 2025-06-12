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
    /// The criteria to use for the insights.
    /// </summary>
    public partial class InsightsFilter
    {
        private List<string> _categories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _kubernetesVersions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _statuses = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The categories to use to filter insights. The following lists the available categories:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UPGRADE_READINESS</c>: Amazon EKS identifies issues that could impact your ability
        /// to upgrade to new versions of Kubernetes. These are called upgrade insights.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISCONFIGURATION</c>: Amazon EKS identifies misconfiguration in your EKS Hybrid
        /// Nodes setup that could impair functionality of your cluster or workloads. These are
        /// called configuration insights.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && (this._categories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KubernetesVersions. 
        /// <para>
        /// The Kubernetes versions to use to filter the insights.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KubernetesVersions
        {
            get { return this._kubernetesVersions; }
            set { this._kubernetesVersions = value; }
        }

        // Check to see if KubernetesVersions property is set
        internal bool IsSetKubernetesVersions()
        {
            return this._kubernetesVersions != null && (this._kubernetesVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        /// The statuses to use to filter the insights. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Statuses
        {
            get { return this._statuses; }
            set { this._statuses = value; }
        }

        // Check to see if Statuses property is set
        internal bool IsSetStatuses()
        {
            return this._statuses != null && (this._statuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}