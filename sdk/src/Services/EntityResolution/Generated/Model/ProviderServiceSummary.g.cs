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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// A list of <c>ProviderService</c> objects, each of which contain the fields <c>providerName</c>,
    /// <c>providerServiceArn</c>, <c>providerServiceName</c>, and <c>providerServiceType</c>.
    /// </summary>
    public partial class ProviderServiceSummary
    {
        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the provider. This name is typically the company name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderName property is set.
        /// </summary>
        internal bool IsSetProviderName() => this.ProviderName != null;

        /// <summary>
        /// Gets and sets the property ProviderServiceArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) that Entity Resolution generated for the <c>providerService</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 255)]
        public string ProviderServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ProviderServiceArn property is set.
        /// </summary>
        internal bool IsSetProviderServiceArn() => this.ProviderServiceArn != null;

        /// <summary>
        /// Gets and sets the property ProviderServiceDisplayName. 
        /// <para>
        /// The display name of the provider service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 255)]
        public string ProviderServiceDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderServiceDisplayName property is set.
        /// </summary>
        internal bool IsSetProviderServiceDisplayName() => this.ProviderServiceDisplayName != null;

        /// <summary>
        /// Gets and sets the property ProviderServiceName. 
        /// <para>
        /// The name of the product that the provider service provides.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProviderServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderServiceName property is set.
        /// </summary>
        internal bool IsSetProviderServiceName() => this.ProviderServiceName != null;

        /// <summary>
        /// Gets and sets the property ProviderServiceType. 
        /// <para>
        /// The type of provider service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceType ProviderServiceType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderServiceType property is set.
        /// </summary>
        internal bool IsSetProviderServiceType() => this.ProviderServiceType != null;
    }
}
