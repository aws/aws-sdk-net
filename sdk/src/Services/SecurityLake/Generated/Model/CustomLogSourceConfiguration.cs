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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// The configuration used for the third-party custom source.
    /// </summary>
    public partial class CustomLogSourceConfiguration
    {
        private CustomLogSourceCrawlerConfiguration _crawlerConfiguration;
        private AwsIdentity _providerIdentity;

        /// <summary>
        /// Gets and sets the property CrawlerConfiguration. 
        /// <para>
        /// The configuration used for the Glue Crawler for a third-party custom source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomLogSourceCrawlerConfiguration CrawlerConfiguration
        {
            get { return this._crawlerConfiguration; }
            set { this._crawlerConfiguration = value; }
        }

        // Check to see if CrawlerConfiguration property is set
        internal bool IsSetCrawlerConfiguration()
        {
            return this._crawlerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderIdentity. 
        /// <para>
        /// The identity of the log provider for the third-party custom source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AwsIdentity ProviderIdentity
        {
            get { return this._providerIdentity; }
            set { this._providerIdentity = value; }
        }

        // Check to see if ProviderIdentity property is set
        internal bool IsSetProviderIdentity()
        {
            return this._providerIdentity != null;
        }

    }
}