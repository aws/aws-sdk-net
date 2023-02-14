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
    /// Container for the parameters to the CreateComponent operation.
    /// Create an Proton component. A component is an infrastructure extension for a service
    /// instance.
    /// 
    ///  
    /// <para>
    /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
    /// components</a> in the <i>Proton User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateComponentRequest : AmazonProtonRequest
    {
        private string _description;
        private string _environmentName;
        private string _manifest;
        private string _name;
        private string _serviceInstanceName;
        private string _serviceName;
        private string _serviceSpec;
        private List<Tag> _tags = new List<Tag>();
        private string _templateFile;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional customer-provided description of the component.
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
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the Proton environment that you want to associate this component with.
        /// You must specify this when you don't specify <code>serviceInstanceName</code> and
        /// <code>serviceName</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property Manifest. 
        /// <para>
        /// A path to a manifest file that lists the Infrastructure as Code (IaC) file, template
        /// language, and rendering engine for infrastructure that a custom component provisions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string Manifest
        {
            get { return this._manifest; }
            set { this._manifest = value; }
        }

        // Check to see if Manifest property is set
        internal bool IsSetManifest()
        {
            return this._manifest != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The customer-provided name of the component.
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
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of the service instance that you want to attach this component to. If you
        /// don't specify this, the component isn't attached to any service instance. Specify
        /// both <code>serviceInstanceName</code> and <code>serviceName</code> or neither of them.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ServiceInstanceName
        {
            get { return this._serviceInstanceName; }
            set { this._serviceInstanceName = value; }
        }

        // Check to see if ServiceInstanceName property is set
        internal bool IsSetServiceInstanceName()
        {
            return this._serviceInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that <code>serviceInstanceName</code> is associated with.
        /// If you don't specify this, the component isn't attached to any service instance. Specify
        /// both <code>serviceInstanceName</code> and <code>serviceName</code> or neither of them.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceSpec. 
        /// <para>
        /// The service spec that you want the component to use to access service inputs. Set
        /// this only when you attach the component to a service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=51200)]
        public string ServiceSpec
        {
            get { return this._serviceSpec; }
            set { this._serviceSpec = value; }
        }

        // Check to see if ServiceSpec property is set
        internal bool IsSetServiceSpec()
        {
            return this._serviceSpec != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of metadata items that you can associate with the Proton component.
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
        /// Gets and sets the property TemplateFile. 
        /// <para>
        /// A path to the Infrastructure as Code (IaC) file describing infrastructure that a custom
        /// component provisions.
        /// </para>
        ///  <note> 
        /// <para>
        /// Components support a single IaC file, even if you use Terraform as your template language.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=51200)]
        public string TemplateFile
        {
            get { return this._templateFile; }
            set { this._templateFile = value; }
        }

        // Check to see if TemplateFile property is set
        internal bool IsSetTemplateFile()
        {
            return this._templateFile != null;
        }

    }
}