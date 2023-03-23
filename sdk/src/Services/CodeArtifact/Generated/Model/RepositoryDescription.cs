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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// The details of a repository stored in CodeArtifact. A CodeArtifact repository contains
    /// a set of package versions, each of which maps to a set of assets. Repositories are
    /// polyglot—a single repository can contain packages of any supported type. Each repository
    /// exposes endpoints for fetching and publishing packages using tools like the <code>npm</code>
    /// CLI, the Maven CLI (<code>mvn</code>), and <code>pip</code>. You can create up to
    /// 100 repositories per Amazon Web Services account.
    /// </summary>
    public partial class RepositoryDescription
    {
        private string _administratorAccount;
        private string _arn;
        private DateTime? _createdTime;
        private string _description;
        private string _domainName;
        private string _domainOwner;
        private List<RepositoryExternalConnectionInfo> _externalConnections = new List<RepositoryExternalConnectionInfo>();
        private string _name;
        private List<UpstreamRepositoryInfo> _upstreams = new List<UpstreamRepositoryInfo>();

        /// <summary>
        /// Gets and sets the property AdministratorAccount. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that manages the repository.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AdministratorAccount
        {
            get { return this._administratorAccount; }
            set { this._administratorAccount = value; }
        }

        // Check to see if AdministratorAccount property is set
        internal bool IsSetAdministratorAccount()
        {
            return this._administratorAccount != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// A timestamp that represents the date and time the repository was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A text description of the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  The name of the domain that contains the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
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
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that owns the domain
        /// that contains the repository. It does not include dashes or spaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DomainOwner
        {
            get { return this._domainOwner; }
            set { this._domainOwner = value; }
        }

        // Check to see if DomainOwner property is set
        internal bool IsSetDomainOwner()
        {
            return this._domainOwner != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalConnections. 
        /// <para>
        ///  An array of external connections associated with the repository. 
        /// </para>
        /// </summary>
        public List<RepositoryExternalConnectionInfo> ExternalConnections
        {
            get { return this._externalConnections; }
            set { this._externalConnections = value; }
        }

        // Check to see if ExternalConnections property is set
        internal bool IsSetExternalConnections()
        {
            return this._externalConnections != null && this._externalConnections.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Upstreams. 
        /// <para>
        ///  A list of upstream repositories to associate with the repository. The order of the
        /// upstream repositories in the list determines their priority order when CodeArtifact
        /// looks for a requested package version. For more information, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/repos-upstream.html">Working
        /// with upstream repositories</a>. 
        /// </para>
        /// </summary>
        public List<UpstreamRepositoryInfo> Upstreams
        {
            get { return this._upstreams; }
            set { this._upstreams = value; }
        }

        // Check to see if Upstreams property is set
        internal bool IsSetUpstreams()
        {
            return this._upstreams != null && this._upstreams.Count > 0; 
        }

    }
}