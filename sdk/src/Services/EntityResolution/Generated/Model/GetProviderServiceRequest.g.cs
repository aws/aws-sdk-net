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
    /// Container for the parameters to the GetProviderService operation. Returns the <c>ProviderService</c>
    /// of a given name.
    /// </summary>
    public partial class GetProviderServiceRequest : AmazonEntityResolutionRequest
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
        /// Gets and sets the property ProviderServiceName. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the product that the provider service provides.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 255)]
        public string ProviderServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderServiceName property is set.
        /// </summary>
        internal bool IsSetProviderServiceName() => this.ProviderServiceName != null;
    }
}
