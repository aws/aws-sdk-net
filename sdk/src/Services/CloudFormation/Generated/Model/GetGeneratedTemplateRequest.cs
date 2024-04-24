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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the GetGeneratedTemplate operation.
    /// Retrieves a generated template. If the template is in an <c>InProgress</c> or <c>Pending</c>
    /// status then the template returned will be the template when the template was last
    /// in a <c>Complete</c> status. If the template has not yet been in a <c>Complete</c>
    /// status then an empty template will be returned.
    /// </summary>
    public partial class GetGeneratedTemplateRequest : AmazonCloudFormationRequest
    {
        private TemplateFormat _format;
        private string _generatedTemplateName;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The language to use to retrieve for the generated template. Supported values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>JSON</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YAML</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TemplateFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property GeneratedTemplateName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the generated template. The format is <c>arn:${Partition}:cloudformation:${Region}:${Account}:generatedtemplate/${Id}</c>.
        /// For example, <c>arn:aws:cloudformation:<i>us-east-1</i>:<i>123456789012</i>:generatedtemplate/<i>2e8465c1-9a80-43ea-a3a3-4f2d692fe6dc</i>
        /// </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string GeneratedTemplateName
        {
            get { return this._generatedTemplateName; }
            set { this._generatedTemplateName = value; }
        }

        // Check to see if GeneratedTemplateName property is set
        internal bool IsSetGeneratedTemplateName()
        {
            return this._generatedTemplateName != null;
        }

    }
}