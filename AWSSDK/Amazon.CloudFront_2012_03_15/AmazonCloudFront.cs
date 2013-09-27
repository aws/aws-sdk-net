/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-11-01
 *
 */

using System;

using Amazon.CloudFront_2012_03_15.Model;

namespace Amazon.CloudFront_2012_03_15
{
    /// <summary>
    /// Interface for Amazon CloudFront Clients.
    /// For more information about Amazon CloudFront, <see href="http://aws.amazon.com/cloudfront"/>
    /// </summary>
    [Obsolete("This version of the CloudFront SDK has been obsoleted but is kept around due to " +
            "breaking changes in the main Amazon.CloudFront namespace. No further updates will be made " +
            "to this version and applications should migrate to the Amazon.CloudFront namespace.")]
    public interface AmazonCloudFront : IDisposable
    {
        #region Operations on Distributions

        /// <summary>
        /// List Distributions
        /// </summary>
        /// <returns>List Distributions Response from the service</returns>
        /// <remarks>
        /// The ListDistributions operation lists all of the distributions associated with
        /// your account.
        /// </remarks>
        ListDistributionsResponse ListDistributions();

        /// <summary>
        /// List Distributions
        /// </summary>
        /// <param name="request">The ListDistributionsRequest with values for
        /// the Marker and MaxItems properties set</param>
        /// <returns>List Distributions Response from the service</returns>
        /// <remarks>
        /// The ListDistributions operation lists all of the distributions associated with
        /// your account.
        /// </remarks>
        ListDistributionsResponse ListDistributions(ListDistributionsRequest request);

        /// <summary>
        /// The GetDistributionConfig gets the Configuration for the CloudFront distribution.
        /// For more information on the format of the CloudFront Distribution Configuration object,
        /// please refer:
        /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/DistributionConfigDatatype.html"/>
        /// </summary>
        /// <param name="request">The GetDistributionConfigRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetDistributionConfigResponse from CloudFront.</returns>
        GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request);

        /// <summary>
        /// The GetDistributionInfo operation gets the complete information asociated with a distribution.
        /// For more information on what information is returned by CloudFront, please refer:
        /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/DeveloperGuide/AboutCreatingDistributions.html"/><br />
        /// and <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIRe/DistributionDatatype.html"/>
        /// </summary>
        /// <param name="request">
        /// The GetDistributionInfoRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetDistributionInfoResponse from CloudFront.</returns>
        GetDistributionInfoResponse GetDistributionInfo(GetDistributionInfoRequest request);

        /// <summary>
        /// The SetDistributionConfig operation sets the configuration for a CloudFront distribution.
        /// The returned response contains only the headers from CloudFront.
        /// </summary>
        /// <param name="request">
        /// The SetDistributionConfigRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a SetDistributionConfigResponse from CloudFront.</returns>
        SetDistributionConfigResponse SetDistributionConfig(SetDistributionConfigRequest request);

        /// <summary>
        /// The CreateDistribution operation creates a new CloudFront Distribution.
        /// </summary>
        /// <param name="request">
        /// The CreateDistributionRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a CreateDistributionResponse from CloudFront.</returns>
        CreateDistributionResponse CreateDistribution(CreateDistributionRequest request);

