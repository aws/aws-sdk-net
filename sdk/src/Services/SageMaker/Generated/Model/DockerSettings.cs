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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A collection of settings that configure the domain's Docker interaction.
    /// </summary>
    public partial class DockerSettings
    {
        private FeatureStatus _enableDockerAccess;
        private FeatureStatus _rootlessDocker;
        private List<string> _vpcOnlyTrustedAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EnableDockerAccess. 
        /// <para>
        /// Indicates whether the domain can access Docker.
        /// </para>
        /// </summary>
        public FeatureStatus EnableDockerAccess
        {
            get { return this._enableDockerAccess; }
            set { this._enableDockerAccess = value; }
        }

        // Check to see if EnableDockerAccess property is set
        internal bool IsSetEnableDockerAccess()
        {
            return this._enableDockerAccess != null;
        }

        /// <summary>
        /// Gets and sets the property RootlessDocker. 
        /// <para>
        /// Indicates whether to use rootless Docker.
        /// </para>
        /// </summary>
        public FeatureStatus RootlessDocker
        {
            get { return this._rootlessDocker; }
            set { this._rootlessDocker = value; }
        }

        // Check to see if RootlessDocker property is set
        internal bool IsSetRootlessDocker()
        {
            return this._rootlessDocker != null;
        }

        /// <summary>
        /// Gets and sets the property VpcOnlyTrustedAccounts. 
        /// <para>
        /// The list of Amazon Web Services accounts that are trusted when the domain is created
        /// in VPC-only mode.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> VpcOnlyTrustedAccounts
        {
            get { return this._vpcOnlyTrustedAccounts; }
            set { this._vpcOnlyTrustedAccounts = value; }
        }

        // Check to see if VpcOnlyTrustedAccounts property is set
        internal bool IsSetVpcOnlyTrustedAccounts()
        {
            return this._vpcOnlyTrustedAccounts != null && (this._vpcOnlyTrustedAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}