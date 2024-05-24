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
    /// This is the response object from the TestRenderTemplate operation.
    /// </summary>
    public partial class TestRenderTemplateResponse : AmazonWebServiceResponse
    {
        private string _renderedTemplate;

        /// <summary>
        /// Gets and sets the property RenderedTemplate. 
        /// <para>
        /// The complete MIME message rendered by applying the data in the TemplateData parameter
        /// to the template specified in the TemplateName parameter.
        /// </para>
        /// </summary>
        public string RenderedTemplate
        {
            get { return this._renderedTemplate; }
            set { this._renderedTemplate = value; }
        }

        // Check to see if RenderedTemplate property is set
        internal bool IsSetRenderedTemplate()
        {
            return this._renderedTemplate != null;
        }

    }
}