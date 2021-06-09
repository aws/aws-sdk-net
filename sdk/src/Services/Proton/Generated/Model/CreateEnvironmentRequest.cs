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
    /// Container for the parameters to the CreateEnvironment operation.
    /// Deploy a new environment. An AWS Proton environment is created from an environment
    /// template that defines infrastructure and resources that can be shared across services.
    /// For more information, see the <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-environments.html">Environments</a>
    /// in the <i>AWS Proton Administration Guide.</i>
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonProtonRequest
    {
        private string _description;
        private string _environmentAccountConnectionId;
        private string _name;
        private string _protonServiceRoleArn;
        private string _spec;
        private List<Tag> _tags = new List<Tag>();
        private string _templateMajorVersion;
        private string _templateMinorVersion;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the environment that's being created and deployed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// Gets and sets the property EnvironmentAccountConnectionId. 
        /// <para>
        /// The ID of the environment account connection that you provide if you're provisioning
        /// your environment infrastructure resources to an environment account. You must include
        /// either the <code>environmentAccountConnectionId</code> or <code>protonServiceRoleArn</code>
        /// parameter and value. For more information, see <a href="proton/latest/adminguide/ag-env-account-connections.html">Environment
        /// account connections</a> in the <i>AWS Proton Administration guide</i>.
        /// </para>
        /// </summary>
        public string EnvironmentAccountConnectionId
        {
            get { return this._environmentAccountConnectionId; }
            set { this._environmentAccountConnectionId = value; }
        }

        // Check to see if EnvironmentAccountConnectionId property is set
        internal bool IsSetEnvironmentAccountConnectionId()
        {
            return this._environmentAccountConnectionId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment.
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
        /// Gets and sets the property ProtonServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Proton service role that allows AWS Proton
        /// to make calls to other services on your behalf. You must include either the <code>environmentAccountConnectionId</code>
        /// or <code>protonServiceRoleArn</code> parameter and value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ProtonServiceRoleArn
        {
            get { return this._protonServiceRoleArn; }
            set { this._protonServiceRoleArn = value; }
        }

        // Check to see if ProtonServiceRoleArn property is set
        internal bool IsSetProtonServiceRoleArn()
        {
            return this._protonServiceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// A link to a YAML formatted spec file that provides inputs as defined in the environment
        /// template bundle schema file. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-managing-environments.html">Environments</a>
        /// in the <i>AWS Proton Administration Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=51200)]
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
        /// Create tags for your environment. For more information, see <i>AWS Proton resources
        /// and tagging</i> in the <a href="https://docs.aws.amazon.com/proton/latest/adminguide/resources.html">AWS
        /// Proton Administration Guide</a> or <a href="https://docs.aws.amazon.com/proton/latest/userguide/resources.html">AWS
        /// Proton User Guide</a>.
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
        /// The ID of the major version of the environment template.
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
        /// The ID of the minor version of the environment template.
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
        /// The name of the environment template. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-env-templates.html">Environment
        /// Templates</a> in the <i>AWS Proton Administration Guide</i>.
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