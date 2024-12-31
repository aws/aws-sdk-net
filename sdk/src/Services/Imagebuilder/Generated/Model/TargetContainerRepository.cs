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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// The container repository where the output container image is stored.
    /// </summary>
    public partial class TargetContainerRepository
    {
        private string _repositoryName;
        private ContainerRepositoryService _service;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the container repository where the output container image is stored. This
        /// name is prefixed by the repository location. For example, <c>&lt;repository location
        /// url&gt;/repository_name</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// Specifies the service in which this image was registered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerRepositoryService Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

    }
}