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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This API allows you to create a conformance pack template with an Amazon Web Services
    /// Systems Manager document (SSM document). To deploy a conformance pack using an SSM
    /// document, first create an SSM document with conformance pack content, and then provide
    /// the <c>DocumentName</c> in the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_PutConformancePack.html">PutConformancePack
    /// API</a>. You can also provide the <c>DocumentVersion</c>.
    /// 
    ///  
    /// <para>
    /// The <c>TemplateSSMDocumentDetails</c> object contains the name of the SSM document
    /// and the version of the SSM document.
    /// </para>
    /// </summary>
    public partial class TemplateSSMDocumentDetails
    {
        private string _documentName;
        private string _documentVersion;

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the SSM document to use to create a conformance
        /// pack. If you use the document name, Config checks only your account and Amazon Web
        /// Services Region for the SSM document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of the SSM document to use to create a conformance pack. By default, Config
        /// uses the latest version.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is optional.
        /// </para>
        ///  </note>
        /// </summary>
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
        }

    }
}