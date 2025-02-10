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
    /// The summary information about the Amazon EKS add-on compatibility for the next Kubernetes
    /// version for an insight check in the <c>UPGRADE_READINESS</c> category.
    /// </summary>
    public partial class AddonCompatibilityDetail
    {
        private List<string> _compatibleVersions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property CompatibleVersions. 
        /// <para>
        /// The list of compatible Amazon EKS add-on versions for the next Kubernetes version.
        /// </para>
        /// </summary>
        public List<string> CompatibleVersions
        {
            get { return this._compatibleVersions; }
            set { this._compatibleVersions = value; }
        }

        // Check to see if CompatibleVersions property is set
        internal bool IsSetCompatibleVersions()
        {
            return this._compatibleVersions != null && (this._compatibleVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon EKS add-on.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}