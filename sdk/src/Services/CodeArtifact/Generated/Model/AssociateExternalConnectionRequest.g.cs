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

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateExternalConnection operation. Adds an
    /// existing external connection to a repository. One external connection is allowed per
    /// repository. <note> <para> A repository can have one or more upstream repositories,
    /// or an external connection. </para> </note>
    /// </summary>
    public partial class AssociateExternalConnectionRequest : AmazonCodeArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain that contains the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 50)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that owns the domain.
        /// It does not include dashes or spaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string DomainOwner { get; set; }

        /// <summary>
        /// Checks to see if the DomainOwner property is set.
        /// </summary>
        internal bool IsSetDomainOwner() => this.DomainOwner != null;

        /// <summary>
        /// Gets and sets the property ExternalConnection. 
        /// <para>
        ///  The name of the external connection to add to the repository. The following values
        /// are supported: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>public:npmjs</c> - for the npm public repository. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public:nuget-org</c> - for the NuGet Gallery. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public:pypi</c> - for the Python Package Index. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public:maven-central</c> - for Maven Central. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public:maven-googleandroid</c> - for the Google Android repository. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public:maven-gradleplugins</c> - for the Gradle plugins repository. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public:maven-commonsware</c> - for the CommonsWare Android repository. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public:maven-clojars</c> - for the Clojars repository. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public:ruby-gems-org</c> - for RubyGems.org. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public:crates-io</c> - for Crates.io. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string ExternalConnection { get; set; }

        /// <summary>
        /// Checks to see if the ExternalConnection property is set.
        /// </summary>
        internal bool IsSetExternalConnection() => this.ExternalConnection != null;

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        ///  The name of the repository to which the external connection is added. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;
    }
}
