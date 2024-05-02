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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the TestRenderTemplate operation.
    /// Creates a preview of the MIME content of an email when provided with a template and
    /// a set of replacement data.
    /// 
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class TestRenderTemplateRequest : AmazonSimpleEmailServiceRequest
    {
        private string _templateData;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property TemplateData. 
        /// <para>
        /// A list of replacement values to apply to the template. This parameter is a JSON object,
        /// typically consisting of key-value pairs in which the keys correspond to replacement
        /// tags in the email template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=262144)]
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
        /// The name of the template to render.
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

    }
}