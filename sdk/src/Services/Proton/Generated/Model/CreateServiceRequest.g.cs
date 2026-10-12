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
    /// Container for the parameters to the CreateService operation. Create an Proton service.
    /// An Proton service is an instantiation of a service template and often includes several
    /// service instances and pipeline. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-services.html">Services</a>
    /// in the <i>Proton User Guide</i>.
    /// </summary>
    public partial class CreateServiceRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The name of the code repository branch that holds the code that's deployed in Proton.
        /// <i>Don't</i> include this parameter if your service template <i>doesn't</i> include
        /// a service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string BranchName { get; set; }

        /// <summary>
        /// Checks to see if the BranchName property is set.
        /// </summary>
        internal bool IsSetBranchName() => this.BranchName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the Proton service.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The service name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RepositoryConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the repository connection. For more information,
        /// see <a href="https://docs.aws.amazon.com/proton/latest/userguide/setting-up-for-service.html#setting-up-vcontrol">Setting
        /// up an AWS CodeStar connection</a> in the <i>Proton User Guide</i>. <i>Don't</i> include
        /// this parameter if your service template <i>doesn't</i> include a service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string RepositoryConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryConnectionArn property is set.
        /// </summary>
        internal bool IsSetRepositoryConnectionArn() => this.RepositoryConnectionArn != null;

        /// <summary>
        /// Gets and sets the property RepositoryId. 
        /// <para>
        /// The ID of the code repository. <i>Don't</i> include this parameter if your service
        /// template <i>doesn't</i> include a service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string RepositoryId { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryId property is set.
        /// </summary>
        internal bool IsSetRepositoryId() => this.RepositoryId != null;

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
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 51200)]
        public string Spec { get; set; }

        /// <summary>
        /// Checks to see if the Spec property is set.
        /// </summary>
        internal bool IsSetSpec() => this.Spec != null;

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
        /// Gets and sets the property TemplateMajorVersion. 
        /// <para>
        /// The major version of the service template that was used to create the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string TemplateMajorVersion { get; set; }

        /// <summary>
        /// Checks to see if the TemplateMajorVersion property is set.
        /// </summary>
        internal bool IsSetTemplateMajorVersion() => this.TemplateMajorVersion != null;

        /// <summary>
        /// Gets and sets the property TemplateMinorVersion. 
        /// <para>
        /// The minor version of the service template that was used to create the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string TemplateMinorVersion { get; set; }

        /// <summary>
        /// Checks to see if the TemplateMinorVersion property is set.
        /// </summary>
        internal bool IsSetTemplateMinorVersion() => this.TemplateMinorVersion != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the service template that's used to create the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;
    }
}
