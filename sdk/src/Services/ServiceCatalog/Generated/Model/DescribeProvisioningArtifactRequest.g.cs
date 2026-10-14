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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeProvisioningArtifact operation. Gets information
    /// about the specified provisioning artifact (also known as a version) for the specified
    /// product.
    /// </summary>
    public partial class DescribeProvisioningArtifactRequest : AmazonServiceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>jp</c> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh</c> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Checks to see if the AcceptLanguage property is set.
        /// </summary>
        internal bool IsSetAcceptLanguage() => this.AcceptLanguage != null;

        /// <summary>
        /// Gets and sets the property IncludeProvisioningArtifactParameters. 
        /// <para>
        /// Indicates if the API call response does or does not include additional details about
        /// the provisioning parameters. 
        /// </para>
        /// </summary>
        public bool? IncludeProvisioningArtifactParameters { get; set; }

        /// <summary>
        /// Checks to see if the IncludeProvisioningArtifactParameters property is set.
        /// </summary>
        internal bool IsSetIncludeProvisioningArtifactParameters() => this.IncludeProvisioningArtifactParameters.HasValue;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The product name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8191)]
        public string ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The identifier of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ProvisioningArtifactId { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningArtifactId property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifactId() => this.ProvisioningArtifactId != null;

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactName. 
        /// <para>
        /// The provisioning artifact name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string ProvisioningArtifactName { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningArtifactName property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifactName() => this.ProvisioningArtifactName != null;

        /// <summary>
        /// Gets and sets the property Verbose. 
        /// <para>
        /// Indicates whether a verbose level of detail is enabled.
        /// </para>
        /// </summary>
        public bool? Verbose { get; set; }

        /// <summary>
        /// Checks to see if the Verbose property is set.
        /// </summary>
        internal bool IsSetVerbose() => this.Verbose.HasValue;
    }
}
