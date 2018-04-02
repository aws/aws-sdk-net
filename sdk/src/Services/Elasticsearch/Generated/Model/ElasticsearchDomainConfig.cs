/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// The configuration of an Elasticsearch domain.
    /// </summary>
    public partial class ElasticsearchDomainConfig
    {
        private AccessPoliciesStatus _accessPolicies;
        private AdvancedOptionsStatus _advancedOptions;
        private CognitoOptionsStatus _cognitoOptions;
        private EBSOptionsStatus _ebsOptions;
        private ElasticsearchClusterConfigStatus _elasticsearchClusterConfig;
        private ElasticsearchVersionStatus _elasticsearchVersion;
        private EncryptionAtRestOptionsStatus _encryptionAtRestOptions;
        private LogPublishingOptionsStatus _logPublishingOptions;
        private SnapshotOptionsStatus _snapshotOptions;
        private VPCDerivedInfoStatus _vpcOptions;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// IAM access policy as a JSON-formatted string.
        /// </para>
        /// </summary>
        public AccessPoliciesStatus AccessPolicies
        {
            get { return this._accessPolicies; }
            set { this._accessPolicies = value; }
        }

        // Check to see if AccessPolicies property is set
        internal bool IsSetAccessPolicies()
        {
            return this._accessPolicies != null;
        }

        /// <summary>
        /// Gets and sets the property AdvancedOptions. 
        /// <para>
        /// Specifies the <code>AdvancedOptions</code> for the domain. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomain-configure-advanced-options"
        /// target="_blank">Configuring Advanced Options</a> for more information.
        /// </para>
        /// </summary>
        public AdvancedOptionsStatus AdvancedOptions
        {
            get { return this._advancedOptions; }
            set { this._advancedOptions = value; }
        }

        // Check to see if AdvancedOptions property is set
        internal bool IsSetAdvancedOptions()
        {
            return this._advancedOptions != null;
        }

        /// <summary>
        /// Gets and sets the property CognitoOptions. 
        /// <para>
        /// The <code>CognitoOptions</code> for the specified domain. For more information, see
        /// <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-cognito-auth.html"
        /// target="_blank">Amazon Cognito Authentication for Kibana</a>.
        /// </para>
        /// </summary>
        public CognitoOptionsStatus CognitoOptions
        {
            get { return this._cognitoOptions; }
            set { this._cognitoOptions = value; }
        }

        // Check to see if CognitoOptions property is set
        internal bool IsSetCognitoOptions()
        {
            return this._cognitoOptions != null;
        }

        /// <summary>
        /// Gets and sets the property EBSOptions. 
        /// <para>
        /// Specifies the <code>EBSOptions</code> for the Elasticsearch domain.
        /// </para>
        /// </summary>
        public EBSOptionsStatus EBSOptions
        {
            get { return this._ebsOptions; }
            set { this._ebsOptions = value; }
        }

        // Check to see if EBSOptions property is set
        internal bool IsSetEBSOptions()
        {
            return this._ebsOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticsearchClusterConfig. 
        /// <para>
        /// Specifies the <code>ElasticsearchClusterConfig</code> for the Elasticsearch domain.
        /// </para>
        /// </summary>
        public ElasticsearchClusterConfigStatus ElasticsearchClusterConfig
        {
            get { return this._elasticsearchClusterConfig; }
            set { this._elasticsearchClusterConfig = value; }
        }

        // Check to see if ElasticsearchClusterConfig property is set
        internal bool IsSetElasticsearchClusterConfig()
        {
            return this._elasticsearchClusterConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticsearchVersion. 
        /// <para>
        /// String of format X.Y to specify version for the Elasticsearch domain.
        /// </para>
        /// </summary>
        public ElasticsearchVersionStatus ElasticsearchVersion
        {
            get { return this._elasticsearchVersion; }
            set { this._elasticsearchVersion = value; }
        }

        // Check to see if ElasticsearchVersion property is set
        internal bool IsSetElasticsearchVersion()
        {
            return this._elasticsearchVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionAtRestOptions. 
        /// <para>
        /// Specifies the <code>EncryptionAtRestOptions</code> for the Elasticsearch domain.
        /// </para>
        /// </summary>
        public EncryptionAtRestOptionsStatus EncryptionAtRestOptions
        {
            get { return this._encryptionAtRestOptions; }
            set { this._encryptionAtRestOptions = value; }
        }

        // Check to see if EncryptionAtRestOptions property is set
        internal bool IsSetEncryptionAtRestOptions()
        {
            return this._encryptionAtRestOptions != null;
        }

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Log publishing options for the given domain.
        /// </para>
        /// </summary>
        public LogPublishingOptionsStatus LogPublishingOptions
        {
            get { return this._logPublishingOptions; }
            set { this._logPublishingOptions = value; }
        }

        // Check to see if LogPublishingOptions property is set
        internal bool IsSetLogPublishingOptions()
        {
            return this._logPublishingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotOptions. 
        /// <para>
        /// Specifies the <code>SnapshotOptions</code> for the Elasticsearch domain.
        /// </para>
        /// </summary>
        public SnapshotOptionsStatus SnapshotOptions
        {
            get { return this._snapshotOptions; }
            set { this._snapshotOptions = value; }
        }

        // Check to see if SnapshotOptions property is set
        internal bool IsSetSnapshotOptions()
        {
            return this._snapshotOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VPCOptions. 
        /// <para>
        /// The <code>VPCOptions</code> for the specified domain. For more information, see <a
        /// href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-vpc.html"
        /// target="_blank">VPC Endpoints for Amazon Elasticsearch Service Domains</a>.
        /// </para>
        /// </summary>
        public VPCDerivedInfoStatus VPCOptions
        {
            get { return this._vpcOptions; }
            set { this._vpcOptions = value; }
        }

        // Check to see if VPCOptions property is set
        internal bool IsSetVPCOptions()
        {
            return this._vpcOptions != null;
        }

    }
}