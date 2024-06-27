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
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SageMakerFeatureStoreRuntime.Model;

#pragma warning disable CS1570
namespace Amazon.SageMakerFeatureStoreRuntime
{
    /// <summary>
    /// <para>Interface for accessing SageMakerFeatureStoreRuntime</para>
    ///
    /// Contains all data plane API operations and data types for the Amazon SageMaker Feature
    /// Store. Use this API to put, delete, and retrieve (get) features from a feature store.
    /// 
    ///  
    /// <para>
    /// Use the following operations to configure your <c>OnlineStore</c> and <c>OfflineStore</c>
    /// features, and to create and manage feature groups:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateFeatureGroup.html">CreateFeatureGroup</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteFeatureGroup.html">DeleteFeatureGroup</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeFeatureGroup.html">DescribeFeatureGroup</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListFeatureGroups.html">ListFeatureGroups</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonSageMakerFeatureStoreRuntime : IAmazonService, IDisposable
    {
                
        #region  BatchGetRecord



        /// <summary>
        /// Retrieves a batch of <c>Records</c> from a <c>FeatureGroup</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetRecord service method, as returned by SageMakerFeatureStoreRuntime.</returns>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.AccessForbiddenException">
        /// You do not have permission to perform an action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.InternalFailureException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ValidationErrorException">
        /// There was an error validating your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/BatchGetRecord">REST API Reference for BatchGetRecord Operation</seealso>
        Task<BatchGetRecordResponse> BatchGetRecordAsync(BatchGetRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRecord



        /// <summary>
        /// Deletes a <c>Record</c> from a <c>FeatureGroup</c> in the <c>OnlineStore</c>. Feature
        /// Store supports both <c>SoftDelete</c> and <c>HardDelete</c>. For <c>SoftDelete</c>
        /// (default), feature columns are set to <c>null</c> and the record is no longer retrievable
        /// by <c>GetRecord</c> or <c>BatchGetRecord</c>. For <c>HardDelete</c>, the complete
        /// <c>Record</c> is removed from the <c>OnlineStore</c>. In both cases, Feature Store
        /// appends the deleted record marker to the <c>OfflineStore</c>. The deleted record marker
        /// is a record with the same <c>RecordIdentifer</c> as the original, but with <c>is_deleted</c>
        /// value set to <c>True</c>, <c>EventTime</c> set to the delete input <c>EventTime</c>,
        /// and other feature values set to <c>null</c>.
        /// 
        ///  
        /// <para>
        /// Note that the <c>EventTime</c> specified in <c>DeleteRecord</c> should be set later
        /// than the <c>EventTime</c> of the existing record in the <c>OnlineStore</c> for that
        /// <c>RecordIdentifer</c>. If it is not, the deletion does not occur:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>SoftDelete</c>, the existing (not deleted) record remains in the <c>OnlineStore</c>,
        /// though the delete record marker is still written to the <c>OfflineStore</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HardDelete</c> returns <c>EventTime</c>: <c>400 ValidationException</c> to indicate
        /// that the delete operation failed. No delete record marker is written to the <c>OfflineStore</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When a record is deleted from the <c>OnlineStore</c>, the deleted record marker is
        /// appended to the <c>OfflineStore</c>. If you have the Iceberg table format enabled
        /// for your <c>OfflineStore</c>, you can remove all history of a record from the <c>OfflineStore</c>
        /// using Amazon Athena or Apache Spark. For information on how to hard delete a record
        /// from the <c>OfflineStore</c> with the Iceberg table format enabled, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/feature-store-delete-records-offline-store.html#feature-store-delete-records-offline-store">Delete
        /// records from the offline store</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRecord service method, as returned by SageMakerFeatureStoreRuntime.</returns>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.AccessForbiddenException">
        /// You do not have permission to perform an action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.InternalFailureException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ValidationErrorException">
        /// There was an error validating your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/DeleteRecord">REST API Reference for DeleteRecord Operation</seealso>
        Task<DeleteRecordResponse> DeleteRecordAsync(DeleteRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRecord



        /// <summary>
        /// Use for <c>OnlineStore</c> serving from a <c>FeatureStore</c>. Only the latest records
        /// stored in the <c>OnlineStore</c> can be retrieved. If no Record with <c>RecordIdentifierValue</c>
        /// is found, then an empty result is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecord service method, as returned by SageMakerFeatureStoreRuntime.</returns>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.AccessForbiddenException">
        /// You do not have permission to perform an action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.InternalFailureException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ResourceNotFoundException">
        /// A resource that is required to perform an action was not found.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ValidationErrorException">
        /// There was an error validating your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/GetRecord">REST API Reference for GetRecord Operation</seealso>
        Task<GetRecordResponse> GetRecordAsync(GetRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutRecord



        /// <summary>
        /// The <c>PutRecord</c> API is used to ingest a list of <c>Records</c> into your feature
        /// group. 
        /// 
        ///  
        /// <para>
        /// If a new record’s <c>EventTime</c> is greater, the new record is written to both the
        /// <c>OnlineStore</c> and <c>OfflineStore</c>. Otherwise, the record is a historic record
        /// and it is written only to the <c>OfflineStore</c>. 
        /// </para>
        ///  
        /// <para>
        /// You can specify the ingestion to be applied to the <c>OnlineStore</c>, <c>OfflineStore</c>,
        /// or both by using the <c>TargetStores</c> request parameter. 
        /// </para>
        ///  
        /// <para>
        /// You can set the ingested record to expire at a given time to live (TTL) duration after
        /// the record’s event time, <c>ExpiresAt</c> = <c>EventTime</c> + <c>TtlDuration</c>,
        /// by specifying the <c>TtlDuration</c> parameter. A record level <c>TtlDuration</c>
        /// is set when specifying the <c>TtlDuration</c> parameter using the <c>PutRecord</c>
        /// API call. If the input <c>TtlDuration</c> is <c>null</c> or unspecified, <c>TtlDuration</c>
        /// is set to the default feature group level <c>TtlDuration</c>. A record level <c>TtlDuration</c>
        /// supersedes the group level <c>TtlDuration</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRecord service method, as returned by SageMakerFeatureStoreRuntime.</returns>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.AccessForbiddenException">
        /// You do not have permission to perform an action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.InternalFailureException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ValidationErrorException">
        /// There was an error validating your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/PutRecord">REST API Reference for PutRecord Operation</seealso>
        Task<PutRecordResponse> PutRecordAsync(PutRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSageMakerFeatureStoreRuntimeConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSageMakerFeatureStoreRuntimeConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSageMakerFeatureStoreRuntimeConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSageMakerFeatureStoreRuntimeConfig to create AmazonSageMakerFeatureStoreRuntimeClient");
            }

            return awsCredentials == null ? 
                    new AmazonSageMakerFeatureStoreRuntimeClient(serviceClientConfig) :
                    new AmazonSageMakerFeatureStoreRuntimeClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}