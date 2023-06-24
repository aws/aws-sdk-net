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
    /// Container for the parameters to the CreateService operation.
    /// Create an Proton service. An Proton service is an instantiation of a service template
    /// and often includes several service instances and pipeline. For more information, see
    /// <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-services.html">Services</a>
    /// in the <i>Proton User Guide</i>.
    /// </summary>
    public partial class CreateServiceRequest : AmazonProtonRequest
    {
        private string _branchName;
        private string _description;
        private string _name;
        private string _repositoryConnectionArn;
        private string _repositoryId;
        private string _spec;
        private List<Tag> _tags = new List<Tag>();
        private string _templateMajorVersion;
        private string _templateMinorVersion;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The name of the code repository branch that holds the code that's deployed in Proton.
        /// <i>Don't</i> include this parameter if your service template <i>doesn't</i> include
        /// a service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string BranchName
        {
            get { return this._branchName; }
            set { this._branchName = value; }
        }

        // Check to see if BranchName property is set
        internal bool IsSetBranchName()
        {
            return this._branchName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the Proton service.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The service name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the repository connection. For more information,
        /// see <a href="https://docs.aws.amazon.com/proton/latest/userguide/setting-up-for-service.html#setting-up-vcontrol">Setting
        /// up an AWS CodeStar connection</a> in the <i>Proton User Guide</i>. <i>Don't</i> include
        /// this parameter if your service template <i>doesn't</i> include a service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string RepositoryConnectionArn
        {
            get { return this._repositoryConnectionArn; }
            set { this._repositoryConnectionArn = value; }
        }

        // Check to see if RepositoryConnectionArn property is set
        internal bool IsSetRepositoryConnectionArn()
        {
            return this._repositoryConnectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryId. 
        /// <para>
        /// The ID of the code repository. <i>Don't</i> include this parameter if your service
        /// template <i>doesn't</i> include a service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string RepositoryId
        {
            get { return this._repositoryId; }
            set { this._repositoryId = value; }
        }

        // Check to see if RepositoryId property is set
        internal bool IsSetRepositoryId()
        {
            return this._repositoryId != null;
        }

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// A link to a spec file that provides inputs as defined in the service template bundle
        /// schema file. The spec file is in YAML format. <i>Don’t</i> include pipeline inputs
        /// in the spec if your service template <i>doesn’t</i> include a service pipeline. For
        /// more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-create-svc.html">Create
        /// a service</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=51200)]
        public string Spec
        {
            get { return this._spec; }
            set { this._spec = value; }
        }

        // Check to see if Spec property is set
        internal bool IsSetSpec()
        {
            return this._spec != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of metadata items that you can associate with the Proton service.
        /// A tag is a key-value pair.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/resources.html">Proton
        /// resources and tagging</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateMajorVersion. 
        /// <para>
        /// The major version of the service template that was used to create the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string TemplateMajorVersion
        {
            get { return this._templateMajorVersion; }
            set { this._templateMajorVersion = value; }
        }

        // Check to see if TemplateMajorVersion property is set
        internal bool IsSetTemplateMajorVersion()
        {
            return this._templateMajorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateMinorVersion. 
        /// <para>
        /// The minor version of the service template that was used to create the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string TemplateMinorVersion
        {
            get { return this._templateMinorVersion; }
            set { this._templateMinorVersion = value; }
        }

        // Check to see if TemplateMinorVersion property is set
        internal bool IsSetTemplateMinorVersion()
        {
            return this._templateMinorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the service template that's used to create the service.
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

    }
}