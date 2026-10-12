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

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Proton settings that are used for multiple services in the Amazon Web Services account.
    /// </summary>
    public partial class AccountSettings
    {
        /// <summary>
        /// Gets and sets the property PipelineCodebuildRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service role that Proton uses for provisioning
        /// pipelines. Proton assumes this role for CodeBuild-based provisioning.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string PipelineCodebuildRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the PipelineCodebuildRoleArn property is set.
        /// </summary>
        internal bool IsSetPipelineCodebuildRoleArn() => this.PipelineCodebuildRoleArn != null;

        /// <summary>
        /// Gets and sets the property PipelineProvisioningRepository. 
        /// <para>
        /// The linked repository for pipeline provisioning. Required if you have environments
        /// configured for self-managed provisioning with services that include pipelines. A linked
        /// repository is a repository that has been registered with Proton. For more information,
        /// see <a>CreateRepository</a>.
        /// </para>
        /// </summary>
        public RepositoryBranch PipelineProvisioningRepository { get; set; }

        /// <summary>
        /// Checks to see if the PipelineProvisioningRepository property is set.
        /// </summary>
        internal bool IsSetPipelineProvisioningRepository() => this.PipelineProvisioningRepository != null;

        /// <summary>
        /// Gets and sets the property PipelineServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service role you want to use for provisioning
        /// pipelines. Assumed by Proton for Amazon Web Services-managed provisioning, and by
        /// customer-owned automation for self-managed provisioning.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string PipelineServiceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the PipelineServiceRoleArn property is set.
        /// </summary>
        internal bool IsSetPipelineServiceRoleArn() => this.PipelineServiceRoleArn != null;
    }
}
