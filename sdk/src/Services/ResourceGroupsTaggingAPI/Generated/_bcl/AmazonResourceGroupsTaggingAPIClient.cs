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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ResourceGroupsTaggingAPI.Model;
using Amazon.ResourceGroupsTaggingAPI.Model.Internal.MarshallTransformations;
using Amazon.ResourceGroupsTaggingAPI.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ResourceGroupsTaggingAPI
{
    /// <summary>
    /// <para>Implementation for accessing ResourceGroupsTaggingAPI</para>
    ///
    /// Resource Groups Tagging API
    /// </summary>
    public partial class AmazonResourceGroupsTaggingAPIClient : AmazonServiceClient, IAmazonResourceGroupsTaggingAPI
    {
        private static IServiceMetadata serviceMetadata = new AmazonResourceGroupsTaggingAPIMetadata();
        private IResourceGroupsTaggingAPIPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IResourceGroupsTaggingAPIPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ResourceGroupsTaggingAPIPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with the credentials loaded from the application's
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
        public AmazonResourceGroupsTaggingAPIClient()
            : base(new AmazonResourceGroupsTaggingAPIConfig()) { }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with the credentials loaded from the application's
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
        public AmazonResourceGroupsTaggingAPIClient(RegionEndpoint region)
            : base(new AmazonResourceGroupsTaggingAPIConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonResourceGroupsTaggingAPIClient Configuration Object</param>
        public AmazonResourceGroupsTaggingAPIClient(AmazonResourceGroupsTaggingAPIConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonResourceGroupsTaggingAPIClient(AWSCredentials credentials)
            : this(credentials, new AmazonResourceGroupsTaggingAPIConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResourceGroupsTaggingAPIClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonResourceGroupsTaggingAPIConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Credentials and an
        /// AmazonResourceGroupsTaggingAPIClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonResourceGroupsTaggingAPIClient Configuration Object</param>
        public AmazonResourceGroupsTaggingAPIClient(AWSCredentials credentials, AmazonResourceGroupsTaggingAPIConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonResourceGroupsTaggingAPIClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResourceGroupsTaggingAPIConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResourceGroupsTaggingAPIClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResourceGroupsTaggingAPIConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResourceGroupsTaggingAPIClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonResourceGroupsTaggingAPIClient Configuration Object</param>
        public AmazonResourceGroupsTaggingAPIClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonResourceGroupsTaggingAPIConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonResourceGroupsTaggingAPIClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResourceGroupsTaggingAPIConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResourceGroupsTaggingAPIClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResourceGroupsTaggingAPIConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResourceGroupsTaggingAPIClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonResourceGroupsTaggingAPIClient Configuration Object</param>
        public AmazonResourceGroupsTaggingAPIClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonResourceGroupsTaggingAPIConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonResourceGroupsTaggingAPIEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonResourceGroupsTaggingAPIAuthSchemeHandler());
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


        #region  DescribeReportCreation


        /// <summary>
        /// Describes the status of the <c>StartReportCreation</c> operation. 
        /// 
        ///  
        /// <para>
        /// You can call this operation only from the organization's management account and from
        /// the us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportCreation service method.</param>
        /// 
        /// <returns>The response from the DescribeReportCreation service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied because performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html">Prerequisites
        /// and Permissions for Using Tag Policies</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must enable the tag policies service principal (<c>tagpolicies.tag.amazonaws.com</c>)
        /// to integrate with Organizations For information, see <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have a tag policy attached to the organization root, an OU, or an account.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/DescribeReportCreation">REST API Reference for DescribeReportCreation Operation</seealso>
        public virtual DescribeReportCreationResponse DescribeReportCreation(DescribeReportCreationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReportCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportCreationResponseUnmarshaller.Instance;

            return Invoke<DescribeReportCreationResponse>(request, options);
        }


        /// <summary>
        /// Describes the status of the <c>StartReportCreation</c> operation. 
        /// 
        ///  
        /// <para>
        /// You can call this operation only from the organization's management account and from
        /// the us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportCreation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReportCreation service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied because performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html">Prerequisites
        /// and Permissions for Using Tag Policies</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must enable the tag policies service principal (<c>tagpolicies.tag.amazonaws.com</c>)
        /// to integrate with Organizations For information, see <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have a tag policy attached to the organization root, an OU, or an account.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/DescribeReportCreation">REST API Reference for DescribeReportCreation Operation</seealso>
        public virtual Task<DescribeReportCreationResponse> DescribeReportCreationAsync(DescribeReportCreationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReportCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportCreationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReportCreationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComplianceSummary


        /// <summary>
        /// Returns a table that shows counts of resources that are noncompliant with their tag
        /// policies.
        /// 
        ///  
        /// <para>
        /// For more information on tag policies, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">Tag
        /// Policies</a> in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// You can call this operation only from the organization's management account and from
        /// the us-east-1 Region.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination, where the response can be sent in multiple pages.
        /// You should check the <c>PaginationToken</c> response parameter to determine if there
        /// are additional results available to return. Repeat the query, passing the <c>PaginationToken</c>
        /// response parameter value as an input to the next request until you recieve a <c>null</c>
        /// value. A null value for <c>PaginationToken</c> indicates that there are no more results
        /// waiting to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummary service method.</param>
        /// 
        /// <returns>The response from the GetComplianceSummary service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied because performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html">Prerequisites
        /// and Permissions for Using Tag Policies</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must enable the tag policies service principal (<c>tagpolicies.tag.amazonaws.com</c>)
        /// to integrate with Organizations For information, see <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have a tag policy attached to the organization root, an OU, or an account.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetComplianceSummary">REST API Reference for GetComplianceSummary Operation</seealso>
        public virtual GetComplianceSummaryResponse GetComplianceSummary(GetComplianceSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComplianceSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceSummaryResponseUnmarshaller.Instance;

            return Invoke<GetComplianceSummaryResponse>(request, options);
        }


        /// <summary>
        /// Returns a table that shows counts of resources that are noncompliant with their tag
        /// policies.
        /// 
        ///  
        /// <para>
        /// For more information on tag policies, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">Tag
        /// Policies</a> in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// You can call this operation only from the organization's management account and from
        /// the us-east-1 Region.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination, where the response can be sent in multiple pages.
        /// You should check the <c>PaginationToken</c> response parameter to determine if there
        /// are additional results available to return. Repeat the query, passing the <c>PaginationToken</c>
        /// response parameter value as an input to the next request until you recieve a <c>null</c>
        /// value. A null value for <c>PaginationToken</c> indicates that there are no more results
        /// waiting to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComplianceSummary service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied because performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html">Prerequisites
        /// and Permissions for Using Tag Policies</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must enable the tag policies service principal (<c>tagpolicies.tag.amazonaws.com</c>)
        /// to integrate with Organizations For information, see <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have a tag policy attached to the organization root, an OU, or an account.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetComplianceSummary">REST API Reference for GetComplianceSummary Operation</seealso>
        public virtual Task<GetComplianceSummaryResponse> GetComplianceSummaryAsync(GetComplianceSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComplianceSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceSummaryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetComplianceSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResources


        /// <summary>
        /// Returns all the tagged or previously tagged resources that are located in the specified
        /// Amazon Web Services Region for the account.
        /// 
        ///  
        /// <para>
        /// Depending on what information you want returned, you can also specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Filters</i> that specify what tags and resource types you want returned. The response
        /// includes all tags that are associated with the requested resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Information about compliance with the account's effective tag policy. For more information
        /// on tag policies, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">Tag
        /// Policies</a> in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation supports pagination, where the response can be sent in multiple pages.
        /// You should check the <c>PaginationToken</c> response parameter to determine if there
        /// are additional results available to return. Repeat the query, passing the <c>PaginationToken</c>
        /// response parameter value as an input to the next request until you recieve a <c>null</c>
        /// value. A null value for <c>PaginationToken</c> indicates that there are no more results
        /// waiting to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResources service method.</param>
        /// 
        /// <returns>The response from the GetResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <c>PaginationToken</c> is valid for a maximum of 15 minutes. Your request was denied
        /// because the specified <c>PaginationToken</c> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetResources">REST API Reference for GetResources Operation</seealso>
        public virtual GetResourcesResponse GetResources(GetResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return Invoke<GetResourcesResponse>(request, options);
        }


        /// <summary>
        /// Returns all the tagged or previously tagged resources that are located in the specified
        /// Amazon Web Services Region for the account.
        /// 
        ///  
        /// <para>
        /// Depending on what information you want returned, you can also specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Filters</i> that specify what tags and resource types you want returned. The response
        /// includes all tags that are associated with the requested resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Information about compliance with the account's effective tag policy. For more information
        /// on tag policies, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">Tag
        /// Policies</a> in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation supports pagination, where the response can be sent in multiple pages.
        /// You should check the <c>PaginationToken</c> response parameter to determine if there
        /// are additional results available to return. Repeat the query, passing the <c>PaginationToken</c>
        /// response parameter value as an input to the next request until you recieve a <c>null</c>
        /// value. A null value for <c>PaginationToken</c> indicates that there are no more results
        /// waiting to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <c>PaginationToken</c> is valid for a maximum of 15 minutes. Your request was denied
        /// because the specified <c>PaginationToken</c> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetResources">REST API Reference for GetResources Operation</seealso>
        public virtual Task<GetResourcesResponse> GetResourcesAsync(GetResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTagKeys


        /// <summary>
        /// Returns all tag keys currently in use in the specified Amazon Web Services Region
        /// for the calling account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination, where the response can be sent in multiple pages.
        /// You should check the <c>PaginationToken</c> response parameter to determine if there
        /// are additional results available to return. Repeat the query, passing the <c>PaginationToken</c>
        /// response parameter value as an input to the next request until you recieve a <c>null</c>
        /// value. A null value for <c>PaginationToken</c> indicates that there are no more results
        /// waiting to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTagKeys service method.</param>
        /// 
        /// <returns>The response from the GetTagKeys service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <c>PaginationToken</c> is valid for a maximum of 15 minutes. Your request was denied
        /// because the specified <c>PaginationToken</c> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagKeys">REST API Reference for GetTagKeys Operation</seealso>
        public virtual GetTagKeysResponse GetTagKeys(GetTagKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTagKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagKeysResponseUnmarshaller.Instance;

            return Invoke<GetTagKeysResponse>(request, options);
        }


        /// <summary>
        /// Returns all tag keys currently in use in the specified Amazon Web Services Region
        /// for the calling account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination, where the response can be sent in multiple pages.
        /// You should check the <c>PaginationToken</c> response parameter to determine if there
        /// are additional results available to return. Repeat the query, passing the <c>PaginationToken</c>
        /// response parameter value as an input to the next request until you recieve a <c>null</c>
        /// value. A null value for <c>PaginationToken</c> indicates that there are no more results
        /// waiting to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTagKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTagKeys service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <c>PaginationToken</c> is valid for a maximum of 15 minutes. Your request was denied
        /// because the specified <c>PaginationToken</c> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagKeys">REST API Reference for GetTagKeys Operation</seealso>
        public virtual Task<GetTagKeysResponse> GetTagKeysAsync(GetTagKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTagKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagKeysResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTagKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTagValues


        /// <summary>
        /// Returns all tag values for the specified key that are used in the specified Amazon
        /// Web Services Region for the calling account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination, where the response can be sent in multiple pages.
        /// You should check the <c>PaginationToken</c> response parameter to determine if there
        /// are additional results available to return. Repeat the query, passing the <c>PaginationToken</c>
        /// response parameter value as an input to the next request until you recieve a <c>null</c>
        /// value. A null value for <c>PaginationToken</c> indicates that there are no more results
        /// waiting to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTagValues service method.</param>
        /// 
        /// <returns>The response from the GetTagValues service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <c>PaginationToken</c> is valid for a maximum of 15 minutes. Your request was denied
        /// because the specified <c>PaginationToken</c> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagValues">REST API Reference for GetTagValues Operation</seealso>
        public virtual GetTagValuesResponse GetTagValues(GetTagValuesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTagValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagValuesResponseUnmarshaller.Instance;

            return Invoke<GetTagValuesResponse>(request, options);
        }


        /// <summary>
        /// Returns all tag values for the specified key that are used in the specified Amazon
        /// Web Services Region for the calling account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination, where the response can be sent in multiple pages.
        /// You should check the <c>PaginationToken</c> response parameter to determine if there
        /// are additional results available to return. Repeat the query, passing the <c>PaginationToken</c>
        /// response parameter value as an input to the next request until you recieve a <c>null</c>
        /// value. A null value for <c>PaginationToken</c> indicates that there are no more results
        /// waiting to be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTagValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTagValues service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <c>PaginationToken</c> is valid for a maximum of 15 minutes. Your request was denied
        /// because the specified <c>PaginationToken</c> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagValues">REST API Reference for GetTagValues Operation</seealso>
        public virtual Task<GetTagValuesResponse> GetTagValuesAsync(GetTagValuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTagValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagValuesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTagValuesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartReportCreation


        /// <summary>
        /// Generates a report that lists all tagged resources in the accounts across your organization
        /// and tells whether each resource is compliant with the effective tag policy. Compliance
        /// data is refreshed daily. The report is generated asynchronously.
        /// 
        ///  
        /// <para>
        /// The generated report is saved to the following location:
        /// </para>
        ///  
        /// <para>
        ///  <c>s3://example-bucket/AwsTagPolicies/o-exampleorgid/YYYY-MM-ddTHH:mm:ssZ/report.csv</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can call this operation only from the organization's management account and from
        /// the us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReportCreation service method.</param>
        /// 
        /// <returns>The response from the StartReportCreation service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied because performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html">Prerequisites
        /// and Permissions for Using Tag Policies</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must enable the tag policies service principal (<c>tagpolicies.tag.amazonaws.com</c>)
        /// to integrate with Organizations For information, see <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have a tag policy attached to the organization root, an OU, or an account.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/StartReportCreation">REST API Reference for StartReportCreation Operation</seealso>
        public virtual StartReportCreationResponse StartReportCreation(StartReportCreationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReportCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReportCreationResponseUnmarshaller.Instance;

            return Invoke<StartReportCreationResponse>(request, options);
        }


        /// <summary>
        /// Generates a report that lists all tagged resources in the accounts across your organization
        /// and tells whether each resource is compliant with the effective tag policy. Compliance
        /// data is refreshed daily. The report is generated asynchronously.
        /// 
        ///  
        /// <para>
        /// The generated report is saved to the following location:
        /// </para>
        ///  
        /// <para>
        ///  <c>s3://example-bucket/AwsTagPolicies/o-exampleorgid/YYYY-MM-ddTHH:mm:ssZ/report.csv</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can call this operation only from the organization's management account and from
        /// the us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReportCreation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartReportCreation service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied because performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html">Prerequisites
        /// and Permissions for Using Tag Policies</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must enable the tag policies service principal (<c>tagpolicies.tag.amazonaws.com</c>)
        /// to integrate with Organizations For information, see <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have a tag policy attached to the organization root, an OU, or an account.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/StartReportCreation">REST API Reference for StartReportCreation Operation</seealso>
        public virtual Task<StartReportCreationResponse> StartReportCreationAsync(StartReportCreationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReportCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReportCreationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartReportCreationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResources


        /// <summary>
        /// Applies one or more tags to the specified resources. Note the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Not all resources can have tags. For a list of services with resources that support
        /// tagging using this operation, see <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/supported-services.html">Services
        /// that support the Resource Groups Tagging API</a>. If the resource doesn't yet support
        /// this operation, the resource's service might support tagging using its own API operations.
        /// For more information, refer to the documentation for that service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each resource can have up to 50 tags. For other limits, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html#tag-conventions">Tag
        /// Naming and Usage Conventions</a> in the <i>Amazon Web Services General Reference.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified Amazon Web Services Region
        /// for the Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add tags to a resource, you need the necessary permissions for the service that
        /// the resource belongs to as well as permissions for adding tags. For more information,
        /// see the documentation for each service.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Do not store personally identifiable information (PII) or other confidential or sensitive
        /// information in tags. We use tags to provide you with billing and administration services.
        /// Tags are not intended to be used for private or sensitive data.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// In addition to the <c>tag:TagResources</c> permission required by this operation,
        /// you must also have the tagging permission defined by the service that created the
        /// resource. For example, to tag an Amazon EC2 instance using the <c>TagResources</c>
        /// operation, you must have both of the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>tag:TagResource</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:CreateTags</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResources service method.</param>
        /// 
        /// <returns>The response from the TagResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/TagResources">REST API Reference for TagResources Operation</seealso>
        public virtual TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourcesResponseUnmarshaller.Instance;

            return Invoke<TagResourcesResponse>(request, options);
        }


        /// <summary>
        /// Applies one or more tags to the specified resources. Note the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Not all resources can have tags. For a list of services with resources that support
        /// tagging using this operation, see <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/supported-services.html">Services
        /// that support the Resource Groups Tagging API</a>. If the resource doesn't yet support
        /// this operation, the resource's service might support tagging using its own API operations.
        /// For more information, refer to the documentation for that service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each resource can have up to 50 tags. For other limits, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html#tag-conventions">Tag
        /// Naming and Usage Conventions</a> in the <i>Amazon Web Services General Reference.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified Amazon Web Services Region
        /// for the Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add tags to a resource, you need the necessary permissions for the service that
        /// the resource belongs to as well as permissions for adding tags. For more information,
        /// see the documentation for each service.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Do not store personally identifiable information (PII) or other confidential or sensitive
        /// information in tags. We use tags to provide you with billing and administration services.
        /// Tags are not intended to be used for private or sensitive data.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// In addition to the <c>tag:TagResources</c> permission required by this operation,
        /// you must also have the tagging permission defined by the service that created the
        /// resource. For example, to tag an Amazon EC2 instance using the <c>TagResources</c>
        /// operation, you must have both of the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>tag:TagResource</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:CreateTags</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/TagResources">REST API Reference for TagResources Operation</seealso>
        public virtual Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResources


        /// <summary>
        /// Removes the specified tags from the specified resources. When you specify a tag key,
        /// the action removes both that key and its associated value. The operation succeeds
        /// even if you attempt to remove tags from a resource that were already removed. Note
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To remove tags from a resource, you need the necessary permissions for the service
        /// that the resource belongs to as well as permissions for removing tags. For more information,
        /// see the documentation for the service whose resource you want to untag.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified Amazon Web Services Region
        /// for the calling Amazon Web Services account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// In addition to the <c>tag:UntagResources</c> permission required by this operation,
        /// you must also have the remove tags permission defined by the service that created
        /// the resource. For example, to remove the tags from an Amazon EC2 instance using the
        /// <c>UntagResources</c> operation, you must have both of the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>tag:UntagResource</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:DeleteTags</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResources service method.</param>
        /// 
        /// <returns>The response from the UntagResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/UntagResources">REST API Reference for UntagResources Operation</seealso>
        public virtual UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourcesResponseUnmarshaller.Instance;

            return Invoke<UntagResourcesResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified tags from the specified resources. When you specify a tag key,
        /// the action removes both that key and its associated value. The operation succeeds
        /// even if you attempt to remove tags from a resource that were already removed. Note
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To remove tags from a resource, you need the necessary permissions for the service
        /// that the resource belongs to as well as permissions for removing tags. For more information,
        /// see the documentation for the service whose resource you want to untag.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified Amazon Web Services Region
        /// for the calling Amazon Web Services account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// In addition to the <c>tag:UntagResources</c> permission required by this operation,
        /// you must also have the remove tags permission defined by the service that created
        /// the resource. For example, to remove the tags from an Amazon EC2 instance using the
        /// <c>UntagResources</c> operation, you must have both of the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>tag:UntagResource</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:DeleteTags</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/UntagResources">REST API Reference for UntagResources Operation</seealso>
        public virtual Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}