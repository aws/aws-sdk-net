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
    /// Container for the parameters to the CreateElasticsearchDomain operation.
    /// Creates a new Elasticsearch domain. For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomains"
    /// target="_blank">Creating Elasticsearch Domains</a> in the <i>Amazon Elasticsearch
    /// Service Developer Guide</i>.
    /// </summary>
    public partial class CreateElasticsearchDomainRequest : AmazonElasticsearchRequest
    {
        private string _accessPolicies;
        private Dictionary<string, string> _advancedOptions = new Dictionary<string, string>();
        private string _domainName;
        private EBSOptions _ebsOptions;
        private ElasticsearchClusterConfig _elasticsearchClusterConfig;
        private string _elasticsearchVersion;
        private SnapshotOptions _snapshotOptions;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        ///  IAM access policy as a JSON-formatted string.
        /// </para>
        /// </summary>
        public string AccessPolicies
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
        ///  Option to allow references to indices in an HTTP request body. Must be <code>false</code>
        /// when configuring access to individual sub-resources. By default, the value is <code>true</code>.
        /// See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomain-configure-advanced-options"
        /// target="_blank">Configuration Advanced Options</a> for more information.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AdvancedOptions
        {
            get { return this._advancedOptions; }
            set { this._advancedOptions = value; }
        }

        // Check to see if AdvancedOptions property is set
        internal bool IsSetAdvancedOptions()
        {
            return this._advancedOptions != null && this._advancedOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the Elasticsearch domain that you are creating. Domain names are unique
        /// across the domains owned by an account within an AWS region. Domain names must start
        /// with a letter or number and can contain the following characters: a-z (lowercase),
        /// 0-9, and - (hyphen).
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property EBSOptions. 
        /// <para>
        /// Options to enable, disable and specify the type and size of EBS storage volumes. 
        /// </para>
        /// </summary>
        public EBSOptions EBSOptions
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
        /// Configuration options for an Elasticsearch domain. Specifies the instance type and
        /// number of instances in the domain cluster. 
        /// </para>
        /// </summary>
        public ElasticsearchClusterConfig ElasticsearchClusterConfig
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
        /// String of format X.Y to specify version for the Elasticsearch domain eg. "1.5" or
        /// "2.3". For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomains"
        /// target="_blank">Creating Elasticsearch Domains</a> in the <i>Amazon Elasticsearch
        /// Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ElasticsearchVersion
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
        /// Gets and sets the property SnapshotOptions. 
        /// <para>
        /// Option to set time, in UTC format, of the daily automated snapshot. Default value
        /// is 0 hours. 
        /// </para>
        /// </summary>
        public SnapshotOptions SnapshotOptions
        {
            get { return this._snapshotOptions; }
            set { this._snapshotOptions = value; }
        }

        // Check to see if SnapshotOptions property is set
        internal bool IsSetSnapshotOptions()
        {
            return this._snapshotOptions != null;
        }

    }
}