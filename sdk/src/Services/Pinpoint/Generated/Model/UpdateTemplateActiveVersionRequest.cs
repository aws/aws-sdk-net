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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTemplateActiveVersion operation.
    /// Changes the status of a specific version of a message template to <i>active</i>.
    /// </summary>
    public partial class UpdateTemplateActiveVersionRequest : AmazonPinpointRequest
    {
        private TemplateActiveVersionRequest _templateActiveVersionRequest;
        private string _templateName;
        private string _templateType;

        /// <summary>
        /// Gets and sets the property TemplateActiveVersionRequest.
        /// </summary>
        [AWSProperty(Required=true)]
        public TemplateActiveVersionRequest TemplateActiveVersionRequest
        {
            get { return this._templateActiveVersionRequest; }
            set { this._templateActiveVersionRequest = value; }
        }

        // Check to see if TemplateActiveVersionRequest property is set
        internal bool IsSetTemplateActiveVersionRequest()
        {
            return this._templateActiveVersionRequest != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the message template. A template name must start with an alphanumeric
        /// character and can contain a maximum of 128 characters. The characters can be alphanumeric
        /// characters, underscores (_), or hyphens (-). Template names are case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The type of channel that the message template is designed for. Valid values are: EMAIL,
        /// PUSH, SMS, and VOICE.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TemplateType
        {
            get { return this._templateType; }
            set { this._templateType = value; }
        }

        // Check to see if TemplateType property is set
        internal bool IsSetTemplateType()
        {
            return this._templateType != null;
        }

    }
}