        /// <summary>
        /// The DeleteDistribution operation deletes the distribution specified in the request.
        /// </summary>
        /// <param name="request">
        /// The DeleteDistributionRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a DeleteDistributionResponse from CloudFront.</returns>
        DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request);

        #endregion

        #region Operations on Origin Access Identities

        /// <summary>
        /// The CreateOriginAccessIdentity operation creates a new CloudFront Access Identity.
        /// You can create up to 100 per AWS account.
        /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html" />
        /// </summary>
        /// <param name="request">
        /// The CreateOriginAccessIdentityRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a CreateOriginAccessIdentityResponse from CloudFront.</returns>
        /// <seealso cref="T:Amazon.CloudFront.Model.CreateOriginAccessIdentityRequest"/>
        CreateOriginAccessIdentityResponse CreateOriginAccessIdentity(CreateOriginAccessIdentityRequest request);

        /// <summary>
        /// The DeleteOriginAccessIdentity operation deletes the origin access identity specified in the request.
        /// </summary>
        /// <param name="request">
        /// The DeleteOriginAccessIdentityRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a DeleteOriginAccessIdentityResponse from CloudFront.</returns>
        DeleteOriginAccessIdentityResponse DeleteOriginAccessIdentity(DeleteOriginAccessIdentityRequest request);

        /// <summary>
        /// The ListOriginAccessIdentities operation returns a list of all of the Origin Access Identities
        /// owned by the authenticated sender of the request.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a ListOriginAccessIdentitiesResponse with the response from CloudFront.</returns>
        ListOriginAccessIdentitiesResponse ListOriginAccessIdentities();

        /// <summary>
        /// The ListOriginAccessIdentities operation returns a list of all of the Origin Access Identities
        /// owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="request">The ListOriginAccessIdentitiesRequest with values for
        /// the Marker and MaxItems properties set</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a ListOriginAccessIdentitiesResponse with the response from CloudFront.</returns>
        ListOriginAccessIdentitiesResponse ListOriginAccessIdentities(ListOriginAccessIdentitiesRequest request);

        /// <summary>
        /// The GetOriginAccessIdentityInfo operation gets the complete information asociated with an Origin Access Identity.
        /// For more information on what information is returned by CloudFront, please refer:
        /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/GetOAI.html"/><br />
        /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/OAIDatatype.html"/>
        /// </summary>
        /// <param name="request">
        /// The GetOriginAccessIdentityInfoRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetOriginAccessIdentityInfoResponse from CloudFront.</returns>
        GetOriginAccessIdentityInfoResponse GetOriginAccessIdentityInfo(GetOriginAccessIdentityInfoRequest request);

        /// <summary>
        /// The GetOriginAccessIdentityConfig gets the Configuration for the CloudFront Origin Access Identity.
        /// For more information on the format of the CloudFront Origin Access Identity Configuration object,
        /// please refer:
        /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/OAIConfigDatatype.html"/>
        /// </summary>
        /// <param name="request">The GetOriginAccessIdentityConfigRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetOriginAccessIdentityConfigResponse from CloudFront.</returns>
        GetOriginAccessIdentityConfigResponse GetOriginAccessIdentityConfig(GetOriginAccessIdentityConfigRequest request);

        /// <summary>
        /// The SetOriginAccessIdentityConfig operation sets the configuration for a CloudFront Origin Access Identity.
        /// The returned response contains only the headers from CloudFront.
        /// </summary>
        /// <param name="request">
        /// The SetOriginAccessIdentityConfigRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a SetOriginAccessIdentityConfigResponse from CloudFront.</returns>
        SetOriginAccessIdentityConfigResponse SetOriginAccessIdentityConfig(SetOriginAccessIdentityConfigRequest request);

        #endregion

        #region Operations on Streaming Distributions

        /// <summary>
        /// List CloudFront Streaming Distributions
        /// </summary>
        /// <returns>List Streaming Distributions Response from the service</returns>
        /// <remarks>
        /// The ListStreamingDistributions operation lists all of the streaming distributions 
        /// associated with your account.
        /// </remarks>
        ListStreamingDistributionsResponse ListStreamingDistributions();

        /// <summary>
        /// List CloudFront Streaming Distributions
        /// </summary>
        /// <param name="request">The ListStreamingDistributionsRequest with values for
        /// the Marker and MaxItems properties set</param>
        /// <returns>List Streaming Distributions Response from the service</returns>
        /// <remarks>
        /// The ListStreamingDistributions operation lists all of the distributions associated with
        /// your account.
        /// </remarks>
        ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request);

        /// <summary>
        /// The GetStreamingDistributionConfig gets the Configuration for the streaming distribution.
        /// For more information on the format of the CloudFront StreamingDistribution Configuration object,
        /// please refer:
        /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/StreamingDistributionConfigDatatype.html"/>
        /// </summary>
        /// <param name="request">The GetStreamingDistributionConfigRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetStreamingDistributionConfigResponse from CloudFront.</returns>
        GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request);

        /// <summary>
        /// The GetStreamingDistributionInfo operation gets the complete information asociated with a streaming distribution.
        /// For more information on what information is returned by CloudFront, please refer:
        /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/DeveloperGuide/AboutCreatingStreamingDistributions.html"/><br />
        /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/StreamingDistributionDatatype.html"/>
        /// </summary>
        /// <param name="request">
        /// The GetStreamingDistributionInfoRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetStreamingDistributionInfoResponse from CloudFront.</returns>
        GetStreamingDistributionInfoResponse GetStreamingDistributionInfo(GetStreamingDistributionInfoRequest request);

        /// <summary>
        /// The SetStreamingDistributionConfig operation sets the configuration for a CloudFront 
        /// streaming distribution. The returned response contains only the headers from CloudFront.
        /// </summary>
        /// <param name="request">
        /// The SetStreamingDistributionConfigRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a SetStreamingDistributionConfigResponse from CloudFront.</returns>
        SetStreamingDistributionConfigResponse SetStreamingDistributionConfig(SetStreamingDistributionConfigRequest request);

        /// <summary>
        /// The CreateStreamingDistribution operation creates a new CloudFront StreamingDistribution.
        /// </summary>
        /// <param name="request">
        /// The CreateStreamingDistributionRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a CreateStreamingDistributionResponse from CloudFront.</returns>
        CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request);

        /// <summary>
        /// The DeleteStreamingDistribution operation deletes the streaming distribution specified in the request.
        /// </summary>
        /// <param name="request">
        /// The DeleteStreamingDistributionRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a DeleteStreamingDistributionResponse from CloudFront.</returns>
        DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request);

        #endregion

        #region Operations for Invalidations

        /// <summary>
        /// The PostInvalidation operation invalidates objects specified in the PostInvalidationRequest which will
        /// cause Cloudfront to go back to the origin to get a new copy.
        /// 
        /// <code>
        /// PostInvalidationRequest request = new PostInvalidationRequest();
        /// request.DistributionId = distributionId;
        /// request.InvalidationBatch.CallerReference = callerReference;
        /// request.InvalidationBatch.WithPaths("/image1.jpg", "/image2.jpg");
        /// PostInvalidationResponse response = cfcClient.PostInvalidation(request);
        /// </code>
        /// </summary>
        /// <param name="request">The PostInvalidationRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a PostInvalidationResponse from CloudFront.</returns>
        PostInvalidationResponse PostInvalidation(PostInvalidationRequest request);

        /// <summary>
        /// The GetInvalidationList operation will return back a list of all the invalidations done for a distribution for the
        /// current and previous billing period. If the list is long, you can paginate it using the MaxItems
        /// and Marker parameters
        /// 
        /// <code>
        /// GetInvalidationListRequest request = new GetInvalidationListRequest();
        /// request.DistributionId = distributionId;
        /// GetInvalidationListResponse response = cfcClient.GetInvalidationList(request);
        /// </code>
        /// </summary>
        /// <param name="request">The GetInvalidationListRequest that defines the parameters of the operation. Distribution id is a required parameter.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetInvalidationListResponse from CloudFront.</returns>
        GetInvalidationListResponse GetInvalidationList(GetInvalidationListRequest request);

        /// <summary>
        /// The GetInvalidation operation returns back the details for a specific invalidation.
        /// 
        /// <code>
        /// GetInvalidationRequest request = new GetInvalidationRequest()
        ///     .WithDistribtionId(distributionId)
        ///     .WithInvalidationId(invalidationId);
        /// GetInvalidationResponse response = cfcClient.GetInvalidation(request);
        /// </code>
        /// </summary>
        /// <param name="request">The GetInvalidationRequest that defines the parameters of the operation.  Distribution id and Invalidation id are required parameters.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.CloudFront.AmazonCloudFrontException"></exception>
        /// <returns>Returns a GetInvalidationResponse from CloudFront.</returns>
        GetInvalidationResponse GetInvalidation(GetInvalidationRequest request);

        #endregion
    }
}