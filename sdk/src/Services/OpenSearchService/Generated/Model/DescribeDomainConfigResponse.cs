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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Contains the configuration information of the requested domain.
    /// </summary>
    public partial class DescribeDomainConfigResponse : AmazonWebServiceResponse
    {
        private DomainConfig _domainConfig;

        /// <summary>
        /// Gets and sets the property DomainConfig. 
        /// <para>
        /// Container for the configuration of the OpenSearch Service domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DomainConfig DomainConfig
        {
            get { return this._domainConfig; }
            set { this._domainConfig = value; }
        }

        // Check to see if DomainConfig property is set
        internal bool IsSetDomainConfig()
        {
            return this._domainConfig != null;
        }

    }
}