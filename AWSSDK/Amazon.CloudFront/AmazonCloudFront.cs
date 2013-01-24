/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.CloudFront;
using Amazon.CloudFront.Model;

namespace Amazon.CloudFront
{
    /// <summary>
    /// Interface for accessing AmazonCloudFront.
    ///  
    ///  
    /// </summary>
    public interface AmazonCloudFront : IDisposable
    {
        

        #region CreateInvalidation

        /// <summary>
        /// <para> Create a new invalidation. </para>
        /// </summary>
        /// 
        /// <param name="createInvalidationRequest">Container for the necessary parameters to execute the CreateInvalidation service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateInvalidation service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="TooManyInvalidationsInProgressException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="BatchTooLargeException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest createInvalidationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateInvalidation"/>
        /// </summary>
        /// 
        /// <param name="createInvalidationRequest">Container for the necessary parameters to execute the CreateInvalidation operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateInvalidation operation.</returns>
        IAsyncResult BeginCreateInvalidation(CreateInvalidationRequest createInvalidationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateInvalidation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInvalidation.</param>
        /// 
        /// <returns>Returns a CreateInvalidationResult from AmazonCloudFront.</returns>
        CreateInvalidationResponse EndCreateInvalidation(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListCloudFrontOriginAccessIdentities

        /// <summary>
        /// <para> List origin access identities. </para>
        /// </summary>
        /// 
        /// <param name="listCloudFrontOriginAccessIdentitiesRequest">Container for the necessary parameters to execute the
        ///          ListCloudFrontOriginAccessIdentities service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidArgumentException"/>
        ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest listCloudFrontOriginAccessIdentitiesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudFrontOriginAccessIdentities operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListCloudFrontOriginAccessIdentities"/>
        /// </summary>
        /// 
        /// <param name="listCloudFrontOriginAccessIdentitiesRequest">Container for the necessary parameters to execute the
        ///          ListCloudFrontOriginAccessIdentities operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListCloudFrontOriginAccessIdentities operation.</returns>
        IAsyncResult BeginListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest listCloudFrontOriginAccessIdentitiesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListCloudFrontOriginAccessIdentities operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListCloudFrontOriginAccessIdentities"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudFrontOriginAccessIdentities.</param>
        /// 
        /// <returns>Returns a ListCloudFrontOriginAccessIdentitiesResult from AmazonCloudFront.</returns>
        ListCloudFrontOriginAccessIdentitiesResponse EndListCloudFrontOriginAccessIdentities(IAsyncResult asyncResult);

        /// <summary>
        /// <para> List origin access identities. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidArgumentException"/>
        ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities();
        
        #endregion
        
    

        #region UpdateCloudFrontOriginAccessIdentity

        /// <summary>
        /// <para> Update an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="updateCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          UpdateCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the UpdateCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="IllegalUpdateException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest updateCloudFrontOriginAccessIdentityRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.UpdateCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="updateCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          UpdateCloudFrontOriginAccessIdentity operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateCloudFrontOriginAccessIdentity operation.</returns>
        IAsyncResult BeginUpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest updateCloudFrontOriginAccessIdentityRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.UpdateCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a UpdateCloudFrontOriginAccessIdentityResult from AmazonCloudFront.</returns>
        UpdateCloudFrontOriginAccessIdentityResponse EndUpdateCloudFrontOriginAccessIdentity(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetStreamingDistribution

        /// <summary>
        /// <para> Get the information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="getStreamingDistributionRequest">Container for the necessary parameters to execute the GetStreamingDistribution service method
        ///          on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest getStreamingDistributionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="getStreamingDistributionRequest">Container for the necessary parameters to execute the GetStreamingDistribution operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetStreamingDistribution operation.</returns>
        IAsyncResult BeginGetStreamingDistribution(GetStreamingDistributionRequest getStreamingDistributionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingDistribution.</param>
        /// 
        /// <returns>Returns a GetStreamingDistributionResult from AmazonCloudFront.</returns>
        GetStreamingDistributionResponse EndGetStreamingDistribution(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Get the information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        GetStreamingDistributionResponse GetStreamingDistribution();
        
        #endregion
        
    

        #region DeleteDistribution

        /// <summary>
        /// <para> Delete a distribution. </para>
        /// </summary>
        /// 
        /// <param name="deleteDistributionRequest">Container for the necessary parameters to execute the DeleteDistribution service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="DistributionNotDisabledException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest deleteDistributionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.DeleteDistribution"/>
        /// </summary>
        /// 
        /// <param name="deleteDistributionRequest">Container for the necessary parameters to execute the DeleteDistribution operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteDistribution(DeleteDistributionRequest deleteDistributionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.DeleteDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDistribution.</param>
        DeleteDistributionResponse EndDeleteDistribution(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Delete a distribution. </para>
        /// </summary>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="DistributionNotDisabledException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        DeleteDistributionResponse DeleteDistribution();
        
        #endregion
        
    

        #region GetDistributionConfig

        /// <summary>
        /// <para> Get the configuration information about a distribution. </para>
        /// </summary>
        /// 
        /// <param name="getDistributionConfigRequest">Container for the necessary parameters to execute the GetDistributionConfig service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest getDistributionConfigRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetDistributionConfig"/>
        /// </summary>
        /// 
        /// <param name="getDistributionConfigRequest">Container for the necessary parameters to execute the GetDistributionConfig operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetDistributionConfig operation.</returns>
        IAsyncResult BeginGetDistributionConfig(GetDistributionConfigRequest getDistributionConfigRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetDistributionConfig"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistributionConfig.</param>
        /// 
        /// <returns>Returns a GetDistributionConfigResult from AmazonCloudFront.</returns>
        GetDistributionConfigResponse EndGetDistributionConfig(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Get the configuration information about a distribution. </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        GetDistributionConfigResponse GetDistributionConfig();
        
        #endregion
        
    

        #region UpdateDistribution

        /// <summary>
        /// <para> Update a distribution. </para>
        /// </summary>
        /// 
        /// <param name="updateDistributionRequest">Container for the necessary parameters to execute the UpdateDistribution service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the UpdateDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="TooManyCookieNamesInWhiteListException"/>
        /// <exception cref="InvalidDefaultRootObjectException"/>
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="IllegalUpdateException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="TooManyDistributionCNAMEsException"/>
        /// <exception cref="InvalidForwardCookiesException"/>
        /// <exception cref="NoSuchOriginException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        /// <exception cref="CNAMEAlreadyExistsException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="TrustedSignerDoesNotExistException"/>
        /// <exception cref="InvalidOriginAccessIdentityException"/>
        /// <exception cref="TooManyCacheBehaviorsException"/>
        /// <exception cref="TooManyTrustedSignersException"/>
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="TooManyOriginsException"/>
        /// <exception cref="InvalidRequiredProtocolException"/>
        UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest updateDistributionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.UpdateDistribution"/>
        /// </summary>
        /// 
        /// <param name="updateDistributionRequest">Container for the necessary parameters to execute the UpdateDistribution operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateDistribution operation.</returns>
        IAsyncResult BeginUpdateDistribution(UpdateDistributionRequest updateDistributionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.UpdateDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDistribution.</param>
        /// 
        /// <returns>Returns a UpdateDistributionResult from AmazonCloudFront.</returns>
        UpdateDistributionResponse EndUpdateDistribution(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateDistribution

        /// <summary>
        /// <para> Create a new distribution. </para>
        /// </summary>
        /// 
        /// <param name="createDistributionRequest">Container for the necessary parameters to execute the CreateDistribution service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="TooManyCookieNamesInWhiteListException"/>
        /// <exception cref="InvalidDefaultRootObjectException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="TooManyDistributionCNAMEsException"/>
        /// <exception cref="InvalidForwardCookiesException"/>
        /// <exception cref="TooManyDistributionsException"/>
        /// <exception cref="NoSuchOriginException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        /// <exception cref="CNAMEAlreadyExistsException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="InvalidOriginAccessIdentityException"/>
        /// <exception cref="TrustedSignerDoesNotExistException"/>
        /// <exception cref="InvalidOriginException"/>
        /// <exception cref="TooManyCacheBehaviorsException"/>
        /// <exception cref="TooManyTrustedSignersException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="TooManyOriginsException"/>
        /// <exception cref="DistributionAlreadyExistsException"/>
        /// <exception cref="InvalidRequiredProtocolException"/>
        CreateDistributionResponse CreateDistribution(CreateDistributionRequest createDistributionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateDistribution"/>
        /// </summary>
        /// 
        /// <param name="createDistributionRequest">Container for the necessary parameters to execute the CreateDistribution operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateDistribution operation.</returns>
        IAsyncResult BeginCreateDistribution(CreateDistributionRequest createDistributionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDistribution.</param>
        /// 
        /// <returns>Returns a CreateDistributionResult from AmazonCloudFront.</returns>
        CreateDistributionResponse EndCreateDistribution(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetCloudFrontOriginAccessIdentityConfig

        /// <summary>
        /// <para> Get the configuration information about an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="getCloudFrontOriginAccessIdentityConfigRequest">Container for the necessary parameters to execute the
        ///          GetCloudFrontOriginAccessIdentityConfig service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="AccessDeniedException"/>
        GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest getCloudFrontOriginAccessIdentityConfigRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentityConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetCloudFrontOriginAccessIdentityConfig"/>
        /// </summary>
        /// 
        /// <param name="getCloudFrontOriginAccessIdentityConfigRequest">Container for the necessary parameters to execute the
        ///          GetCloudFrontOriginAccessIdentityConfig operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetCloudFrontOriginAccessIdentityConfig operation.</returns>
        IAsyncResult BeginGetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest getCloudFrontOriginAccessIdentityConfigRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetCloudFrontOriginAccessIdentityConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetCloudFrontOriginAccessIdentityConfig"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFrontOriginAccessIdentityConfig.</param>
        /// 
        /// <returns>Returns a GetCloudFrontOriginAccessIdentityConfigResult from AmazonCloudFront.</returns>
        GetCloudFrontOriginAccessIdentityConfigResponse EndGetCloudFrontOriginAccessIdentityConfig(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Get the configuration information about an origin access identity. </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="AccessDeniedException"/>
        GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig();
        
        #endregion
        
    

        #region ListInvalidations

        /// <summary>
        /// <para> List invalidation batches. </para>
        /// </summary>
        /// 
        /// <param name="listInvalidationsRequest">Container for the necessary parameters to execute the ListInvalidations service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListInvalidations service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="AccessDeniedException"/>
        ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest listInvalidationsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvalidations operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListInvalidations"/>
        /// </summary>
        /// 
        /// <param name="listInvalidationsRequest">Container for the necessary parameters to execute the ListInvalidations operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvalidations
        ///         operation.</returns>
        IAsyncResult BeginListInvalidations(ListInvalidationsRequest listInvalidationsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListInvalidations operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListInvalidations"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvalidations.</param>
        /// 
        /// <returns>Returns a ListInvalidationsResult from AmazonCloudFront.</returns>
        ListInvalidationsResponse EndListInvalidations(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListDistributions

        /// <summary>
        /// <para> List distributions. </para>
        /// </summary>
        /// 
        /// <param name="listDistributionsRequest">Container for the necessary parameters to execute the ListDistributions service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidArgumentException"/>
        ListDistributionsResponse ListDistributions(ListDistributionsRequest listDistributionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributions operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListDistributions"/>
        /// </summary>
        /// 
        /// <param name="listDistributionsRequest">Container for the necessary parameters to execute the ListDistributions operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributions
        ///         operation.</returns>
        IAsyncResult BeginListDistributions(ListDistributionsRequest listDistributionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListDistributions operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListDistributions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributions.</param>
        /// 
        /// <returns>Returns a ListDistributionsResult from AmazonCloudFront.</returns>
        ListDistributionsResponse EndListDistributions(IAsyncResult asyncResult);

        /// <summary>
        /// <para> List distributions. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidArgumentException"/>
        ListDistributionsResponse ListDistributions();
        
        #endregion
        
    

        #region GetStreamingDistributionConfig

        /// <summary>
        /// <para> Get the configuration information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="getStreamingDistributionConfigRequest">Container for the necessary parameters to execute the GetStreamingDistributionConfig
        ///          service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest getStreamingDistributionConfigRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetStreamingDistributionConfig"/>
        /// </summary>
        /// 
        /// <param name="getStreamingDistributionConfigRequest">Container for the necessary parameters to execute the GetStreamingDistributionConfig
        ///          operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetStreamingDistributionConfig operation.</returns>
        IAsyncResult BeginGetStreamingDistributionConfig(GetStreamingDistributionConfigRequest getStreamingDistributionConfigRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetStreamingDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetStreamingDistributionConfig"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingDistributionConfig.</param>
        /// 
        /// <returns>Returns a GetStreamingDistributionConfigResult from AmazonCloudFront.</returns>
        GetStreamingDistributionConfigResponse EndGetStreamingDistributionConfig(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Get the configuration information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        GetStreamingDistributionConfigResponse GetStreamingDistributionConfig();
        
        #endregion
        
    

        #region GetDistribution

        /// <summary>
        /// <para> Get the information about a distribution. </para>
        /// </summary>
        /// 
        /// <param name="getDistributionRequest">Container for the necessary parameters to execute the GetDistribution service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        GetDistributionResponse GetDistribution(GetDistributionRequest getDistributionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetDistribution"/>
        /// </summary>
        /// 
        /// <param name="getDistributionRequest">Container for the necessary parameters to execute the GetDistribution operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistribution
        ///         operation.</returns>
        IAsyncResult BeginGetDistribution(GetDistributionRequest getDistributionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistribution.</param>
        /// 
        /// <returns>Returns a GetDistributionResult from AmazonCloudFront.</returns>
        GetDistributionResponse EndGetDistribution(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Get the information about a distribution. </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        GetDistributionResponse GetDistribution();
        
        #endregion
        
    

        #region DeleteStreamingDistribution

        /// <summary>
        /// <para> Delete a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="deleteStreamingDistributionRequest">Container for the necessary parameters to execute the DeleteStreamingDistribution service
        ///          method on AmazonCloudFront.</param>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="StreamingDistributionNotDisabledException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest deleteStreamingDistributionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.DeleteStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="deleteStreamingDistributionRequest">Container for the necessary parameters to execute the DeleteStreamingDistribution operation
        ///          on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteStreamingDistribution(DeleteStreamingDistributionRequest deleteStreamingDistributionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.DeleteStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStreamingDistribution.</param>
        DeleteStreamingDistributionResponse EndDeleteStreamingDistribution(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Delete a streaming distribution. </para>
        /// </summary>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="StreamingDistributionNotDisabledException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        DeleteStreamingDistributionResponse DeleteStreamingDistribution();
        
        #endregion
        
    

        #region CreateCloudFrontOriginAccessIdentity

        /// <summary>
        /// <para> Create a new origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="createCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          CreateCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="TooManyCloudFrontOriginAccessIdentitiesException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        /// <exception cref="CloudFrontOriginAccessIdentityAlreadyExistsException"/>
        CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest createCloudFrontOriginAccessIdentityRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="createCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          CreateCloudFrontOriginAccessIdentity operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateCloudFrontOriginAccessIdentity operation.</returns>
        IAsyncResult BeginCreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest createCloudFrontOriginAccessIdentityRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a CreateCloudFrontOriginAccessIdentityResult from AmazonCloudFront.</returns>
        CreateCloudFrontOriginAccessIdentityResponse EndCreateCloudFrontOriginAccessIdentity(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListStreamingDistributions

        /// <summary>
        /// <para> List streaming distributions. </para>
        /// </summary>
        /// 
        /// <param name="listStreamingDistributionsRequest">Container for the necessary parameters to execute the ListStreamingDistributions service
        ///          method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidArgumentException"/>
        ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest listStreamingDistributionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamingDistributions operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListStreamingDistributions"/>
        /// </summary>
        /// 
        /// <param name="listStreamingDistributionsRequest">Container for the necessary parameters to execute the ListStreamingDistributions operation
        ///          on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListStreamingDistributions operation.</returns>
        IAsyncResult BeginListStreamingDistributions(ListStreamingDistributionsRequest listStreamingDistributionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListStreamingDistributions operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListStreamingDistributions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamingDistributions.</param>
        /// 
        /// <returns>Returns a ListStreamingDistributionsResult from AmazonCloudFront.</returns>
        ListStreamingDistributionsResponse EndListStreamingDistributions(IAsyncResult asyncResult);

        /// <summary>
        /// <para> List streaming distributions. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidArgumentException"/>
        ListStreamingDistributionsResponse ListStreamingDistributions();
        
        #endregion
        
    

        #region DeleteCloudFrontOriginAccessIdentity

        /// <summary>
        /// <para> Delete an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="deleteCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          DeleteCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="CloudFrontOriginAccessIdentityInUseException"/>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest deleteCloudFrontOriginAccessIdentityRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.DeleteCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="deleteCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          DeleteCloudFrontOriginAccessIdentity operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest deleteCloudFrontOriginAccessIdentityRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.DeleteCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudFrontOriginAccessIdentity.</param>
        DeleteCloudFrontOriginAccessIdentityResponse EndDeleteCloudFrontOriginAccessIdentity(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Delete an origin access identity. </para>
        /// </summary>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="CloudFrontOriginAccessIdentityInUseException"/>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity();
        
        #endregion
        
    

        #region UpdateStreamingDistribution

        /// <summary>
        /// <para> Update a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="updateStreamingDistributionRequest">Container for the necessary parameters to execute the UpdateStreamingDistribution service
        ///          method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the UpdateStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="IllegalUpdateException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="CNAMEAlreadyExistsException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        /// <exception cref="InvalidOriginAccessIdentityException"/>
        /// <exception cref="TrustedSignerDoesNotExistException"/>
        /// <exception cref="TooManyTrustedSignersException"/>
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="TooManyStreamingDistributionCNAMEsException"/>
        /// <exception cref="AccessDeniedException"/>
        UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest updateStreamingDistributionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.UpdateStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="updateStreamingDistributionRequest">Container for the necessary parameters to execute the UpdateStreamingDistribution operation
        ///          on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateStreamingDistribution operation.</returns>
        IAsyncResult BeginUpdateStreamingDistribution(UpdateStreamingDistributionRequest updateStreamingDistributionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.UpdateStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStreamingDistribution.</param>
        /// 
        /// <returns>Returns a UpdateStreamingDistributionResult from AmazonCloudFront.</returns>
        UpdateStreamingDistributionResponse EndUpdateStreamingDistribution(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetInvalidation

        /// <summary>
        /// <para> Get the information about an invalidation. </para>
        /// </summary>
        /// 
        /// <param name="getInvalidationRequest">Container for the necessary parameters to execute the GetInvalidation service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetInvalidation service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchInvalidationException"/>
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        GetInvalidationResponse GetInvalidation(GetInvalidationRequest getInvalidationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetInvalidation"/>
        /// </summary>
        /// 
        /// <param name="getInvalidationRequest">Container for the necessary parameters to execute the GetInvalidation operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvalidation
        ///         operation.</returns>
        IAsyncResult BeginGetInvalidation(GetInvalidationRequest getInvalidationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetInvalidation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvalidation.</param>
        /// 
        /// <returns>Returns a GetInvalidationResult from AmazonCloudFront.</returns>
        GetInvalidationResponse EndGetInvalidation(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateStreamingDistribution

        /// <summary>
        /// <para> Create a new streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="createStreamingDistributionRequest">Container for the necessary parameters to execute the CreateStreamingDistribution service
        ///          method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="TooManyTrustedSignersException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="TooManyStreamingDistributionCNAMEsException"/>
        /// <exception cref="StreamingDistributionAlreadyExistsException"/>
        /// <exception cref="CNAMEAlreadyExistsException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="TooManyStreamingDistributionsException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        /// <exception cref="InvalidOriginAccessIdentityException"/>
        /// <exception cref="TrustedSignerDoesNotExistException"/>
        /// <exception cref="InvalidOriginException"/>
        CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest createStreamingDistributionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="createStreamingDistributionRequest">Container for the necessary parameters to execute the CreateStreamingDistribution operation
        ///          on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateStreamingDistribution operation.</returns>
        IAsyncResult BeginCreateStreamingDistribution(CreateStreamingDistributionRequest createStreamingDistributionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingDistribution.</param>
        /// 
        /// <returns>Returns a CreateStreamingDistributionResult from AmazonCloudFront.</returns>
        CreateStreamingDistributionResponse EndCreateStreamingDistribution(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetCloudFrontOriginAccessIdentity

        /// <summary>
        /// <para> Get the information about an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="getCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          GetCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="AccessDeniedException"/>
        GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest getCloudFrontOriginAccessIdentityRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="getCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          GetCloudFrontOriginAccessIdentity operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetCloudFrontOriginAccessIdentity operation.</returns>
        IAsyncResult BeginGetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest getCloudFrontOriginAccessIdentityRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a GetCloudFrontOriginAccessIdentityResult from AmazonCloudFront.</returns>
        GetCloudFrontOriginAccessIdentityResponse EndGetCloudFrontOriginAccessIdentity(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Get the information about an origin access identity. </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="AccessDeniedException"/>
        GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity();
        
        #endregion
        
    
    }
}
    
