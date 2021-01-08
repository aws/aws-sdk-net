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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that defines the email template to use for an email message, and the values
    /// to use for any message variables in that template. An <i>email template</i> is a type
    /// of message template that contains content that you want to define, save, and reuse
    /// in email messages that you send.
    /// </summary>
    public partial class Template
    {
        private string _templateArn;
        private string _templateData;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the template.
        /// </para>
        /// </summary>
        public string TemplateArn
        {
            get { return this._templateArn; }
            set { this._templateArn = value; }
        }

        // Check to see if TemplateArn property is set
        internal bool IsSetTemplateArn()
        {
            return this._templateArn != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateData. 
        /// <para>
        /// An object that defines the values to use for message variables in the template. This
        /// object is a set of key-value pairs. Each key defines a message variable in the template.
        /// The corresponding value defines the value to use for that variable.
        /// </para>
        /// </summary>
        [AWSProperty(Max=262144)]
        public string TemplateData
        {
            get { return this._templateData; }
            set { this._templateData = value; }
        }

        // Check to see if TemplateData property is set
        internal bool IsSetTemplateData()
        {
            return this._templateData != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the template. You will refer to this name when you send email using the
        /// <code>SendTemplatedEmail</code> or <code>SendBulkTemplatedEmail</code> operations.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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