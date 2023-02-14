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
    /// Container for the parameters to the AssociateExternalConnection operation.
    /// Adds an existing external connection to a repository. One external connection is allowed
    /// per repository.
    /// 
    ///  <note> 
    /// <para>
    /// A repository can have one or more upstream repositories, or an external connection.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AssociateExternalConnectionRequest : AmazonCodeArtifactRequest
    {
        private string _domain;
        private string _domainOwner;
        private string _externalConnection;
        private string _repository;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain that contains the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that owns the domain.
        /// It does not include dashes or spaces. 
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
        /// Gets and sets the property ExternalConnection. 
        /// <para>
        ///  The name of the external connection to add to the repository. The following values
        /// are supported: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>public:npmjs</code> - for the npm public repository. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>public:nuget-org</code> - for the NuGet Gallery. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>public:pypi</code> - for the Python Package Index. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>public:maven-central</code> - for Maven Central. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>public:maven-googleandroid</code> - for the Google Android repository. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>public:maven-gradleplugins</code> - for the Gradle plugins repository. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>public:maven-commonsware</code> - for the CommonsWare Android repository. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
        public string ExternalConnection
        {
            get { return this._externalConnection; }
            set { this._externalConnection = value; }
        }

        // Check to see if ExternalConnection property is set
        internal bool IsSetExternalConnection()
        {
            return this._externalConnection != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        ///  The name of the repository to which the external connection is added. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
        public string Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

    }
}