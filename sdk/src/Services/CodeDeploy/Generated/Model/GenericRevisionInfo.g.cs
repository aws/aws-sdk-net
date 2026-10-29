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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about an application revision.
    /// </summary>
    public partial class GenericRevisionInfo
    {
        /// <summary>
        /// Gets and sets the property DeploymentGroups. 
        /// <para>
        /// The deployment groups for which this is the current target revision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeploymentGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DeploymentGroups property is set.
        /// </summary>
        internal bool IsSetDeploymentGroups() => this.DeploymentGroups != null && (this.DeploymentGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A comment about the revision.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FirstUsedTime. 
        /// <para>
        /// When the revision was first used by CodeDeploy.
        /// </para>
        /// </summary>
        public DateTime? FirstUsedTime { get; set; }

        /// <summary>
        /// Checks to see if the FirstUsedTime property is set.
        /// </summary>
        internal bool IsSetFirstUsedTime() => this.FirstUsedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUsedTime. 
        /// <para>
        /// When the revision was last used by CodeDeploy.
        /// </para>
        /// </summary>
        public DateTime? LastUsedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUsedTime property is set.
        /// </summary>
        internal bool IsSetLastUsedTime() => this.LastUsedTime.HasValue;

        /// <summary>
        /// Gets and sets the property RegisterTime. 
        /// <para>
        /// When the revision was registered with CodeDeploy.
        /// </para>
        /// </summary>
        public DateTime? RegisterTime { get; set; }

        /// <summary>
        /// Checks to see if the RegisterTime property is set.
        /// </summary>
        internal bool IsSetRegisterTime() => this.RegisterTime.HasValue;
    }
}
