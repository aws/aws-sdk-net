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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// This is the response object from the CreateRepositoryCreationTemplate operation.
    /// </summary>
    public partial class CreateRepositoryCreationTemplateResponse : AmazonWebServiceResponse
    {
        private string _registryId;
        private RepositoryCreationTemplate _repositoryCreationTemplate;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The registry ID associated with the request.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryCreationTemplate. 
        /// <para>
        /// The details of the repository creation template associated with the request.
        /// </para>
        /// </summary>
        public RepositoryCreationTemplate RepositoryCreationTemplate
        {
            get { return this._repositoryCreationTemplate; }
            set { this._repositoryCreationTemplate = value; }
        }

        // Check to see if RepositoryCreationTemplate property is set
        internal bool IsSetRepositoryCreationTemplate()
        {
            return this._repositoryCreationTemplate != null;
        }

    }
}