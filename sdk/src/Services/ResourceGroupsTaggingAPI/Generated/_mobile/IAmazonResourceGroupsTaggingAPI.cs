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
using System.Threading;
using System.Threading.Tasks;
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
    /// A tag is a label that you assign to an AWS resource. A tag consists of a key and a
    /// value, both of which you define. For example, if you have two Amazon EC2 instances,
    /// you might assign both a tag key of "Stack." But the value of "Stack" might be "Testing"
    /// for one and "Production" for the other.
    /// </para>
    ///  
    /// <para>
    /// Tagging can help you organize your resources and enables you to simplify resource
    /// management, access management and cost allocation. 
    /// </para>
    ///  
    /// <para>
    /// You can use the resource groups tagging API operations to complete the following tasks:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Tag and untag supported resources located in the specified region for the AWS account
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use tag-based filters to search for resources located in the specified region for
    /// the AWS account
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// List all existing tag keys in the specified region for the AWS account
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// List all existing values for the specified key in the specified region for the AWS
    /// account
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To make full use of the resource groups tagging API operations, you might need additional
    /// IAM permissions, including permission to access the resources of individual services
    /// as well as permission to view and apply tags to those resources. For more information,
    /// see <a href="http://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/obtaining-permissions-for-resource-groups.html">Obtaining
    /// Permissions for Resource Groups and Tag Editor</a>.
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
    /// AWS AppSync
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
    /// AWS IoT Greengrass
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
    /// Amazon Kinesis Data Analytics
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
    /// Amazon Simple Notification Service (SNS)
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
                
        #region  GetResources



        /// <summary>
        /// Returns all the tagged or previously tagged resources that are located in the specified
        /// region for the AWS account. You can optionally specify <i>filters</i> (tags and resource
        /// types) in your request, depending on what information you want returned. The response
        /// includes all tags that are associated with the requested resources.
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
        /// A parameter is missing or a malformed string or invalid or out-of-range value was
        /// supplied for the request parameter.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetResources">REST API Reference for GetResources Operation</seealso>
        Task<GetResourcesResponse> GetResourcesAsync(GetResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTagKeys



        /// <summary>
        /// Returns all tag keys in the specified region for the AWS account.
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
        /// A parameter is missing or a malformed string or invalid or out-of-range value was
        /// supplied for the request parameter.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagKeys">REST API Reference for GetTagKeys Operation</seealso>
        Task<GetTagKeysResponse> GetTagKeysAsync(GetTagKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTagValues



        /// <summary>
        /// Returns all tag values for the specified key in the specified region for the AWS account.
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
        /// A parameter is missing or a malformed string or invalid or out-of-range value was
        /// supplied for the request parameter.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagValues">REST API Reference for GetTagValues Operation</seealso>
        Task<GetTagValuesResponse> GetTagValuesAsync(GetTagValuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResources



        /// <summary>
        /// Applies one or more tags to the specified resources. Note the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Not all resources can have tags. For a list of resources that support tagging, see
        /// <a href="http://docs.aws.amazon.com/ARG/latest/userguide/supported-resources.html">Supported
        /// Resources</a> in the <i>AWS Resource Groups User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each resource can have up to 50 tags. For other limits, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html#tag-restrictions">Tag
        /// Restrictions</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified region for the AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add tags to a resource, you need the necessary permissions for the service that
        /// the resource belongs to as well as permissions for adding tags. For more information,
        /// see <a href="http://docs.aws.amazon.com/ARG/latest/userguide/obtaining-permissions-for-tagging.html">Obtaining
        /// Permissions for Tagging</a> in the <i>AWS Resource Groups User Guide</i>.
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
        /// A parameter is missing or a malformed string or invalid or out-of-range value was
        /// supplied for the request parameter.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/TagResources">REST API Reference for TagResources Operation</seealso>
        Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// see <a href="http://docs.aws.amazon.com/ARG/latest/userguide/obtaining-permissions-for-tagging.html">Obtaining
        /// Permissions for Tagging</a> in the <i>AWS Resource Groups User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified region for the AWS account.
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
        /// A parameter is missing or a malformed string or invalid or out-of-range value was
        /// supplied for the request parameter.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/UntagResources">REST API Reference for UntagResources Operation</seealso>
        Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}