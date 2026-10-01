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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Configuration for Azure DevOps project integration.
    /// </summary>
    public partial class AzureDevOpsConfiguration
    {
        /// <summary>
        /// Gets and sets the property OrganizationName. 
        /// <para>
        /// Azure DevOps organization name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationName property is set.
        /// </summary>
        internal bool IsSetOrganizationName() => this.OrganizationName != null;

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// Azure DevOps project ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Checks to see if the ProjectId property is set.
        /// </summary>
        internal bool IsSetProjectId() => this.ProjectId != null;

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// Azure DevOps project name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;
    }
}
