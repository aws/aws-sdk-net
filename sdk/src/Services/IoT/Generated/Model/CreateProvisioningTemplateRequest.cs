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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProvisioningTemplate operation.
    /// Creates a fleet provisioning template.
    /// </summary>
    public partial class CreateProvisioningTemplateRequest : AmazonIoTRequest
    {
        private string _description;
        private bool? _enabled;
        private ProvisioningHook _preProvisioningHook;
        private string _provisioningRoleArn;
        private List<Tag> _tags = new List<Tag>();
        private string _templateBody;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the fleet provisioning template.
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
        /// True to enable the fleet provisioning template, otherwise false.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
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
        /// Creates a pre-provisioning hook template.
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
        /// The role ARN for the role associated with the fleet provisioning template. This IoT
        /// role grants permission to provision a device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the fleet provisioning template.
        /// </para>
        ///  <note> 
        /// <para>
        /// For URI Request parameters use format: ...key1=value1&amp;key2=value2...
        /// </para>
        ///  
        /// <para>
        /// For the CLI command-line parameter use format: &amp;&amp;tags "key1=value1&amp;key2=value2..."
        /// </para>
        ///  
        /// <para>
        /// For the cli-input-json file use format: "tags": "key1=value1&amp;key2=value2..."
        /// </para>
        ///  </note>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The JSON formatted contents of the fleet provisioning template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the fleet provisioning template.
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