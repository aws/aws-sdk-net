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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateComponent operation. Create an Proton component.
    /// A component is an infrastructure extension for a service instance. <para> For more
    /// information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
    /// components</a> in the <i>Proton User Guide</i>. </para>
    /// </summary>
    public partial class CreateComponentRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token for the created component.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional customer-provided description of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the Proton environment that you want to associate this component with.
        /// You must specify this when you don't specify <c>serviceInstanceName</c> and <c>serviceName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property Manifest. 
        /// <para>
        /// A path to a manifest file that lists the Infrastructure as Code (IaC) file, template
        /// language, and rendering engine for infrastructure that a custom component provisions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1024)]
        public string Manifest { get; set; }

        /// <summary>
        /// Checks to see if the Manifest property is set.
        /// </summary>
        internal bool IsSetManifest() => this.Manifest != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The customer-provided name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of the service instance that you want to attach this component to. If you
        /// don't specify this, the component isn't attached to any service instance. Specify
        /// both <c>serviceInstanceName</c> and <c>serviceName</c> or neither of them.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ServiceInstanceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceInstanceName property is set.
        /// </summary>
        internal bool IsSetServiceInstanceName() => this.ServiceInstanceName != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that <c>serviceInstanceName</c> is associated with. If you
        /// don't specify this, the component isn't attached to any service instance. Specify
        /// both <c>serviceInstanceName</c> and <c>serviceName</c> or neither of them.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ServiceSpec. 
        /// <para>
        /// The service spec that you want the component to use to access service inputs. Set
        /// this only when you attach the component to a service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 51200)]
        public string ServiceSpec { get; set; }

        /// <summary>
        /// Checks to see if the ServiceSpec property is set.
        /// </summary>
        internal bool IsSetServiceSpec() => this.ServiceSpec != null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 51200)]
        public string TemplateFile { get; set; }

        /// <summary>
        /// Checks to see if the TemplateFile property is set.
        /// </summary>
        internal bool IsSetTemplateFile() => this.TemplateFile != null;
    }
}
