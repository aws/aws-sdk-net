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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Specifies the mapping template for the transformer. This template is used to map the
    /// parsed EDI file using JSONata or XSLT.
    /// </summary>
    public partial class Mapping
    {
        private string _template;
        private MappingTemplateLanguage _templateLanguage;

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// A string that represents the mapping template, in the transformation language specified
        /// in <c>templateLanguage</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=350000)]
        public string Template
        {
            get { return this._template; }
            set { this._template = value; }
        }

        // Check to see if Template property is set
        internal bool IsSetTemplate()
        {
            return this._template != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateLanguage. 
        /// <para>
        /// The transformation language for the template, either XSLT or JSONATA.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MappingTemplateLanguage TemplateLanguage
        {
            get { return this._templateLanguage; }
            set { this._templateLanguage = value; }
        }

        // Check to see if TemplateLanguage property is set
        internal bool IsSetTemplateLanguage()
        {
            return this._templateLanguage != null;
        }

    }
}