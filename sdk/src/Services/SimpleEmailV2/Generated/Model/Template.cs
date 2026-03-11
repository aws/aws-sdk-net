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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that defines the email template to use for an email message, and the values
    /// to use for any message variables in that template. An <i>email template</i> is a type
    /// of message template that contains content that you want to reuse in email messages
    /// that you send. You can specifiy the email template by providing the name or ARN of
    /// an <i>email template</i> previously saved in your Amazon SES account or by providing
    /// the full template content.
    /// </summary>
    public partial class Template
    {
        private List<Attachment> _attachments = AWSConfigs.InitializeCollections ? new List<Attachment>() : null;
        private List<MessageHeader> _headers = AWSConfigs.InitializeCollections ? new List<MessageHeader>() : null;
        private string _templateArn;
        private EmailTemplateContent _templateContent;
        private string _templateData;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        ///  The List of attachments to include in your email. All recipients will receive the
        /// same attachments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attachment> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && (this._attachments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// The list of message headers that will be added to the email message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public List<MessageHeader> Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null && (this._headers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property TemplateContent. 
        /// <para>
        /// The content of the template.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon SES supports only simple substitions when you send email using the <c>SendEmail</c>
        /// or <c>SendBulkEmail</c> operations and you provide the full template content in the
        /// request.
        /// </para>
        ///  </note>
        /// </summary>
        public EmailTemplateContent TemplateContent
        {
            get { return this._templateContent; }
            set { this._templateContent = value; }
        }

        // Check to see if TemplateContent property is set
        internal bool IsSetTemplateContent()
        {
            return this._templateContent != null;
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
        /// <c>SendEmail</c> or <c>SendBulkEmail</c> operations. 
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