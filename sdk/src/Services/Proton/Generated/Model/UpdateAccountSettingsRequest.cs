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
    /// Update the Proton service pipeline role or repository settings.
    /// </summary>
    public partial class UpdateAccountSettingsRequest : AmazonProtonRequest
    {
        private RepositoryBranchInput _pipelineProvisioningRepository;
        private string _pipelineServiceRoleArn;

        /// <summary>
        /// Gets and sets the property PipelineProvisioningRepository. 
        /// <para>
        /// The repository that you provide with pull request provisioning.
        /// </para>
        ///  <important> 
        /// <para>
        /// Provisioning by pull request is currently in feature preview and is only usable with
        /// Terraform based Proton Templates. To learn more about <a href="https://aws.amazon.com/service-terms">Amazon
        /// Web Services Feature Preview terms</a>, see section 2 on Beta and Previews.
        /// </para>
        ///  </important>
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
        /// The Amazon Resource Name (ARN) of the Proton pipeline service role.
        /// </para>
        ///  <important> 
        /// <para>
        /// Provisioning by pull request is currently in feature preview and is only usable with
        /// Terraform based Proton Templates. To learn more about <a href="https://aws.amazon.com/service-terms">Amazon
        /// Web Services Feature Preview terms</a>, see section 2 on Beta and Previews.
        /// </para>
        ///  </important>
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