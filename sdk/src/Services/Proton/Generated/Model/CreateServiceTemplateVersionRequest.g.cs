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
    /// Container for the parameters to the CreateServiceTemplateVersion operation. Create
    /// a new major or minor version of a service template. A major version of a service template
    /// is a version that <i>isn't</i> backward compatible. A minor version of a service template
    /// is a version that's backward compatible within its major version.
    /// </summary>
    public partial class CreateServiceTemplateVersionRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// When included, if two identical requests are made with the same client token, Proton
        /// returns the service template version that the first request created.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CompatibleEnvironmentTemplates. 
        /// <para>
        /// An array of environment template objects that are compatible with the new service
        /// template version. A service instance based on this service template version can run
        /// in environments based on compatible templates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<CompatibleEnvironmentTemplateInput> CompatibleEnvironmentTemplates { get; set; } = AWSConfigs.InitializeCollections ? new List<CompatibleEnvironmentTemplateInput>() : null;

        /// <summary>
        /// Checks to see if the CompatibleEnvironmentTemplates property is set.
        /// </summary>
        internal bool IsSetCompatibleEnvironmentTemplates() => this.CompatibleEnvironmentTemplates != null && (this.CompatibleEnvironmentTemplates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the new version of a service template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MajorVersion. 
        /// <para>
        /// To create a new minor version of the service template, include a <c>major Version</c>.
        /// </para>
        ///  
        /// <para>
        /// To create a new major and minor version of the service template, <i>exclude</i> <c>major
        /// Version</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string MajorVersion { get; set; }

        /// <summary>
        /// Checks to see if the MajorVersion property is set.
        /// </summary>
        internal bool IsSetMajorVersion() => this.MajorVersion != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// An object that includes the template bundle S3 bucket path and name for the new version
        /// of a service template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TemplateVersionSourceInput Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SupportedComponentSources. 
        /// <para>
        /// An array of supported component sources. Components with supported sources can be
        /// attached to service instances based on this service template version.
        /// </para>
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedComponentSources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedComponentSources property is set.
        /// </summary>
        internal bool IsSetSupportedComponentSources() => this.SupportedComponentSources != null && (this.SupportedComponentSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of metadata items that you can associate with the Proton service
        /// template version. A tag is a key-value pair.
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
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the service template.
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
