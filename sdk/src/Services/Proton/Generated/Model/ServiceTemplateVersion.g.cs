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
    /// Detailed data of an Proton service template version resource.
    /// </summary>
    public partial class ServiceTemplateVersion
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the version of a service template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CompatibleEnvironmentTemplates. 
        /// <para>
        /// An array of compatible environment template names for the major version of a service
        /// template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<CompatibleEnvironmentTemplate> CompatibleEnvironmentTemplates { get; set; } = AWSConfigs.InitializeCollections ? new List<CompatibleEnvironmentTemplate>() : null;

        /// <summary>
        /// Checks to see if the CompatibleEnvironmentTemplates property is set.
        /// </summary>
        internal bool IsSetCompatibleEnvironmentTemplates() => this.CompatibleEnvironmentTemplates != null && (this.CompatibleEnvironmentTemplates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the version of a service template was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the version of a service template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The time when the version of a service template was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedAt property is set.
        /// </summary>
        internal bool IsSetLastModifiedAt() => this.LastModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MajorVersion. 
        /// <para>
        /// The latest major version that's associated with the version of a service template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string MajorVersion { get; set; }

        /// <summary>
        /// Checks to see if the MajorVersion property is set.
        /// </summary>
        internal bool IsSetMajorVersion() => this.MajorVersion != null;

        /// <summary>
        /// Gets and sets the property MinorVersion. 
        /// <para>
        /// The minor version of a service template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string MinorVersion { get; set; }

        /// <summary>
        /// Checks to see if the MinorVersion property is set.
        /// </summary>
        internal bool IsSetMinorVersion() => this.MinorVersion != null;

        /// <summary>
        /// Gets and sets the property RecommendedMinorVersion. 
        /// <para>
        /// The recommended minor version of the service template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string RecommendedMinorVersion { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedMinorVersion property is set.
        /// </summary>
        internal bool IsSetRecommendedMinorVersion() => this.RecommendedMinorVersion != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema of the version of a service template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 51200)]
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The service template version status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TemplateVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A service template version status message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

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
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the version of a service template.
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
