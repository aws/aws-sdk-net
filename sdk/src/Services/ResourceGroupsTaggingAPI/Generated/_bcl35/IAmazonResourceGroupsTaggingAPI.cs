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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ResourceGroupsTaggingAPI.Model;

#pragma warning disable CS1570
namespace Amazon.ResourceGroupsTaggingAPI
{
    /// <summary>
    /// <para>Interface for accessing ResourceGroupsTaggingAPI</para>
    ///
    /// Resource Groups Tagging API
    /// </summary>
    public partial interface IAmazonResourceGroupsTaggingAPI : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IResourceGroupsTaggingAPIPaginatorFactory Paginators { get; }
#endif


        
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
        /// The request failed because performing the operation would violate a constraint.
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#tag-policies-prereqs">Prerequisites
        /// and permissions</a> in the <i>Tagging Amazon Web Services resources and Tag Editor</i>
        /// user guide. 
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
        /// The request failed because of one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A required parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A provided string parameter is malformed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An provided parameter value is out of range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#bucket-policy">Amazon
        /// S3 bucket policy for report storage</a> in the <i>Tagging Amazon Web Services resources
        /// and Tag Editor</i> user guide. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The partition specified in an ARN parameter in the request doesn't match the partition
        /// where you invoked the operation. The partition is specified by the second field of
        /// the ARN.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request failed because it exceeded the allowed frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/DescribeReportCreation">REST API Reference for DescribeReportCreation Operation</seealso>
        DescribeReportCreationResponse DescribeReportCreation(DescribeReportCreationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReportCreation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportCreation operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReportCreation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/DescribeReportCreation">REST API Reference for DescribeReportCreation Operation</seealso>
        IAsyncResult BeginDescribeReportCreation(DescribeReportCreationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReportCreation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReportCreation.</param>
        /// 
        /// <returns>Returns a  DescribeReportCreationResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/DescribeReportCreation">REST API Reference for DescribeReportCreation Operation</seealso>
        DescribeReportCreationResponse EndDescribeReportCreation(IAsyncResult asyncResult);

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
        /// The request failed because performing the operation would violate a constraint.
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#tag-policies-prereqs">Prerequisites
        /// and permissions</a> in the <i>Tagging Amazon Web Services resources and Tag Editor</i>
        /// user guide. 
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
        /// The request failed because of one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A required parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A provided string parameter is malformed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An provided parameter value is out of range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#bucket-policy">Amazon
        /// S3 bucket policy for report storage</a> in the <i>Tagging Amazon Web Services resources
        /// and Tag Editor</i> user guide. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The partition specified in an ARN parameter in the request doesn't match the partition
        /// where you invoked the operation. The partition is specified by the second field of
        /// the ARN.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request failed because it exceeded the allowed frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetComplianceSummary">REST API Reference for GetComplianceSummary Operation</seealso>
        GetComplianceSummaryResponse GetComplianceSummary(GetComplianceSummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummary operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComplianceSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetComplianceSummary">REST API Reference for GetComplianceSummary Operation</seealso>
        IAsyncResult BeginGetComplianceSummary(GetComplianceSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetComplianceSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComplianceSummary.</param>
        /// 
        /// <returns>Returns a  GetComplianceSummaryResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetComplianceSummary">REST API Reference for GetComplianceSummary Operation</seealso>
        GetComplianceSummaryResponse EndGetComplianceSummary(IAsyncResult asyncResult);

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
        ///  <note> 
        /// <para>
        ///  <c>GetResources</c> does not return untagged resources. 
        /// </para>
        ///  
        /// <para>
        /// To find untagged resources in your account, use Amazon Web Services Resource Explorer
        /// with a query that uses <c>tag:none</c>. For more information, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/using-search-query-syntax.html">
        /// Search query syntax reference for Resource Explorer</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResources service method.</param>
        /// 
        /// <returns>The response from the GetResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// The request failed because of one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A required parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A provided string parameter is malformed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An provided parameter value is out of range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#bucket-policy">Amazon
        /// S3 bucket policy for report storage</a> in the <i>Tagging Amazon Web Services resources
        /// and Tag Editor</i> user guide. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The partition specified in an ARN parameter in the request doesn't match the partition
        /// where you invoked the operation. The partition is specified by the second field of
        /// the ARN.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// The request failed because the specified <c>PaginationToken</c> has expired. A <c>PaginationToken</c>
        /// is valid for a maximum of 15 minutes.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request failed because it exceeded the allowed frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetResources">REST API Reference for GetResources Operation</seealso>
        GetResourcesResponse GetResources(GetResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResources operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetResources">REST API Reference for GetResources Operation</seealso>
        IAsyncResult BeginGetResources(GetResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResources.</param>
        /// 
        /// <returns>Returns a  GetResourcesResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetResources">REST API Reference for GetResources Operation</seealso>
        GetResourcesResponse EndGetResources(IAsyncResult asyncResult);

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
        /// The request failed because of one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A required parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A provided string parameter is malformed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An provided parameter value is out of range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#bucket-policy">Amazon
        /// S3 bucket policy for report storage</a> in the <i>Tagging Amazon Web Services resources
        /// and Tag Editor</i> user guide. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The partition specified in an ARN parameter in the request doesn't match the partition
        /// where you invoked the operation. The partition is specified by the second field of
        /// the ARN.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// The request failed because the specified <c>PaginationToken</c> has expired. A <c>PaginationToken</c>
        /// is valid for a maximum of 15 minutes.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request failed because it exceeded the allowed frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagKeys">REST API Reference for GetTagKeys Operation</seealso>
        GetTagKeysResponse GetTagKeys(GetTagKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTagKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTagKeys operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTagKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagKeys">REST API Reference for GetTagKeys Operation</seealso>
        IAsyncResult BeginGetTagKeys(GetTagKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTagKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTagKeys.</param>
        /// 
        /// <returns>Returns a  GetTagKeysResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagKeys">REST API Reference for GetTagKeys Operation</seealso>
        GetTagKeysResponse EndGetTagKeys(IAsyncResult asyncResult);

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
        /// The request failed because of one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A required parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A provided string parameter is malformed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An provided parameter value is out of range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#bucket-policy">Amazon
        /// S3 bucket policy for report storage</a> in the <i>Tagging Amazon Web Services resources
        /// and Tag Editor</i> user guide. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The partition specified in an ARN parameter in the request doesn't match the partition
        /// where you invoked the operation. The partition is specified by the second field of
        /// the ARN.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// The request failed because the specified <c>PaginationToken</c> has expired. A <c>PaginationToken</c>
        /// is valid for a maximum of 15 minutes.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request failed because it exceeded the allowed frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagValues">REST API Reference for GetTagValues Operation</seealso>
        GetTagValuesResponse GetTagValues(GetTagValuesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTagValues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTagValues operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTagValues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagValues">REST API Reference for GetTagValues Operation</seealso>
        IAsyncResult BeginGetTagValues(GetTagValuesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTagValues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTagValues.</param>
        /// 
        /// <returns>Returns a  GetTagValuesResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagValues">REST API Reference for GetTagValues Operation</seealso>
        GetTagValuesResponse EndGetTagValues(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRequiredTags


        /// <summary>
        /// Lists the required tags for supported resource types in an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequiredTags service method.</param>
        /// 
        /// <returns>The response from the ListRequiredTags service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// The request failed because of one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A required parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A provided string parameter is malformed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An provided parameter value is out of range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#bucket-policy">Amazon
        /// S3 bucket policy for report storage</a> in the <i>Tagging Amazon Web Services resources
        /// and Tag Editor</i> user guide. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The partition specified in an ARN parameter in the request doesn't match the partition
        /// where you invoked the operation. The partition is specified by the second field of
        /// the ARN.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// The request failed because the specified <c>PaginationToken</c> has expired. A <c>PaginationToken</c>
        /// is valid for a maximum of 15 minutes.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request failed because it exceeded the allowed frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/ListRequiredTags">REST API Reference for ListRequiredTags Operation</seealso>
        ListRequiredTagsResponse ListRequiredTags(ListRequiredTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRequiredTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRequiredTags operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRequiredTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/ListRequiredTags">REST API Reference for ListRequiredTags Operation</seealso>
        IAsyncResult BeginListRequiredTags(ListRequiredTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRequiredTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRequiredTags.</param>
        /// 
        /// <returns>Returns a  ListRequiredTagsResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/ListRequiredTags">REST API Reference for ListRequiredTags Operation</seealso>
        ListRequiredTagsResponse EndListRequiredTags(IAsyncResult asyncResult);

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
        ///  <c>s3://amzn-s3-demo-bucket/AwsTagPolicies/o-exampleorgid/YYYY-MM-ddTHH:mm:ssZ/report.csv</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about evaluating resource compliance with tag policies, including
        /// the required permissions, review <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#tag-policies-permissions-org">Permissions
        /// for evaluating organization-wide compliance</a> in the <i>Tagging Amazon Web Services
        /// Resources and Tag Editor</i> user guide. 
        /// </para>
        ///  
        /// <para>
        /// You can call this operation only from the organization's management account and from
        /// the us-east-1 Region.
        /// </para>
        ///  
        /// <para>
        /// If the account associated with the identity used to call <c>StartReportCreation</c>
        /// is different from the account that owns the Amazon S3 bucket, there must be a bucket
        /// policy attached to the bucket to provide access. For more information, review <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#bucket-policy">Amazon
        /// S3 bucket policy for report storage</a> in the <i>Tagging Amazon Web Services Resources
        /// and Tag Editor</i> user guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReportCreation service method.</param>
        /// 
        /// <returns>The response from the StartReportCreation service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConcurrentModificationException">
        /// The request failed because the target of the operation is currently being modified
        /// by a different request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request failed because performing the operation would violate a constraint.
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#tag-policies-prereqs">Prerequisites
        /// and permissions</a> in the <i>Tagging Amazon Web Services resources and Tag Editor</i>
        /// user guide. 
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
        /// The request failed because of one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A required parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A provided string parameter is malformed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An provided parameter value is out of range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#bucket-policy">Amazon
        /// S3 bucket policy for report storage</a> in the <i>Tagging Amazon Web Services resources
        /// and Tag Editor</i> user guide. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The partition specified in an ARN parameter in the request doesn't match the partition
        /// where you invoked the operation. The partition is specified by the second field of
        /// the ARN.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request failed because it exceeded the allowed frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/StartReportCreation">REST API Reference for StartReportCreation Operation</seealso>
        StartReportCreationResponse StartReportCreation(StartReportCreationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartReportCreation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReportCreation operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReportCreation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/StartReportCreation">REST API Reference for StartReportCreation Operation</seealso>
        IAsyncResult BeginStartReportCreation(StartReportCreationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartReportCreation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReportCreation.</param>
        /// 
        /// <returns>Returns a  StartReportCreationResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/StartReportCreation">REST API Reference for StartReportCreation Operation</seealso>
        StartReportCreationResponse EndStartReportCreation(IAsyncResult asyncResult);

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
        ///  </li> <li> 
        /// <para>
        /// When you use the <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/overview.html">Amazon
        /// Web Services Resource Groups Tagging API</a> to update tags for Amazon Web Services
        /// CloudFormation stack sets, Amazon Web Services calls the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStack.html">Amazon
        /// Web Services CloudFormation <c>UpdateStack</c> </a> operation. This operation may
        /// initiate additional resource property updates in addition to the desired tag updates.
        /// To avoid unexpected resource updates, Amazon Web Services recommends that you only
        /// apply or update tags to your CloudFormation stack sets using Amazon Web Services CloudFormation.
        /// 
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
        ///  <c>tag:TagResources</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:CreateTags</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// In addition, some services might have specific requirements for tagging some types
        /// of resources. For example, to tag an Amazon S3 bucket, you must also have the <c>s3:GetBucketTagging</c>
        /// permission. If the expected minimum permissions don't work, check the documentation
        /// for that service's tagging APIs for more information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResources service method.</param>
        /// 
        /// <returns>The response from the TagResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// The request failed because of one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A required parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A provided string parameter is malformed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An provided parameter value is out of range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#bucket-policy">Amazon
        /// S3 bucket policy for report storage</a> in the <i>Tagging Amazon Web Services resources
        /// and Tag Editor</i> user guide. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The partition specified in an ARN parameter in the request doesn't match the partition
        /// where you invoked the operation. The partition is specified by the second field of
        /// the ARN.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request failed because it exceeded the allowed frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/TagResources">REST API Reference for TagResources Operation</seealso>
        TagResourcesResponse TagResources(TagResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResources operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/TagResources">REST API Reference for TagResources Operation</seealso>
        IAsyncResult BeginTagResources(TagResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResources.</param>
        /// 
        /// <returns>Returns a  TagResourcesResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/TagResources">REST API Reference for TagResources Operation</seealso>
        TagResourcesResponse EndTagResources(IAsyncResult asyncResult);

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
        ///  <c>tag:UntagResources</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ec2:DeleteTags</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// In addition, some services might have specific requirements for untagging some types
        /// of resources. For example, to untag Amazon Web Services Glue Connection, you must
        /// also have the <c>glue:GetConnection</c> permission. If the expected minimum permissions
        /// don't work, check the documentation for that service's tagging APIs for more information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResources service method.</param>
        /// 
        /// <returns>The response from the UntagResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// The request failed because of one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A required parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A provided string parameter is malformed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An provided parameter value is out of range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tag-policies-orgs.html#bucket-policy">Amazon
        /// S3 bucket policy for report storage</a> in the <i>Tagging Amazon Web Services resources
        /// and Tag Editor</i> user guide. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The partition specified in an ARN parameter in the request doesn't match the partition
        /// where you invoked the operation. The partition is specified by the second field of
        /// the ARN.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request failed because it exceeded the allowed frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/UntagResources">REST API Reference for UntagResources Operation</seealso>
        UntagResourcesResponse UntagResources(UntagResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResources operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/UntagResources">REST API Reference for UntagResources Operation</seealso>
        IAsyncResult BeginUntagResources(UntagResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResources.</param>
        /// 
        /// <returns>Returns a  UntagResourcesResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/UntagResources">REST API Reference for UntagResources Operation</seealso>
        UntagResourcesResponse EndUntagResources(IAsyncResult asyncResult);

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