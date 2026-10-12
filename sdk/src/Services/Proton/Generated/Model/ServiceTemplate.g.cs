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
    /// Detailed data of an Proton service template resource.
    /// </summary>
    public partial class ServiceTemplate
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the service template was created.
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
        /// A description of the service template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The service template name as displayed in the developer interface.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The customer provided service template encryption key that's used to encrypt data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The time when the service template was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedAt property is set.
        /// </summary>
        internal bool IsSetLastModifiedAt() => this.LastModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PipelineProvisioning. 
        /// <para>
        /// If <c>pipelineProvisioning</c> is <c>true</c>, a service pipeline is included in the
        /// service template. Otherwise, a service pipeline <i>isn't</i> included in the service
        /// template.
        /// </para>
        /// </summary>
        public Provisioning PipelineProvisioning { get; set; }

        /// <summary>
        /// Checks to see if the PipelineProvisioning property is set.
        /// </summary>
        internal bool IsSetPipelineProvisioning() => this.PipelineProvisioning != null;

        /// <summary>
        /// Gets and sets the property RecommendedVersion. 
        /// <para>
        /// The recommended version of the service template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string RecommendedVersion { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedVersion property is set.
        /// </summary>
        internal bool IsSetRecommendedVersion() => this.RecommendedVersion != null;
    }
}
