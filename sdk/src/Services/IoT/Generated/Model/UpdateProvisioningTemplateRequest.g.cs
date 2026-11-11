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
    /// Container for the parameters to the UpdateProvisioningTemplate operation. Updates
    /// a provisioning template. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateProvisioningTemplate</a>
    /// action. </para>
    /// </summary>
    public partial class UpdateProvisioningTemplateRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property DefaultVersionId. 
        /// <para>
        /// The ID of the default provisioning template version.
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
        /// True to enable the provisioning template, otherwise false.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property PreProvisioningHook. 
        /// <para>
        /// Updates the pre-provisioning hook template. Only supports template of type <c>FLEET_PROVISIONING</c>.
        /// For more information about provisioning template types, see <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_CreateProvisioningTemplate.html#iot-CreateProvisioningTemplate-request-type">type</a>.
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
        /// Gets and sets the property RemovePreProvisioningHook. 
        /// <para>
        /// Removes pre-provisioning hook template.
        /// </para>
        /// </summary>
        public bool? RemovePreProvisioningHook { get; set; }

        /// <summary>
        /// Checks to see if the RemovePreProvisioningHook property is set.
        /// </summary>
        internal bool IsSetRemovePreProvisioningHook() => this.RemovePreProvisioningHook.HasValue;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the provisioning template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;
    }
}
