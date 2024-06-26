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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeArtifact.Model;

#pragma warning disable CS1570
namespace Amazon.CodeArtifact
{
    /// <summary>
    /// <para>Interface for accessing CodeArtifact</para>
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
    ///  <b>CodeArtifact concepts</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Repository</b>: A CodeArtifact repository contains a set of <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/welcome.html#welcome-concepts-package-version">package
    /// versions</a>, each of which maps to a set of assets, or files. Repositories are polyglot,
    /// so a single repository can contain packages of any supported type. Each repository
    /// exposes endpoints for fetching and publishing packages using tools such as the <b>
    /// <c>npm</c> </b> CLI or the Maven CLI (<b> <c>mvn</c> </b>). For a list of supported
    /// package managers, see the <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/welcome.html">CodeArtifact
    /// User Guide</a>.
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
    /// to resolve dependencies and install the software. CodeArtifact supports npm, PyPI,
    /// Maven, NuGet, Swift, Ruby, Cargo, and generic package formats. For more information
    /// about the supported package formats and how to use CodeArtifact with them, see the
    /// <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/welcome.html">CodeArtifact
    /// User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// In CodeArtifact, a package consists of:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A <i>name</i> (for example, <c>webpack</c> is the name of a popular npm package)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An optional namespace (for example, <c>@types</c> in <c>@types/node</c>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A set of versions (for example, <c>1.0.0</c>, <c>1.0.1</c>, <c>1.0.2</c>, etc.)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Package-level metadata (for example, npm tags)
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Package group</b>: A group of packages that match a specified definition. Package
    /// groups can be used to apply configuration to multiple packages that match a defined
    /// pattern using package format, package namespace, and package name. You can use package
    /// groups to more conveniently configure package origin controls for multiple packages.
    /// Package origin controls are used to block or allow ingestion or publishing of new
    /// package versions, which protects users from malicious actions known as dependency
    /// substitution attacks.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Package version</b>: A version of a package, such as <c>@types/node 12.6.9</c>.
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
    /// version, such as an npm <c>.tgz</c> file or Maven POM and JAR files.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>CodeArtifact supported API operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>AssociateExternalConnection</c>: Adds an existing external connection to a repository.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CopyPackageVersions</c>: Copies package versions from one repository to another
    /// repository in the same domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CreateDomain</c>: Creates a domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CreatePackageGroup</c>: Creates a package group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CreateRepository</c>: Creates a CodeArtifact repository in a domain. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteDomain</c>: Deletes a domain. You cannot delete a domain that contains repositories.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteDomainPermissionsPolicy</c>: Deletes the resource policy that is set on
    /// a domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeletePackage</c>: Deletes a package and all associated package versions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeletePackageGroup</c>: Deletes a package group. Does not delete packages or package
    /// versions that are associated with a package group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeletePackageVersions</c>: Deletes versions of a package. After a package has
    /// been deleted, it can be republished, but its assets and metadata cannot be restored
    /// because they have been permanently removed from storage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteRepository</c>: Deletes a repository. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteRepositoryPermissionsPolicy</c>: Deletes the resource policy that is set
    /// on a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeDomain</c>: Returns a <c>DomainDescription</c> object that contains information
    /// about the requested domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribePackage</c>: Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageDescription.html">PackageDescription</a>
    /// object that contains details about a package. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribePackageGroup</c>: Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageGroup.html">PackageGroup</a>
    /// object that contains details about a package group. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribePackageVersion</c>: Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionDescription.html">PackageVersionDescription</a>
    /// object that contains details about a package version. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeRepository</c>: Returns a <c>RepositoryDescription</c> object that contains
    /// detailed information about the requested repository. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DisposePackageVersions</c>: Disposes versions of a package. A package version
    /// with the status <c>Disposed</c> cannot be restored because they have been permanently
    /// removed from storage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DisassociateExternalConnection</c>: Removes an existing external connection from
    /// a repository. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GetAssociatedPackageGroup</c>: Returns the most closely associated package group
    /// to the specified package.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GetAuthorizationToken</c>: Generates a temporary authorization token for accessing
    /// repositories in the domain. The token expires the authorization period has passed.
    /// The default authorization period is 12 hours and can be customized to any length with
    /// a maximum of 12 hours.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GetDomainPermissionsPolicy</c>: Returns the policy of a resource that is attached
    /// to the specified domain. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GetPackageVersionAsset</c>: Returns the contents of an asset that is in a package
    /// version. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GetPackageVersionReadme</c>: Gets the readme file or descriptive text for a package
    /// version.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GetRepositoryEndpoint</c>: Returns the endpoint of a repository for a specific
    /// package format. A repository has one endpoint for each package format: 
    /// </para>
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
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <c>GetRepositoryPermissionsPolicy</c>: Returns the resource policy that is set on
    /// a repository. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListAllowedRepositoriesForGroup</c>: Lists the allowed repositories for a package
    /// group that has origin configuration set to <c>ALLOW_SPECIFIC_REPOSITORIES</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListAssociatedPackages</c>: Returns a list of packages associated with the requested
    /// package group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListDomains</c>: Returns a list of <c>DomainSummary</c> objects. Each returned
    /// <c>DomainSummary</c> object contains information about a domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListPackages</c>: Lists the packages in a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListPackageGroups</c>: Returns a list of package groups in the requested domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListPackageVersionAssets</c>: Lists the assets for a given package version.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListPackageVersionDependencies</c>: Returns a list of the direct dependencies
    /// for a package version. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListPackageVersions</c>: Returns a list of package versions for a specified package
    /// in a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListRepositories</c>: Returns a list of repositories owned by the Amazon Web Services
    /// account that called this method.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListRepositoriesInDomain</c>: Returns a list of the repositories in a domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListSubPackageGroups</c>: Returns a list of direct children of the specified package
    /// group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PublishPackageVersion</c>: Creates a new package version containing one or more
    /// assets.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PutDomainPermissionsPolicy</c>: Attaches a resource policy to a domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PutPackageOriginConfiguration</c>: Sets the package origin configuration for a
    /// package, which determine how new versions of the package can be added to a specific
    /// repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PutRepositoryPermissionsPolicy</c>: Sets the resource policy on a repository that
    /// specifies permissions to access it. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UpdatePackageGroup</c>: Updates a package group. This API cannot be used to update
    /// a package group's origin configuration or pattern.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UpdatePackageGroupOriginConfiguration</c>: Updates the package origin configuration
    /// for a package group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UpdatePackageVersionsStatus</c>: Updates the status of one or more versions of
    /// a package.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UpdateRepository</c>: Updates the properties of a repository.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonCodeArtifact : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICodeArtifactPaginatorFactory Paginators { get; }

        
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
        AssociateExternalConnectionResponse AssociateExternalConnection(AssociateExternalConnectionRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociateExternalConnectionResponse> AssociateExternalConnectionAsync(AssociateExternalConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CopyPackageVersions


        /// <summary>
        /// Copies package versions from one repository to another repository in the same domain.
        /// 
        /// 
        ///  <note> 
        /// <para>
        ///  You must specify <c>versions</c> or <c>versionRevisions</c>. You cannot specify both.
        /// 
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
        CopyPackageVersionsResponse CopyPackageVersions(CopyPackageVersionsRequest request);



        /// <summary>
        /// Copies package versions from one repository to another repository in the same domain.
        /// 
        /// 
        ///  <note> 
        /// <para>
        ///  You must specify <c>versions</c> or <c>versionRevisions</c>. You cannot specify both.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyPackageVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CopyPackageVersionsResponse> CopyPackageVersionsAsync(CopyPackageVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateDomainResponse CreateDomain(CreateDomainRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePackageGroup


        /// <summary>
        /// Creates a package group. For more information about creating package groups, including
        /// example CLI commands, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/create-package-group.html">Create
        /// a package group</a> in the <i>CodeArtifact User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackageGroup service method.</param>
        /// 
        /// <returns>The response from the CreatePackageGroup service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/CreatePackageGroup">REST API Reference for CreatePackageGroup Operation</seealso>
        CreatePackageGroupResponse CreatePackageGroup(CreatePackageGroupRequest request);



        /// <summary>
        /// Creates a package group. For more information about creating package groups, including
        /// example CLI commands, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/create-package-group.html">Create
        /// a package group</a> in the <i>CodeArtifact User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackageGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePackageGroup service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/CreatePackageGroup">REST API Reference for CreatePackageGroup Operation</seealso>
        Task<CreatePackageGroupResponse> CreatePackageGroupAsync(CreatePackageGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request);



        /// <summary>
        /// Creates a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);



        /// <summary>
        /// Deletes a domain. You cannot delete a domain that contains repositories. If you want
        /// to delete a domain with repositories, first delete its repositories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteDomainPermissionsPolicyResponse DeleteDomainPermissionsPolicy(DeleteDomainPermissionsPolicyRequest request);



        /// <summary>
        /// Deletes the resource policy set on a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainPermissionsPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDomainPermissionsPolicyResponse> DeleteDomainPermissionsPolicyAsync(DeleteDomainPermissionsPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePackage


        /// <summary>
        /// Deletes a package and all associated package versions. A deleted package cannot be
        /// restored. To delete one or more package versions, use the <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_DeletePackageVersions.html">DeletePackageVersions</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage service method.</param>
        /// 
        /// <returns>The response from the DeletePackage service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        DeletePackageResponse DeletePackage(DeletePackageRequest request);



        /// <summary>
        /// Deletes a package and all associated package versions. A deleted package cannot be
        /// restored. To delete one or more package versions, use the <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_DeletePackageVersions.html">DeletePackageVersions</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePackage service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        Task<DeletePackageResponse> DeletePackageAsync(DeletePackageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePackageGroup


        /// <summary>
        /// Deletes a package group. Deleting a package group does not delete packages or package
        /// versions associated with the package group. When a package group is deleted, the direct
        /// child package groups will become children of the package group's direct parent package
        /// group. Therefore, if any of the child groups are inheriting any settings from the
        /// parent, those settings could change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackageGroup service method.</param>
        /// 
        /// <returns>The response from the DeletePackageGroup service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeletePackageGroup">REST API Reference for DeletePackageGroup Operation</seealso>
        DeletePackageGroupResponse DeletePackageGroup(DeletePackageGroupRequest request);



        /// <summary>
        /// Deletes a package group. Deleting a package group does not delete packages or package
        /// versions associated with the package group. When a package group is deleted, the direct
        /// child package groups will become children of the package group's direct parent package
        /// group. Therefore, if any of the child groups are inheriting any settings from the
        /// parent, those settings could change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackageGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePackageGroup service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DeletePackageGroup">REST API Reference for DeletePackageGroup Operation</seealso>
        Task<DeletePackageGroupResponse> DeletePackageGroupAsync(DeletePackageGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePackageVersions


        /// <summary>
        /// Deletes one or more versions of a package. A deleted package version cannot be restored
        /// in your repository. If you want to remove a package version from your repository and
        /// be able to restore it later, set its status to <c>Archived</c>. Archived packages
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
        DeletePackageVersionsResponse DeletePackageVersions(DeletePackageVersionsRequest request);



        /// <summary>
        /// Deletes one or more versions of a package. A deleted package version cannot be restored
        /// in your repository. If you want to remove a package version from your repository and
        /// be able to restore it later, set its status to <c>Archived</c>. Archived packages
        /// cannot be downloaded from a repository and don't show up with list package APIs (for
        /// example, <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_ListPackageVersions.html">ListPackageVersions</a>),
        /// but you can restore them using <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_UpdatePackageVersionsStatus.html">UpdatePackageVersionsStatus</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackageVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeletePackageVersionsResponse> DeletePackageVersionsAsync(DeletePackageVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request);



        /// <summary>
        /// Deletes a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRepositoryPermissionsPolicy


        /// <summary>
        /// Deletes the resource policy that is set on a repository. After a resource policy
        /// is deleted, the permissions allowed and denied by the deleted policy are removed.
        /// The effect of deleting a resource policy might not be immediate. 
        /// 
        ///  <important> 
        /// <para>
        ///  Use <c>DeleteRepositoryPermissionsPolicy</c> with caution. After a policy is deleted,
        /// Amazon Web Services users, roles, and accounts lose permissions to perform the repository
        /// actions granted by the deleted policy. 
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
        DeleteRepositoryPermissionsPolicyResponse DeleteRepositoryPermissionsPolicy(DeleteRepositoryPermissionsPolicyRequest request);



        /// <summary>
        /// Deletes the resource policy that is set on a repository. After a resource policy
        /// is deleted, the permissions allowed and denied by the deleted policy are removed.
        /// The effect of deleting a resource policy might not be immediate. 
        /// 
        ///  <important> 
        /// <para>
        ///  Use <c>DeleteRepositoryPermissionsPolicy</c> with caution. After a policy is deleted,
        /// Amazon Web Services users, roles, and accounts lose permissions to perform the repository
        /// actions granted by the deleted policy. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryPermissionsPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteRepositoryPermissionsPolicyResponse> DeleteRepositoryPermissionsPolicyAsync(DeleteRepositoryPermissionsPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeDomainResponse DescribeDomain(DescribeDomainRequest request);



        /// <summary>
        /// Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_DomainDescription.html">DomainDescription</a>
        /// object that contains information about the requested domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribePackageResponse DescribePackage(DescribePackageRequest request);



        /// <summary>
        /// Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageDescription.html">PackageDescription</a>
        /// object that contains information about the requested package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribePackageResponse> DescribePackageAsync(DescribePackageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePackageGroup


        /// <summary>
        /// Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageGroupDescription.html">PackageGroupDescription</a>
        /// object that contains information about the requested package group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageGroup service method.</param>
        /// 
        /// <returns>The response from the DescribePackageGroup service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribePackageGroup">REST API Reference for DescribePackageGroup Operation</seealso>
        DescribePackageGroupResponse DescribePackageGroup(DescribePackageGroupRequest request);



        /// <summary>
        /// Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageGroupDescription.html">PackageGroupDescription</a>
        /// object that contains information about the requested package group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePackageGroup service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/DescribePackageGroup">REST API Reference for DescribePackageGroup Operation</seealso>
        Task<DescribePackageGroupResponse> DescribePackageGroupAsync(DescribePackageGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribePackageVersionResponse DescribePackageVersion(DescribePackageVersionRequest request);



        /// <summary>
        /// Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionDescription.html">PackageVersionDescription</a>
        /// object that contains information about the requested package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribePackageVersionResponse> DescribePackageVersionAsync(DescribePackageVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRepository


        /// <summary>
        /// Returns a <c>RepositoryDescription</c> object that contains detailed information
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
        DescribeRepositoryResponse DescribeRepository(DescribeRepositoryRequest request);



        /// <summary>
        /// Returns a <c>RepositoryDescription</c> object that contains detailed information
        /// about the requested repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeRepositoryResponse> DescribeRepositoryAsync(DescribeRepositoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DisassociateExternalConnectionResponse DisassociateExternalConnection(DisassociateExternalConnectionRequest request);



        /// <summary>
        /// Removes an existing external connection from a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateExternalConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateExternalConnectionResponse> DisassociateExternalConnectionAsync(DisassociateExternalConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisposePackageVersions


        /// <summary>
        /// Deletes the assets in package versions and sets the package versions' status to <c>Disposed</c>.
        /// A disposed package version cannot be restored in your repository because its assets
        /// are deleted. 
        /// 
        ///  
        /// <para>
        ///  To view all disposed package versions in a repository, use <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_ListPackageVersions.html">ListPackageVersions</a>
        /// and set the <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_ListPackageVersions.html#API_ListPackageVersions_RequestSyntax">status</a>
        /// parameter to <c>Disposed</c>. 
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
        DisposePackageVersionsResponse DisposePackageVersions(DisposePackageVersionsRequest request);



        /// <summary>
        /// Deletes the assets in package versions and sets the package versions' status to <c>Disposed</c>.
        /// A disposed package version cannot be restored in your repository because its assets
        /// are deleted. 
        /// 
        ///  
        /// <para>
        ///  To view all disposed package versions in a repository, use <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_ListPackageVersions.html">ListPackageVersions</a>
        /// and set the <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_ListPackageVersions.html#API_ListPackageVersions_RequestSyntax">status</a>
        /// parameter to <c>Disposed</c>. 
        /// </para>
        ///  
        /// <para>
        ///  To view information about a disposed package version, use <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_DescribePackageVersion.html">DescribePackageVersion</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisposePackageVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisposePackageVersionsResponse> DisposePackageVersionsAsync(DisposePackageVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAssociatedPackageGroup


        /// <summary>
        /// Returns the most closely associated package group to the specified package. This API
        /// does not require that the package exist in any repository in the domain. As such,
        /// <c>GetAssociatedPackageGroup</c> can be used to see which package group's origin configuration
        /// applies to a package before that package is in a repository. This can be helpful to
        /// check if public packages are blocked without ingesting them.
        /// 
        ///  
        /// <para>
        /// For information package group association and matching, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-definition-syntax-matching-behavior.html">Package
        /// group definition syntax and matching behavior</a> in the <i>CodeArtifact User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociatedPackageGroup service method.</param>
        /// 
        /// <returns>The response from the GetAssociatedPackageGroup service method, as returned by CodeArtifact.</returns>
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
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetAssociatedPackageGroup">REST API Reference for GetAssociatedPackageGroup Operation</seealso>
        GetAssociatedPackageGroupResponse GetAssociatedPackageGroup(GetAssociatedPackageGroupRequest request);



        /// <summary>
        /// Returns the most closely associated package group to the specified package. This API
        /// does not require that the package exist in any repository in the domain. As such,
        /// <c>GetAssociatedPackageGroup</c> can be used to see which package group's origin configuration
        /// applies to a package before that package is in a repository. This can be helpful to
        /// check if public packages are blocked without ingesting them.
        /// 
        ///  
        /// <para>
        /// For information package group association and matching, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-definition-syntax-matching-behavior.html">Package
        /// group definition syntax and matching behavior</a> in the <i>CodeArtifact User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociatedPackageGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssociatedPackageGroup service method, as returned by CodeArtifact.</returns>
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
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/GetAssociatedPackageGroup">REST API Reference for GetAssociatedPackageGroup Operation</seealso>
        Task<GetAssociatedPackageGroupResponse> GetAssociatedPackageGroupAsync(GetAssociatedPackageGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAuthorizationToken


        /// <summary>
        /// Generates a temporary authorization token for accessing repositories in the domain.
        /// This API requires the <c>codeartifact:GetAuthorizationToken</c> and <c>sts:GetServiceBearerToken</c>
        /// permissions. For more information about authorization tokens, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/tokens-authentication.html">CodeArtifact
        /// authentication and tokens</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// CodeArtifact authorization tokens are valid for a period of 12 hours when created
        /// with the <c>login</c> command. You can call <c>login</c> periodically to refresh the
        /// token. When you create an authorization token with the <c>GetAuthorizationToken</c>
        /// API, you can set a custom authorization period, up to a maximum of 12 hours, with
        /// the <c>durationSeconds</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// The authorization period begins after <c>login</c> or <c>GetAuthorizationToken</c>
        /// is called. If <c>login</c> or <c>GetAuthorizationToken</c> is called while assuming
        /// a role, the token lifetime is independent of the maximum session duration of the role.
        /// For example, if you call <c>sts assume-role</c> and specify a session duration of
        /// 15 minutes, then generate a CodeArtifact authorization token, the token will be valid
        /// for the full authorization period even though this is longer than the 15-minute session
        /// duration.
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
        GetAuthorizationTokenResponse GetAuthorizationToken(GetAuthorizationTokenRequest request);



        /// <summary>
        /// Generates a temporary authorization token for accessing repositories in the domain.
        /// This API requires the <c>codeartifact:GetAuthorizationToken</c> and <c>sts:GetServiceBearerToken</c>
        /// permissions. For more information about authorization tokens, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/tokens-authentication.html">CodeArtifact
        /// authentication and tokens</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// CodeArtifact authorization tokens are valid for a period of 12 hours when created
        /// with the <c>login</c> command. You can call <c>login</c> periodically to refresh the
        /// token. When you create an authorization token with the <c>GetAuthorizationToken</c>
        /// API, you can set a custom authorization period, up to a maximum of 12 hours, with
        /// the <c>durationSeconds</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// The authorization period begins after <c>login</c> or <c>GetAuthorizationToken</c>
        /// is called. If <c>login</c> or <c>GetAuthorizationToken</c> is called while assuming
        /// a role, the token lifetime is independent of the maximum session duration of the role.
        /// For example, if you call <c>sts assume-role</c> and specify a session duration of
        /// 15 minutes, then generate a CodeArtifact authorization token, the token will be valid
        /// for the full authorization period even though this is longer than the 15-minute session
        /// duration.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using
        /// IAM Roles</a> for more information on controlling session duration. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizationToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAuthorizationTokenResponse> GetAuthorizationTokenAsync(GetAuthorizationTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetDomainPermissionsPolicyResponse GetDomainPermissionsPolicy(GetDomainPermissionsPolicyRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDomainPermissionsPolicyResponse> GetDomainPermissionsPolicyAsync(GetDomainPermissionsPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPackageVersionAsset


        /// <summary>
        /// Returns an asset (or file) that is in a package. For example, for a Maven package
        /// version, use <c>GetPackageVersionAsset</c> to download a <c>JAR</c> file, a <c>POM</c>
        /// file, or any other assets in the package version.
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
        GetPackageVersionAssetResponse GetPackageVersionAsset(GetPackageVersionAssetRequest request);



        /// <summary>
        /// Returns an asset (or file) that is in a package. For example, for a Maven package
        /// version, use <c>GetPackageVersionAsset</c> to download a <c>JAR</c> file, a <c>POM</c>
        /// file, or any other assets in the package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetPackageVersionAssetResponse> GetPackageVersionAssetAsync(GetPackageVersionAssetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetPackageVersionReadmeResponse GetPackageVersionReadme(GetPackageVersionReadmeRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetPackageVersionReadmeResponse> GetPackageVersionReadmeAsync(GetPackageVersionReadmeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRepositoryEndpoint


        /// <summary>
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
        GetRepositoryEndpointResponse GetRepositoryEndpoint(GetRepositoryEndpointRequest request);



        /// <summary>
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
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRepositoryEndpointResponse> GetRepositoryEndpointAsync(GetRepositoryEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetRepositoryPermissionsPolicyResponse GetRepositoryPermissionsPolicy(GetRepositoryPermissionsPolicyRequest request);



        /// <summary>
        /// Returns the resource policy that is set on a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryPermissionsPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRepositoryPermissionsPolicyResponse> GetRepositoryPermissionsPolicyAsync(GetRepositoryPermissionsPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAllowedRepositoriesForGroup


        /// <summary>
        /// Lists the repositories in the added repositories list of the specified restriction
        /// type for a package group. For more information about restriction types and added repository
        /// lists, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-origin-controls.html">Package
        /// group origin controls</a> in the <i>CodeArtifact User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAllowedRepositoriesForGroup service method.</param>
        /// 
        /// <returns>The response from the ListAllowedRepositoriesForGroup service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListAllowedRepositoriesForGroup">REST API Reference for ListAllowedRepositoriesForGroup Operation</seealso>
        ListAllowedRepositoriesForGroupResponse ListAllowedRepositoriesForGroup(ListAllowedRepositoriesForGroupRequest request);



        /// <summary>
        /// Lists the repositories in the added repositories list of the specified restriction
        /// type for a package group. For more information about restriction types and added repository
        /// lists, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-origin-controls.html">Package
        /// group origin controls</a> in the <i>CodeArtifact User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAllowedRepositoriesForGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAllowedRepositoriesForGroup service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListAllowedRepositoriesForGroup">REST API Reference for ListAllowedRepositoriesForGroup Operation</seealso>
        Task<ListAllowedRepositoriesForGroupResponse> ListAllowedRepositoriesForGroupAsync(ListAllowedRepositoriesForGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssociatedPackages


        /// <summary>
        /// Returns a list of packages associated with the requested package group. For information
        /// package group association and matching, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-definition-syntax-matching-behavior.html">Package
        /// group definition syntax and matching behavior</a> in the <i>CodeArtifact User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedPackages service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedPackages service method, as returned by CodeArtifact.</returns>
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
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListAssociatedPackages">REST API Reference for ListAssociatedPackages Operation</seealso>
        ListAssociatedPackagesResponse ListAssociatedPackages(ListAssociatedPackagesRequest request);



        /// <summary>
        /// Returns a list of packages associated with the requested package group. For information
        /// package group association and matching, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-definition-syntax-matching-behavior.html">Package
        /// group definition syntax and matching behavior</a> in the <i>CodeArtifact User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociatedPackages service method, as returned by CodeArtifact.</returns>
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
        /// <exception cref="Amazon.CodeArtifact.Model.ValidationException">
        /// The operation did not succeed because a parameter in the request was sent with an
        /// invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListAssociatedPackages">REST API Reference for ListAssociatedPackages Operation</seealso>
        Task<ListAssociatedPackagesResponse> ListAssociatedPackagesAsync(ListAssociatedPackagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionDescription.html">DomainSummary</a>
        /// objects for all domains owned by the Amazon Web Services account that makes this call.
        /// Each returned <c>DomainSummary</c> object contains information about a domain.
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
        ListDomainsResponse ListDomains(ListDomainsRequest request);



        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionDescription.html">DomainSummary</a>
        /// objects for all domains owned by the Amazon Web Services account that makes this call.
        /// Each returned <c>DomainSummary</c> object contains information about a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPackageGroups


        /// <summary>
        /// Returns a list of package groups in the requested domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackageGroups service method.</param>
        /// 
        /// <returns>The response from the ListPackageGroups service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackageGroups">REST API Reference for ListPackageGroups Operation</seealso>
        ListPackageGroupsResponse ListPackageGroups(ListPackageGroupsRequest request);



        /// <summary>
        /// Returns a list of package groups in the requested domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackageGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPackageGroups service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListPackageGroups">REST API Reference for ListPackageGroups Operation</seealso>
        Task<ListPackageGroupsResponse> ListPackageGroupsAsync(ListPackageGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListPackagesResponse ListPackages(ListPackagesRequest request);



        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageSummary.html">PackageSummary</a>
        /// objects for packages in a repository that match the request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPackagesResponse> ListPackagesAsync(ListPackagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListPackageVersionAssetsResponse ListPackageVersionAssets(ListPackageVersionAssetsRequest request);



        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_AssetSummary.html">AssetSummary</a>
        /// objects for assets in a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackageVersionAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPackageVersionAssetsResponse> ListPackageVersionAssetsAsync(ListPackageVersionAssetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPackageVersionDependencies


        /// <summary>
        /// Returns the direct dependencies for a package version. The dependencies are returned
        /// as <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageDependency.html">PackageDependency</a>
        /// objects. CodeArtifact extracts the dependencies for a package version from the metadata
        /// file for the package format (for example, the <c>package.json</c> file for npm packages
        /// and the <c>pom.xml</c> file for Maven). Any package version dependencies that are
        /// not listed in the configuration file are not returned.
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
        ListPackageVersionDependenciesResponse ListPackageVersionDependencies(ListPackageVersionDependenciesRequest request);



        /// <summary>
        /// Returns the direct dependencies for a package version. The dependencies are returned
        /// as <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageDependency.html">PackageDependency</a>
        /// objects. CodeArtifact extracts the dependencies for a package version from the metadata
        /// file for the package format (for example, the <c>package.json</c> file for npm packages
        /// and the <c>pom.xml</c> file for Maven). Any package version dependencies that are
        /// not listed in the configuration file are not returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackageVersionDependencies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPackageVersionDependenciesResponse> ListPackageVersionDependenciesAsync(ListPackageVersionDependenciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPackageVersions


        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionSummary.html">PackageVersionSummary</a>
        /// objects for package versions in a repository that match the request parameters. Package
        /// versions of all statuses will be returned by default when calling <c>list-package-versions</c>
        /// with no <c>--status</c> parameter.
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
        ListPackageVersionsResponse ListPackageVersions(ListPackageVersionsRequest request);



        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionSummary.html">PackageVersionSummary</a>
        /// objects for package versions in a repository that match the request parameters. Package
        /// versions of all statuses will be returned by default when calling <c>list-package-versions</c>
        /// with no <c>--status</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackageVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPackageVersionsResponse> ListPackageVersionsAsync(ListPackageVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRepositories


        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_RepositorySummary.html">RepositorySummary</a>
        /// objects. Each <c>RepositorySummary</c> contains information about a repository in
        /// the specified Amazon Web Services account and that matches the input parameters.
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
        ListRepositoriesResponse ListRepositories(ListRepositoriesRequest request);



        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_RepositorySummary.html">RepositorySummary</a>
        /// objects. Each <c>RepositorySummary</c> contains information about a repository in
        /// the specified Amazon Web Services account and that matches the input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListRepositoriesResponse> ListRepositoriesAsync(ListRepositoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRepositoriesInDomain


        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_RepositorySummary.html">RepositorySummary</a>
        /// objects. Each <c>RepositorySummary</c> contains information about a repository in
        /// the specified domain and that matches the input parameters.
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
        ListRepositoriesInDomainResponse ListRepositoriesInDomain(ListRepositoriesInDomainRequest request);



        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_RepositorySummary.html">RepositorySummary</a>
        /// objects. Each <c>RepositorySummary</c> contains information about a repository in
        /// the specified domain and that matches the input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoriesInDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListRepositoriesInDomainResponse> ListRepositoriesInDomainAsync(ListRepositoriesInDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSubPackageGroups


        /// <summary>
        /// Returns a list of direct children of the specified package group.
        /// 
        ///  
        /// <para>
        /// For information package group hierarchy, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-definition-syntax-matching-behavior.html">Package
        /// group definition syntax and matching behavior</a> in the <i>CodeArtifact User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubPackageGroups service method.</param>
        /// 
        /// <returns>The response from the ListSubPackageGroups service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListSubPackageGroups">REST API Reference for ListSubPackageGroups Operation</seealso>
        ListSubPackageGroupsResponse ListSubPackageGroups(ListSubPackageGroupsRequest request);



        /// <summary>
        /// Returns a list of direct children of the specified package group.
        /// 
        ///  
        /// <para>
        /// For information package group hierarchy, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-definition-syntax-matching-behavior.html">Package
        /// group definition syntax and matching behavior</a> in the <i>CodeArtifact User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubPackageGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubPackageGroups service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/ListSubPackageGroups">REST API Reference for ListSubPackageGroups Operation</seealso>
        Task<ListSubPackageGroupsResponse> ListSubPackageGroupsAsync(ListSubPackageGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Gets information about Amazon Web Services tags for a specified Amazon Resource Name
        /// (ARN) in CodeArtifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PublishPackageVersion


        /// <summary>
        /// Creates a new package version containing one or more assets (or files).
        /// 
        ///  
        /// <para>
        /// The <c>unfinished</c> flag can be used to keep the package version in the <c>Unfinished</c>
        /// state until all of its assets have been uploaded (see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/packages-overview.html#package-version-status.html#package-version-status">Package
        /// version status</a> in the <i>CodeArtifact user guide</i>). To set the package version’s
        /// status to <c>Published</c>, omit the <c>unfinished</c> flag when uploading the final
        /// asset, or set the status using <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_UpdatePackageVersionsStatus.html">UpdatePackageVersionStatus</a>.
        /// Once a package version’s status is set to <c>Published</c>, it cannot change back
        /// to <c>Unfinished</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only generic packages can be published using this API. For more information, see <a
        /// href="https://docs.aws.amazon.com/codeartifact/latest/ug/using-generic.html">Using
        /// generic packages</a> in the <i>CodeArtifact User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishPackageVersion service method.</param>
        /// 
        /// <returns>The response from the PublishPackageVersion service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/PublishPackageVersion">REST API Reference for PublishPackageVersion Operation</seealso>
        PublishPackageVersionResponse PublishPackageVersion(PublishPackageVersionRequest request);



        /// <summary>
        /// Creates a new package version containing one or more assets (or files).
        /// 
        ///  
        /// <para>
        /// The <c>unfinished</c> flag can be used to keep the package version in the <c>Unfinished</c>
        /// state until all of its assets have been uploaded (see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/packages-overview.html#package-version-status.html#package-version-status">Package
        /// version status</a> in the <i>CodeArtifact user guide</i>). To set the package version’s
        /// status to <c>Published</c>, omit the <c>unfinished</c> flag when uploading the final
        /// asset, or set the status using <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_UpdatePackageVersionsStatus.html">UpdatePackageVersionStatus</a>.
        /// Once a package version’s status is set to <c>Published</c>, it cannot change back
        /// to <c>Unfinished</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only generic packages can be published using this API. For more information, see <a
        /// href="https://docs.aws.amazon.com/codeartifact/latest/ug/using-generic.html">Using
        /// generic packages</a> in the <i>CodeArtifact User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishPackageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishPackageVersion service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/PublishPackageVersion">REST API Reference for PublishPackageVersion Operation</seealso>
        Task<PublishPackageVersionResponse> PublishPackageVersionAsync(PublishPackageVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutDomainPermissionsPolicy


        /// <summary>
        /// Sets a resource policy on a domain that specifies permissions to access it. 
        /// 
        ///  
        /// <para>
        ///  When you call <c>PutDomainPermissionsPolicy</c>, the resource policy on the domain
        /// is ignored when evaluting permissions. This ensures that the owner of a domain cannot
        /// lock themselves out of the domain, which would prevent them from being able to update
        /// the resource policy. 
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
        PutDomainPermissionsPolicyResponse PutDomainPermissionsPolicy(PutDomainPermissionsPolicyRequest request);



        /// <summary>
        /// Sets a resource policy on a domain that specifies permissions to access it. 
        /// 
        ///  
        /// <para>
        ///  When you call <c>PutDomainPermissionsPolicy</c>, the resource policy on the domain
        /// is ignored when evaluting permissions. This ensures that the owner of a domain cannot
        /// lock themselves out of the domain, which would prevent them from being able to update
        /// the resource policy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDomainPermissionsPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutDomainPermissionsPolicyResponse> PutDomainPermissionsPolicyAsync(PutDomainPermissionsPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ///  <c>PutPackageOriginConfiguration</c> can be called on a package that doesn't yet
        /// exist in the repository. When called on a package that does not exist, a package is
        /// created in the repository with no versions and the requested restrictions are set
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
        PutPackageOriginConfigurationResponse PutPackageOriginConfiguration(PutPackageOriginConfigurationRequest request);



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
        ///  <c>PutPackageOriginConfiguration</c> can be called on a package that doesn't yet
        /// exist in the repository. When called on a package that does not exist, a package is
        /// created in the repository with no versions and the requested restrictions are set
        /// on the package. This can be used to preemptively block ingesting or retaining any
        /// versions from external connections or upstream repositories, or to block publishing
        /// any versions of the package into the repository before connecting any package managers
        /// or publishers to the repository.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPackageOriginConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutPackageOriginConfigurationResponse> PutPackageOriginConfigurationAsync(PutPackageOriginConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutRepositoryPermissionsPolicy


        /// <summary>
        /// Sets the resource policy on a repository that specifies permissions to access it.
        /// 
        /// 
        ///  
        /// <para>
        ///  When you call <c>PutRepositoryPermissionsPolicy</c>, the resource policy on the repository
        /// is ignored when evaluting permissions. This ensures that the owner of a repository
        /// cannot lock themselves out of the repository, which would prevent them from being
        /// able to update the resource policy. 
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
        PutRepositoryPermissionsPolicyResponse PutRepositoryPermissionsPolicy(PutRepositoryPermissionsPolicyRequest request);



        /// <summary>
        /// Sets the resource policy on a repository that specifies permissions to access it.
        /// 
        /// 
        ///  
        /// <para>
        ///  When you call <c>PutRepositoryPermissionsPolicy</c>, the resource policy on the repository
        /// is ignored when evaluting permissions. This ensures that the owner of a repository
        /// cannot lock themselves out of the repository, which would prevent them from being
        /// able to update the resource policy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRepositoryPermissionsPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutRepositoryPermissionsPolicyResponse> PutRepositoryPermissionsPolicyAsync(PutRepositoryPermissionsPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds or updates tags for a resource in CodeArtifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from a resource in CodeArtifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePackageGroup


        /// <summary>
        /// Updates a package group. This API cannot be used to update a package group's origin
        /// configuration or pattern. To update a package group's origin configuration, use <a
        /// href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_UpdatePackageGroupOriginConfiguration.html">UpdatePackageGroupOriginConfiguration</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackageGroup service method.</param>
        /// 
        /// <returns>The response from the UpdatePackageGroup service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/UpdatePackageGroup">REST API Reference for UpdatePackageGroup Operation</seealso>
        UpdatePackageGroupResponse UpdatePackageGroup(UpdatePackageGroupRequest request);



        /// <summary>
        /// Updates a package group. This API cannot be used to update a package group's origin
        /// configuration or pattern. To update a package group's origin configuration, use <a
        /// href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_UpdatePackageGroupOriginConfiguration.html">UpdatePackageGroupOriginConfiguration</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackageGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePackageGroup service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/UpdatePackageGroup">REST API Reference for UpdatePackageGroup Operation</seealso>
        Task<UpdatePackageGroupResponse> UpdatePackageGroupAsync(UpdatePackageGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePackageGroupOriginConfiguration


        /// <summary>
        /// Updates the package origin configuration for a package group.
        /// 
        ///  
        /// <para>
        /// The package origin configuration determines how new versions of a package can be added
        /// to a repository. You can allow or block direct publishing of new package versions,
        /// or ingestion and retaining of new package versions from an external connection or
        /// upstream source. For more information about package group origin controls and configuration,
        /// see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-origin-controls.html">Package
        /// group origin controls</a> in the <i>CodeArtifact User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackageGroupOriginConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdatePackageGroupOriginConfiguration service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/UpdatePackageGroupOriginConfiguration">REST API Reference for UpdatePackageGroupOriginConfiguration Operation</seealso>
        UpdatePackageGroupOriginConfigurationResponse UpdatePackageGroupOriginConfiguration(UpdatePackageGroupOriginConfigurationRequest request);



        /// <summary>
        /// Updates the package origin configuration for a package group.
        /// 
        ///  
        /// <para>
        /// The package origin configuration determines how new versions of a package can be added
        /// to a repository. You can allow or block direct publishing of new package versions,
        /// or ingestion and retaining of new package versions from an external connection or
        /// upstream source. For more information about package group origin controls and configuration,
        /// see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-origin-controls.html">Package
        /// group origin controls</a> in the <i>CodeArtifact User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackageGroupOriginConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePackageGroupOriginConfiguration service method, as returned by CodeArtifact.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeartifact-2018-09-22/UpdatePackageGroupOriginConfiguration">REST API Reference for UpdatePackageGroupOriginConfiguration Operation</seealso>
        Task<UpdatePackageGroupOriginConfigurationResponse> UpdatePackageGroupOriginConfigurationAsync(UpdatePackageGroupOriginConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePackageVersionsStatus


        /// <summary>
        /// Updates the status of one or more versions of a package. Using <c>UpdatePackageVersionsStatus</c>,
        /// you can update the status of package versions to <c>Archived</c>, <c>Published</c>,
        /// or <c>Unlisted</c>. To set the status of a package version to <c>Disposed</c>, use
        /// <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_DisposePackageVersions.html">DisposePackageVersions</a>.
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
        UpdatePackageVersionsStatusResponse UpdatePackageVersionsStatus(UpdatePackageVersionsStatusRequest request);



        /// <summary>
        /// Updates the status of one or more versions of a package. Using <c>UpdatePackageVersionsStatus</c>,
        /// you can update the status of package versions to <c>Archived</c>, <c>Published</c>,
        /// or <c>Unlisted</c>. To set the status of a package version to <c>Disposed</c>, use
        /// <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_DisposePackageVersions.html">DisposePackageVersions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackageVersionsStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdatePackageVersionsStatusResponse> UpdatePackageVersionsStatusAsync(UpdatePackageVersionsStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateRepositoryResponse UpdateRepository(UpdateRepositoryRequest request);



        /// <summary>
        /// Update the properties of a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateRepositoryResponse> UpdateRepositoryAsync(UpdateRepositoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}