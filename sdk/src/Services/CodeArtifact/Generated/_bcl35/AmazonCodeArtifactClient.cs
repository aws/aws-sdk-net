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
using System.Net;

using Amazon.CodeArtifact.Model;
using Amazon.CodeArtifact.Model.Internal.MarshallTransformations;
using Amazon.CodeArtifact.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CodeArtifact
{
    /// <summary>
    /// Implementation for accessing CodeArtifact
    ///
    /// CodeArtifact is a fully managed artifact repository compatible with language-native
    /// package managers and build tools such as npm, Apache Maven, pip, and dotnet. You can
    /// use CodeArtifact to share packages with development teams and pull packages. Packages
    /// can be pulled from both public and CodeArtifact repositories. You can also create
    /// an upstream relationship between a CodeArtifact repository and another repository,
    /// which effectively merges their contents from the point of view of a package manager
    /// client. 
    /// 
    ///  
    /// <para>
    ///  <b>CodeArtifact Components</b> 
    /// </para>
    ///  
    /// <para>
    /// Use the information in this guide to help you work with the following CodeArtifact
    /// components:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Repository</b>: A CodeArtifact repository contains a set of <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/welcome.html#welcome-concepts-package-version">package
    /// versions</a>, each of which maps to a set of assets, or files. Repositories are polyglot,
    /// so a single repository can contain packages of any supported type. Each repository
    /// exposes endpoints for fetching and publishing packages using tools like the <b> <code>npm</code>
    /// </b> CLI, the Maven CLI (<b> <code>mvn</code> </b>), Python CLIs (<b> <code>pip</code>
    /// </b> and <code>twine</code>), and NuGet CLIs (<code>nuget</code> and <code>dotnet</code>).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Domain</b>: Repositories are aggregated into a higher-level entity known as a
    /// <i>domain</i>. All package assets and metadata are stored in the domain, but are consumed
    /// through repositories. A given package asset, such as a Maven JAR file, is stored once
    /// per domain, no matter how many repositories it's present in. All of the assets and
    /// metadata in a domain are encrypted with the same customer master key (CMK) stored
    /// in Key Management Service (KMS).
    /// </para>
    ///  
    /// <para>
    /// Each repository is a member of a single domain and can't be moved to a different domain.
    /// </para>
    ///  
    /// <para>
    /// The domain allows organizational policy to be applied across multiple repositories,
    /// such as which accounts can access repositories in the domain, and which public repositories
    /// can be used as sources of packages.
    /// </para>
    ///  
    /// <para>
    /// Although an organization can have multiple domains, we recommend a single production
    /// domain that contains all published artifacts so that teams can find and share packages
    /// across their organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Package</b>: A <i>package</i> is a bundle of software and the metadata required
    /// to resolve dependencies and install the software. CodeArtifact supports <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/using-npm.html">npm</a>,
    /// <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/using-python.html">PyPI</a>,
    /// <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/using-maven">Maven</a>,
    /// and <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/using-nuget">NuGet</a>
    /// package formats.
    /// </para>
    ///  
    /// <para>
    /// In CodeArtifact, a package consists of:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A <i>name</i> (for example, <code>webpack</code> is the name of a popular npm package)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An optional namespace (for example, <code>@types</code> in <code>@types/node</code>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A set of versions (for example, <code>1.0.0</code>, <code>1.0.1</code>, <code>1.0.2</code>,
    /// etc.)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Package-level metadata (for example, npm tags)
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Package version</b>: A version of a package, such as <code>@types/node 12.6.9</code>.
    /// The version number format and semantics vary for different package formats. For example,
    /// npm package versions must conform to the <a href="https://semver.org/">Semantic Versioning
    /// specification</a>. In CodeArtifact, a package version consists of the version identifier,
    /// metadata at the package version level, and a set of assets.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Upstream repository</b>: One repository is <i>upstream</i> of another when the
    /// package versions in it can be accessed from the repository endpoint of the downstream
    /// repository, effectively merging the contents of the two repositories from the point
    /// of view of a client. CodeArtifact allows creating an upstream relationship between
    /// two repositories.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Asset</b>: An individual file stored in CodeArtifact associated with a package
    /// version, such as an npm <code>.tgz</code> file or Maven POM and JAR files.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// CodeArtifact supports these operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>AssociateExternalConnection</code>: Adds an existing external connection to
    /// a repository. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CopyPackageVersions</code>: Copies package versions from one repository to
    /// another repository in the same domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreateDomain</code>: Creates a domain
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreateRepository</code>: Creates a CodeArtifact repository in a domain. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteDomain</code>: Deletes a domain. You cannot delete a domain that contains
    /// repositories. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteDomainPermissionsPolicy</code>: Deletes the resource policy that is set
    /// on a domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeletePackageVersions</code>: Deletes versions of a package. After a package
    /// has been deleted, it can be republished, but its assets and metadata cannot be restored
    /// because they have been permanently removed from storage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteRepository</code>: Deletes a repository. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteRepositoryPermissionsPolicy</code>: Deletes the resource policy that
    /// is set on a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeDomain</code>: Returns a <code>DomainDescription</code> object that
    /// contains information about the requested domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribePackage</code>: Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageDescription.html">PackageDescription</a>
    /// object that contains details about a package. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribePackageVersion</code>: Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionDescription.html">PackageVersionDescription</a>
    /// object that contains details about a package version. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeRepository</code>: Returns a <code>RepositoryDescription</code> object
    /// that contains detailed information about the requested repository. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DisposePackageVersions</code>: Disposes versions of a package. A package version
    /// with the status <code>Disposed</code> cannot be restored because they have been permanently
    /// removed from storage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DisassociateExternalConnection</code>: Removes an existing external connection
    /// from a repository. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>GetAuthorizationToken</code>: Generates a temporary authorization token for
    /// accessing repositories in the domain. The token expires the authorization period has
    /// passed. The default authorization period is 12 hours and can be customized to any
    /// length with a maximum of 12 hours.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>GetDomainPermissionsPolicy</code>: Returns the policy of a resource that is
    /// attached to the specified domain. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>GetPackageVersionAsset</code>: Returns the contents of an asset that is in
    /// a package version. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>GetPackageVersionReadme</code>: Gets the readme file or descriptive text for
    /// a package version.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>GetRepositoryEndpoint</code>: Returns the endpoint of a repository for a specific
    /// package format. A repository has one endpoint for each package format: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>maven</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>npm</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>nuget</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>pypi</code> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <code>GetRepositoryPermissionsPolicy</code>: Returns the resource policy that is
    /// set on a repository. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListDomains</code>: Returns a list of <code>DomainSummary</code> objects. Each
    /// returned <code>DomainSummary</code> object contains information about a domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListPackages</code>: Lists the packages in a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListPackageVersionAssets</code>: Lists the assets for a given package version.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListPackageVersionDependencies</code>: Returns a list of the direct dependencies
    /// for a package version. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListPackageVersions</code>: Returns a list of package versions for a specified
    /// package in a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListRepositories</code>: Returns a list of repositories owned by the Amazon
    /// Web Services account that called this method.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListRepositoriesInDomain</code>: Returns a list of the repositories in a domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PutDomainPermissionsPolicy</code>: Attaches a resource policy to a domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PutPackageOriginConfiguration</code>: Sets the package origin configuration
    /// for a package, which determine how new versions of the package can be added to a specific
    /// repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PutRepositoryPermissionsPolicy</code>: Sets the resource policy on a repository
    /// that specifies permissions to access it. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdatePackageVersionsStatus</code>: Updates the status of one or more versions
    /// of a package.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateRepository</code>: Updates the properties of a repository.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCodeArtifactClient : AmazonServiceClient, IAmazonCodeArtifact
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeArtifactMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ICodeArtifactPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICodeArtifactPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CodeArtifactPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonCodeArtifactClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCodeArtifactClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeArtifactConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeArtifactClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeArtifactClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeArtifactConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeArtifactClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCodeArtifactClient Configuration Object</param>
        public AmazonCodeArtifactClient(AmazonCodeArtifactConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCodeArtifactClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeArtifactClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeArtifactConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeArtifactClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeArtifactClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeArtifactConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeArtifactClient with AWS Credentials and an
        /// AmazonCodeArtifactClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeArtifactClient Configuration Object</param>
        public AmazonCodeArtifactClient(AWSCredentials credentials, AmazonCodeArtifactConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeArtifactClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeArtifactClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeArtifactConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeArtifactClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeArtifactClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeArtifactConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeArtifactClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeArtifactClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeArtifactClient Configuration Object</param>
        public AmazonCodeArtifactClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeArtifactConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeArtifactClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeArtifactClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeArtifactConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeArtifactClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeArtifactClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeArtifactConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeArtifactClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeArtifactClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeArtifactClient Configuration Object</param>
        public AmazonCodeArtifactClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeArtifactConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodeArtifactEndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AssociateExternalConnection

        /// <summary>
        /// Adds an existing external connection to a repository. One external connection is allowed
        /// per repository.
        /// 
        ///  <note> 
        /// <para>
        /// A repository can have one or more upstream repositories, or an external connection.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateExternalConnection service method.</param>
        /// 
        /// <returns>The response from the AssociateExternalConnection service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ServiceQuotaExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for
        /// your account.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/AssociateExternalConnection">REST API Reference for AssociateExternalConnection Operation</seealso>
        public virtual AssociateExternalConnectionResponse AssociateExternalConnection(AssociateExternalConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateExternalConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateExternalConnectionResponseUnmarshaller.Instance;

            return Invoke<AssociateExternalConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateExternalConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateExternalConnection operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateExternalConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/AssociateExternalConnection">REST API Reference for AssociateExternalConnection Operation</seealso>
        public virtual IAsyncResult BeginAssociateExternalConnection(AssociateExternalConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateExternalConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateExternalConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateExternalConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateExternalConnection.</param>
        /// 
        /// <returns>Returns a  AssociateExternalConnectionResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/AssociateExternalConnection">REST API Reference for AssociateExternalConnection Operation</seealso>
        public virtual AssociateExternalConnectionResponse EndAssociateExternalConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateExternalConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyPackageVersions

        /// <summary>
        /// Copies package versions from one repository to another repository in the same domain.
        /// 
        /// 
        ///  <note> 
        /// <para>
        ///  You must specify <code>versions</code> or <code>versionRevisions</code>. You cannot
        /// specify both. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyPackageVersions service method.</param>
        /// 
        /// <returns>The response from the CopyPackageVersions service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ServiceQuotaExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for
        /// your account.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/CopyPackageVersions">REST API Reference for CopyPackageVersions Operation</seealso>
        public virtual CopyPackageVersionsResponse CopyPackageVersions(CopyPackageVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyPackageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyPackageVersionsResponseUnmarshaller.Instance;

            return Invoke<CopyPackageVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyPackageVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyPackageVersions operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyPackageVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/CopyPackageVersions">REST API Reference for CopyPackageVersions Operation</seealso>
        public virtual IAsyncResult BeginCopyPackageVersions(CopyPackageVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyPackageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyPackageVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyPackageVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyPackageVersions.</param>
        /// 
        /// <returns>Returns a  CopyPackageVersionsResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/CopyPackageVersions">REST API Reference for CopyPackageVersions Operation</seealso>
        public virtual CopyPackageVersionsResponse EndCopyPackageVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyPackageVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDomain

        /// <summary>
        /// Creates a domain. CodeArtifact <i>domains</i> make it easier to manage multiple repositories
        /// across an organization. You can use a domain to apply permissions across many repositories
        /// owned by different Amazon Web Services accounts. An asset is stored only once in a
        /// domain, even if it's in multiple repositories. 
        /// 
        ///  
        /// <para>
        /// Although you can have multiple domains, we recommend a single production domain that
        /// contains all published artifacts so that your development teams can find and share
        /// packages. You can use a second pre-production domain to test changes to the production
        /// domain configuration. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ServiceQuotaExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for
        /// your account.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRepository

        /// <summary>
        /// Creates a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository service method.</param>
        /// 
        /// <returns>The response from the CreateRepository service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ServiceQuotaExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for
        /// your account.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        public virtual CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return Invoke<CreateRepositoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        public virtual IAsyncResult BeginCreateRepository(CreateRepositoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRepository.</param>
        /// 
        /// <returns>Returns a  CreateRepositoryResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        public virtual CreateRepositoryResponse EndCreateRepository(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRepositoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomain

        /// <summary>
        /// Deletes a domain. You cannot delete a domain that contains repositories. If you want
        /// to delete a domain with repositories, first delete its repositories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomainPermissionsPolicy

        /// <summary>
        /// Deletes the resource policy set on a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainPermissionsPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainPermissionsPolicy service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeleteDomainPermissionsPolicy">REST API Reference for DeleteDomainPermissionsPolicy Operation</seealso>
        public virtual DeleteDomainPermissionsPolicyResponse DeleteDomainPermissionsPolicy(DeleteDomainPermissionsPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainPermissionsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainPermissionsPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainPermissionsPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainPermissionsPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainPermissionsPolicy operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomainPermissionsPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeleteDomainPermissionsPolicy">REST API Reference for DeleteDomainPermissionsPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteDomainPermissionsPolicy(DeleteDomainPermissionsPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainPermissionsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainPermissionsPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainPermissionsPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainPermissionsPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteDomainPermissionsPolicyResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeleteDomainPermissionsPolicy">REST API Reference for DeleteDomainPermissionsPolicy Operation</seealso>
        public virtual DeleteDomainPermissionsPolicyResponse EndDeleteDomainPermissionsPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainPermissionsPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePackageVersions

        /// <summary>
        /// Deletes one or more versions of a package. A deleted package version cannot be restored
        /// in your repository. If you want to remove a package version from your repository and
        /// be able to restore it later, set its status to <code>Archived</code>. Archived packages
        /// cannot be downloaded from a repository and don't show up with list package APIs (for
        /// example, <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_ListPackageVersions.html">ListPackageVersions</a>),
        /// but you can restore them using <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_UpdatePackageVersionsStatus.html">UpdatePackageVersionsStatus</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackageVersions service method.</param>
        /// 
        /// <returns>The response from the DeletePackageVersions service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeletePackageVersions">REST API Reference for DeletePackageVersions Operation</seealso>
        public virtual DeletePackageVersionsResponse DeletePackageVersions(DeletePackageVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePackageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackageVersionsResponseUnmarshaller.Instance;

            return Invoke<DeletePackageVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePackageVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePackageVersions operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePackageVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeletePackageVersions">REST API Reference for DeletePackageVersions Operation</seealso>
        public virtual IAsyncResult BeginDeletePackageVersions(DeletePackageVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePackageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackageVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePackageVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePackageVersions.</param>
        /// 
        /// <returns>Returns a  DeletePackageVersionsResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeletePackageVersions">REST API Reference for DeletePackageVersions Operation</seealso>
        public virtual DeletePackageVersionsResponse EndDeletePackageVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePackageVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRepository

        /// <summary>
        /// Deletes a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteRepository service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        public virtual DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        public virtual IAsyncResult BeginDeleteRepository(DeleteRepositoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRepository.</param>
        /// 
        /// <returns>Returns a  DeleteRepositoryResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        public virtual DeleteRepositoryResponse EndDeleteRepository(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRepositoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRepositoryPermissionsPolicy

        /// <summary>
        /// Deletes the resource policy that is set on a repository. After a resource policy
        /// is deleted, the permissions allowed and denied by the deleted policy are removed.
        /// The effect of deleting a resource policy might not be immediate. 
        /// 
        ///  <important> 
        /// <para>
        ///  Use <code>DeleteRepositoryPermissionsPolicy</code> with caution. After a policy is
        /// deleted, Amazon Web Services users, roles, and accounts lose permissions to perform
        /// the repository actions granted by the deleted policy. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryPermissionsPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteRepositoryPermissionsPolicy service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeleteRepositoryPermissionsPolicy">REST API Reference for DeleteRepositoryPermissionsPolicy Operation</seealso>
        public virtual DeleteRepositoryPermissionsPolicyResponse DeleteRepositoryPermissionsPolicy(DeleteRepositoryPermissionsPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryPermissionsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryPermissionsPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryPermissionsPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepositoryPermissionsPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryPermissionsPolicy operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRepositoryPermissionsPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeleteRepositoryPermissionsPolicy">REST API Reference for DeleteRepositoryPermissionsPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteRepositoryPermissionsPolicy(DeleteRepositoryPermissionsPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryPermissionsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryPermissionsPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRepositoryPermissionsPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRepositoryPermissionsPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteRepositoryPermissionsPolicyResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeleteRepositoryPermissionsPolicy">REST API Reference for DeleteRepositoryPermissionsPolicy Operation</seealso>
        public virtual DeleteRepositoryPermissionsPolicyResponse EndDeleteRepositoryPermissionsPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRepositoryPermissionsPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDomain

        /// <summary>
        /// Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_DomainDescription.html">DomainDescription</a>
        /// object that contains information about the requested domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        public virtual DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        public virtual IAsyncResult BeginDescribeDomain(DescribeDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomain.</param>
        /// 
        /// <returns>Returns a  DescribeDomainResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        public virtual DescribeDomainResponse EndDescribeDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePackage

        /// <summary>
        /// Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageDescription.html">PackageDescription</a>
        /// object that contains information about the requested package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackage service method.</param>
        /// 
        /// <returns>The response from the DescribePackage service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribePackage">REST API Reference for DescribePackage Operation</seealso>
        public virtual DescribePackageResponse DescribePackage(DescribePackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageResponseUnmarshaller.Instance;

            return Invoke<DescribePackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackage operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribePackage">REST API Reference for DescribePackage Operation</seealso>
        public virtual IAsyncResult BeginDescribePackage(DescribePackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePackage.</param>
        /// 
        /// <returns>Returns a  DescribePackageResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribePackage">REST API Reference for DescribePackage Operation</seealso>
        public virtual DescribePackageResponse EndDescribePackage(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePackageResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePackageVersion

        /// <summary>
        /// Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionDescription.html">PackageVersionDescription</a>
        /// object that contains information about the requested package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageVersion service method.</param>
        /// 
        /// <returns>The response from the DescribePackageVersion service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribePackageVersion">REST API Reference for DescribePackageVersion Operation</seealso>
        public virtual DescribePackageVersionResponse DescribePackageVersion(DescribePackageVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageVersionResponseUnmarshaller.Instance;

            return Invoke<DescribePackageVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackageVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageVersion operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePackageVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribePackageVersion">REST API Reference for DescribePackageVersion Operation</seealso>
        public virtual IAsyncResult BeginDescribePackageVersion(DescribePackageVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePackageVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePackageVersion.</param>
        /// 
        /// <returns>Returns a  DescribePackageVersionResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribePackageVersion">REST API Reference for DescribePackageVersion Operation</seealso>
        public virtual DescribePackageVersionResponse EndDescribePackageVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePackageVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRepository

        /// <summary>
        /// Returns a <code>RepositoryDescription</code> object that contains detailed information
        /// about the requested repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepository service method.</param>
        /// 
        /// <returns>The response from the DescribeRepository service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribeRepository">REST API Reference for DescribeRepository Operation</seealso>
        public virtual DescribeRepositoryResponse DescribeRepository(DescribeRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRepositoryResponseUnmarshaller.Instance;

            return Invoke<DescribeRepositoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepository operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribeRepository">REST API Reference for DescribeRepository Operation</seealso>
        public virtual IAsyncResult BeginDescribeRepository(DescribeRepositoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRepositoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRepository.</param>
        /// 
        /// <returns>Returns a  DescribeRepositoryResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribeRepository">REST API Reference for DescribeRepository Operation</seealso>
        public virtual DescribeRepositoryResponse EndDescribeRepository(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRepositoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateExternalConnection

        /// <summary>
        /// Removes an existing external connection from a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateExternalConnection service method.</param>
        /// 
        /// <returns>The response from the DisassociateExternalConnection service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ServiceQuotaExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for
        /// your account.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DisassociateExternalConnection">REST API Reference for DisassociateExternalConnection Operation</seealso>
        public virtual DisassociateExternalConnectionResponse DisassociateExternalConnection(DisassociateExternalConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateExternalConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateExternalConnectionResponseUnmarshaller.Instance;

            return Invoke<DisassociateExternalConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateExternalConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateExternalConnection operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateExternalConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DisassociateExternalConnection">REST API Reference for DisassociateExternalConnection Operation</seealso>
        public virtual IAsyncResult BeginDisassociateExternalConnection(DisassociateExternalConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateExternalConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateExternalConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateExternalConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateExternalConnection.</param>
        /// 
        /// <returns>Returns a  DisassociateExternalConnectionResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DisassociateExternalConnection">REST API Reference for DisassociateExternalConnection Operation</seealso>
        public virtual DisassociateExternalConnectionResponse EndDisassociateExternalConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateExternalConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DisposePackageVersions

        /// <summary>
        /// Deletes the assets in package versions and sets the package versions' status to <code>Disposed</code>.
        /// A disposed package version cannot be restored in your repository because its assets
        /// are deleted. 
        /// 
        ///  
        /// <para>
        ///  To view all disposed package versions in a repository, use <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_ListPackageVersions.html">ListPackageVersions</a>
        /// and set the <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_ListPackageVersions.html#API_ListPackageVersions_RequestSyntax">status</a>
        /// parameter to <code>Disposed</code>. 
        /// </para>
        ///  
        /// <para>
        ///  To view information about a disposed package version, use <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_DescribePackageVersion.html">DescribePackageVersion</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisposePackageVersions service method.</param>
        /// 
        /// <returns>The response from the DisposePackageVersions service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DisposePackageVersions">REST API Reference for DisposePackageVersions Operation</seealso>
        public virtual DisposePackageVersionsResponse DisposePackageVersions(DisposePackageVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisposePackageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisposePackageVersionsResponseUnmarshaller.Instance;

            return Invoke<DisposePackageVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisposePackageVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisposePackageVersions operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisposePackageVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DisposePackageVersions">REST API Reference for DisposePackageVersions Operation</seealso>
        public virtual IAsyncResult BeginDisposePackageVersions(DisposePackageVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisposePackageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisposePackageVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisposePackageVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisposePackageVersions.</param>
        /// 
        /// <returns>Returns a  DisposePackageVersionsResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DisposePackageVersions">REST API Reference for DisposePackageVersions Operation</seealso>
        public virtual DisposePackageVersionsResponse EndDisposePackageVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DisposePackageVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAuthorizationToken

        /// <summary>
        /// Generates a temporary authorization token for accessing repositories in the domain.
        /// This API requires the <code>codeartifact:GetAuthorizationToken</code> and <code>sts:GetServiceBearerToken</code>
        /// permissions. For more information about authorization tokens, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/tokens-authentication.html">CodeArtifact
        /// authentication and tokens</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// CodeArtifact authorization tokens are valid for a period of 12 hours when created
        /// with the <code>login</code> command. You can call <code>login</code> periodically
        /// to refresh the token. When you create an authorization token with the <code>GetAuthorizationToken</code>
        /// API, you can set a custom authorization period, up to a maximum of 12 hours, with
        /// the <code>durationSeconds</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// The authorization period begins after <code>login</code> or <code>GetAuthorizationToken</code>
        /// is called. If <code>login</code> or <code>GetAuthorizationToken</code> is called while
        /// assuming a role, the token lifetime is independent of the maximum session duration
        /// of the role. For example, if you call <code>sts assume-role</code> and specify a session
        /// duration of 15 minutes, then generate a CodeArtifact authorization token, the token
        /// will be valid for the full authorization period even though this is longer than the
        /// 15-minute session duration.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using
        /// IAM Roles</a> for more information on controlling session duration. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizationToken service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizationToken service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetAuthorizationToken">REST API Reference for GetAuthorizationToken Operation</seealso>
        public virtual GetAuthorizationTokenResponse GetAuthorizationToken(GetAuthorizationTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizationTokenResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizationTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizationToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizationToken operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAuthorizationToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetAuthorizationToken">REST API Reference for GetAuthorizationToken Operation</seealso>
        public virtual IAsyncResult BeginGetAuthorizationToken(GetAuthorizationTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizationTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizationToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizationToken.</param>
        /// 
        /// <returns>Returns a  GetAuthorizationTokenResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetAuthorizationToken">REST API Reference for GetAuthorizationToken Operation</seealso>
        public virtual GetAuthorizationTokenResponse EndGetAuthorizationToken(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAuthorizationTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomainPermissionsPolicy

        /// <summary>
        /// Returns the resource policy attached to the specified domain. 
        /// 
        ///  <note> 
        /// <para>
        ///  The policy is a resource-based policy, not an identity-based policy. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_identity-vs-resource.html">Identity-based
        /// policies and resource-based policies </a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainPermissionsPolicy service method.</param>
        /// 
        /// <returns>The response from the GetDomainPermissionsPolicy service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetDomainPermissionsPolicy">REST API Reference for GetDomainPermissionsPolicy Operation</seealso>
        public virtual GetDomainPermissionsPolicyResponse GetDomainPermissionsPolicy(GetDomainPermissionsPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainPermissionsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainPermissionsPolicyResponseUnmarshaller.Instance;

            return Invoke<GetDomainPermissionsPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainPermissionsPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainPermissionsPolicy operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainPermissionsPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetDomainPermissionsPolicy">REST API Reference for GetDomainPermissionsPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetDomainPermissionsPolicy(GetDomainPermissionsPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainPermissionsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainPermissionsPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainPermissionsPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainPermissionsPolicy.</param>
        /// 
        /// <returns>Returns a  GetDomainPermissionsPolicyResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetDomainPermissionsPolicy">REST API Reference for GetDomainPermissionsPolicy Operation</seealso>
        public virtual GetDomainPermissionsPolicyResponse EndGetDomainPermissionsPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainPermissionsPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPackageVersionAsset

        /// <summary>
        /// Returns an asset (or file) that is in a package. For example, for a Maven package
        /// version, use <code>GetPackageVersionAsset</code> to download a <code>JAR</code> file,
        /// a <code>POM</code> file, or any other assets in the package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionAsset service method.</param>
        /// 
        /// <returns>The response from the GetPackageVersionAsset service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetPackageVersionAsset">REST API Reference for GetPackageVersionAsset Operation</seealso>
        public virtual GetPackageVersionAssetResponse GetPackageVersionAsset(GetPackageVersionAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPackageVersionAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPackageVersionAssetResponseUnmarshaller.Instance;

            return Invoke<GetPackageVersionAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPackageVersionAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionAsset operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPackageVersionAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetPackageVersionAsset">REST API Reference for GetPackageVersionAsset Operation</seealso>
        public virtual IAsyncResult BeginGetPackageVersionAsset(GetPackageVersionAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPackageVersionAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPackageVersionAssetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPackageVersionAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPackageVersionAsset.</param>
        /// 
        /// <returns>Returns a  GetPackageVersionAssetResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetPackageVersionAsset">REST API Reference for GetPackageVersionAsset Operation</seealso>
        public virtual GetPackageVersionAssetResponse EndGetPackageVersionAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPackageVersionAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPackageVersionReadme

        /// <summary>
        /// Gets the readme file or descriptive text for a package version. 
        /// 
        ///  
        /// <para>
        ///  The returned text might contain formatting. For example, it might contain formatting
        /// for Markdown or reStructuredText. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionReadme service method.</param>
        /// 
        /// <returns>The response from the GetPackageVersionReadme service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetPackageVersionReadme">REST API Reference for GetPackageVersionReadme Operation</seealso>
        public virtual GetPackageVersionReadmeResponse GetPackageVersionReadme(GetPackageVersionReadmeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPackageVersionReadmeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPackageVersionReadmeResponseUnmarshaller.Instance;

            return Invoke<GetPackageVersionReadmeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPackageVersionReadme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionReadme operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPackageVersionReadme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetPackageVersionReadme">REST API Reference for GetPackageVersionReadme Operation</seealso>
        public virtual IAsyncResult BeginGetPackageVersionReadme(GetPackageVersionReadmeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPackageVersionReadmeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPackageVersionReadmeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPackageVersionReadme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPackageVersionReadme.</param>
        /// 
        /// <returns>Returns a  GetPackageVersionReadmeResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetPackageVersionReadme">REST API Reference for GetPackageVersionReadme Operation</seealso>
        public virtual GetPackageVersionReadmeResponse EndGetPackageVersionReadme(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPackageVersionReadmeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRepositoryEndpoint

        /// <summary>
        /// Returns the endpoint of a repository for a specific package format. A repository
        /// has one endpoint for each package format: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>maven</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>npm</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>nuget</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pypi</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetRepositoryEndpoint service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetRepositoryEndpoint">REST API Reference for GetRepositoryEndpoint Operation</seealso>
        public virtual GetRepositoryEndpointResponse GetRepositoryEndpoint(GetRepositoryEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryEndpointResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRepositoryEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryEndpoint operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRepositoryEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetRepositoryEndpoint">REST API Reference for GetRepositoryEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetRepositoryEndpoint(GetRepositoryEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRepositoryEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRepositoryEndpoint.</param>
        /// 
        /// <returns>Returns a  GetRepositoryEndpointResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetRepositoryEndpoint">REST API Reference for GetRepositoryEndpoint Operation</seealso>
        public virtual GetRepositoryEndpointResponse EndGetRepositoryEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRepositoryEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRepositoryPermissionsPolicy

        /// <summary>
        /// Returns the resource policy that is set on a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryPermissionsPolicy service method.</param>
        /// 
        /// <returns>The response from the GetRepositoryPermissionsPolicy service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetRepositoryPermissionsPolicy">REST API Reference for GetRepositoryPermissionsPolicy Operation</seealso>
        public virtual GetRepositoryPermissionsPolicyResponse GetRepositoryPermissionsPolicy(GetRepositoryPermissionsPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryPermissionsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryPermissionsPolicyResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryPermissionsPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRepositoryPermissionsPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryPermissionsPolicy operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRepositoryPermissionsPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetRepositoryPermissionsPolicy">REST API Reference for GetRepositoryPermissionsPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetRepositoryPermissionsPolicy(GetRepositoryPermissionsPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryPermissionsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryPermissionsPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRepositoryPermissionsPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRepositoryPermissionsPolicy.</param>
        /// 
        /// <returns>Returns a  GetRepositoryPermissionsPolicyResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetRepositoryPermissionsPolicy">REST API Reference for GetRepositoryPermissionsPolicy Operation</seealso>
        public virtual GetRepositoryPermissionsPolicyResponse EndGetRepositoryPermissionsPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRepositoryPermissionsPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDomains

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionDescription.html">DomainSummary</a>
        /// objects for all domains owned by the Amazon Web Services account that makes this call.
        /// Each returned <code>DomainSummary</code> object contains information about a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// 
        /// <returns>Returns a  ListDomainsResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse EndListDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPackages

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageSummary.html">PackageSummary</a>
        /// objects for packages in a repository that match the request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackages service method.</param>
        /// 
        /// <returns>The response from the ListPackages service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackages">REST API Reference for ListPackages Operation</seealso>
        public virtual ListPackagesResponse ListPackages(ListPackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagesResponseUnmarshaller.Instance;

            return Invoke<ListPackagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackages operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackages">REST API Reference for ListPackages Operation</seealso>
        public virtual IAsyncResult BeginListPackages(ListPackagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPackages.</param>
        /// 
        /// <returns>Returns a  ListPackagesResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackages">REST API Reference for ListPackages Operation</seealso>
        public virtual ListPackagesResponse EndListPackages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPackagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPackageVersionAssets

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_AssetSummary.html">AssetSummary</a>
        /// objects for assets in a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackageVersionAssets service method.</param>
        /// 
        /// <returns>The response from the ListPackageVersionAssets service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackageVersionAssets">REST API Reference for ListPackageVersionAssets Operation</seealso>
        public virtual ListPackageVersionAssetsResponse ListPackageVersionAssets(ListPackageVersionAssetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackageVersionAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackageVersionAssetsResponseUnmarshaller.Instance;

            return Invoke<ListPackageVersionAssetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPackageVersionAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackageVersionAssets operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPackageVersionAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackageVersionAssets">REST API Reference for ListPackageVersionAssets Operation</seealso>
        public virtual IAsyncResult BeginListPackageVersionAssets(ListPackageVersionAssetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackageVersionAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackageVersionAssetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPackageVersionAssets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPackageVersionAssets.</param>
        /// 
        /// <returns>Returns a  ListPackageVersionAssetsResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackageVersionAssets">REST API Reference for ListPackageVersionAssets Operation</seealso>
        public virtual ListPackageVersionAssetsResponse EndListPackageVersionAssets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPackageVersionAssetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPackageVersionDependencies

        /// <summary>
        /// Returns the direct dependencies for a package version. The dependencies are returned
        /// as <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageDependency.html">PackageDependency</a>
        /// objects. CodeArtifact extracts the dependencies for a package version from the metadata
        /// file for the package format (for example, the <code>package.json</code> file for npm
        /// packages and the <code>pom.xml</code> file for Maven). Any package version dependencies
        /// that are not listed in the configuration file are not returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackageVersionDependencies service method.</param>
        /// 
        /// <returns>The response from the ListPackageVersionDependencies service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackageVersionDependencies">REST API Reference for ListPackageVersionDependencies Operation</seealso>
        public virtual ListPackageVersionDependenciesResponse ListPackageVersionDependencies(ListPackageVersionDependenciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackageVersionDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackageVersionDependenciesResponseUnmarshaller.Instance;

            return Invoke<ListPackageVersionDependenciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPackageVersionDependencies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackageVersionDependencies operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPackageVersionDependencies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackageVersionDependencies">REST API Reference for ListPackageVersionDependencies Operation</seealso>
        public virtual IAsyncResult BeginListPackageVersionDependencies(ListPackageVersionDependenciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackageVersionDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackageVersionDependenciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPackageVersionDependencies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPackageVersionDependencies.</param>
        /// 
        /// <returns>Returns a  ListPackageVersionDependenciesResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackageVersionDependencies">REST API Reference for ListPackageVersionDependencies Operation</seealso>
        public virtual ListPackageVersionDependenciesResponse EndListPackageVersionDependencies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPackageVersionDependenciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPackageVersions

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionSummary.html">PackageVersionSummary</a>
        /// objects for package versions in a repository that match the request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackageVersions service method.</param>
        /// 
        /// <returns>The response from the ListPackageVersions service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackageVersions">REST API Reference for ListPackageVersions Operation</seealso>
        public virtual ListPackageVersionsResponse ListPackageVersions(ListPackageVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackageVersionsResponseUnmarshaller.Instance;

            return Invoke<ListPackageVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPackageVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackageVersions operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPackageVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackageVersions">REST API Reference for ListPackageVersions Operation</seealso>
        public virtual IAsyncResult BeginListPackageVersions(ListPackageVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackageVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPackageVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPackageVersions.</param>
        /// 
        /// <returns>Returns a  ListPackageVersionsResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackageVersions">REST API Reference for ListPackageVersions Operation</seealso>
        public virtual ListPackageVersionsResponse EndListPackageVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPackageVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRepositories

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_RepositorySummary.html">RepositorySummary</a>
        /// objects. Each <code>RepositorySummary</code> contains information about a repository
        /// in the specified Amazon Web Services account and that matches the input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories service method.</param>
        /// 
        /// <returns>The response from the ListRepositories service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListRepositories">REST API Reference for ListRepositories Operation</seealso>
        public virtual ListRepositoriesResponse ListRepositories(ListRepositoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesResponseUnmarshaller.Instance;

            return Invoke<ListRepositoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRepositories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListRepositories">REST API Reference for ListRepositories Operation</seealso>
        public virtual IAsyncResult BeginListRepositories(ListRepositoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRepositories.</param>
        /// 
        /// <returns>Returns a  ListRepositoriesResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListRepositories">REST API Reference for ListRepositories Operation</seealso>
        public virtual ListRepositoriesResponse EndListRepositories(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRepositoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRepositoriesInDomain

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_RepositorySummary.html">RepositorySummary</a>
        /// objects. Each <code>RepositorySummary</code> contains information about a repository
        /// in the specified domain and that matches the input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoriesInDomain service method.</param>
        /// 
        /// <returns>The response from the ListRepositoriesInDomain service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListRepositoriesInDomain">REST API Reference for ListRepositoriesInDomain Operation</seealso>
        public virtual ListRepositoriesInDomainResponse ListRepositoriesInDomain(ListRepositoriesInDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoriesInDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesInDomainResponseUnmarshaller.Instance;

            return Invoke<ListRepositoriesInDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRepositoriesInDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoriesInDomain operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRepositoriesInDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListRepositoriesInDomain">REST API Reference for ListRepositoriesInDomain Operation</seealso>
        public virtual IAsyncResult BeginListRepositoriesInDomain(ListRepositoriesInDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoriesInDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesInDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRepositoriesInDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRepositoriesInDomain.</param>
        /// 
        /// <returns>Returns a  ListRepositoriesInDomainResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListRepositoriesInDomain">REST API Reference for ListRepositoriesInDomain Operation</seealso>
        public virtual ListRepositoriesInDomainResponse EndListRepositoriesInDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRepositoriesInDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Gets information about Amazon Web Services tags for a specified Amazon Resource Name
        /// (ARN) in CodeArtifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutDomainPermissionsPolicy

        /// <summary>
        /// Sets a resource policy on a domain that specifies permissions to access it. 
        /// 
        ///  
        /// <para>
        ///  When you call <code>PutDomainPermissionsPolicy</code>, the resource policy on the
        /// domain is ignored when evaluting permissions. This ensures that the owner of a domain
        /// cannot lock themselves out of the domain, which would prevent them from being able
        /// to update the resource policy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDomainPermissionsPolicy service method.</param>
        /// 
        /// <returns>The response from the PutDomainPermissionsPolicy service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ServiceQuotaExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for
        /// your account.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/PutDomainPermissionsPolicy">REST API Reference for PutDomainPermissionsPolicy Operation</seealso>
        public virtual PutDomainPermissionsPolicyResponse PutDomainPermissionsPolicy(PutDomainPermissionsPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDomainPermissionsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDomainPermissionsPolicyResponseUnmarshaller.Instance;

            return Invoke<PutDomainPermissionsPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDomainPermissionsPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDomainPermissionsPolicy operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDomainPermissionsPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/PutDomainPermissionsPolicy">REST API Reference for PutDomainPermissionsPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutDomainPermissionsPolicy(PutDomainPermissionsPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDomainPermissionsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDomainPermissionsPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDomainPermissionsPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDomainPermissionsPolicy.</param>
        /// 
        /// <returns>Returns a  PutDomainPermissionsPolicyResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/PutDomainPermissionsPolicy">REST API Reference for PutDomainPermissionsPolicy Operation</seealso>
        public virtual PutDomainPermissionsPolicyResponse EndPutDomainPermissionsPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDomainPermissionsPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPackageOriginConfiguration

        /// <summary>
        /// Sets the package origin configuration for a package.
        /// 
        ///  
        /// <para>
        /// The package origin configuration determines how new versions of a package can be added
        /// to a repository. You can allow or block direct publishing of new package versions,
        /// or ingestion and retaining of new package versions from an external connection or
        /// upstream source. For more information about package origin controls and configuration,
        /// see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-origin-controls.html">Editing
        /// package origin controls</a> in the <i>CodeArtifact User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <code>PutPackageOriginConfiguration</code> can be called on a package that doesn't
        /// yet exist in the repository. When called on a package that does not exist, a package
        /// is created in the repository with no versions and the requested restrictions are set
        /// on the package. This can be used to preemptively block ingesting or retaining any
        /// versions from external connections or upstream repositories, or to block publishing
        /// any versions of the package into the repository before connecting any package managers
        /// or publishers to the repository.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPackageOriginConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutPackageOriginConfiguration service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/PutPackageOriginConfiguration">REST API Reference for PutPackageOriginConfiguration Operation</seealso>
        public virtual PutPackageOriginConfigurationResponse PutPackageOriginConfiguration(PutPackageOriginConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPackageOriginConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPackageOriginConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutPackageOriginConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPackageOriginConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPackageOriginConfiguration operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPackageOriginConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/PutPackageOriginConfiguration">REST API Reference for PutPackageOriginConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutPackageOriginConfiguration(PutPackageOriginConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPackageOriginConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPackageOriginConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPackageOriginConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPackageOriginConfiguration.</param>
        /// 
        /// <returns>Returns a  PutPackageOriginConfigurationResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/PutPackageOriginConfiguration">REST API Reference for PutPackageOriginConfiguration Operation</seealso>
        public virtual PutPackageOriginConfigurationResponse EndPutPackageOriginConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPackageOriginConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRepositoryPermissionsPolicy

        /// <summary>
        /// Sets the resource policy on a repository that specifies permissions to access it.
        /// 
        /// 
        ///  
        /// <para>
        ///  When you call <code>PutRepositoryPermissionsPolicy</code>, the resource policy on
        /// the repository is ignored when evaluting permissions. This ensures that the owner
        /// of a repository cannot lock themselves out of the repository, which would prevent
        /// them from being able to update the resource policy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRepositoryPermissionsPolicy service method.</param>
        /// 
        /// <returns>The response from the PutRepositoryPermissionsPolicy service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ServiceQuotaExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for
        /// your account.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/PutRepositoryPermissionsPolicy">REST API Reference for PutRepositoryPermissionsPolicy Operation</seealso>
        public virtual PutRepositoryPermissionsPolicyResponse PutRepositoryPermissionsPolicy(PutRepositoryPermissionsPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRepositoryPermissionsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRepositoryPermissionsPolicyResponseUnmarshaller.Instance;

            return Invoke<PutRepositoryPermissionsPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRepositoryPermissionsPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRepositoryPermissionsPolicy operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRepositoryPermissionsPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/PutRepositoryPermissionsPolicy">REST API Reference for PutRepositoryPermissionsPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutRepositoryPermissionsPolicy(PutRepositoryPermissionsPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRepositoryPermissionsPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRepositoryPermissionsPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRepositoryPermissionsPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRepositoryPermissionsPolicy.</param>
        /// 
        /// <returns>Returns a  PutRepositoryPermissionsPolicyResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/PutRepositoryPermissionsPolicy">REST API Reference for PutRepositoryPermissionsPolicy Operation</seealso>
        public virtual PutRepositoryPermissionsPolicyResponse EndPutRepositoryPermissionsPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRepositoryPermissionsPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or updates tags for a resource in CodeArtifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ServiceQuotaExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for
        /// your account.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a resource in CodeArtifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePackageVersionsStatus

        /// <summary>
        /// Updates the status of one or more versions of a package. Using <code>UpdatePackageVersionsStatus</code>,
        /// you can update the status of package versions to <code>Archived</code>, <code>Published</code>,
        /// or <code>Unlisted</code>. To set the status of a package version to <code>Disposed</code>,
        /// use <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_DisposePackageVersions.html">DisposePackageVersions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackageVersionsStatus service method.</param>
        /// 
        /// <returns>The response from the UpdatePackageVersionsStatus service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/UpdatePackageVersionsStatus">REST API Reference for UpdatePackageVersionsStatus Operation</seealso>
        public virtual UpdatePackageVersionsStatusResponse UpdatePackageVersionsStatus(UpdatePackageVersionsStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePackageVersionsStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePackageVersionsStatusResponseUnmarshaller.Instance;

            return Invoke<UpdatePackageVersionsStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePackageVersionsStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackageVersionsStatus operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePackageVersionsStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/UpdatePackageVersionsStatus">REST API Reference for UpdatePackageVersionsStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdatePackageVersionsStatus(UpdatePackageVersionsStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePackageVersionsStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePackageVersionsStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePackageVersionsStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePackageVersionsStatus.</param>
        /// 
        /// <returns>Returns a  UpdatePackageVersionsStatusResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/UpdatePackageVersionsStatus">REST API Reference for UpdatePackageVersionsStatus Operation</seealso>
        public virtual UpdatePackageVersionsStatusResponse EndUpdatePackageVersionsStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePackageVersionsStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRepository

        /// <summary>
        /// Update the properties of a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepository service method.</param>
        /// 
        /// <returns>The response from the UpdateRepository service method, as returned by CodeArtifact.</returns>
        /// <exception cref="Amazon.CodeArtifact.Model.AccessDeniedException">
        /// The operation did not succeed because of an unauthorized access attempt.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ConflictException">
        /// The operation did not succeed because prerequisites are not met.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.InternalServerException">
        /// The operation did not succeed because of an error that occurred inside CodeArtifact.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ResourceNotFoundException">
        /// The operation did not succeed because the resource requested is not found in the
        /// service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ServiceQuotaExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for
        /// your account.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ThrottlingException">
        /// The operation did not succeed because too many requests are sent to the service.
        /// </exception>
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/UpdateRepository">REST API Reference for UpdateRepository Operation</seealso>
        public virtual UpdateRepositoryResponse UpdateRepository(UpdateRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryResponseUnmarshaller.Instance;

            return Invoke<UpdateRepositoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepository operation on AmazonCodeArtifactClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/UpdateRepository">REST API Reference for UpdateRepository Operation</seealso>
        public virtual IAsyncResult BeginUpdateRepository(UpdateRepositoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRepository.</param>
        /// 
        /// <returns>Returns a  UpdateRepositoryResult from CodeArtifact.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/UpdateRepository">REST API Reference for UpdateRepository Operation</seealso>
        public virtual UpdateRepositoryResponse EndUpdateRepository(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRepositoryResponse>(asyncResult);
        }

        #endregion
        
    }
}