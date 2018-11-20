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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudTrail.Model;

namespace Amazon.CloudTrail
{
    /// <summary>
    /// Interface for accessing CloudTrail
    ///
    /// AWS CloudTrail 
    /// <para>
    /// This is the CloudTrail API Reference. It provides descriptions of actions, data types,
    /// common parameters, and common errors for CloudTrail.
    /// </para>
    ///  
    /// <para>
    /// CloudTrail is a web service that records AWS API calls for your AWS account and delivers
    /// log files to an Amazon S3 bucket. The recorded information includes the identity of
    /// the user, the start time of the AWS API call, the source IP address, the request parameters,
    /// and the response elements returned by the service.
    /// </para>
    ///  <note> 
    /// <para>
    /// As an alternative to the API, you can use one of the AWS SDKs, which consist of libraries
    /// and sample code for various programming languages and platforms (Java, Ruby, .NET,
    /// iOS, Android, etc.). The SDKs provide a convenient way to create programmatic access
    /// to AWSCloudTrail. For example, the SDKs take care of cryptographically signing requests,
    /// managing errors, and retrying requests automatically. For information about the AWS
    /// SDKs, including how to download and install them, see the <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services page</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// See the <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-user-guide.html">AWS
    /// CloudTrail User Guide</a> for information about the data that is included with each
    /// AWS API call listed in the log files.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudTrail : IAmazonService, IDisposable
    {

        
        #region  AddTags


        /// <summary>
        /// Adds one or more tags to a trail, up to a limit of 50. Tags must be unique per trail.
        /// Overwrites an existing tag's value when a new value is specified for an existing tag
        /// key. If you specify a key without a value, the tag will be created with the specified
        /// key and a value of null. You can tag a trail that applies to all regions only from
        /// the region in which the trail was created (that is, from its home region).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an invalid trail ARN. The
        /// format of a trail ARN is:
        /// 
        ///  
        /// <para>
        ///  <code>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</code> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the key or value specified for the tag does not match
        /// the regular expression <code>^([\\p{L}\\p{Z}\\p{N}_.:/=+\\-@]*)$</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TagsLimitExceededException">
        /// The number of tags per trail has exceeded the permitted amount. Currently, the limit
        /// is 50.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse AddTags(AddTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/AddTags">REST API Reference for AddTags Operation</seealso>
        IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a  AddTagsResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse EndAddTags(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTrail


        /// <summary>
        /// Creates a trail that specifies the settings for delivery of log data to an Amazon
        /// S3 bucket. A maximum of five trails can exist in a region, irrespective of the region
        /// in which they were created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrail service method.</param>
        /// 
        /// <returns>The response from the CreateTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between AWS CloudTrail
        /// and AWS Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">Enabling
        /// Trusted Access with Other AWS Services</a> and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudWatchLogsDeliveryUnavailableException">
        /// Cannot set a CloudWatch Logs delivery for this region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM user or role that is used to create the organization
        /// trail is lacking one or more required permissions for creating an organization trail
        /// in a required service. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// This exception is thrown when the policy on the S3 bucket or KMS key is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientSnsTopicPolicyException">
        /// This exception is thrown when the policy on the SNS topic is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsLogGroupArnException">
        /// This exception is thrown when the provided CloudWatch log group is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsRoleArnException">
        /// This exception is thrown when the provided role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3BucketNameException">
        /// This exception is thrown when the provided S3 bucket name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3PrefixException">
        /// This exception is thrown when the provided S3 prefix is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidSnsTopicNameException">
        /// This exception is thrown when the provided SNS topic name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail can’t be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyDisabledException">
        /// This exception is deprecated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, or when the S3 bucket and
        /// the KMS key are not in the same region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.MaximumNumberOfTrailsExceededException">
        /// This exception is thrown when the maximum number of trails is reached.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when AWS Organizations is not configured to support all features.
        /// All features must be enabled in AWS Organization to support creating an organization
        /// trail. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an AWS account that is not
        /// a member of an organization. To make this request, sign in using the credentials of
        /// an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailAlreadyExistsException">
        /// This exception is thrown when the specified trail already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotProvidedException">
        /// This exception is deprecated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateTrail">REST API Reference for CreateTrail Operation</seealso>
        CreateTrailResponse CreateTrail(CreateTrailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrail operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateTrail">REST API Reference for CreateTrail Operation</seealso>
        IAsyncResult BeginCreateTrail(CreateTrailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrail.</param>
        /// 
        /// <returns>Returns a  CreateTrailResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateTrail">REST API Reference for CreateTrail Operation</seealso>
        CreateTrailResponse EndCreateTrail(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTrail


        /// <summary>
        /// Deletes a trail. This operation must be called from the region in which the trail
        /// was created. <code>DeleteTrail</code> cannot be called on the shadow trails (replicated
        /// trails in other regions) of a trail that is enabled in all regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrail service method.</param>
        /// 
        /// <returns>The response from the DeleteTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM user or role that is used to create the organization
        /// trail is lacking one or more required permissions for creating an organization trail
        /// in a required service. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a region other
        /// than the region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteTrail">REST API Reference for DeleteTrail Operation</seealso>
        DeleteTrailResponse DeleteTrail(DeleteTrailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrail operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteTrail">REST API Reference for DeleteTrail Operation</seealso>
        IAsyncResult BeginDeleteTrail(DeleteTrailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrail.</param>
        /// 
        /// <returns>Returns a  DeleteTrailResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteTrail">REST API Reference for DeleteTrail Operation</seealso>
        DeleteTrailResponse EndDeleteTrail(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTrails


        /// <summary>
        /// Retrieves settings for the trail associated with the current region for your account.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeTrails">REST API Reference for DescribeTrails Operation</seealso>
        DescribeTrailsResponse DescribeTrails();

        /// <summary>
        /// Retrieves settings for the trail associated with the current region for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrails service method.</param>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeTrails">REST API Reference for DescribeTrails Operation</seealso>
        DescribeTrailsResponse DescribeTrails(DescribeTrailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrails operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeTrails">REST API Reference for DescribeTrails Operation</seealso>
        IAsyncResult BeginDescribeTrails(DescribeTrailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrails.</param>
        /// 
        /// <returns>Returns a  DescribeTrailsResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeTrails">REST API Reference for DescribeTrails Operation</seealso>
        DescribeTrailsResponse EndDescribeTrails(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventSelectors


        /// <summary>
        /// Describes the settings for the event selectors that you configured for your trail.
        /// The information returned for your event selectors includes the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If your event selector includes read-only events, write-only events, or all events.
        /// This applies to both management events and data events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your event selector includes management events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your event selector includes data events, the Amazon S3 objects or AWS Lambda functions
        /// that you are logging for data events.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-and-data-events-with-cloudtrail.html">Logging
        /// Data and Management Events for Trails </a> in the <i>AWS CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventSelectors service method.</param>
        /// 
        /// <returns>The response from the GetEventSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetEventSelectors">REST API Reference for GetEventSelectors Operation</seealso>
        GetEventSelectorsResponse GetEventSelectors(GetEventSelectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventSelectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventSelectors operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventSelectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetEventSelectors">REST API Reference for GetEventSelectors Operation</seealso>
        IAsyncResult BeginGetEventSelectors(GetEventSelectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventSelectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventSelectors.</param>
        /// 
        /// <returns>Returns a  GetEventSelectorsResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetEventSelectors">REST API Reference for GetEventSelectors Operation</seealso>
        GetEventSelectorsResponse EndGetEventSelectors(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTrailStatus


        /// <summary>
        /// Returns a JSON-formatted list of information about the specified trail. Fields include
        /// information on delivery errors, Amazon SNS and Amazon S3 errors, and start and stop
        /// logging times for each trail. This operation returns trail status from a single region.
        /// To return trail status from all regions, you must call the operation on each region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrailStatus service method.</param>
        /// 
        /// <returns>The response from the GetTrailStatus service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetTrailStatus">REST API Reference for GetTrailStatus Operation</seealso>
        GetTrailStatusResponse GetTrailStatus(GetTrailStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrailStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrailStatus operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrailStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetTrailStatus">REST API Reference for GetTrailStatus Operation</seealso>
        IAsyncResult BeginGetTrailStatus(GetTrailStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrailStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrailStatus.</param>
        /// 
        /// <returns>Returns a  GetTrailStatusResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetTrailStatus">REST API Reference for GetTrailStatus Operation</seealso>
        GetTrailStatusResponse EndGetTrailStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPublicKeys


        /// <summary>
        /// Returns all public keys whose private keys were used to sign the digest files within
        /// the specified time range. The public key is needed to validate digest files that were
        /// signed with its corresponding private key.
        /// 
        ///  <note> 
        /// <para>
        /// CloudTrail uses different private/public key pairs per region. Each digest file is
        /// signed with a private key unique to its region. Therefore, when you validate a digest
        /// file from a particular region, you must look in the same region for its corresponding
        /// public key.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys service method.</param>
        /// 
        /// <returns>The response from the ListPublicKeys service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTimeRangeException">
        /// Occurs if the timestamp values are invalid. Either the start time occurs after the
        /// end time or the time range is outside the range of possible values.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTokenException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        ListPublicKeysResponse ListPublicKeys(ListPublicKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPublicKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        IAsyncResult BeginListPublicKeys(ListPublicKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPublicKeys.</param>
        /// 
        /// <returns>Returns a  ListPublicKeysResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        ListPublicKeysResponse EndListPublicKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Lists the tags for the trail in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an invalid trail ARN. The
        /// format of a trail ARN is:
        /// 
        ///  
        /// <para>
        ///  <code>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</code> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTokenException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse ListTags(ListTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListTags">REST API Reference for ListTags Operation</seealso>
        IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse EndListTags(IAsyncResult asyncResult);

        #endregion
        
        #region  LookupEvents


        /// <summary>
        /// Looks up <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html#cloudtrail-concepts-management-events">management
        /// events</a> captured by CloudTrail. Events for a region can be looked up in that region
        /// during the last 90 days. Lookup supports the following attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AWS access key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Event ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Event name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Event source
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Read only
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resource name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resource type
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User name
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// All attributes are optional. The default number of results returned is 50, with a
        /// maximum of 50 possible. The response includes a token that you can use to get the
        /// next page of results.
        /// </para>
        ///  <important> 
        /// <para>
        /// The rate of lookup requests is limited to one per second per account. If this limit
        /// is exceeded, a throttling error occurs.
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// Events that occurred during the selected time range will not be available for lookup
        /// if CloudTrail logging was not enabled when the events occurred.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LookupEvents service method.</param>
        /// 
        /// <returns>The response from the LookupEvents service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidLookupAttributesException">
        /// Occurs when an invalid lookup attribute is specified.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// Invalid token or token that was previously used in a request with different parameters.
        /// This exception is thrown if the token is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTimeRangeException">
        /// Occurs if the timestamp values are invalid. Either the start time occurs after the
        /// end time or the time range is outside the range of possible values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/LookupEvents">REST API Reference for LookupEvents Operation</seealso>
        LookupEventsResponse LookupEvents(LookupEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the LookupEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LookupEvents operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLookupEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/LookupEvents">REST API Reference for LookupEvents Operation</seealso>
        IAsyncResult BeginLookupEvents(LookupEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  LookupEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLookupEvents.</param>
        /// 
        /// <returns>Returns a  LookupEventsResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/LookupEvents">REST API Reference for LookupEvents Operation</seealso>
        LookupEventsResponse EndLookupEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEventSelectors


        /// <summary>
        /// Configures an event selector for your trail. Use event selectors to further specify
        /// the management and data event settings for your trail. By default, trails created
        /// without specific event selectors will be configured to log all read and write management
        /// events, and no data events. 
        /// 
        ///  
        /// <para>
        /// When an event occurs in your account, CloudTrail evaluates the event selectors in
        /// all trails. For each trail, if the event matches any event selector, the trail processes
        /// and logs the event. If the event doesn't match any event selector, the trail doesn't
        /// log the event. 
        /// </para>
        ///  
        /// <para>
        /// Example
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// You create an event selector for a trail and specify that you want write-only events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 <code>GetConsoleOutput</code> and <code>RunInstances</code> API operations
        /// occur in your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CloudTrail evaluates whether the events match your event selectors.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>RunInstances</code> is a write-only event and it matches your event selector.
        /// The trail logs the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>GetConsoleOutput</code> is a read-only event but it doesn't match your event
        /// selector. The trail doesn't log the event. 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// The <code>PutEventSelectors</code> operation must be called from the region in which
        /// the trail was created; otherwise, an <code>InvalidHomeRegionException</code> is thrown.
        /// </para>
        ///  
        /// <para>
        /// You can configure up to five event selectors for each trail. For more information,
        /// see <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-and-data-events-with-cloudtrail.html">Logging
        /// Data and Management Events for Trails </a> and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/WhatIsCloudTrail-Limits.html">Limits
        /// in AWS CloudTrail</a> in the <i>AWS CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventSelectors service method.</param>
        /// 
        /// <returns>The response from the PutEventSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM user or role that is used to create the organization
        /// trail is lacking one or more required permissions for creating an organization trail
        /// in a required service. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <code>PutEventSelectors</code> operation is called
        /// with a number of event selectors or data resources that is not valid. The combination
        /// of event selectors and data resources is not valid. A trail can have up to 5 event
        /// selectors. A trail is limited to 250 data resources. These data resources can be distributed
        /// across event selectors, but the overall total cannot exceed 250.
        /// 
        ///  
        /// <para>
        /// You can:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a valid number of event selectors (1 to 5) for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid number of data resources (1 to 250) for an event selector. The limit
        /// of number of resources on an individual event selector is configurable up to 250.
        /// However, this upper limit is allowed only if the total number of data resources does
        /// not exceed 250 across all event selectors for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <code>ReadWriteType</code>
        /// parameter with a value of <code>read-only</code> is invalid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a region other
        /// than the region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutEventSelectors">REST API Reference for PutEventSelectors Operation</seealso>
        PutEventSelectorsResponse PutEventSelectors(PutEventSelectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEventSelectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEventSelectors operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEventSelectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutEventSelectors">REST API Reference for PutEventSelectors Operation</seealso>
        IAsyncResult BeginPutEventSelectors(PutEventSelectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEventSelectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEventSelectors.</param>
        /// 
        /// <returns>Returns a  PutEventSelectorsResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutEventSelectors">REST API Reference for PutEventSelectors Operation</seealso>
        PutEventSelectorsResponse EndPutEventSelectors(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveTags


        /// <summary>
        /// Removes the specified tags from a trail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an invalid trail ARN. The
        /// format of a trail ARN is:
        /// 
        ///  
        /// <para>
        ///  <code>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</code> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the key or value specified for the tag does not match
        /// the regular expression <code>^([\\p{L}\\p{Z}\\p{N}_.:/=+\\-@]*)$</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        RemoveTagsResponse RemoveTags(RemoveTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        IAsyncResult BeginRemoveTags(RemoveTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTags.</param>
        /// 
        /// <returns>Returns a  RemoveTagsResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        RemoveTagsResponse EndRemoveTags(IAsyncResult asyncResult);

        #endregion
        
        #region  StartLogging


        /// <summary>
        /// Starts the recording of AWS API calls and log file delivery for a trail. For a trail
        /// that is enabled in all regions, this operation must be called from the region in which
        /// the trail was created. This operation cannot be called on the shadow trails (replicated
        /// trails in other regions) of a trail that is enabled in all regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLogging service method.</param>
        /// 
        /// <returns>The response from the StartLogging service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM user or role that is used to create the organization
        /// trail is lacking one or more required permissions for creating an organization trail
        /// in a required service. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a region other
        /// than the region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartLogging">REST API Reference for StartLogging Operation</seealso>
        StartLoggingResponse StartLogging(StartLoggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartLogging operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartLogging
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartLogging">REST API Reference for StartLogging Operation</seealso>
        IAsyncResult BeginStartLogging(StartLoggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartLogging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartLogging.</param>
        /// 
        /// <returns>Returns a  StartLoggingResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartLogging">REST API Reference for StartLogging Operation</seealso>
        StartLoggingResponse EndStartLogging(IAsyncResult asyncResult);

        #endregion
        
        #region  StopLogging


        /// <summary>
        /// Suspends the recording of AWS API calls and log file delivery for the specified trail.
        /// Under most circumstances, there is no need to use this action. You can update a trail
        /// without stopping it first. This action is the only way to stop recording. For a trail
        /// enabled in all regions, this operation must be called from the region in which the
        /// trail was created, or an <code>InvalidHomeRegionException</code> will occur. This
        /// operation cannot be called on the shadow trails (replicated trails in other regions)
        /// of a trail enabled in all regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopLogging service method.</param>
        /// 
        /// <returns>The response from the StopLogging service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM user or role that is used to create the organization
        /// trail is lacking one or more required permissions for creating an organization trail
        /// in a required service. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a region other
        /// than the region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StopLogging">REST API Reference for StopLogging Operation</seealso>
        StopLoggingResponse StopLogging(StopLoggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopLogging operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopLogging
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StopLogging">REST API Reference for StopLogging Operation</seealso>
        IAsyncResult BeginStopLogging(StopLoggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopLogging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopLogging.</param>
        /// 
        /// <returns>Returns a  StopLoggingResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StopLogging">REST API Reference for StopLogging Operation</seealso>
        StopLoggingResponse EndStopLogging(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTrail


        /// <summary>
        /// Updates the settings that specify delivery of log files. Changes to a trail do not
        /// require stopping the CloudTrail service. Use this action to designate an existing
        /// bucket for log delivery. If the existing bucket has previously been a target for CloudTrail
        /// log files, an IAM policy exists for the bucket. <code>UpdateTrail</code> must be called
        /// from the region in which the trail was created; otherwise, an <code>InvalidHomeRegionException</code>
        /// is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrail service method.</param>
        /// 
        /// <returns>The response from the UpdateTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between AWS CloudTrail
        /// and AWS Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">Enabling
        /// Trusted Access with Other AWS Services</a> and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudWatchLogsDeliveryUnavailableException">
        /// Cannot set a CloudWatch Logs delivery for this region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM user or role that is used to create the organization
        /// trail is lacking one or more required permissions for creating an organization trail
        /// in a required service. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// This exception is thrown when the policy on the S3 bucket or KMS key is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientSnsTopicPolicyException">
        /// This exception is thrown when the policy on the SNS topic is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsLogGroupArnException">
        /// This exception is thrown when the provided CloudWatch log group is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsRoleArnException">
        /// This exception is thrown when the provided role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a region other
        /// than the region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3BucketNameException">
        /// This exception is thrown when the provided S3 bucket name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3PrefixException">
        /// This exception is thrown when the provided S3 prefix is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidSnsTopicNameException">
        /// This exception is thrown when the provided SNS topic name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail can’t be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyDisabledException">
        /// This exception is deprecated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, or when the S3 bucket and
        /// the KMS key are not in the same region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when AWS Organizations is not configured to support all features.
        /// All features must be enabled in AWS Organization to support creating an organization
        /// trail. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an AWS account that is not
        /// a member of an organization. To make this request, sign in using the credentials of
        /// an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotProvidedException">
        /// This exception is deprecated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateTrail">REST API Reference for UpdateTrail Operation</seealso>
        UpdateTrailResponse UpdateTrail(UpdateTrailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrail operation on AmazonCloudTrailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateTrail">REST API Reference for UpdateTrail Operation</seealso>
        IAsyncResult BeginUpdateTrail(UpdateTrailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrail.</param>
        /// 
        /// <returns>Returns a  UpdateTrailResult from CloudTrail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateTrail">REST API Reference for UpdateTrail Operation</seealso>
        UpdateTrailResponse EndUpdateTrail(IAsyncResult asyncResult);

        #endregion
        
    }
}