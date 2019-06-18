/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ResourceGroupsTaggingAPI
{
    /// <summary>
    /// Interface for accessing ResourceGroupsTaggingAPI
    ///
    /// Resource Groups Tagging API 
    /// <para>
    /// This guide describes the API operations for the resource groups tagging.
    /// </para>
    ///  
    /// <para>
    /// A tag is a key-value pair that you can add to an AWS resource. A tag consists of a
    /// key and a value, both of which you define. For example, if you have two Amazon EC2
    /// instances, you might assign both a tag key of "Stack." But the value of "Stack" might
    /// be "Testing" for one and "Production" for the other.
    /// </para>
    ///  
    /// <para>
    /// Tagging can help you organize your resources and enables you to simplify resource
    /// management, access management, and cost allocation. 
    /// </para>
    ///  
    /// <para>
    /// You can use the resource groups tagging API operations to complete the following tasks:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Tag and untag supported resources located in the specified Region for the AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use tag-based filters to search for resources located in the specified Region for
    /// the AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// List all existing tag keys in the specified Region for the AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// List all existing values for the specified key in the specified Region for the AWS
    /// account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Configure <i>tag policies</i> to help maintain standardized tags across your organization's
    /// resources. For more information on tag policies, see <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies.html">Tag
    /// Policies</a>in the <i>AWS Resource Groups User Guide.</i> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To make full use of the resource groups tagging API operations, you might need additional
    /// IAM permissions, including permission to access the resources of individual services
    /// as well as permission to view and apply tags to those resources. For more information,
    /// see <a href="http://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-prereqs.html#rg-permissions">Set
    /// Up Permissions</a> in the <i>AWS Resource Groups User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// You can use the Resource Groups Tagging API to tag resources for the following AWS
    /// services.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Alexa for Business (a4b)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// API Gateway
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS AppStream
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Athena
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Aurora
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Certificate Manager
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Certificate Manager Private CA
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Cloud Directory
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS CloudFormation
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon CloudFront
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS CloudHSM
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS CloudTrail
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon CloudWatch (alarms only)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon CloudWatch Events
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon CloudWatch Logs
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS CodeBuild
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS CodeStar
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Cognito Identity
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Cognito User Pools
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Comprehend
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Config
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Data Pipeline
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Database Migration Service
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Datasync
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Direct Connect
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Directory Service
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon DynamoDB
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EBS
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EC2
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon ECR
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon ECS
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Elastic Beanstalk
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Elastic File System
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Elastic Load Balancing
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon ElastiCache
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Elasticsearch Service
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Elemental MediaLive
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Elemental MediaPackage
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Elemental MediaTailor
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EMR
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon FSx
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Glacier
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Glue
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Inspector
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS IoT Analytics
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS IoT Core
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS IoT Device Defender
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS IoT Device Management
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Key Management Service
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Kinesis
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Kinesis Data Firehose
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Lambda
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS License Manager
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Machine Learning
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon MQ
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon MSK
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Neptune
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS OpsWorks
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon RDS
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Redshift
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Resource Access Manager
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Resource Groups
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS RoboMaker
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Route 53
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Route 53 Resolver
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon S3 (buckets only)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon SageMaker
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Secrets Manager
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Service Catalog
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Simple Queue Service (SQS)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Simple System Manager (SSM)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Step Functions
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Storage Gateway
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Transfer for SFTP
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon VPC
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon WorkSpaces
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonResourceGroupsTaggingAPI : IAmazonService, IDisposable
    {

        
        #region  DeleteTagPolicy


        /// <summary>
        /// Deletes the policy that is attached to the specified organization root or account.
        /// 
        ///  
        /// <para>
        /// You can call this operation from the organization's master account only and from the
        /// us-east-1 Region only. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteTagPolicy service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied as performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific API or
        /// operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your account must be part of an organization, and you must enable all features in
        /// AWS Organizations. <a href="http://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-prereqs.html#rg-permissions">Set
        /// Up Permissions</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The previous report expired. 
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/DeleteTagPolicy">REST API Reference for DeleteTagPolicy Operation</seealso>
        DeleteTagPolicyResponse DeleteTagPolicy(DeleteTagPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTagPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagPolicy operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTagPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/DeleteTagPolicy">REST API Reference for DeleteTagPolicy Operation</seealso>
        IAsyncResult BeginDeleteTagPolicy(DeleteTagPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTagPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTagPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteTagPolicyResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/DeleteTagPolicy">REST API Reference for DeleteTagPolicy Operation</seealso>
        DeleteTagPolicyResponse EndDeleteTagPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReportCreation


        /// <summary>
        /// Describes the status of the <code>StartReportCreation</code> operation. 
        /// 
        ///  
        /// <para>
        /// You can call this operation from the organization's master account only and from the
        /// us-east-1 Region only. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportCreation service method.</param>
        /// 
        /// <returns>The response from the DescribeReportCreation service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied as performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific API or
        /// operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your account must be part of an organization, and you must enable all features in
        /// AWS Organizations. <a href="http://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-prereqs.html#rg-permissions">Set
        /// Up Permissions</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The previous report expired. 
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
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
        
        #region  DisableTagPolicies


        /// <summary>
        /// Disables tag policies for your organization and deletes all tag policies.
        /// 
        ///  
        /// <para>
        /// You can call this operation from the organization's master account only and from the
        /// us-east-1 Region only. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Use caution when disabling tag policies, as this is a destructive operation that applies
        /// to your entire organization. You cannot undo this operation.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableTagPolicies service method.</param>
        /// 
        /// <returns>The response from the DisableTagPolicies service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied as performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific API or
        /// operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your account must be part of an organization, and you must enable all features in
        /// AWS Organizations. <a href="http://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-prereqs.html#rg-permissions">Set
        /// Up Permissions</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The previous report expired. 
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/DisableTagPolicies">REST API Reference for DisableTagPolicies Operation</seealso>
        DisableTagPoliciesResponse DisableTagPolicies(DisableTagPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableTagPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableTagPolicies operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableTagPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/DisableTagPolicies">REST API Reference for DisableTagPolicies Operation</seealso>
        IAsyncResult BeginDisableTagPolicies(DisableTagPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableTagPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableTagPolicies.</param>
        /// 
        /// <returns>Returns a  DisableTagPoliciesResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/DisableTagPolicies">REST API Reference for DisableTagPolicies Operation</seealso>
        DisableTagPoliciesResponse EndDisableTagPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableTagPolicies


        /// <summary>
        /// Enables tag policies for your organization. To use tag policies, you must be using
        /// AWS Organizations with all features enabled. 
        /// 
        ///  
        /// <para>
        /// You can call this operation from the organization's master account only and from the
        /// us-east-1 Region only. 
        /// </para>
        ///  
        /// <para>
        /// This operation does the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Enables tag policies for the specified organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calls the <a href="http://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>
        /// API on your behalf to allow service access with the <code>tagpolicies.tag.amazonaws.com</code>
        /// service principal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Creates a <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html">service-linked
        /// role</a> named <code>AWSServiceRoleForTagPolicies</code>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on tag policies, see <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies.html">Tag
        /// Policies</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableTagPolicies service method.</param>
        /// 
        /// <returns>The response from the EnableTagPolicies service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied as performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific API or
        /// operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your account must be part of an organization, and you must enable all features in
        /// AWS Organizations. <a href="http://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-prereqs.html#rg-permissions">Set
        /// Up Permissions</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The previous report expired. 
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/EnableTagPolicies">REST API Reference for EnableTagPolicies Operation</seealso>
        EnableTagPoliciesResponse EnableTagPolicies(EnableTagPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableTagPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableTagPolicies operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableTagPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/EnableTagPolicies">REST API Reference for EnableTagPolicies Operation</seealso>
        IAsyncResult BeginEnableTagPolicies(EnableTagPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableTagPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableTagPolicies.</param>
        /// 
        /// <returns>Returns a  EnableTagPoliciesResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/EnableTagPolicies">REST API Reference for EnableTagPolicies Operation</seealso>
        EnableTagPoliciesResponse EndEnableTagPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  GetComplianceSummary


        /// <summary>
        /// Returns a table that shows counts of resources that are noncompliant with their tag
        /// policies.
        /// 
        ///  
        /// <para>
        /// For more information on tag policies, see <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies.html">Tag
        /// Policies</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// You can call this operation from the organization's master account only and from the
        /// us-east-1 Region only. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummary service method.</param>
        /// 
        /// <returns>The response from the GetComplianceSummary service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied as performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific API or
        /// operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your account must be part of an organization, and you must enable all features in
        /// AWS Organizations. <a href="http://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-prereqs.html#rg-permissions">Set
        /// Up Permissions</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The previous report expired. 
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
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
        
        #region  GetEffectiveTagPolicy


        /// <summary>
        /// Returns the contents of the effective tag policy for the AWS account. Depending on
        /// how you use tag policies, the effective tag policy for an account is one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The tag policy attached to the organization that the account belongs to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The tag policy attached to the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The combination of both policies if tag policies are attached to the organization
        /// root and account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEffectiveTagPolicy service method.</param>
        /// 
        /// <returns>The response from the GetEffectiveTagPolicy service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied as performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific API or
        /// operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your account must be part of an organization, and you must enable all features in
        /// AWS Organizations. <a href="http://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-prereqs.html#rg-permissions">Set
        /// Up Permissions</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The previous report expired. 
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetEffectiveTagPolicy">REST API Reference for GetEffectiveTagPolicy Operation</seealso>
        GetEffectiveTagPolicyResponse GetEffectiveTagPolicy(GetEffectiveTagPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEffectiveTagPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEffectiveTagPolicy operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEffectiveTagPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetEffectiveTagPolicy">REST API Reference for GetEffectiveTagPolicy Operation</seealso>
        IAsyncResult BeginGetEffectiveTagPolicy(GetEffectiveTagPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEffectiveTagPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEffectiveTagPolicy.</param>
        /// 
        /// <returns>Returns a  GetEffectiveTagPolicyResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetEffectiveTagPolicy">REST API Reference for GetEffectiveTagPolicy Operation</seealso>
        GetEffectiveTagPolicyResponse EndGetEffectiveTagPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResources


        /// <summary>
        /// Returns all the tagged or previously tagged resources that are located in the specified
        /// Region for the AWS account.
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
        /// Information about compliance with tag policies. If supplied, the compliance check
        /// follows the specified tag policy instead of following the effective tag policy. For
        /// more information on tag policies, see <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies.html">Tag
        /// Policies</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You can check the <code>PaginationToken</code> response parameter to determine if
        /// a query completed. Queries can occasionally return fewer results on a page than allowed.
        /// The <code>PaginationToken</code> response parameter value is <code>null</code> <i>only</i>
        /// when there are no more results to display. 
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
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
        /// Returns all tag keys in the specified Region for the AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// You can check the <code>PaginationToken</code> response parameter to determine if
        /// a query completed. Queries can occasionally return fewer results on a page than allowed.
        /// The <code>PaginationToken</code> response parameter value is <code>null</code> <i>only</i>
        /// when there are no more results to display. 
        /// </para>
        ///  </note>
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
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
        
        #region  GetTagPolicy


        /// <summary>
        /// Returns the policy that is attached to the specified target. 
        /// 
        ///  
        /// <para>
        /// You can call this operation from the organization's master account only and from the
        /// us-east-1 Region only. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTagPolicy service method.</param>
        /// 
        /// <returns>The response from the GetTagPolicy service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied as performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific API or
        /// operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your account must be part of an organization, and you must enable all features in
        /// AWS Organizations. <a href="http://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-prereqs.html#rg-permissions">Set
        /// Up Permissions</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The previous report expired. 
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagPolicy">REST API Reference for GetTagPolicy Operation</seealso>
        GetTagPolicyResponse GetTagPolicy(GetTagPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTagPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTagPolicy operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTagPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagPolicy">REST API Reference for GetTagPolicy Operation</seealso>
        IAsyncResult BeginGetTagPolicy(GetTagPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTagPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTagPolicy.</param>
        /// 
        /// <returns>Returns a  GetTagPolicyResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagPolicy">REST API Reference for GetTagPolicy Operation</seealso>
        GetTagPolicyResponse EndGetTagPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTagValues


        /// <summary>
        /// Returns all tag values for the specified key in the specified Region for the AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// You can check the <code>PaginationToken</code> response parameter to determine if
        /// a query completed. Queries can occasionally return fewer results on a page than allowed.
        /// The <code>PaginationToken</code> response parameter value is <code>null</code> <i>only</i>
        /// when there are no more results to display. 
        /// </para>
        ///  </note>
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
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
        
        #region  PutTagPolicy


        /// <summary>
        /// Validates the tag policy and then attaches it to the account or organization root.
        /// This policy determines whether a resource is compliant.
        /// 
        ///  
        /// <para>
        /// Validating the tag policy includes checking that the tag policy document includes
        /// the required components, uses JSON syntax, and has fewer than 5,000 characters (including
        /// spaces). For more information, see <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-structure.html">Tag
        /// Policy Structure</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you later call this operation to attach a tag policy to the same organization root
        /// or account, it overwrites the original call without prompting you to confirm.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can call this operation from the organization's master account only, and from
        /// the us-east-1 Region only. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTagPolicy service method.</param>
        /// 
        /// <returns>The response from the PutTagPolicy service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied as performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific API or
        /// operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your account must be part of an organization, and you must enable all features in
        /// AWS Organizations. <a href="http://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-prereqs.html#rg-permissions">Set
        /// Up Permissions</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The previous report expired. 
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/PutTagPolicy">REST API Reference for PutTagPolicy Operation</seealso>
        PutTagPolicyResponse PutTagPolicy(PutTagPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutTagPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTagPolicy operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTagPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/PutTagPolicy">REST API Reference for PutTagPolicy Operation</seealso>
        IAsyncResult BeginPutTagPolicy(PutTagPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutTagPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTagPolicy.</param>
        /// 
        /// <returns>Returns a  PutTagPolicyResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/PutTagPolicy">REST API Reference for PutTagPolicy Operation</seealso>
        PutTagPolicyResponse EndPutTagPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  StartReportCreation


        /// <summary>
        /// Generates a report that lists all tagged resources in accounts across your organization,
        /// and whether each resource is compliant with the effective tag policy. 
        /// 
        ///  
        /// <para>
        /// You can call this operation from the organization's master account only and from the
        /// us-east-1 Region only. 
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
        /// The request was denied as performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific API or
        /// operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your account must be part of an organization, and you must enable all features in
        /// AWS Organizations. <a href="http://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-prereqs.html#rg-permissions">Set
        /// Up Permissions</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The previous report expired. 
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
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
        /// Not all resources can have tags. For a list of resources that support tagging, see
        /// <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/Welcome.html">this
        /// list</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each resource can have up to 50 tags. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified Region for the AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add tags to a resource, you need the necessary permissions for the service that
        /// the resource belongs to as well as permissions for adding tags. For more information,
        /// see <a href="http://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-prereqs.html#rg-permissions">Set
        /// Up Permissions</a> in the <i>AWS Resource Groups User Guide.</i> 
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
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
        /// see <a href="http://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-prereqs.html#rg-permissions">Set
        /// Up Permissions</a> in the <i>AWS Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified Region for the AWS account.
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
        /// There is an issue with the tag policy: It exceeds the maximum size limit, is invalid,
        /// or doesn't use JSON syntax. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-prereqs.html#bucket-policy-org-report">Additional
        /// Requirements for Running Organization-Wide Tag Compliance Report</a> in the <i>AWS
        /// Resource Groups User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
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
        
    }
}