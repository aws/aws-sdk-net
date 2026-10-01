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
    /// Container for the parameters to the UpdateTemplate operation. Update template configuration
    /// to define the information included in certificates.
    /// </summary>
    public partial class UpdateTemplateRequest : AmazonPcaConnectorAdRequest
    {
        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// Template configuration to define the information included in certificates. Define
        /// certificate validity and renewal periods, certificate request handling and enrollment
        /// options, key usage extensions, application policies, and cryptography settings.
        /// </para>
        /// </summary>
        public TemplateDefinition Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property ReenrollAllCertificateHolders. 
        /// <para>
        /// This setting allows the major version of a template to be increased automatically.
        /// All members of Active Directory groups that are allowed to enroll with a template
        /// will receive a new certificate issued using that template.
        /// </para>
        /// </summary>
        public bool? ReenrollAllCertificateHolders { get; set; }

        /// <summary>
        /// Checks to see if the ReenrollAllCertificateHolders property is set.
        /// </summary>
        internal bool IsSetReenrollAllCertificateHolders() => this.ReenrollAllCertificateHolders.HasValue;

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that was returned when you called <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateTemplate.html">CreateTemplate</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 200)]
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;
    }
}
