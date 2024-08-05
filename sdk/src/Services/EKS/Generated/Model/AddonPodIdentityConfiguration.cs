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
    /// Information about how to configure IAM for an Addon.
    /// </summary>
    public partial class AddonPodIdentityConfiguration
    {
        private List<string> _recommendedManagedPolicies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serviceAccount;

        /// <summary>
        /// Gets and sets the property RecommendedManagedPolicies. 
        /// <para>
        /// A suggested IAM Policy for the addon.
        /// </para>
        /// </summary>
        public List<string> RecommendedManagedPolicies
        {
            get { return this._recommendedManagedPolicies; }
            set { this._recommendedManagedPolicies = value; }
        }

        // Check to see if RecommendedManagedPolicies property is set
        internal bool IsSetRecommendedManagedPolicies()
        {
            return this._recommendedManagedPolicies != null && (this._recommendedManagedPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceAccount. 
        /// <para>
        /// The Kubernetes Service Account name used by the addon.
        /// </para>
        /// </summary>
        public string ServiceAccount
        {
            get { return this._serviceAccount; }
            set { this._serviceAccount = value; }
        }

        // Check to see if ServiceAccount property is set
        internal bool IsSetServiceAccount()
        {
            return this._serviceAccount != null;
        }

    }
}