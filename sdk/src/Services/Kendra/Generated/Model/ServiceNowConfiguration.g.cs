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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information to connect to ServiceNow as your data source.
    /// </summary>
    public partial class ServiceNowConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The type of authentication used to connect to the ServiceNow instance. If you choose
        /// <c>HTTP_BASIC</c>, Amazon Kendra is authenticated using the user name and password
        /// provided in the Secrets Manager secret in the <c>SecretArn</c> field. If you choose
        /// <c>OAUTH2</c>, Amazon Kendra is authenticated using the credentials of client ID,
        /// client secret, user name and password.
        /// </para>
        ///  
        /// <para>
        /// When you use <c>OAUTH2</c> authentication, you must generate a token and a client
        /// secret using the ServiceNow console. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-servicenow.html">Using
        /// a ServiceNow data source</a>.
        /// </para>
        /// </summary>
        public ServiceNowAuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property HostUrl. 
        /// <para>
        /// The ServiceNow instance that the data source connects to. The host endpoint should
        /// look like the following: <i>{instance}.service-now.com.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string HostUrl { get; set; }

        /// <summary>
        /// Checks to see if the HostUrl property is set.
        /// </summary>
        internal bool IsSetHostUrl() => this.HostUrl != null;

        /// <summary>
        /// Gets and sets the property KnowledgeArticleConfiguration. 
        /// <para>
        /// Configuration information for crawling knowledge articles in the ServiceNow site.
        /// </para>
        /// </summary>
        public ServiceNowKnowledgeArticleConfiguration KnowledgeArticleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeArticleConfiguration property is set.
        /// </summary>
        internal bool IsSetKnowledgeArticleConfiguration() => this.KnowledgeArticleConfiguration != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Secrets Manager secret that contains the user
        /// name and password required to connect to the ServiceNow instance. You can also provide
        /// OAuth authentication credentials of user name, password, client ID, and client secret.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-servicenow.html">Using
        /// a ServiceNow data source</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1284)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property ServiceCatalogConfiguration. 
        /// <para>
        /// Configuration information for crawling service catalogs in the ServiceNow site.
        /// </para>
        /// </summary>
        public ServiceNowServiceCatalogConfiguration ServiceCatalogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCatalogConfiguration property is set.
        /// </summary>
        internal bool IsSetServiceCatalogConfiguration() => this.ServiceCatalogConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceNowBuildVersion. 
        /// <para>
        /// The identifier of the release that the ServiceNow host is running. If the host is
        /// not running the <c>LONDON</c> release, use <c>OTHERS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceNowBuildVersionType ServiceNowBuildVersion { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNowBuildVersion property is set.
        /// </summary>
        internal bool IsSetServiceNowBuildVersion() => this.ServiceNowBuildVersion != null;
    }
}
