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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeManagedJobTemplate operation.
    /// </summary>
    public partial class DescribeManagedJobTemplateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The unique description of a managed template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2028)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// The document schema for a managed job template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string Document { get; set; }

        /// <summary>
        /// Checks to see if the Document property is set.
        /// </summary>
        internal bool IsSetDocument() => this.Document != null;

        /// <summary>
        /// Gets and sets the property DocumentParameters. 
        /// <para>
        /// A map of key-value pairs that you can use as guidance to specify the inputs for creating
        /// a job from a managed template.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>documentParameters</c> can only be used when creating jobs from Amazon Web Services
        /// managed templates. This parameter can't be used with custom job templates or to create
        /// jobs from them.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentParameter> DocumentParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentParameter>() : null;

        /// <summary>
        /// Checks to see if the DocumentParameters property is set.
        /// </summary>
        internal bool IsSetDocumentParameters() => this.DocumentParameters != null && (this.DocumentParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Environments. 
        /// <para>
        /// A list of environments that are supported with the managed job template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Environments { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Environments property is set.
        /// </summary>
        internal bool IsSetEnvironments() => this.Environments != null && (this.Environments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) of the managed template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The unique name of a managed template, such as <c>AWS-Reboot</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property TemplateVersion. 
        /// <para>
        /// The version for a managed template.
        /// </para>
        /// </summary>
        public string TemplateVersion { get; set; }

        /// <summary>
        /// Checks to see if the TemplateVersion property is set.
        /// </summary>
        internal bool IsSetTemplateVersion() => this.TemplateVersion != null;
    }
}
