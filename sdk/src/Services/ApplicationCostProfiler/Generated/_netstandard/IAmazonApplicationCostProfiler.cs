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
 * Do not modify this file. This file is generated from the applicationcostprofiler-2020-09-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ApplicationCostProfiler.Model;

#pragma warning disable CS1570
namespace Amazon.ApplicationCostProfiler
{
    /// <summary>
    /// <para>Interface for accessing ApplicationCostProfiler</para>
    ///
    /// This reference provides descriptions of the AWS Application Cost Profiler API.
    /// 
    ///  
    /// <para>
    /// The AWS Application Cost Profiler API provides programmatic access to view, create,
    /// update, and delete application cost report definitions, as well as to import your
    /// usage data into the Application Cost Profiler service.
    /// </para>
    ///  
    /// <para>
    /// For more information about using this service, see the <a href="https://docs.aws.amazon.com/application-cost-profiler/latest/userguide/introduction.html">AWS
    /// Application Cost Profiler User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonApplicationCostProfiler : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IApplicationCostProfilerPaginatorFactory Paginators { get; }
#endif
                
        #region  DeleteReportDefinition



        /// <summary>
        /// Deletes the specified report definition in AWS Application Cost Profiler. This stops
        /// the report from being generated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        Task<DeleteReportDefinitionResponse> DeleteReportDefinitionAsync(DeleteReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetReportDefinition



        /// <summary>
        /// Retrieves the definition of a report already configured in AWS Application Cost Profiler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/GetReportDefinition">REST API Reference for GetReportDefinition Operation</seealso>
        Task<GetReportDefinitionResponse> GetReportDefinitionAsync(GetReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportApplicationUsage



        /// <summary>
        /// Ingests application usage data from Amazon Simple Storage Service (Amazon S3).
        /// 
        ///  
        /// <para>
        /// The data must already exist in the S3 location. As part of the action, AWS Application
        /// Cost Profiler copies the object from your S3 bucket to an S3 bucket owned by Amazon
        /// for processing asynchronously.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApplicationUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportApplicationUsage service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ImportApplicationUsage">REST API Reference for ImportApplicationUsage Operation</seealso>
        Task<ImportApplicationUsageResponse> ImportApplicationUsageAsync(ImportApplicationUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListReportDefinitions



        /// <summary>
        /// Retrieves a list of all reports and their configurations for your AWS account.
        /// 
        ///  
        /// <para>
        /// The maximum number of reports is one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReportDefinitions service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ListReportDefinitions">REST API Reference for ListReportDefinitions Operation</seealso>
        Task<ListReportDefinitionsResponse> ListReportDefinitionsAsync(ListReportDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutReportDefinition



        /// <summary>
        /// Creates the report definition for a report in Application Cost Profiler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ServiceQuotaExceededException">
        /// Your request exceeds one or more of the service quotas.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        Task<PutReportDefinitionResponse> PutReportDefinitionAsync(PutReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateReportDefinition



        /// <summary>
        /// Updates existing report in AWS Application Cost Profiler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/UpdateReportDefinition">REST API Reference for UpdateReportDefinition Operation</seealso>
        Task<UpdateReportDefinitionResponse> UpdateReportDefinitionAsync(UpdateReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonApplicationCostProfilerConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonApplicationCostProfilerConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonApplicationCostProfilerConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonApplicationCostProfilerConfig to create AmazonApplicationCostProfilerClient");
            }

            return awsCredentials == null ? 
                    new AmazonApplicationCostProfilerClient(serviceClientConfig) :
                    new AmazonApplicationCostProfilerClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}