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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides a template for the configuration information to connect to your data source.
    /// </summary>
    public partial class TemplateConfiguration
    {
        private Amazon.Runtime.Documents.Document _template;

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// The template schema used for the data source, where templates schemas are supported.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/kendra/latest/dg/ds-schemas.html">Data source
        /// template schemas</a>.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Template
        {
            get { return this._template; }
            set { this._template = value; }
        }

        // Check to see if Template property is set
        internal bool IsSetTemplate()
        {
            return !this._template.IsNull();
        }

    }
}