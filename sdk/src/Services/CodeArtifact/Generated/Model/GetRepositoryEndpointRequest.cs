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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Container for the parameters to the GetRepositoryEndpoint operation.
    /// Returns the endpoint of a repository for a specific package format. A repository
    /// has one endpoint for each package format: 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>cargo</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>generic</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>maven</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>npm</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>nuget</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>pypi</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ruby</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>swift</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetRepositoryEndpointRequest : AmazonCodeArtifactRequest
    {
        private string _domain;
        private string _domainOwner;
        private EndpointType _endpointType;
        private PackageFormat _format;
        private string _repository;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain that contains the repository. 
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
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// A string that specifies the type of endpoint.
        /// </para>
        /// </summary>
        public EndpointType EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        ///  Returns which endpoint of a repository to return. A repository has one endpoint for
        /// each package format. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PackageFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        ///  The name of the repository. 
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