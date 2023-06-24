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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccountSettings operation.
    /// Update Proton settings that are used for multiple services in the Amazon Web Services
    /// account.
    /// </summary>
    public partial class UpdateAccountSettingsRequest : AmazonProtonRequest
    {
        private bool? _deletePipelineProvisioningRepository;
        private string _pipelineCodebuildRoleArn;
        private RepositoryBranchInput _pipelineProvisioningRepository;
        private string _pipelineServiceRoleArn;

        /// <summary>
        /// Gets and sets the property DeletePipelineProvisioningRepository. 
        /// <para>
        /// Set to <code>true</code> to remove a configured pipeline repository from the account
        /// settings. Don't set this field if you are updating the configured pipeline repository.
        /// </para>
        /// </summary>
        public bool DeletePipelineProvisioningRepository
        {
            get { return this._deletePipelineProvisioningRepository.GetValueOrDefault(); }
            set { this._deletePipelineProvisioningRepository = value; }
        }

        // Check to see if DeletePipelineProvisioningRepository property is set
        internal bool IsSetDeletePipelineProvisioningRepository()
        {
            return this._deletePipelineProvisioningRepository.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipelineCodebuildRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service role you want to use for provisioning
        /// pipelines. Proton assumes this role for CodeBuild-based provisioning.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string PipelineCodebuildRoleArn
        {
            get { return this._pipelineCodebuildRoleArn; }
            set { this._pipelineCodebuildRoleArn = value; }
        }

        // Check to see if PipelineCodebuildRoleArn property is set
        internal bool IsSetPipelineCodebuildRoleArn()
        {
            return this._pipelineCodebuildRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineProvisioningRepository. 
        /// <para>
        /// A linked repository for pipeline provisioning. Specify it if you have environments
        /// configured for self-managed provisioning with services that include pipelines. A linked
        /// repository is a repository that has been registered with Proton. For more information,
        /// see <a>CreateRepository</a>.
        /// </para>
        ///  
        /// <para>
        /// To remove a previously configured repository, set <code>deletePipelineProvisioningRepository</code>
        /// to <code>true</code>, and don't set <code>pipelineProvisioningRepository</code>.
        /// </para>
        /// </summary>
        public RepositoryBranchInput PipelineProvisioningRepository
        {
            get { return this._pipelineProvisioningRepository; }
            set { this._pipelineProvisioningRepository = value; }
        }

        // Check to see if PipelineProvisioningRepository property is set
        internal bool IsSetPipelineProvisioningRepository()
        {
            return this._pipelineProvisioningRepository != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service role you want to use for provisioning
        /// pipelines. Assumed by Proton for Amazon Web Services-managed provisioning, and by
        /// customer-owned automation for self-managed provisioning.
        /// </para>
        ///  
        /// <para>
        /// To remove a previously configured ARN, specify an empty string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string PipelineServiceRoleArn
        {
            get { return this._pipelineServiceRoleArn; }
            set { this._pipelineServiceRoleArn = value; }
        }

        // Check to see if PipelineServiceRoleArn property is set
        internal bool IsSetPipelineServiceRoleArn()
        {
            return this._pipelineServiceRoleArn != null;
        }

    }
}