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
    /// This is the response object from the DescribeProvisioningTemplate operation.
    /// </summary>
    public partial class DescribeProvisioningTemplateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date when the provisioning template was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultVersionId. 
        /// <para>
        /// The default fleet template version ID.
        /// </para>
        /// </summary>
        public int? DefaultVersionId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultVersionId property is set.
        /// </summary>
        internal bool IsSetDefaultVersionId() => this.DefaultVersionId.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the provisioning template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// True if the provisioning template is enabled, otherwise false.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the provisioning template was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property PreProvisioningHook. 
        /// <para>
        /// Gets information about a pre-provisioned hook.
        /// </para>
        /// </summary>
        public ProvisioningHook PreProvisioningHook { get; set; }

        /// <summary>
        /// Checks to see if the PreProvisioningHook property is set.
        /// </summary>
        internal bool IsSetPreProvisioningHook() => this.PreProvisioningHook != null;

        /// <summary>
        /// Gets and sets the property ProvisioningRoleArn. 
        /// <para>
        /// The ARN of the role associated with the provisioning template. This IoT role grants
        /// permission to provision a device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ProvisioningRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningRoleArn property is set.
        /// </summary>
        internal bool IsSetProvisioningRoleArn() => this.ProvisioningRoleArn != null;

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The ARN of the provisioning template.
        /// </para>
        /// </summary>
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The JSON formatted contents of the provisioning template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10240)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// Checks to see if the TemplateBody property is set.
        /// </summary>
        internal bool IsSetTemplateBody() => this.TemplateBody != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the provisioning template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type you define in a provisioning template. You can create a template with only
        /// one type. You can't change the template type after its creation. The default value
        /// is <c>FLEET_PROVISIONING</c>. For more information about provisioning template, see:
        /// <a href="https://docs.aws.amazon.com/iot/latest/developerguide/provision-template.html">Provisioning
        /// template</a>. 
        /// </para>
        /// </summary>
        public TemplateType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
