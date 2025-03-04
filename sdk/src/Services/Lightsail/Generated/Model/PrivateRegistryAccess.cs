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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the configuration for an Amazon Lightsail container service to access private
    /// container image repositories, such as Amazon Elastic Container Registry (Amazon ECR)
    /// private repositories.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-container-service-ecr-private-repo-access">Configuring
    /// access to an Amazon ECR private repository for an Amazon Lightsail container service</a>
    /// in the <i>Amazon Lightsail Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class PrivateRegistryAccess
    {
        private ContainerServiceECRImagePullerRole _ecrImagePullerRole;

        /// <summary>
        /// Gets and sets the property EcrImagePullerRole. 
        /// <para>
        /// An object that describes the activation status of the role that you can use to grant
        /// a Lightsail container service access to Amazon ECR private repositories. If the role
        /// is activated, the Amazon Resource Name (ARN) of the role is also listed.
        /// </para>
        /// </summary>
        public ContainerServiceECRImagePullerRole EcrImagePullerRole
        {
            get { return this._ecrImagePullerRole; }
            set { this._ecrImagePullerRole = value; }
        }

        // Check to see if EcrImagePullerRole property is set
        internal bool IsSetEcrImagePullerRole()
        {
            return this._ecrImagePullerRole != null;
        }

    }
}