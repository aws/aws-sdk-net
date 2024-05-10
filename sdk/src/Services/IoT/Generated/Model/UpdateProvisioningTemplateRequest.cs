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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
    /// Container for the parameters to the UpdateProvisioningTemplate operation.
    /// Updates a provisioning template.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateProvisioningTemplate</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateProvisioningTemplateRequest : AmazonIoTRequest
    {
        private int? _defaultVersionId;
        private string _description;
        private bool? _enabled;
        private ProvisioningHook _preProvisioningHook;
        private string _provisioningRoleArn;
        private bool? _removePreProvisioningHook;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property DefaultVersionId. 
        /// <para>
        /// The ID of the default provisioning template version.
        /// </para>
        /// </summary>
        public int? DefaultVersionId
        {
            get { return this._defaultVersionId; }
            set { this._defaultVersionId = value; }
        }

        // Check to see if DefaultVersionId property is set
        internal bool IsSetDefaultVersionId()
        {
            return this._defaultVersionId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the provisioning template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// Gets and sets the property Enabled. 
        /// <para>
        /// True to enable the provisioning template, otherwise false.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreProvisioningHook. 
        /// <para>
        /// Updates the pre-provisioning hook template. Only supports template of type <c>FLEET_PROVISIONING</c>.
        /// For more information about provisioning template types, see <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_CreateProvisioningTemplate.html#iot-CreateProvisioningTemplate-request-type">type</a>.
        /// </para>
        /// </summary>
        public ProvisioningHook PreProvisioningHook
        {
            get { return this._preProvisioningHook; }
            set { this._preProvisioningHook = value; }
        }

        // Check to see if PreProvisioningHook property is set
        internal bool IsSetPreProvisioningHook()
        {
            return this._preProvisioningHook != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningRoleArn. 
        /// <para>
        /// The ARN of the role associated with the provisioning template. This IoT role grants
        /// permission to provision a device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ProvisioningRoleArn
        {
            get { return this._provisioningRoleArn; }
            set { this._provisioningRoleArn = value; }
        }

        // Check to see if ProvisioningRoleArn property is set
        internal bool IsSetProvisioningRoleArn()
        {
            return this._provisioningRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RemovePreProvisioningHook. 
        /// <para>
        /// Removes pre-provisioning hook template.
        /// </para>
        /// </summary>
        public bool? RemovePreProvisioningHook
        {
            get { return this._removePreProvisioningHook; }
            set { this._removePreProvisioningHook = value; }
        }

        // Check to see if RemovePreProvisioningHook property is set
        internal bool IsSetRemovePreProvisioningHook()
        {
            return this._removePreProvisioningHook.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the provisioning template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}