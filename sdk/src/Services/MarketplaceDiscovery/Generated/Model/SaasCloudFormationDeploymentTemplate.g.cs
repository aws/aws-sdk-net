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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Contains a single AWS CloudFormation deployment template for a Software as a Service
    /// (SaaS) product.
    /// </summary>
    public partial class SaasCloudFormationDeploymentTemplate
    {
        /// <summary>
        /// Gets and sets the property DefaultStackName. 
        /// <para>
        /// The default CloudFormation stack name used when deploying this template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DefaultStackName { get; set; }

        /// <summary>
        /// Checks to see if the DefaultStackName property is set.
        /// </summary>
        internal bool IsSetDefaultStackName() => this.DefaultStackName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the deployment template.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IamPolicy. 
        /// <para>
        /// The AWS Identity and Access Management (IAM) policy that you need to deploy this template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 8192)]
        public string IamPolicy { get; set; }

        /// <summary>
        /// Checks to see if the IamPolicy property is set.
        /// </summary>
        internal bool IsSetIamPolicy() => this.IamPolicy != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The display name of the deployment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property TemplateUrl. 
        /// <para>
        /// The URL of the CloudFormation deployment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string TemplateUrl { get; set; }

        /// <summary>
        /// Checks to see if the TemplateUrl property is set.
        /// </summary>
        internal bool IsSetTemplateUrl() => this.TemplateUrl != null;
    }
}
