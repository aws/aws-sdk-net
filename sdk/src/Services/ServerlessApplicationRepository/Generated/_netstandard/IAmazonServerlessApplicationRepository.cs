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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ServerlessApplicationRepository.Model;

#pragma warning disable CS1570
namespace Amazon.ServerlessApplicationRepository
{
    /// <summary>
    /// <para>Interface for accessing ServerlessApplicationRepository</para>
    ///
    /// The AWS Serverless Application Repository makes it easy for developers and enterprises
    /// to quickly find and deploy serverless applications in the AWS Cloud. For more information
    /// about serverless applications, see Serverless Computing and Applications on the AWS
    /// website.
    /// 
    /// 
    /// <para>
    /// The AWS Serverless Application Repository is deeply integrated with the AWS Lambda
    /// console, so that developers of  all levels can get started with serverless computing
    /// without needing to learn anything new. You can use category  keywords to browse for
    /// applications such as web and mobile backends, data processing applications, or chatbots.
    ///  You can also search for applications by name, publisher, or event source. To use
    /// an application, you simply choose it,  configure any required fields, and deploy it
    /// with a few clicks. 
    /// </para>
    /// 
    /// <para>
    /// You can also easily publish applications, sharing them publicly with the community
    /// at large, or privately within your team or across your organization. To publish a
    /// serverless application (or app), you can use the AWS Management Console, AWS Command
    /// Line Interface (AWS CLI), or AWS SDKs to upload the code. Along with the code, you
    /// upload a simple manifest file, also known as the AWS Serverless Application Model
    /// (AWS SAM) template. For more information about AWS SAM, see AWS Serverless Application
    /// Model (AWS SAM) on the AWS Labs GitHub repository.
    /// </para>
    /// 
    /// <para>
    /// The AWS Serverless Application Repository Developer Guide contains more information
    /// about the two developer experiences available:
    /// </para>
    /// <ul> <li> 
    /// <para>
    /// Consuming Applications – Browse for applications and view information about them,
    /// including source code and readme files. Also install, configure, and deploy applications
    /// of your choosing. 
    /// </para>
    ///  
    /// <para>
    /// Publishing Applications – Configure and upload applications to make them available
    /// to other developers, and publish new versions of applications. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonServerlessApplicationRepository : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IServerlessApplicationRepositoryPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateApplication



        /// <summary>
        /// Creates an application, optionally including an AWS SAM file to create the first application
        /// version in the same call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApplicationVersion



        /// <summary>
        /// Creates an application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplicationVersion service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateApplicationVersion">REST API Reference for CreateApplicationVersion Operation</seealso>
        Task<CreateApplicationVersionResponse> CreateApplicationVersionAsync(CreateApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCloudFormationChangeSet



        /// <summary>
        /// Creates an AWS CloudFormation change set for the given application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFormationChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCloudFormationChangeSet service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateCloudFormationChangeSet">REST API Reference for CreateCloudFormationChangeSet Operation</seealso>
        Task<CreateCloudFormationChangeSetResponse> CreateCloudFormationChangeSetAsync(CreateCloudFormationChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCloudFormationTemplate



        /// <summary>
        /// Creates an AWS CloudFormation template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFormationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCloudFormationTemplate service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/CreateCloudFormationTemplate">REST API Reference for CreateCloudFormationTemplate Operation</seealso>
        Task<CreateCloudFormationTemplateResponse> CreateCloudFormationTemplateAsync(CreateCloudFormationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApplication



        /// <summary>
        /// Deletes the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApplication



        /// <summary>
        /// Gets the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetApplication">REST API Reference for GetApplication Operation</seealso>
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApplicationPolicy



        /// <summary>
        /// Retrieves the policy for the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplicationPolicy service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetApplicationPolicy">REST API Reference for GetApplicationPolicy Operation</seealso>
        Task<GetApplicationPolicyResponse> GetApplicationPolicyAsync(GetApplicationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCloudFormationTemplate



        /// <summary>
        /// Gets the specified AWS CloudFormation template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFormationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudFormationTemplate service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/GetCloudFormationTemplate">REST API Reference for GetCloudFormationTemplate Operation</seealso>
        Task<GetCloudFormationTemplateResponse> GetCloudFormationTemplateAsync(GetCloudFormationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplicationDependencies



        /// <summary>
        /// Retrieves the list of applications nested in the containing application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationDependencies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationDependencies service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplicationDependencies">REST API Reference for ListApplicationDependencies Operation</seealso>
        Task<ListApplicationDependenciesResponse> ListApplicationDependenciesAsync(ListApplicationDependenciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplications



        /// <summary>
        /// Lists applications owned by the requester.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplicationVersions



        /// <summary>
        /// Lists versions for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationVersions service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/ListApplicationVersions">REST API Reference for ListApplicationVersions Operation</seealso>
        Task<ListApplicationVersionsResponse> ListApplicationVersionsAsync(ListApplicationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutApplicationPolicy



        /// <summary>
        /// Sets the permission policy for an application. For the list of actions supported for
        /// this operation, see <a href="https://docs.aws.amazon.com/serverlessrepo/latest/devguide/access-control-resource-based.html#application-permissions">Application
        ///  Permissions</a> .
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutApplicationPolicy service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/PutApplicationPolicy">REST API Reference for PutApplicationPolicy Operation</seealso>
        Task<PutApplicationPolicyResponse> PutApplicationPolicyAsync(PutApplicationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UnshareApplication



        /// <summary>
        /// Unshares an application from an AWS Organization.
        /// 
        /// 
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnshareApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnshareApplication service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/UnshareApplication">REST API Reference for UnshareApplication Operation</seealso>
        Task<UnshareApplicationResponse> UnshareApplicationAsync(UnshareApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApplication



        /// <summary>
        /// Updates the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ServerlessApplicationRepository.</returns>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.BadRequestException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.ForbiddenException">
        /// The client is not authenticated.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.InternalServerErrorException">
        /// The AWS Serverless Application Repository service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.NotFoundException">
        /// The resource (for example, an access policy statement) specified in the request doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.ServerlessApplicationRepository.Model.TooManyRequestsException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/serverlessrepo-2017-09-08/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonServerlessApplicationRepositoryConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonServerlessApplicationRepositoryConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonServerlessApplicationRepositoryConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonServerlessApplicationRepositoryConfig to create AmazonServerlessApplicationRepositoryClient");
            }

            return awsCredentials == null ? 
                    new AmazonServerlessApplicationRepositoryClient(serviceClientConfig) :
                    new AmazonServerlessApplicationRepositoryClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}