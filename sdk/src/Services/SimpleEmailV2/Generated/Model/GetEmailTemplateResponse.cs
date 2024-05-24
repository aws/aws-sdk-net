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
    /// The following element is returned by the service.
    /// </summary>
    public partial class GetEmailTemplateResponse : AmazonWebServiceResponse
    {
        private EmailTemplateContent _templateContent;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property TemplateContent. 
        /// <para>
        /// The content of the email template, composed of a subject line, an HTML part, and a
        /// text-only part.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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