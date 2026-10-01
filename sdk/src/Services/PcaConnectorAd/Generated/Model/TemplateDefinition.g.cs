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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Template configuration to define the information included in certificates. Define
    /// certificate validity and renewal periods, certificate request handling and enrollment
    /// options, key usage extensions, application policies, and cryptography settings.
    /// </summary>
    public partial class TemplateDefinition
    {
        /// <summary>
        /// Gets and sets the property TemplateV2. 
        /// <para>
        /// Template configuration to define the information included in certificates. Define
        /// certificate validity and renewal periods, certificate request handling and enrollment
        /// options, key usage extensions, application policies, and cryptography settings.
        /// </para>
        /// </summary>
        public TemplateV2 TemplateV2 { get; set; }

        /// <summary>
        /// Checks to see if the TemplateV2 property is set.
        /// </summary>
        internal bool IsSetTemplateV2() => this.TemplateV2 != null;

        /// <summary>
        /// Gets and sets the property TemplateV3. 
        /// <para>
        /// Template configuration to define the information included in certificates. Define
        /// certificate validity and renewal periods, certificate request handling and enrollment
        /// options, key usage extensions, application policies, and cryptography settings.
        /// </para>
        /// </summary>
        public TemplateV3 TemplateV3 { get; set; }

        /// <summary>
        /// Checks to see if the TemplateV3 property is set.
        /// </summary>
        internal bool IsSetTemplateV3() => this.TemplateV3 != null;

        /// <summary>
        /// Gets and sets the property TemplateV4. 
        /// <para>
        /// Template configuration to define the information included in certificates. Define
        /// certificate validity and renewal periods, certificate request handling and enrollment
        /// options, key usage extensions, application policies, and cryptography settings.
        /// </para>
        /// </summary>
        public TemplateV4 TemplateV4 { get; set; }

        /// <summary>
        /// Checks to see if the TemplateV4 property is set.
        /// </summary>
        internal bool IsSetTemplateV4() => this.TemplateV4 != null;
    }
}
