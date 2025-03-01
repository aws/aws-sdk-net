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
    /// Describes a request to activate or deactivate the role that you can use to grant an
    /// Amazon Lightsail container service access to Amazon Elastic Container Registry (Amazon
    /// ECR) private repositories.
    /// 
    ///  
    /// <para>
    /// When activated, Lightsail creates an Identity and Access Management (IAM) role for
    /// the specified Lightsail container service. You can use the ARN of the role to create
    /// a trust relationship between your Lightsail container service and an Amazon ECR private
    /// repository in your Amazon Web Services account. This allows your container service
    /// to pull images from Amazon ECR private repositories. For more information, see <a
    /// href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-container-service-ecr-private-repo-access">Configuring
    /// access to an Amazon ECR private repository for an Amazon Lightsail container service</a>
    /// in the <i>Amazon Lightsail Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ContainerServiceECRImagePullerRoleRequest
    {
        private bool? _isActive;

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// A Boolean value that indicates whether to activate the role.
        /// </para>
        /// </summary>
        public bool? IsActive
        {
            get { return this._isActive; }
            set { this._isActive = value; }
        }

        // Check to see if IsActive property is set
        internal bool IsSetIsActive()
        {
            return this._isActive.HasValue; 
        }

    }
}