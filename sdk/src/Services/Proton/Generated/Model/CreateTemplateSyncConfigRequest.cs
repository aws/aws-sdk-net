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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTemplateSyncConfig operation.
    /// Set up a template to create new template versions automatically by tracking a linked
    /// repository. A linked repository is a repository that has been registered with Proton.
    /// For more information, see <a>CreateRepository</a>.
    /// 
    ///  
    /// <para>
    /// When a commit is pushed to your linked repository, Proton checks for changes to your
    /// repository template bundles. If it detects a template bundle change, a new major or
    /// minor version of its template is created, if the version doesn’t already exist. For
    /// more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-template-sync-configs.html">Template
    /// sync configurations</a> in the <i>Proton User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateTemplateSyncConfigRequest : AmazonProtonRequest
    {
        private string _branch;
        private string _repositoryName;
        private RepositoryProvider _repositoryProvider;
        private string _subdirectory;
        private string _templateName;
        private TemplateType _templateType;

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The repository branch for your template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string Branch
        {
            get { return this._branch; }
            set { this._branch = value; }
        }

        // Check to see if Branch property is set
        internal bool IsSetBranch()
        {
            return this._branch != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository name (for example, <c>myrepos/myrepo</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property RepositoryProvider. 
        /// <para>
        /// The provider type for your repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RepositoryProvider RepositoryProvider
        {
            get { return this._repositoryProvider; }
            set { this._repositoryProvider = value; }
        }

        // Check to see if RepositoryProvider property is set
        internal bool IsSetRepositoryProvider()
        {
            return this._repositoryProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// A repository subdirectory path to your template bundle directory. When included, Proton
        /// limits the template bundle search to this repository directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Subdirectory
        {
            get { return this._subdirectory; }
            set { this._subdirectory = value; }
        }

        // Check to see if Subdirectory property is set
        internal bool IsSetSubdirectory()
        {
            return this._subdirectory != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of your registered template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The type of the registered template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TemplateType TemplateType
        {
            get { return this._templateType; }
            set { this._templateType = value; }
        }

        // Check to see if TemplateType property is set
        internal bool IsSetTemplateType()
        {
            return this._templateType != null;
        }

    }
}