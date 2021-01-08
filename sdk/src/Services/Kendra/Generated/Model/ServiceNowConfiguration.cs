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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides configuration information required to connect to a ServiceNow data source.
    /// </summary>
    public partial class ServiceNowConfiguration
    {
        private string _hostUrl;
        private ServiceNowKnowledgeArticleConfiguration _knowledgeArticleConfiguration;
        private string _secretArn;
        private ServiceNowServiceCatalogConfiguration _serviceCatalogConfiguration;
        private ServiceNowBuildVersionType _serviceNowBuildVersion;

        /// <summary>
        /// Gets and sets the property HostUrl. 
        /// <para>
        /// The ServiceNow instance that the data source connects to. The host endpoint should
        /// look like the following: <code>{instance}.service-now.com.</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string HostUrl
        {
            get { return this._hostUrl; }
            set { this._hostUrl = value; }
        }

        // Check to see if HostUrl property is set
        internal bool IsSetHostUrl()
        {
            return this._hostUrl != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeArticleConfiguration. 
        /// <para>
        /// Provides configuration information for crawling knowledge articles in the ServiceNow
        /// site.
        /// </para>
        /// </summary>
        public ServiceNowKnowledgeArticleConfiguration KnowledgeArticleConfiguration
        {
            get { return this._knowledgeArticleConfiguration; }
            set { this._knowledgeArticleConfiguration = value; }
        }

        // Check to see if KnowledgeArticleConfiguration property is set
        internal bool IsSetKnowledgeArticleConfiguration()
        {
            return this._knowledgeArticleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Secret Manager secret that contains the
        /// user name and password required to connect to the ServiceNow instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1284)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCatalogConfiguration. 
        /// <para>
        /// Provides configuration information for crawling service catalogs in the ServiceNow
        /// site.
        /// </para>
        /// </summary>
        public ServiceNowServiceCatalogConfiguration ServiceCatalogConfiguration
        {
            get { return this._serviceCatalogConfiguration; }
            set { this._serviceCatalogConfiguration = value; }
        }

        // Check to see if ServiceCatalogConfiguration property is set
        internal bool IsSetServiceCatalogConfiguration()
        {
            return this._serviceCatalogConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNowBuildVersion. 
        /// <para>
        /// The identifier of the release that the ServiceNow host is running. If the host is
        /// not running the <code>LONDON</code> release, use <code>OTHERS</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceNowBuildVersionType ServiceNowBuildVersion
        {
            get { return this._serviceNowBuildVersion; }
            set { this._serviceNowBuildVersion = value; }
        }

        // Check to see if ServiceNowBuildVersion property is set
        internal bool IsSetServiceNowBuildVersion()
        {
            return this._serviceNowBuildVersion != null;
        }

    }
}