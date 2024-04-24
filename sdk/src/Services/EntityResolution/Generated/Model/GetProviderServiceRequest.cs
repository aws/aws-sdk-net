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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the GetProviderService operation.
    /// Returns the <c>ProviderService</c> of a given name.
    /// </summary>
    public partial class GetProviderServiceRequest : AmazonEntityResolutionRequest
    {
        private string _providerName;
        private string _providerServiceName;

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the provider. This name is typically the company name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderServiceName. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the product that the provider service provides.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=255)]
        public string ProviderServiceName
        {
            get { return this._providerServiceName; }
            set { this._providerServiceName = value; }
        }

        // Check to see if ProviderServiceName property is set
        internal bool IsSetProviderServiceName()
        {
            return this._providerServiceName != null;
        }

    }
}