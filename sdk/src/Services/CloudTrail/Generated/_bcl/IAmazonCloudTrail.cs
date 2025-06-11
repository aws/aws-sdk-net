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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudTrail.Model;

#pragma warning disable CS1570
namespace Amazon.CloudTrail
{
    /// <summary>
    /// <para>Interface for accessing CloudTrail</para>
    ///
    /// CloudTrail 
    /// <para>
    /// This is the CloudTrail API Reference. It provides descriptions of actions, data types,
    /// common parameters, and common errors for CloudTrail.
    /// </para>
    ///  
    /// <para>
    /// CloudTrail is a web service that records Amazon Web Services API calls for your Amazon
    /// Web Services account and delivers log files to an Amazon S3 bucket. The recorded information
    /// includes the identity of the user, the start time of the Amazon Web Services API call,
    /// the source IP address, the request parameters, and the response elements returned
    /// by the service.
    /// </para>
    ///  <note> 
    /// <para>
    /// As an alternative to the API, you can use one of the Amazon Web Services SDKs, which
    /// consist of libraries and sample code for various programming languages and platforms
    /// (Java, Ruby, .NET, iOS, Android, etc.). The SDKs provide programmatic access to CloudTrail.
    /// For example, the SDKs handle cryptographically signing requests, managing errors,
    /// and retrying requests automatically. For more information about the Amazon Web Services
    /// SDKs, including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// to Build on Amazon Web Services</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// See the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-user-guide.html">CloudTrail
    /// User Guide</a> for information about the data that is included with each Amazon Web
    /// Services API call listed in the log files.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudTrail : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICloudTrailPaginatorFactory Paginators { get; }

        
        #region  AddTags


        /// <summary>
        /// Adds one or more tags to a trail, event data store, dashboard, or channel, up to a
        /// limit of 50. Overwrites an existing tag's value when a new value is specified for
        /// an existing tag key. Tag key names must be unique; you cannot have two keys with the
        /// same name but different values. If you specify a key without a value, the tag will
        /// be created with the specified key and a value of null. You can tag a trail or event
        /// data store that applies to all Amazon Web Services Regions only from the Region in
        /// which the trail or event data store was created (also known as its home Region).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
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
        /// The number of tags per trail, event data store, dashboard, or channel has exceeded
        /// the permitted amount. Currently, the limit is 50.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse AddTags(AddTagsRequest request);



        /// <summary>
        /// Adds one or more tags to a trail, event data store, dashboard, or channel, up to a
        /// limit of 50. Overwrites an existing tag's value when a new value is specified for
        /// an existing tag key. Tag key names must be unique; you cannot have two keys with the
        /// same name but different values. If you specify a key without a value, the tag will
        /// be created with the specified key and a value of null. You can tag a trail or event
        /// data store that applies to all Amazon Web Services Regions only from the Region in
        /// which the trail or event data store was created (also known as its home Region).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
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
        /// The number of tags per trail, event data store, dashboard, or channel has exceeded
        /// the permitted amount. Currently, the limit is 50.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/AddTags">REST API Reference for AddTags Operation</seealso>
        Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelQuery


        /// <summary>
        /// Cancels a query if the query is not in a terminated state, such as <c>CANCELLED</c>,
        /// <c>FAILED</c>, <c>TIMED_OUT</c>, or <c>FINISHED</c>. You must specify an ARN value
        /// for <c>EventDataStore</c>. The ID of the query that you want to cancel is also required.
        /// When you run <c>CancelQuery</c>, the query status might show as <c>CANCELLED</c> even
        /// if the operation is not yet finished.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelQuery service method.</param>
        /// 
        /// <returns>The response from the CancelQuery service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveQueryException">
        /// The specified query cannot be canceled because it is in the <c>FINISHED</c>, <c>FAILED</c>,
        /// <c>TIMED_OUT</c>, or <c>CANCELLED</c> state.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.QueryIdNotFoundException">
        /// The query ID does not exist or does not map to a query.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CancelQuery">REST API Reference for CancelQuery Operation</seealso>
        CancelQueryResponse CancelQuery(CancelQueryRequest request);



        /// <summary>
        /// Cancels a query if the query is not in a terminated state, such as <c>CANCELLED</c>,
        /// <c>FAILED</c>, <c>TIMED_OUT</c>, or <c>FINISHED</c>. You must specify an ARN value
        /// for <c>EventDataStore</c>. The ID of the query that you want to cancel is also required.
        /// When you run <c>CancelQuery</c>, the query status might show as <c>CANCELLED</c> even
        /// if the operation is not yet finished.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelQuery service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveQueryException">
        /// The specified query cannot be canceled because it is in the <c>FINISHED</c>, <c>FAILED</c>,
        /// <c>TIMED_OUT</c>, or <c>CANCELLED</c> state.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.QueryIdNotFoundException">
        /// The query ID does not exist or does not map to a query.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CancelQuery">REST API Reference for CancelQuery Operation</seealso>
        Task<CancelQueryResponse> CancelQueryAsync(CancelQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateChannel


        /// <summary>
        /// Creates a channel for CloudTrail to ingest events from a partner or external source.
        /// After you create a channel, a CloudTrail Lake event data store can log events from
        /// the partner or source that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelAlreadyExistsException">
        /// This exception is thrown when the provided channel already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelMaxLimitExceededException">
        /// This exception is thrown when the maximum number of channels limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidSourceException">
        /// This exception is thrown when the specified value of <c>Source</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TagsLimitExceededException">
        /// The number of tags per trail, event data store, dashboard, or channel has exceeded
        /// the permitted amount. Currently, the limit is 50.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse CreateChannel(CreateChannelRequest request);



        /// <summary>
        /// Creates a channel for CloudTrail to ingest events from a partner or external source.
        /// After you create a channel, a CloudTrail Lake event data store can log events from
        /// the partner or source that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelAlreadyExistsException">
        /// This exception is thrown when the provided channel already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelMaxLimitExceededException">
        /// This exception is thrown when the maximum number of channels limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidSourceException">
        /// This exception is thrown when the specified value of <c>Source</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TagsLimitExceededException">
        /// The number of tags per trail, event data store, dashboard, or channel has exceeded
        /// the permitted amount. Currently, the limit is 50.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDashboard


        /// <summary>
        /// Creates a custom dashboard or the Highlights dashboard. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Custom dashboards</b> - Custom dashboards allow you to query events in any event
        /// data store type. You can add up to 10 widgets to a custom dashboard. You can manually
        /// refresh a custom dashboard, or you can set a refresh schedule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Highlights dashboard</b> - You can create the Highlights dashboard to see a summary
        /// of key user activities and API usage across all your event data stores. CloudTrail
        /// Lake manages the Highlights dashboard and refreshes the dashboard every 6 hours. To
        /// create the Highlights dashboard, you must set and enable a refresh schedule.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  CloudTrail runs queries to populate the dashboard's widgets during a manual or scheduled
        /// refresh. CloudTrail must be granted permissions to run the <c>StartQuery</c> operation
        /// on your behalf. To provide permissions, run the <c>PutResourcePolicy</c> operation
        /// to attach a resource-based policy to each event data store. For more information,
        /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-eds-dashboard">Example:
        /// Allow CloudTrail to run queries to populate a dashboard</a> in the <i>CloudTrail User
        /// Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  To set a refresh schedule, CloudTrail must be granted permissions to run the <c>StartDashboardRefresh</c>
        /// operation to refresh the dashboard on your behalf. To provide permissions, run the
        /// <c>PutResourcePolicy</c> operation to attach a resource-based policy to the dashboard.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-dashboards">
        /// Resource-based policy example for a dashboard</a> in the <i>CloudTrail User Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about dashboards, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-dashboard.html">CloudTrail
        /// Lake dashboards</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidQueryStatementException">
        /// The query that was submitted has validation errors, or uses incorrect syntax or unsupported
        /// keywords. For more information about writing a query, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-create-edit-query.html">Create
        /// or edit a query</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ServiceQuotaExceededException">
        /// This exception is thrown when the quota is exceeded. For information about CloudTrail
        /// quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/ct.html#limits_cloudtrail">Service
        /// quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        CreateDashboardResponse CreateDashboard(CreateDashboardRequest request);



        /// <summary>
        /// Creates a custom dashboard or the Highlights dashboard. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Custom dashboards</b> - Custom dashboards allow you to query events in any event
        /// data store type. You can add up to 10 widgets to a custom dashboard. You can manually
        /// refresh a custom dashboard, or you can set a refresh schedule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Highlights dashboard</b> - You can create the Highlights dashboard to see a summary
        /// of key user activities and API usage across all your event data stores. CloudTrail
        /// Lake manages the Highlights dashboard and refreshes the dashboard every 6 hours. To
        /// create the Highlights dashboard, you must set and enable a refresh schedule.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  CloudTrail runs queries to populate the dashboard's widgets during a manual or scheduled
        /// refresh. CloudTrail must be granted permissions to run the <c>StartQuery</c> operation
        /// on your behalf. To provide permissions, run the <c>PutResourcePolicy</c> operation
        /// to attach a resource-based policy to each event data store. For more information,
        /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-eds-dashboard">Example:
        /// Allow CloudTrail to run queries to populate a dashboard</a> in the <i>CloudTrail User
        /// Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  To set a refresh schedule, CloudTrail must be granted permissions to run the <c>StartDashboardRefresh</c>
        /// operation to refresh the dashboard on your behalf. To provide permissions, run the
        /// <c>PutResourcePolicy</c> operation to attach a resource-based policy to the dashboard.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-dashboards">
        /// Resource-based policy example for a dashboard</a> in the <i>CloudTrail User Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about dashboards, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-dashboard.html">CloudTrail
        /// Lake dashboards</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidQueryStatementException">
        /// The query that was submitted has validation errors, or uses incorrect syntax or unsupported
        /// keywords. For more information about writing a query, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-create-edit-query.html">Create
        /// or edit a query</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ServiceQuotaExceededException">
        /// This exception is thrown when the quota is exceeded. For information about CloudTrail
        /// quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/ct.html#limits_cloudtrail">Service
        /// quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        Task<CreateDashboardResponse> CreateDashboardAsync(CreateDashboardRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEventDataStore


        /// <summary>
        /// Creates a new event data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventDataStore service method.</param>
        /// 
        /// <returns>The response from the CreateEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreAlreadyExistsException">
        /// An event data store with that name already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreMaxLimitExceededException">
        /// Your account has used the maximum number of event data stores.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <c>PutEventSelectors</c> operation is called with
        /// a number of event selectors, advanced event selectors, or data resources that is not
        /// valid. The combination of event selectors or advanced event selectors and data resources
        /// is not valid. A trail can have up to 5 event selectors. If a trail uses advanced event
        /// selectors, a maximum of 500 total values for all conditions in all advanced event
        /// selectors is allowed. A trail is limited to 250 data resources. These data resources
        /// can be distributed across event selectors, but the overall total cannot exceed 250.
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
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <c>ReadWriteType</c>
        /// parameter with a value of <c>read-only</c> is not valid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same Region, or when the KMS key associated with the Amazon
        /// SNS topic either does not exist or is not in the same Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateEventDataStore">REST API Reference for CreateEventDataStore Operation</seealso>
        CreateEventDataStoreResponse CreateEventDataStore(CreateEventDataStoreRequest request);



        /// <summary>
        /// Creates a new event data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventDataStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreAlreadyExistsException">
        /// An event data store with that name already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreMaxLimitExceededException">
        /// Your account has used the maximum number of event data stores.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <c>PutEventSelectors</c> operation is called with
        /// a number of event selectors, advanced event selectors, or data resources that is not
        /// valid. The combination of event selectors or advanced event selectors and data resources
        /// is not valid. A trail can have up to 5 event selectors. If a trail uses advanced event
        /// selectors, a maximum of 500 total values for all conditions in all advanced event
        /// selectors is allowed. A trail is limited to 250 data resources. These data resources
        /// can be distributed across event selectors, but the overall total cannot exceed 250.
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
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <c>ReadWriteType</c>
        /// parameter with a value of <c>read-only</c> is not valid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same Region, or when the KMS key associated with the Amazon
        /// SNS topic either does not exist or is not in the same Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateEventDataStore">REST API Reference for CreateEventDataStore Operation</seealso>
        Task<CreateEventDataStoreResponse> CreateEventDataStoreAsync(CreateEventDataStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTrail


        /// <summary>
        /// Creates a trail that specifies the settings for delivery of log data to an Amazon
        /// S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrail service method.</param>
        /// 
        /// <returns>The response from the CreateTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailInvalidClientTokenIdException">
        /// This exception is thrown when a call results in the <c>InvalidClientTokenId</c> error
        /// code. This can occur when you are creating or updating a trail to send notifications
        /// to an Amazon SNS topic that is in a suspended Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudWatchLogsDeliveryUnavailableException">
        /// Cannot set a CloudWatch Logs delivery for this Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientSnsTopicPolicyException">
        /// This exception is thrown when the policy on the Amazon SNS topic is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsLogGroupArnException">
        /// This exception is thrown when the provided CloudWatch Logs log group is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsRoleArnException">
        /// This exception is thrown when the provided role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
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
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyDisabledException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same Region, or when the KMS key associated with the Amazon
        /// SNS topic either does not exist or is not in the same Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.MaximumNumberOfTrailsExceededException">
        /// This exception is thrown when the maximum number of trails is reached.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TagsLimitExceededException">
        /// The number of tags per trail, event data store, dashboard, or channel has exceeded
        /// the permitted amount. Currently, the limit is 50.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailAlreadyExistsException">
        /// This exception is thrown when the specified trail already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotProvidedException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateTrail">REST API Reference for CreateTrail Operation</seealso>
        CreateTrailResponse CreateTrail(CreateTrailRequest request);



        /// <summary>
        /// Creates a trail that specifies the settings for delivery of log data to an Amazon
        /// S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailInvalidClientTokenIdException">
        /// This exception is thrown when a call results in the <c>InvalidClientTokenId</c> error
        /// code. This can occur when you are creating or updating a trail to send notifications
        /// to an Amazon SNS topic that is in a suspended Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudWatchLogsDeliveryUnavailableException">
        /// Cannot set a CloudWatch Logs delivery for this Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientSnsTopicPolicyException">
        /// This exception is thrown when the policy on the Amazon SNS topic is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsLogGroupArnException">
        /// This exception is thrown when the provided CloudWatch Logs log group is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsRoleArnException">
        /// This exception is thrown when the provided role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
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
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyDisabledException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same Region, or when the KMS key associated with the Amazon
        /// SNS topic either does not exist or is not in the same Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.MaximumNumberOfTrailsExceededException">
        /// This exception is thrown when the maximum number of trails is reached.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TagsLimitExceededException">
        /// The number of tags per trail, event data store, dashboard, or channel has exceeded
        /// the permitted amount. Currently, the limit is 50.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailAlreadyExistsException">
        /// This exception is thrown when the specified trail already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotProvidedException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateTrail">REST API Reference for CreateTrail Operation</seealso>
        Task<CreateTrailResponse> CreateTrailAsync(CreateTrailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteChannel


        /// <summary>
        /// Deletes a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse DeleteChannel(DeleteChannelRequest request);



        /// <summary>
        /// Deletes a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDashboard


        /// <summary>
        /// Deletes the specified dashboard. You cannot delete a dashboard that has termination
        /// protection enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        DeleteDashboardResponse DeleteDashboard(DeleteDashboardRequest request);



        /// <summary>
        /// Deletes the specified dashboard. You cannot delete a dashboard that has termination
        /// protection enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        Task<DeleteDashboardResponse> DeleteDashboardAsync(DeleteDashboardRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEventDataStore


        /// <summary>
        /// Disables the event data store specified by <c>EventDataStore</c>, which accepts an
        /// event data store ARN. After you run <c>DeleteEventDataStore</c>, the event data store
        /// enters a <c>PENDING_DELETION</c> state, and is automatically deleted after a wait
        /// period of seven days. <c>TerminationProtectionEnabled</c> must be set to <c>False</c>
        /// on the event data store and the <c>FederationStatus</c> must be <c>DISABLED</c>. You
        /// cannot delete an event data store if <c>TerminationProtectionEnabled</c> is <c>True</c>
        /// or the <c>FederationStatus</c> is <c>ENABLED</c>.
        /// 
        ///  
        /// <para>
        /// After you run <c>DeleteEventDataStore</c> on an event data store, you cannot run <c>ListQueries</c>,
        /// <c>DescribeQuery</c>, or <c>GetQueryResults</c> on queries that are using an event
        /// data store in a <c>PENDING_DELETION</c> state. An event data store in the <c>PENDING_DELETION</c>
        /// state does not incur costs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventDataStore service method.</param>
        /// 
        /// <returns>The response from the DeleteEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelExistsForEDSException">
        /// This exception is thrown when the specified event data store cannot yet be deleted
        /// because it is in use by a channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreFederationEnabledException">
        /// You cannot delete the event data store because Lake query federation is enabled.
        /// To delete the event data store, run the <c>DisableFederation</c> operation to disable
        /// Lake query federation on the event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreHasOngoingImportException">
        /// This exception is thrown when you try to update or delete an event data store that
        /// currently has an import in progress.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreTerminationProtectedException">
        /// The event data store cannot be deleted because termination protection is enabled for
        /// it.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteEventDataStore">REST API Reference for DeleteEventDataStore Operation</seealso>
        DeleteEventDataStoreResponse DeleteEventDataStore(DeleteEventDataStoreRequest request);



        /// <summary>
        /// Disables the event data store specified by <c>EventDataStore</c>, which accepts an
        /// event data store ARN. After you run <c>DeleteEventDataStore</c>, the event data store
        /// enters a <c>PENDING_DELETION</c> state, and is automatically deleted after a wait
        /// period of seven days. <c>TerminationProtectionEnabled</c> must be set to <c>False</c>
        /// on the event data store and the <c>FederationStatus</c> must be <c>DISABLED</c>. You
        /// cannot delete an event data store if <c>TerminationProtectionEnabled</c> is <c>True</c>
        /// or the <c>FederationStatus</c> is <c>ENABLED</c>.
        /// 
        ///  
        /// <para>
        /// After you run <c>DeleteEventDataStore</c> on an event data store, you cannot run <c>ListQueries</c>,
        /// <c>DescribeQuery</c>, or <c>GetQueryResults</c> on queries that are using an event
        /// data store in a <c>PENDING_DELETION</c> state. An event data store in the <c>PENDING_DELETION</c>
        /// state does not incur costs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventDataStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelExistsForEDSException">
        /// This exception is thrown when the specified event data store cannot yet be deleted
        /// because it is in use by a channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreFederationEnabledException">
        /// You cannot delete the event data store because Lake query federation is enabled.
        /// To delete the event data store, run the <c>DisableFederation</c> operation to disable
        /// Lake query federation on the event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreHasOngoingImportException">
        /// This exception is thrown when you try to update or delete an event data store that
        /// currently has an import in progress.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreTerminationProtectedException">
        /// The event data store cannot be deleted because termination protection is enabled for
        /// it.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteEventDataStore">REST API Reference for DeleteEventDataStore Operation</seealso>
        Task<DeleteEventDataStoreResponse> DeleteEventDataStoreAsync(DeleteEventDataStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes the resource-based policy attached to the CloudTrail event data store, dashboard,
        /// or channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceARNNotValidException">
        /// This exception is thrown when the provided resource does not exist, or the ARN format
        /// of the resource is not valid. 
        /// 
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourcePolicyNotFoundException">
        /// This exception is thrown when the specified resource policy is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);



        /// <summary>
        /// Deletes the resource-based policy attached to the CloudTrail event data store, dashboard,
        /// or channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceARNNotValidException">
        /// This exception is thrown when the provided resource does not exist, or the ARN format
        /// of the resource is not valid. 
        /// 
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourcePolicyNotFoundException">
        /// This exception is thrown when the specified resource policy is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTrail


        /// <summary>
        /// Deletes a trail. This operation must be called from the Region in which the trail
        /// was created. <c>DeleteTrail</c> cannot be called on the shadow trails (replicated
        /// trails in other Regions) of a trail that is enabled in all Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrail service method.</param>
        /// 
        /// <returns>The response from the DeleteTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
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
        /// Deletes a trail. This operation must be called from the Region in which the trail
        /// was created. <c>DeleteTrail</c> cannot be called on the shadow trails (replicated
        /// trails in other Regions) of a trail that is enabled in all Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteTrail">REST API Reference for DeleteTrail Operation</seealso>
        Task<DeleteTrailResponse> DeleteTrailAsync(DeleteTrailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterOrganizationDelegatedAdmin


        /// <summary>
        /// Removes CloudTrail delegated administrator permissions from a member account in an
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOrganizationDelegatedAdmin service method.</param>
        /// 
        /// <returns>The response from the DeregisterOrganizationDelegatedAdmin service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccountNotFoundException">
        /// This exception is thrown when the specified account is not found or not part of an
        /// organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.AccountNotRegisteredException">
        /// This exception is thrown when the specified account is not registered as the CloudTrail
        /// delegated administrator.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationManagementAccountException">
        /// This exception is thrown when the account making the request is not the organization's
        /// management account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeregisterOrganizationDelegatedAdmin">REST API Reference for DeregisterOrganizationDelegatedAdmin Operation</seealso>
        DeregisterOrganizationDelegatedAdminResponse DeregisterOrganizationDelegatedAdmin(DeregisterOrganizationDelegatedAdminRequest request);



        /// <summary>
        /// Removes CloudTrail delegated administrator permissions from a member account in an
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOrganizationDelegatedAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterOrganizationDelegatedAdmin service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccountNotFoundException">
        /// This exception is thrown when the specified account is not found or not part of an
        /// organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.AccountNotRegisteredException">
        /// This exception is thrown when the specified account is not registered as the CloudTrail
        /// delegated administrator.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationManagementAccountException">
        /// This exception is thrown when the account making the request is not the organization's
        /// management account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeregisterOrganizationDelegatedAdmin">REST API Reference for DeregisterOrganizationDelegatedAdmin Operation</seealso>
        Task<DeregisterOrganizationDelegatedAdminResponse> DeregisterOrganizationDelegatedAdminAsync(DeregisterOrganizationDelegatedAdminRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeQuery


        /// <summary>
        /// Returns metadata about a query, including query run time in milliseconds, number of
        /// events scanned and matched, and query status. If the query results were delivered
        /// to an S3 bucket, the response also provides the S3 URI and the delivery status.
        /// 
        ///  
        /// <para>
        /// You must specify either <c>QueryId</c> or <c>QueryAlias</c>. Specifying the <c>QueryAlias</c>
        /// parameter returns information about the last query run for the alias. You can provide
        /// <c>RefreshId</c> along with <c>QueryAlias</c> to view the query results of a dashboard
        /// query for the specified <c>RefreshId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuery service method.</param>
        /// 
        /// <returns>The response from the DescribeQuery service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.QueryIdNotFoundException">
        /// The query ID does not exist or does not map to a query.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeQuery">REST API Reference for DescribeQuery Operation</seealso>
        DescribeQueryResponse DescribeQuery(DescribeQueryRequest request);



        /// <summary>
        /// Returns metadata about a query, including query run time in milliseconds, number of
        /// events scanned and matched, and query status. If the query results were delivered
        /// to an S3 bucket, the response also provides the S3 URI and the delivery status.
        /// 
        ///  
        /// <para>
        /// You must specify either <c>QueryId</c> or <c>QueryAlias</c>. Specifying the <c>QueryAlias</c>
        /// parameter returns information about the last query run for the alias. You can provide
        /// <c>RefreshId</c> along with <c>QueryAlias</c> to view the query results of a dashboard
        /// query for the specified <c>RefreshId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQuery service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.QueryIdNotFoundException">
        /// The query ID does not exist or does not map to a query.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeQuery">REST API Reference for DescribeQuery Operation</seealso>
        Task<DescribeQueryResponse> DescribeQueryAsync(DescribeQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTrails


        /// <summary>
        /// Retrieves settings for one or more trails associated with the current Region for your
        /// account.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeTrails">REST API Reference for DescribeTrails Operation</seealso>
        DescribeTrailsResponse DescribeTrails();


        /// <summary>
        /// Retrieves settings for one or more trails associated with the current Region for your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrails service method.</param>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeTrails">REST API Reference for DescribeTrails Operation</seealso>
        DescribeTrailsResponse DescribeTrails(DescribeTrailsRequest request);


        /// <summary>
        /// Retrieves settings for one or more trails associated with the current Region for your
        /// account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeTrails">REST API Reference for DescribeTrails Operation</seealso>
        Task<DescribeTrailsResponse> DescribeTrailsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Retrieves settings for one or more trails associated with the current Region for your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeTrails">REST API Reference for DescribeTrails Operation</seealso>
        Task<DescribeTrailsResponse> DescribeTrailsAsync(DescribeTrailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableFederation


        /// <summary>
        /// Disables Lake query federation on the specified event data store. When you disable
        /// federation, CloudTrail disables the integration with Glue, Lake Formation, and Amazon
        /// Athena. After disabling Lake query federation, you can no longer query your event
        /// data in Amazon Athena.
        /// 
        ///  
        /// <para>
        /// No CloudTrail Lake data is deleted when you disable federation and you can continue
        /// to run queries in CloudTrail Lake.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableFederation service method.</param>
        /// 
        /// <returns>The response from the DisableFederation service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConcurrentModificationException">
        /// You are trying to update a resource when another request is in progress. Allow sufficient
        /// wait time for the previous request to complete, then retry your request.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DisableFederation">REST API Reference for DisableFederation Operation</seealso>
        DisableFederationResponse DisableFederation(DisableFederationRequest request);



        /// <summary>
        /// Disables Lake query federation on the specified event data store. When you disable
        /// federation, CloudTrail disables the integration with Glue, Lake Formation, and Amazon
        /// Athena. After disabling Lake query federation, you can no longer query your event
        /// data in Amazon Athena.
        /// 
        ///  
        /// <para>
        /// No CloudTrail Lake data is deleted when you disable federation and you can continue
        /// to run queries in CloudTrail Lake.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableFederation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableFederation service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConcurrentModificationException">
        /// You are trying to update a resource when another request is in progress. Allow sufficient
        /// wait time for the previous request to complete, then retry your request.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DisableFederation">REST API Reference for DisableFederation Operation</seealso>
        Task<DisableFederationResponse> DisableFederationAsync(DisableFederationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableFederation


        /// <summary>
        /// Enables Lake query federation on the specified event data store. Federating an event
        /// data store lets you view the metadata associated with the event data store in the
        /// Glue <a href="https://docs.aws.amazon.com/glue/latest/dg/components-overview.html#data-catalog-intro">Data
        /// Catalog</a> and run SQL queries against your event data using Amazon Athena. The table
        /// metadata stored in the Glue Data Catalog lets the Athena query engine know how to
        /// find, read, and process the data that you want to query.
        /// 
        ///  
        /// <para>
        /// When you enable Lake query federation, CloudTrail creates a managed database named
        /// <c>aws:cloudtrail</c> (if the database doesn't already exist) and a managed federated
        /// table in the Glue Data Catalog. The event data store ID is used for the table name.
        /// CloudTrail registers the role ARN and event data store in <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-federation-lake-formation.html">Lake
        /// Formation</a>, the service responsible for allowing fine-grained access control of
        /// the federated resources in the Glue Data Catalog.
        /// </para>
        ///  
        /// <para>
        /// For more information about Lake query federation, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-federation.html">Federate
        /// an event data store</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableFederation service method.</param>
        /// 
        /// <returns>The response from the EnableFederation service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConcurrentModificationException">
        /// You are trying to update a resource when another request is in progress. Allow sufficient
        /// wait time for the previous request to complete, then retry your request.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreFederationEnabledException">
        /// You cannot delete the event data store because Lake query federation is enabled.
        /// To delete the event data store, run the <c>DisableFederation</c> operation to disable
        /// Lake query federation on the event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/EnableFederation">REST API Reference for EnableFederation Operation</seealso>
        EnableFederationResponse EnableFederation(EnableFederationRequest request);



        /// <summary>
        /// Enables Lake query federation on the specified event data store. Federating an event
        /// data store lets you view the metadata associated with the event data store in the
        /// Glue <a href="https://docs.aws.amazon.com/glue/latest/dg/components-overview.html#data-catalog-intro">Data
        /// Catalog</a> and run SQL queries against your event data using Amazon Athena. The table
        /// metadata stored in the Glue Data Catalog lets the Athena query engine know how to
        /// find, read, and process the data that you want to query.
        /// 
        ///  
        /// <para>
        /// When you enable Lake query federation, CloudTrail creates a managed database named
        /// <c>aws:cloudtrail</c> (if the database doesn't already exist) and a managed federated
        /// table in the Glue Data Catalog. The event data store ID is used for the table name.
        /// CloudTrail registers the role ARN and event data store in <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-federation-lake-formation.html">Lake
        /// Formation</a>, the service responsible for allowing fine-grained access control of
        /// the federated resources in the Glue Data Catalog.
        /// </para>
        ///  
        /// <para>
        /// For more information about Lake query federation, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-federation.html">Federate
        /// an event data store</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableFederation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableFederation service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConcurrentModificationException">
        /// You are trying to update a resource when another request is in progress. Allow sufficient
        /// wait time for the previous request to complete, then retry your request.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreFederationEnabledException">
        /// You cannot delete the event data store because Lake query federation is enabled.
        /// To delete the event data store, run the <c>DisableFederation</c> operation to disable
        /// Lake query federation on the event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/EnableFederation">REST API Reference for EnableFederation Operation</seealso>
        Task<EnableFederationResponse> EnableFederationAsync(EnableFederationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GenerateQuery


        /// <summary>
        /// Generates a query from a natural language prompt. This operation uses generative
        /// artificial intelligence (generative AI) to produce a ready-to-use SQL query from the
        /// prompt. 
        /// 
        ///  
        /// <para>
        /// The prompt can be a question or a statement about the event data in your event data
        /// store. For example, you can enter prompts like "What are my top errors in the past
        /// month?" and “Give me a list of users that used SNS.”
        /// </para>
        ///  
        /// <para>
        /// The prompt must be in English. For information about limitations, permissions, and
        /// supported Regions, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-query-generator.html">Create
        /// CloudTrail Lake queries from natural language prompts</a> in the <i>CloudTrail </i>
        /// user guide.
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not include any personally identifying, confidential, or sensitive information
        /// in your prompts.
        /// </para>
        ///  
        /// <para>
        /// This feature uses generative AI large language models (LLMs); we recommend double-checking
        /// the LLM response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateQuery service method.</param>
        /// 
        /// <returns>The response from the GenerateQuery service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.GenerateResponseException">
        /// This exception is thrown when a valid query could not be generated for the provided
        /// prompt.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GenerateQuery">REST API Reference for GenerateQuery Operation</seealso>
        GenerateQueryResponse GenerateQuery(GenerateQueryRequest request);



        /// <summary>
        /// Generates a query from a natural language prompt. This operation uses generative
        /// artificial intelligence (generative AI) to produce a ready-to-use SQL query from the
        /// prompt. 
        /// 
        ///  
        /// <para>
        /// The prompt can be a question or a statement about the event data in your event data
        /// store. For example, you can enter prompts like "What are my top errors in the past
        /// month?" and “Give me a list of users that used SNS.”
        /// </para>
        ///  
        /// <para>
        /// The prompt must be in English. For information about limitations, permissions, and
        /// supported Regions, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-query-generator.html">Create
        /// CloudTrail Lake queries from natural language prompts</a> in the <i>CloudTrail </i>
        /// user guide.
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not include any personally identifying, confidential, or sensitive information
        /// in your prompts.
        /// </para>
        ///  
        /// <para>
        /// This feature uses generative AI large language models (LLMs); we recommend double-checking
        /// the LLM response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateQuery service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.GenerateResponseException">
        /// This exception is thrown when a valid query could not be generated for the provided
        /// prompt.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GenerateQuery">REST API Reference for GenerateQuery Operation</seealso>
        Task<GenerateQueryResponse> GenerateQueryAsync(GenerateQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetChannel


        /// <summary>
        /// Returns information about a specific channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannel service method.</param>
        /// 
        /// <returns>The response from the GetChannel service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetChannel">REST API Reference for GetChannel Operation</seealso>
        GetChannelResponse GetChannel(GetChannelRequest request);



        /// <summary>
        /// Returns information about a specific channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannel service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetChannel">REST API Reference for GetChannel Operation</seealso>
        Task<GetChannelResponse> GetChannelAsync(GetChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDashboard


        /// <summary>
        /// Returns the specified dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboard service method.</param>
        /// 
        /// <returns>The response from the GetDashboard service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        GetDashboardResponse GetDashboard(GetDashboardRequest request);



        /// <summary>
        /// Returns the specified dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDashboard service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        Task<GetDashboardResponse> GetDashboardAsync(GetDashboardRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEventConfiguration


        /// <summary>
        /// Retrieves the current event configuration settings for the specified event data store,
        /// including details about maximum event size and context key selectors configured for
        /// the event data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetEventConfiguration service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetEventConfiguration">REST API Reference for GetEventConfiguration Operation</seealso>
        GetEventConfigurationResponse GetEventConfiguration(GetEventConfigurationRequest request);



        /// <summary>
        /// Retrieves the current event configuration settings for the specified event data store,
        /// including details about maximum event size and context key selectors configured for
        /// the event data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventConfiguration service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetEventConfiguration">REST API Reference for GetEventConfiguration Operation</seealso>
        Task<GetEventConfigurationResponse> GetEventConfigurationAsync(GetEventConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEventDataStore


        /// <summary>
        /// Returns information about an event data store specified as either an ARN or the ID
        /// portion of the ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventDataStore service method.</param>
        /// 
        /// <returns>The response from the GetEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetEventDataStore">REST API Reference for GetEventDataStore Operation</seealso>
        GetEventDataStoreResponse GetEventDataStore(GetEventDataStoreRequest request);



        /// <summary>
        /// Returns information about an event data store specified as either an ARN or the ID
        /// portion of the ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventDataStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetEventDataStore">REST API Reference for GetEventDataStore Operation</seealso>
        Task<GetEventDataStoreResponse> GetEventDataStoreAsync(GetEventDataStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEventSelectors


        /// <summary>
        /// Describes the settings for the event selectors that you configured for your trail.
        /// The information returned for your event selectors includes the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If your event selector includes read-only events, write-only events, or all events.
        /// This applies to management events, data events, and network activity events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your event selector includes management events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your event selector includes network activity events, the event sources for which
        /// you are logging network activity events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your event selector includes data events, the resources on which you are logging
        /// data events.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about logging management, data, and network activity events,
        /// see the following topics in the <i>CloudTrail User Guide</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-events-with-cloudtrail.html">Logging
        /// management events</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
        /// data events</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-network-events-with-cloudtrail.html">Logging
        /// network activity events</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventSelectors service method.</param>
        /// 
        /// <returns>The response from the GetEventSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
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
        /// Describes the settings for the event selectors that you configured for your trail.
        /// The information returned for your event selectors includes the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If your event selector includes read-only events, write-only events, or all events.
        /// This applies to management events, data events, and network activity events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your event selector includes management events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your event selector includes network activity events, the event sources for which
        /// you are logging network activity events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your event selector includes data events, the resources on which you are logging
        /// data events.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about logging management, data, and network activity events,
        /// see the following topics in the <i>CloudTrail User Guide</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-events-with-cloudtrail.html">Logging
        /// management events</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
        /// data events</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-network-events-with-cloudtrail.html">Logging
        /// network activity events</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventSelectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
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
        Task<GetEventSelectorsResponse> GetEventSelectorsAsync(GetEventSelectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetImport


        /// <summary>
        /// Returns information about a specific import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImport service method.</param>
        /// 
        /// <returns>The response from the GetImport service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ImportNotFoundException">
        /// The specified import was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetImport">REST API Reference for GetImport Operation</seealso>
        GetImportResponse GetImport(GetImportRequest request);



        /// <summary>
        /// Returns information about a specific import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImport service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ImportNotFoundException">
        /// The specified import was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetImport">REST API Reference for GetImport Operation</seealso>
        Task<GetImportResponse> GetImportAsync(GetImportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInsightSelectors


        /// <summary>
        /// Describes the settings for the Insights event selectors that you configured for your
        /// trail or event data store. <c>GetInsightSelectors</c> shows if CloudTrail Insights
        /// event logging is enabled on the trail or event data store, and if it is, which Insights
        /// types are enabled. If you run <c>GetInsightSelectors</c> on a trail or event data
        /// store that does not have Insights events enabled, the operation throws the exception
        /// <c>InsightNotEnabledException</c> 
        /// 
        ///  
        /// <para>
        /// Specify either the <c>EventDataStore</c> parameter to get Insights event selectors
        /// for an event data store, or the <c>TrailName</c> parameter to the get Insights event
        /// selectors for a trail. You cannot specify these parameters together.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Working
        /// with CloudTrail Insights</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightSelectors service method.</param>
        /// 
        /// <returns>The response from the GetInsightSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsightNotEnabledException">
        /// If you run <c>GetInsightSelectors</c> on a trail or event data store that does not
        /// have Insights events enabled, the operation throws the exception <c>InsightNotEnabledException</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetInsightSelectors">REST API Reference for GetInsightSelectors Operation</seealso>
        GetInsightSelectorsResponse GetInsightSelectors(GetInsightSelectorsRequest request);



        /// <summary>
        /// Describes the settings for the Insights event selectors that you configured for your
        /// trail or event data store. <c>GetInsightSelectors</c> shows if CloudTrail Insights
        /// event logging is enabled on the trail or event data store, and if it is, which Insights
        /// types are enabled. If you run <c>GetInsightSelectors</c> on a trail or event data
        /// store that does not have Insights events enabled, the operation throws the exception
        /// <c>InsightNotEnabledException</c> 
        /// 
        ///  
        /// <para>
        /// Specify either the <c>EventDataStore</c> parameter to get Insights event selectors
        /// for an event data store, or the <c>TrailName</c> parameter to the get Insights event
        /// selectors for a trail. You cannot specify these parameters together.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Working
        /// with CloudTrail Insights</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightSelectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInsightSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsightNotEnabledException">
        /// If you run <c>GetInsightSelectors</c> on a trail or event data store that does not
        /// have Insights events enabled, the operation throws the exception <c>InsightNotEnabledException</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetInsightSelectors">REST API Reference for GetInsightSelectors Operation</seealso>
        Task<GetInsightSelectorsResponse> GetInsightSelectorsAsync(GetInsightSelectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetQueryResults


        /// <summary>
        /// Gets event data results of a query. You must specify the <c>QueryID</c> value returned
        /// by the <c>StartQuery</c> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults service method.</param>
        /// 
        /// <returns>The response from the GetQueryResults service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.QueryIdNotFoundException">
        /// The query ID does not exist or does not map to a query.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        GetQueryResultsResponse GetQueryResults(GetQueryResultsRequest request);



        /// <summary>
        /// Gets event data results of a query. You must specify the <c>QueryID</c> value returned
        /// by the <c>StartQuery</c> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryResults service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.QueryIdNotFoundException">
        /// The query ID does not exist or does not map to a query.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        Task<GetQueryResultsResponse> GetQueryResultsAsync(GetQueryResultsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Retrieves the JSON text of the resource-based policy document attached to the CloudTrail
        /// event data store, dashboard, or channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceARNNotValidException">
        /// This exception is thrown when the provided resource does not exist, or the ARN format
        /// of the resource is not valid. 
        /// 
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourcePolicyNotFoundException">
        /// This exception is thrown when the specified resource policy is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);



        /// <summary>
        /// Retrieves the JSON text of the resource-based policy document attached to the CloudTrail
        /// event data store, dashboard, or channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceARNNotValidException">
        /// This exception is thrown when the provided resource does not exist, or the ARN format
        /// of the resource is not valid. 
        /// 
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourcePolicyNotFoundException">
        /// This exception is thrown when the specified resource policy is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTrail


        /// <summary>
        /// Returns settings information for a specified trail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrail service method.</param>
        /// 
        /// <returns>The response from the GetTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetTrail">REST API Reference for GetTrail Operation</seealso>
        GetTrailResponse GetTrail(GetTrailRequest request);



        /// <summary>
        /// Returns settings information for a specified trail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetTrail">REST API Reference for GetTrail Operation</seealso>
        Task<GetTrailResponse> GetTrailAsync(GetTrailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTrailStatus


        /// <summary>
        /// Returns a JSON-formatted list of information about the specified trail. Fields include
        /// information on delivery errors, Amazon SNS and Amazon S3 errors, and start and stop
        /// logging times for each trail. This operation returns trail status from a single Region.
        /// To return trail status from all Regions, you must call the operation on each Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrailStatus service method.</param>
        /// 
        /// <returns>The response from the GetTrailStatus service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetTrailStatus">REST API Reference for GetTrailStatus Operation</seealso>
        GetTrailStatusResponse GetTrailStatus(GetTrailStatusRequest request);



        /// <summary>
        /// Returns a JSON-formatted list of information about the specified trail. Fields include
        /// information on delivery errors, Amazon SNS and Amazon S3 errors, and start and stop
        /// logging times for each trail. This operation returns trail status from a single Region.
        /// To return trail status from all Regions, you must call the operation on each Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrailStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrailStatus service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetTrailStatus">REST API Reference for GetTrailStatus Operation</seealso>
        Task<GetTrailStatusResponse> GetTrailStatusAsync(GetTrailStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Lists the channels in the current account, and their source names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse ListChannels(ListChannelsRequest request);



        /// <summary>
        /// Lists the channels in the current account, and their source names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListChannels">REST API Reference for ListChannels Operation</seealso>
        Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDashboards


        /// <summary>
        /// Returns information about all dashboards in the account, in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        ListDashboardsResponse ListDashboards(ListDashboardsRequest request);



        /// <summary>
        /// Returns information about all dashboards in the account, in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        Task<ListDashboardsResponse> ListDashboardsAsync(ListDashboardsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEventDataStores


        /// <summary>
        /// Returns information about all event data stores in the account, in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventDataStores service method.</param>
        /// 
        /// <returns>The response from the ListEventDataStores service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListEventDataStores">REST API Reference for ListEventDataStores Operation</seealso>
        ListEventDataStoresResponse ListEventDataStores(ListEventDataStoresRequest request);



        /// <summary>
        /// Returns information about all event data stores in the account, in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventDataStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventDataStores service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListEventDataStores">REST API Reference for ListEventDataStores Operation</seealso>
        Task<ListEventDataStoresResponse> ListEventDataStoresAsync(ListEventDataStoresRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListImportFailures


        /// <summary>
        /// Returns a list of failures for the specified import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportFailures service method.</param>
        /// 
        /// <returns>The response from the ListImportFailures service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListImportFailures">REST API Reference for ListImportFailures Operation</seealso>
        ListImportFailuresResponse ListImportFailures(ListImportFailuresRequest request);



        /// <summary>
        /// Returns a list of failures for the specified import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportFailures service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImportFailures service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListImportFailures">REST API Reference for ListImportFailures Operation</seealso>
        Task<ListImportFailuresResponse> ListImportFailuresAsync(ListImportFailuresRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListImports


        /// <summary>
        /// Returns information on all imports, or a select set of imports by <c>ImportStatus</c>
        /// or <c>Destination</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListImports">REST API Reference for ListImports Operation</seealso>
        ListImportsResponse ListImports(ListImportsRequest request);



        /// <summary>
        /// Returns information on all imports, or a select set of imports by <c>ImportStatus</c>
        /// or <c>Destination</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListImports">REST API Reference for ListImports Operation</seealso>
        Task<ListImportsResponse> ListImportsAsync(ListImportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInsightsMetricData


        /// <summary>
        /// Returns Insights metrics data for trails that have enabled Insights. The request must
        /// include the <c>EventSource</c>, <c>EventName</c>, and <c>InsightType</c> parameters.
        /// 
        ///  
        /// <para>
        /// If the <c>InsightType</c> is set to <c>ApiErrorRateInsight</c>, the request must also
        /// include the <c>ErrorCode</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// The following are the available time periods for <c>ListInsightsMetricData</c>. Each
        /// cutoff is inclusive.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Data points with a period of 60 seconds (1-minute) are available for 15 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 300 seconds (5-minute) are available for 63 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 3600 seconds (1 hour) are available for 90 days.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Access to the <c>ListInsightsMetricData</c> API operation is linked to the <c>cloudtrail:LookupEvents</c>
        /// action. To use this operation, you must have permissions to perform the <c>cloudtrail:LookupEvents</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInsightsMetricData service method.</param>
        /// 
        /// <returns>The response from the ListInsightsMetricData service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListInsightsMetricData">REST API Reference for ListInsightsMetricData Operation</seealso>
        ListInsightsMetricDataResponse ListInsightsMetricData(ListInsightsMetricDataRequest request);



        /// <summary>
        /// Returns Insights metrics data for trails that have enabled Insights. The request must
        /// include the <c>EventSource</c>, <c>EventName</c>, and <c>InsightType</c> parameters.
        /// 
        ///  
        /// <para>
        /// If the <c>InsightType</c> is set to <c>ApiErrorRateInsight</c>, the request must also
        /// include the <c>ErrorCode</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// The following are the available time periods for <c>ListInsightsMetricData</c>. Each
        /// cutoff is inclusive.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Data points with a period of 60 seconds (1-minute) are available for 15 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 300 seconds (5-minute) are available for 63 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 3600 seconds (1 hour) are available for 90 days.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Access to the <c>ListInsightsMetricData</c> API operation is linked to the <c>cloudtrail:LookupEvents</c>
        /// action. To use this operation, you must have permissions to perform the <c>cloudtrail:LookupEvents</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInsightsMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInsightsMetricData service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListInsightsMetricData">REST API Reference for ListInsightsMetricData Operation</seealso>
        Task<ListInsightsMetricDataResponse> ListInsightsMetricDataAsync(ListInsightsMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPublicKeys


        /// <summary>
        /// Returns all public keys whose private keys were used to sign the digest files within
        /// the specified time range. The public key is needed to validate digest files that were
        /// signed with its corresponding private key.
        /// 
        ///  <note> 
        /// <para>
        /// CloudTrail uses different private and public key pairs per Region. Each digest file
        /// is signed with a private key unique to its Region. When you validate a digest file
        /// from a specific Region, you must look in the same Region for its corresponding public
        /// key.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys service method.</param>
        /// 
        /// <returns>The response from the ListPublicKeys service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTimeRangeException">
        /// Occurs if the timestamp values are not valid. Either the start time occurs after the
        /// end time, or the time range is outside the range of possible values.
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
        /// Returns all public keys whose private keys were used to sign the digest files within
        /// the specified time range. The public key is needed to validate digest files that were
        /// signed with its corresponding private key.
        /// 
        ///  <note> 
        /// <para>
        /// CloudTrail uses different private and public key pairs per Region. Each digest file
        /// is signed with a private key unique to its Region. When you validate a digest file
        /// from a specific Region, you must look in the same Region for its corresponding public
        /// key.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPublicKeys service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTimeRangeException">
        /// Occurs if the timestamp values are not valid. Either the start time occurs after the
        /// end time, or the time range is outside the range of possible values.
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
        Task<ListPublicKeysResponse> ListPublicKeysAsync(ListPublicKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListQueries


        /// <summary>
        /// Returns a list of queries and query statuses for the past seven days. You must specify
        /// an ARN value for <c>EventDataStore</c>. Optionally, to shorten the list of results,
        /// you can specify a time range, formatted as timestamps, by adding <c>StartTime</c>
        /// and <c>EndTime</c> parameters, and a <c>QueryStatus</c> value. Valid values for <c>QueryStatus</c>
        /// include <c>QUEUED</c>, <c>RUNNING</c>, <c>FINISHED</c>, <c>FAILED</c>, <c>TIMED_OUT</c>,
        /// or <c>CANCELLED</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueries service method.</param>
        /// 
        /// <returns>The response from the ListQueries service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidDateRangeException">
        /// A date range for the query was specified that is not valid. Be sure that the start
        /// time is chronologically before the end time. For more information about writing a
        /// query, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-create-edit-query.html">Create
        /// or edit a query</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidQueryStatusException">
        /// The query status is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListQueries">REST API Reference for ListQueries Operation</seealso>
        ListQueriesResponse ListQueries(ListQueriesRequest request);



        /// <summary>
        /// Returns a list of queries and query statuses for the past seven days. You must specify
        /// an ARN value for <c>EventDataStore</c>. Optionally, to shorten the list of results,
        /// you can specify a time range, formatted as timestamps, by adding <c>StartTime</c>
        /// and <c>EndTime</c> parameters, and a <c>QueryStatus</c> value. Valid values for <c>QueryStatus</c>
        /// include <c>QUEUED</c>, <c>RUNNING</c>, <c>FINISHED</c>, <c>FAILED</c>, <c>TIMED_OUT</c>,
        /// or <c>CANCELLED</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueries service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidDateRangeException">
        /// A date range for the query was specified that is not valid. Be sure that the start
        /// time is chronologically before the end time. For more information about writing a
        /// query, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-create-edit-query.html">Create
        /// or edit a query</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidQueryStatusException">
        /// The query status is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListQueries">REST API Reference for ListQueries Operation</seealso>
        Task<ListQueriesResponse> ListQueriesAsync(ListQueriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Lists the tags for the specified trails, event data stores, dashboards, or channels
        /// in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
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
        /// Lists the tags for the specified trails, event data stores, dashboards, or channels
        /// in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
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
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTrails


        /// <summary>
        /// Lists trails that are in the current account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrails service method.</param>
        /// 
        /// <returns>The response from the ListTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListTrails">REST API Reference for ListTrails Operation</seealso>
        ListTrailsResponse ListTrails(ListTrailsRequest request);



        /// <summary>
        /// Lists trails that are in the current account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListTrails">REST API Reference for ListTrails Operation</seealso>
        Task<ListTrailsResponse> ListTrailsAsync(ListTrailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  LookupEvents


        /// <summary>
        /// Looks up <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html#cloudtrail-concepts-management-events">management
        /// events</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html#cloudtrail-concepts-insights-events">CloudTrail
        /// Insights events</a> that are captured by CloudTrail. You can look up events that occurred
        /// in a Region within the last 90 days.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>LookupEvents</c> returns recent Insights events for trails that enable Insights.
        /// To view Insights events for an event data store, you can run queries on your Insights
        /// event data store, and you can also view the Lake dashboard for Insights.
        /// </para>
        ///  </note> 
        /// <para>
        /// Lookup supports the following attributes for management events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services access key
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
        /// Lookup supports the following attributes for Insights events:
        /// </para>
        ///  <ul> <li> 
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
        ///  </li> </ul> 
        /// <para>
        /// All attributes are optional. The default number of results returned is 50, with a
        /// maximum of 50 possible. The response includes a token that you can use to get the
        /// next page of results.
        /// </para>
        ///  <important> 
        /// <para>
        /// The rate of lookup requests is limited to two per second, per account, per Region.
        /// If this limit is exceeded, a throttling error occurs.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LookupEvents service method.</param>
        /// 
        /// <returns>The response from the LookupEvents service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventCategoryException">
        /// Occurs if an event category that is not valid is specified as a value of <c>EventCategory</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidLookupAttributesException">
        /// Occurs when a lookup attribute is specified that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTimeRangeException">
        /// Occurs if the timestamp values are not valid. Either the start time occurs after the
        /// end time, or the time range is outside the range of possible values.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/LookupEvents">REST API Reference for LookupEvents Operation</seealso>
        LookupEventsResponse LookupEvents(LookupEventsRequest request);



        /// <summary>
        /// Looks up <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html#cloudtrail-concepts-management-events">management
        /// events</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html#cloudtrail-concepts-insights-events">CloudTrail
        /// Insights events</a> that are captured by CloudTrail. You can look up events that occurred
        /// in a Region within the last 90 days.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>LookupEvents</c> returns recent Insights events for trails that enable Insights.
        /// To view Insights events for an event data store, you can run queries on your Insights
        /// event data store, and you can also view the Lake dashboard for Insights.
        /// </para>
        ///  </note> 
        /// <para>
        /// Lookup supports the following attributes for management events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services access key
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
        /// Lookup supports the following attributes for Insights events:
        /// </para>
        ///  <ul> <li> 
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
        ///  </li> </ul> 
        /// <para>
        /// All attributes are optional. The default number of results returned is 50, with a
        /// maximum of 50 possible. The response includes a token that you can use to get the
        /// next page of results.
        /// </para>
        ///  <important> 
        /// <para>
        /// The rate of lookup requests is limited to two per second, per account, per Region.
        /// If this limit is exceeded, a throttling error occurs.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LookupEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the LookupEvents service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventCategoryException">
        /// Occurs if an event category that is not valid is specified as a value of <c>EventCategory</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidLookupAttributesException">
        /// Occurs when a lookup attribute is specified that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTimeRangeException">
        /// Occurs if the timestamp values are not valid. Either the start time occurs after the
        /// end time, or the time range is outside the range of possible values.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/LookupEvents">REST API Reference for LookupEvents Operation</seealso>
        Task<LookupEventsResponse> LookupEventsAsync(LookupEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutEventConfiguration


        /// <summary>
        /// Updates the event configuration settings for the specified event data store. You can
        /// update the maximum event size and context key selectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutEventConfiguration service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientIAMAccessPermissionException">
        /// The task can't be completed because you are signed in with an account that lacks permissions
        /// to view or create a service-linked role. Sign in with an account that has the required
        /// permissions and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutEventConfiguration">REST API Reference for PutEventConfiguration Operation</seealso>
        PutEventConfigurationResponse PutEventConfiguration(PutEventConfigurationRequest request);



        /// <summary>
        /// Updates the event configuration settings for the specified event data store. You can
        /// update the maximum event size and context key selectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEventConfiguration service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientIAMAccessPermissionException">
        /// The task can't be completed because you are signed in with an account that lacks permissions
        /// to view or create a service-linked role. Sign in with an account that has the required
        /// permissions and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutEventConfiguration">REST API Reference for PutEventConfiguration Operation</seealso>
        Task<PutEventConfigurationResponse> PutEventConfigurationAsync(PutEventConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutEventSelectors


        /// <summary>
        /// Configures event selectors (also referred to as <i>basic event selectors</i>) or advanced
        /// event selectors for your trail. You can use either <c>AdvancedEventSelectors</c> or
        /// <c>EventSelectors</c>, but not both. If you apply <c>AdvancedEventSelectors</c> to
        /// a trail, any existing <c>EventSelectors</c> are overwritten.
        /// 
        ///  
        /// <para>
        /// You can use <c>AdvancedEventSelectors</c> to log management events, data events for
        /// all resource types, and network activity events.
        /// </para>
        ///  
        /// <para>
        /// You can use <c>EventSelectors</c> to log management events and data events for the
        /// following resource types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS::DynamoDB::Table</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Lambda::Function</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::S3::Object</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't use <c>EventSelectors</c> to log network activity events.
        /// </para>
        ///  
        /// <para>
        /// If you want your trail to log Insights events, be sure the event selector or advanced
        /// event selector enables logging of the Insights event types you want configured for
        /// your trail. For more information about logging Insights events, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Working
        /// with CloudTrail Insights</a> in the <i>CloudTrail User Guide</i>. By default, trails
        /// created without specific event selectors are configured to log all read and write
        /// management events, and no data events or network activity events.
        /// </para>
        ///  
        /// <para>
        /// When an event occurs in your account, CloudTrail evaluates the event selectors or
        /// advanced event selectors in all trails. For each trail, if the event matches any event
        /// selector, the trail processes and logs the event. If the event doesn't match any event
        /// selector, the trail doesn't log the event.
        /// </para>
        ///  
        /// <para>
        /// Example
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// You create an event selector for a trail and specify that you want to log write-only
        /// events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 <c>GetConsoleOutput</c> and <c>RunInstances</c> API operations occur in your
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CloudTrail evaluates whether the events match your event selectors.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>RunInstances</c> is a write-only event and it matches your event selector.
        /// The trail logs the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>GetConsoleOutput</c> is a read-only event that doesn't match your event selector.
        /// The trail doesn't log the event. 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// The <c>PutEventSelectors</c> operation must be called from the Region in which the
        /// trail was created; otherwise, an <c>InvalidHomeRegionException</c> exception is thrown.
        /// </para>
        ///  
        /// <para>
        /// You can configure up to five event selectors for each trail.
        /// </para>
        ///  
        /// <para>
        /// You can add advanced event selectors, and conditions for your advanced event selectors,
        /// up to a maximum of 500 values for all conditions and selectors on a trail. For more
        /// information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-events-with-cloudtrail.html">Logging
        /// management events</a>, <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
        /// data events</a>, <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-network-events-with-cloudtrail.html">Logging
        /// network activity events</a>, and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/WhatIsCloudTrail-Limits.html">Quotas
        /// in CloudTrail</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventSelectors service method.</param>
        /// 
        /// <returns>The response from the PutEventSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <c>PutEventSelectors</c> operation is called with
        /// a number of event selectors, advanced event selectors, or data resources that is not
        /// valid. The combination of event selectors or advanced event selectors and data resources
        /// is not valid. A trail can have up to 5 event selectors. If a trail uses advanced event
        /// selectors, a maximum of 500 total values for all conditions in all advanced event
        /// selectors is allowed. A trail is limited to 250 data resources. These data resources
        /// can be distributed across event selectors, but the overall total cannot exceed 250.
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
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <c>ReadWriteType</c>
        /// parameter with a value of <c>read-only</c> is not valid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
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
        /// Configures event selectors (also referred to as <i>basic event selectors</i>) or advanced
        /// event selectors for your trail. You can use either <c>AdvancedEventSelectors</c> or
        /// <c>EventSelectors</c>, but not both. If you apply <c>AdvancedEventSelectors</c> to
        /// a trail, any existing <c>EventSelectors</c> are overwritten.
        /// 
        ///  
        /// <para>
        /// You can use <c>AdvancedEventSelectors</c> to log management events, data events for
        /// all resource types, and network activity events.
        /// </para>
        ///  
        /// <para>
        /// You can use <c>EventSelectors</c> to log management events and data events for the
        /// following resource types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS::DynamoDB::Table</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Lambda::Function</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::S3::Object</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't use <c>EventSelectors</c> to log network activity events.
        /// </para>
        ///  
        /// <para>
        /// If you want your trail to log Insights events, be sure the event selector or advanced
        /// event selector enables logging of the Insights event types you want configured for
        /// your trail. For more information about logging Insights events, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Working
        /// with CloudTrail Insights</a> in the <i>CloudTrail User Guide</i>. By default, trails
        /// created without specific event selectors are configured to log all read and write
        /// management events, and no data events or network activity events.
        /// </para>
        ///  
        /// <para>
        /// When an event occurs in your account, CloudTrail evaluates the event selectors or
        /// advanced event selectors in all trails. For each trail, if the event matches any event
        /// selector, the trail processes and logs the event. If the event doesn't match any event
        /// selector, the trail doesn't log the event.
        /// </para>
        ///  
        /// <para>
        /// Example
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// You create an event selector for a trail and specify that you want to log write-only
        /// events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 <c>GetConsoleOutput</c> and <c>RunInstances</c> API operations occur in your
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CloudTrail evaluates whether the events match your event selectors.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>RunInstances</c> is a write-only event and it matches your event selector.
        /// The trail logs the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>GetConsoleOutput</c> is a read-only event that doesn't match your event selector.
        /// The trail doesn't log the event. 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// The <c>PutEventSelectors</c> operation must be called from the Region in which the
        /// trail was created; otherwise, an <c>InvalidHomeRegionException</c> exception is thrown.
        /// </para>
        ///  
        /// <para>
        /// You can configure up to five event selectors for each trail.
        /// </para>
        ///  
        /// <para>
        /// You can add advanced event selectors, and conditions for your advanced event selectors,
        /// up to a maximum of 500 values for all conditions and selectors on a trail. For more
        /// information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-events-with-cloudtrail.html">Logging
        /// management events</a>, <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
        /// data events</a>, <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-network-events-with-cloudtrail.html">Logging
        /// network activity events</a>, and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/WhatIsCloudTrail-Limits.html">Quotas
        /// in CloudTrail</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventSelectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEventSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <c>PutEventSelectors</c> operation is called with
        /// a number of event selectors, advanced event selectors, or data resources that is not
        /// valid. The combination of event selectors or advanced event selectors and data resources
        /// is not valid. A trail can have up to 5 event selectors. If a trail uses advanced event
        /// selectors, a maximum of 500 total values for all conditions in all advanced event
        /// selectors is allowed. A trail is limited to 250 data resources. These data resources
        /// can be distributed across event selectors, but the overall total cannot exceed 250.
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
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <c>ReadWriteType</c>
        /// parameter with a value of <c>read-only</c> is not valid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutEventSelectors">REST API Reference for PutEventSelectors Operation</seealso>
        Task<PutEventSelectorsResponse> PutEventSelectorsAsync(PutEventSelectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutInsightSelectors


        /// <summary>
        /// Lets you enable Insights event logging by specifying the Insights selectors that you
        /// want to enable on an existing trail or event data store. You also use <c>PutInsightSelectors</c>
        /// to turn off Insights event logging, by passing an empty list of Insights types. The
        /// valid Insights event types are <c>ApiErrorRateInsight</c> and <c>ApiCallRateInsight</c>.
        /// 
        ///  
        /// <para>
        /// To enable Insights on an event data store, you must specify the ARNs (or ID suffix
        /// of the ARNs) for the source event data store (<c>EventDataStore</c>) and the destination
        /// event data store (<c>InsightsDestination</c>). The source event data store logs management
        /// events and enables Insights. The destination event data store logs Insights events
        /// based upon the management event activity of the source event data store. The source
        /// and destination event data stores must belong to the same Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// To log Insights events for a trail, you must specify the name (<c>TrailName</c>) of
        /// the CloudTrail trail for which you want to change or add Insights selectors.
        /// </para>
        ///  
        /// <para>
        /// To log CloudTrail Insights events on API call volume, the trail or event data store
        /// must log <c>write</c> management events. To log CloudTrail Insights events on API
        /// error rate, the trail or event data store must log <c>read</c> or <c>write</c> management
        /// events. You can call <c>GetEventSelectors</c> on a trail to check whether the trail
        /// logs management events. You can call <c>GetEventDataStore</c> on an event data store
        /// to check whether the event data store logs management events.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Working
        /// with CloudTrail Insights</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInsightSelectors service method.</param>
        /// 
        /// <returns>The response from the PutInsightSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidInsightSelectorsException">
        /// For <c>PutInsightSelectors</c>, this exception is thrown when the formatting or syntax
        /// of the <c>InsightSelectors</c> JSON statement is not valid, or the specified <c>InsightType</c>
        /// in the <c>InsightSelectors</c> statement is not valid. Valid values for <c>InsightType</c>
        /// are <c>ApiCallRateInsight</c> and <c>ApiErrorRateInsight</c>. To enable Insights on
        /// an event data store, the destination event data store specified by the <c>InsightsDestination</c>
        /// parameter must log Insights events and the source event data store specified by the
        /// <c>EventDataStore</c> parameter must log management events.
        /// 
        ///  
        /// <para>
        /// For <c>UpdateEventDataStore</c>, this exception is thrown if Insights are enabled
        /// on the event data store and the updated advanced event selectors are not compatible
        /// with the configured <c>InsightSelectors</c>. If the <c>InsightSelectors</c> includes
        /// an <c>InsightType</c> of <c>ApiCallRateInsight</c>, the source event data store must
        /// log <c>write</c> management events. If the <c>InsightSelectors</c> includes an <c>InsightType</c>
        /// of <c>ApiErrorRateInsight</c>, the source event data store must log management events.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutInsightSelectors">REST API Reference for PutInsightSelectors Operation</seealso>
        PutInsightSelectorsResponse PutInsightSelectors(PutInsightSelectorsRequest request);



        /// <summary>
        /// Lets you enable Insights event logging by specifying the Insights selectors that you
        /// want to enable on an existing trail or event data store. You also use <c>PutInsightSelectors</c>
        /// to turn off Insights event logging, by passing an empty list of Insights types. The
        /// valid Insights event types are <c>ApiErrorRateInsight</c> and <c>ApiCallRateInsight</c>.
        /// 
        ///  
        /// <para>
        /// To enable Insights on an event data store, you must specify the ARNs (or ID suffix
        /// of the ARNs) for the source event data store (<c>EventDataStore</c>) and the destination
        /// event data store (<c>InsightsDestination</c>). The source event data store logs management
        /// events and enables Insights. The destination event data store logs Insights events
        /// based upon the management event activity of the source event data store. The source
        /// and destination event data stores must belong to the same Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// To log Insights events for a trail, you must specify the name (<c>TrailName</c>) of
        /// the CloudTrail trail for which you want to change or add Insights selectors.
        /// </para>
        ///  
        /// <para>
        /// To log CloudTrail Insights events on API call volume, the trail or event data store
        /// must log <c>write</c> management events. To log CloudTrail Insights events on API
        /// error rate, the trail or event data store must log <c>read</c> or <c>write</c> management
        /// events. You can call <c>GetEventSelectors</c> on a trail to check whether the trail
        /// logs management events. You can call <c>GetEventDataStore</c> on an event data store
        /// to check whether the event data store logs management events.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Working
        /// with CloudTrail Insights</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInsightSelectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutInsightSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidInsightSelectorsException">
        /// For <c>PutInsightSelectors</c>, this exception is thrown when the formatting or syntax
        /// of the <c>InsightSelectors</c> JSON statement is not valid, or the specified <c>InsightType</c>
        /// in the <c>InsightSelectors</c> statement is not valid. Valid values for <c>InsightType</c>
        /// are <c>ApiCallRateInsight</c> and <c>ApiErrorRateInsight</c>. To enable Insights on
        /// an event data store, the destination event data store specified by the <c>InsightsDestination</c>
        /// parameter must log Insights events and the source event data store specified by the
        /// <c>EventDataStore</c> parameter must log management events.
        /// 
        ///  
        /// <para>
        /// For <c>UpdateEventDataStore</c>, this exception is thrown if Insights are enabled
        /// on the event data store and the updated advanced event selectors are not compatible
        /// with the configured <c>InsightSelectors</c>. If the <c>InsightSelectors</c> includes
        /// an <c>InsightType</c> of <c>ApiCallRateInsight</c>, the source event data store must
        /// log <c>write</c> management events. If the <c>InsightSelectors</c> includes an <c>InsightType</c>
        /// of <c>ApiErrorRateInsight</c>, the source event data store must log management events.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutInsightSelectors">REST API Reference for PutInsightSelectors Operation</seealso>
        Task<PutInsightSelectorsResponse> PutInsightSelectorsAsync(PutInsightSelectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Attaches a resource-based permission policy to a CloudTrail event data store, dashboard,
        /// or channel. For more information about resource-based policies, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html">CloudTrail
        /// resource-based policy examples</a> in the <i>CloudTrail User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceARNNotValidException">
        /// This exception is thrown when the provided resource does not exist, or the ARN format
        /// of the resource is not valid. 
        /// 
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourcePolicyNotValidException">
        /// This exception is thrown when the resouce-based policy has syntax errors, or contains
        /// a principal that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);



        /// <summary>
        /// Attaches a resource-based permission policy to a CloudTrail event data store, dashboard,
        /// or channel. For more information about resource-based policies, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html">CloudTrail
        /// resource-based policy examples</a> in the <i>CloudTrail User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceARNNotValidException">
        /// This exception is thrown when the provided resource does not exist, or the ARN format
        /// of the resource is not valid. 
        /// 
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourcePolicyNotValidException">
        /// This exception is thrown when the resouce-based policy has syntax errors, or contains
        /// a principal that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterOrganizationDelegatedAdmin


        /// <summary>
        /// Registers an organization’s member account as the CloudTrail <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-delegated-administrator.html">delegated
        /// administrator</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOrganizationDelegatedAdmin service method.</param>
        /// 
        /// <returns>The response from the RegisterOrganizationDelegatedAdmin service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccountNotFoundException">
        /// This exception is thrown when the specified account is not found or not part of an
        /// organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.AccountRegisteredException">
        /// This exception is thrown when the account is already registered as the CloudTrail
        /// delegated administrator.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CannotDelegateManagementAccountException">
        /// This exception is thrown when the management account of an organization is registered
        /// as the CloudTrail delegated administrator.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.DelegatedAdminAccountLimitExceededException">
        /// This exception is thrown when the maximum number of CloudTrail delegated administrators
        /// is reached.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientIAMAccessPermissionException">
        /// The task can't be completed because you are signed in with an account that lacks permissions
        /// to view or create a service-linked role. Sign in with an account that has the required
        /// permissions and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationManagementAccountException">
        /// This exception is thrown when the account making the request is not the organization's
        /// management account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/RegisterOrganizationDelegatedAdmin">REST API Reference for RegisterOrganizationDelegatedAdmin Operation</seealso>
        RegisterOrganizationDelegatedAdminResponse RegisterOrganizationDelegatedAdmin(RegisterOrganizationDelegatedAdminRequest request);



        /// <summary>
        /// Registers an organization’s member account as the CloudTrail <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-delegated-administrator.html">delegated
        /// administrator</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOrganizationDelegatedAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterOrganizationDelegatedAdmin service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccountNotFoundException">
        /// This exception is thrown when the specified account is not found or not part of an
        /// organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.AccountRegisteredException">
        /// This exception is thrown when the account is already registered as the CloudTrail
        /// delegated administrator.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CannotDelegateManagementAccountException">
        /// This exception is thrown when the management account of an organization is registered
        /// as the CloudTrail delegated administrator.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.DelegatedAdminAccountLimitExceededException">
        /// This exception is thrown when the maximum number of CloudTrail delegated administrators
        /// is reached.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientIAMAccessPermissionException">
        /// The task can't be completed because you are signed in with an account that lacks permissions
        /// to view or create a service-linked role. Sign in with an account that has the required
        /// permissions and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationManagementAccountException">
        /// This exception is thrown when the account making the request is not the organization's
        /// management account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/RegisterOrganizationDelegatedAdmin">REST API Reference for RegisterOrganizationDelegatedAdmin Operation</seealso>
        Task<RegisterOrganizationDelegatedAdminResponse> RegisterOrganizationDelegatedAdminAsync(RegisterOrganizationDelegatedAdminRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTags


        /// <summary>
        /// Removes the specified tags from a trail, event data store, dashboard, or channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
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
        /// Removes the specified tags from a trail, event data store, dashboard, or channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
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
        Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestoreEventDataStore


        /// <summary>
        /// Restores a deleted event data store specified by <c>EventDataStore</c>, which accepts
        /// an event data store ARN. You can only restore a deleted event data store within the
        /// seven-day wait period after deletion. Restoring an event data store can take several
        /// minutes, depending on the size of the event data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreEventDataStore service method.</param>
        /// 
        /// <returns>The response from the RestoreEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreMaxLimitExceededException">
        /// Your account has used the maximum number of event data stores.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/RestoreEventDataStore">REST API Reference for RestoreEventDataStore Operation</seealso>
        RestoreEventDataStoreResponse RestoreEventDataStore(RestoreEventDataStoreRequest request);



        /// <summary>
        /// Restores a deleted event data store specified by <c>EventDataStore</c>, which accepts
        /// an event data store ARN. You can only restore a deleted event data store within the
        /// seven-day wait period after deletion. Restoring an event data store can take several
        /// minutes, depending on the size of the event data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreEventDataStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreMaxLimitExceededException">
        /// Your account has used the maximum number of event data stores.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/RestoreEventDataStore">REST API Reference for RestoreEventDataStore Operation</seealso>
        Task<RestoreEventDataStoreResponse> RestoreEventDataStoreAsync(RestoreEventDataStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchSampleQueries


        /// <summary>
        /// Searches sample queries and returns a list of sample queries that are sorted by relevance.
        /// To search for sample queries, provide a natural language <c>SearchPhrase</c> in English.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSampleQueries service method.</param>
        /// 
        /// <returns>The response from the SearchSampleQueries service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/SearchSampleQueries">REST API Reference for SearchSampleQueries Operation</seealso>
        SearchSampleQueriesResponse SearchSampleQueries(SearchSampleQueriesRequest request);



        /// <summary>
        /// Searches sample queries and returns a list of sample queries that are sorted by relevance.
        /// To search for sample queries, provide a natural language <c>SearchPhrase</c> in English.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSampleQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchSampleQueries service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/SearchSampleQueries">REST API Reference for SearchSampleQueries Operation</seealso>
        Task<SearchSampleQueriesResponse> SearchSampleQueriesAsync(SearchSampleQueriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartDashboardRefresh


        /// <summary>
        /// Starts a refresh of the specified dashboard. 
        /// 
        ///  
        /// <para>
        ///  Each time a dashboard is refreshed, CloudTrail runs queries to populate the dashboard's
        /// widgets. CloudTrail must be granted permissions to run the <c>StartQuery</c> operation
        /// on your behalf. To provide permissions, run the <c>PutResourcePolicy</c> operation
        /// to attach a resource-based policy to each event data store. For more information,
        /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-eds-dashboard">Example:
        /// Allow CloudTrail to run queries to populate a dashboard</a> in the <i>CloudTrail User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDashboardRefresh service method.</param>
        /// 
        /// <returns>The response from the StartDashboardRefresh service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ServiceQuotaExceededException">
        /// This exception is thrown when the quota is exceeded. For information about CloudTrail
        /// quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/ct.html#limits_cloudtrail">Service
        /// quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartDashboardRefresh">REST API Reference for StartDashboardRefresh Operation</seealso>
        StartDashboardRefreshResponse StartDashboardRefresh(StartDashboardRefreshRequest request);



        /// <summary>
        /// Starts a refresh of the specified dashboard. 
        /// 
        ///  
        /// <para>
        ///  Each time a dashboard is refreshed, CloudTrail runs queries to populate the dashboard's
        /// widgets. CloudTrail must be granted permissions to run the <c>StartQuery</c> operation
        /// on your behalf. To provide permissions, run the <c>PutResourcePolicy</c> operation
        /// to attach a resource-based policy to each event data store. For more information,
        /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-eds-dashboard">Example:
        /// Allow CloudTrail to run queries to populate a dashboard</a> in the <i>CloudTrail User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDashboardRefresh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDashboardRefresh service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ServiceQuotaExceededException">
        /// This exception is thrown when the quota is exceeded. For information about CloudTrail
        /// quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/ct.html#limits_cloudtrail">Service
        /// quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartDashboardRefresh">REST API Reference for StartDashboardRefresh Operation</seealso>
        Task<StartDashboardRefreshResponse> StartDashboardRefreshAsync(StartDashboardRefreshRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartEventDataStoreIngestion


        /// <summary>
        /// Starts the ingestion of live events on an event data store specified as either an
        /// ARN or the ID portion of the ARN. To start ingestion, the event data store <c>Status</c>
        /// must be <c>STOPPED_INGESTION</c> and the <c>eventCategory</c> must be <c>Management</c>,
        /// <c>Data</c>, <c>NetworkActivity</c>, or <c>ConfigurationItem</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEventDataStoreIngestion service method.</param>
        /// 
        /// <returns>The response from the StartEventDataStoreIngestion service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartEventDataStoreIngestion">REST API Reference for StartEventDataStoreIngestion Operation</seealso>
        StartEventDataStoreIngestionResponse StartEventDataStoreIngestion(StartEventDataStoreIngestionRequest request);



        /// <summary>
        /// Starts the ingestion of live events on an event data store specified as either an
        /// ARN or the ID portion of the ARN. To start ingestion, the event data store <c>Status</c>
        /// must be <c>STOPPED_INGESTION</c> and the <c>eventCategory</c> must be <c>Management</c>,
        /// <c>Data</c>, <c>NetworkActivity</c>, or <c>ConfigurationItem</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEventDataStoreIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartEventDataStoreIngestion service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartEventDataStoreIngestion">REST API Reference for StartEventDataStoreIngestion Operation</seealso>
        Task<StartEventDataStoreIngestionResponse> StartEventDataStoreIngestionAsync(StartEventDataStoreIngestionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartImport


        /// <summary>
        /// Starts an import of logged trail events from a source S3 bucket to a destination
        /// event data store. By default, CloudTrail only imports events contained in the S3 bucket's
        /// <c>CloudTrail</c> prefix and the prefixes inside the <c>CloudTrail</c> prefix, and
        /// does not check prefixes for other Amazon Web Services services. If you want to import
        /// CloudTrail events contained in another prefix, you must include the prefix in the
        /// <c>S3LocationUri</c>. For more considerations about importing trail events, see <a
        /// href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-copy-trail-to-lake.html#cloudtrail-trail-copy-considerations">Considerations
        /// for copying trail events</a> in the <i>CloudTrail User Guide</i>. 
        /// 
        ///  
        /// <para>
        ///  When you start a new import, the <c>Destinations</c> and <c>ImportSource</c> parameters
        /// are required. Before starting a new import, disable any access control lists (ACLs)
        /// attached to the source S3 bucket. For more information about disabling ACLs, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">Controlling
        /// ownership of objects and disabling ACLs for your bucket</a>. 
        /// </para>
        ///  
        /// <para>
        ///  When you retry an import, the <c>ImportID</c> parameter is required. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If the destination event data store is for an organization, you must use the management
        /// account to import trail events. You cannot use the delegated administrator account
        /// for the organization. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImport service method.</param>
        /// 
        /// <returns>The response from the StartImport service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccountHasOngoingImportException">
        /// This exception is thrown when you start a new import and a previous import is still
        /// in progress.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ImportNotFoundException">
        /// The specified import was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidImportSourceException">
        /// This exception is thrown when the provided source S3 bucket is not valid for import.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartImport">REST API Reference for StartImport Operation</seealso>
        StartImportResponse StartImport(StartImportRequest request);



        /// <summary>
        /// Starts an import of logged trail events from a source S3 bucket to a destination
        /// event data store. By default, CloudTrail only imports events contained in the S3 bucket's
        /// <c>CloudTrail</c> prefix and the prefixes inside the <c>CloudTrail</c> prefix, and
        /// does not check prefixes for other Amazon Web Services services. If you want to import
        /// CloudTrail events contained in another prefix, you must include the prefix in the
        /// <c>S3LocationUri</c>. For more considerations about importing trail events, see <a
        /// href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-copy-trail-to-lake.html#cloudtrail-trail-copy-considerations">Considerations
        /// for copying trail events</a> in the <i>CloudTrail User Guide</i>. 
        /// 
        ///  
        /// <para>
        ///  When you start a new import, the <c>Destinations</c> and <c>ImportSource</c> parameters
        /// are required. Before starting a new import, disable any access control lists (ACLs)
        /// attached to the source S3 bucket. For more information about disabling ACLs, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">Controlling
        /// ownership of objects and disabling ACLs for your bucket</a>. 
        /// </para>
        ///  
        /// <para>
        ///  When you retry an import, the <c>ImportID</c> parameter is required. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If the destination event data store is for an organization, you must use the management
        /// account to import trail events. You cannot use the delegated administrator account
        /// for the organization. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartImport service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccountHasOngoingImportException">
        /// This exception is thrown when you start a new import and a previous import is still
        /// in progress.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ImportNotFoundException">
        /// The specified import was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidImportSourceException">
        /// This exception is thrown when the provided source S3 bucket is not valid for import.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartImport">REST API Reference for StartImport Operation</seealso>
        Task<StartImportResponse> StartImportAsync(StartImportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartLogging


        /// <summary>
        /// Starts the recording of Amazon Web Services API calls and log file delivery for a
        /// trail. For a trail that is enabled in all Regions, this operation must be called from
        /// the Region in which the trail was created. This operation cannot be called on the
        /// shadow trails (replicated trails in other Regions) of a trail that is enabled in all
        /// Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLogging service method.</param>
        /// 
        /// <returns>The response from the StartLogging service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
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
        /// Starts the recording of Amazon Web Services API calls and log file delivery for a
        /// trail. For a trail that is enabled in all Regions, this operation must be called from
        /// the Region in which the trail was created. This operation cannot be called on the
        /// shadow trails (replicated trails in other Regions) of a trail that is enabled in all
        /// Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartLogging service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartLogging">REST API Reference for StartLogging Operation</seealso>
        Task<StartLoggingResponse> StartLoggingAsync(StartLoggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartQuery


        /// <summary>
        /// Starts a CloudTrail Lake query. Use the <c>QueryStatement</c> parameter to provide
        /// your SQL query, enclosed in single quotation marks. Use the optional <c>DeliveryS3Uri</c>
        /// parameter to deliver the query results to an S3 bucket.
        /// 
        ///  
        /// <para>
        ///  <c>StartQuery</c> requires you specify either the <c>QueryStatement</c> parameter,
        /// or a <c>QueryAlias</c> and any <c>QueryParameters</c>. In the current release, the
        /// <c>QueryAlias</c> and <c>QueryParameters</c> parameters are used only for the queries
        /// that populate the CloudTrail Lake dashboards.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQuery service method.</param>
        /// 
        /// <returns>The response from the StartQuery service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidQueryStatementException">
        /// The query that was submitted has validation errors, or uses incorrect syntax or unsupported
        /// keywords. For more information about writing a query, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-create-edit-query.html">Create
        /// or edit a query</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3BucketNameException">
        /// This exception is thrown when the provided S3 bucket name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3PrefixException">
        /// This exception is thrown when the provided S3 prefix is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.MaxConcurrentQueriesException">
        /// You are already running the maximum number of concurrent queries. The maximum number
        /// of concurrent queries is 10. Wait a minute for some queries to finish, and then run
        /// the query again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartQuery">REST API Reference for StartQuery Operation</seealso>
        StartQueryResponse StartQuery(StartQueryRequest request);



        /// <summary>
        /// Starts a CloudTrail Lake query. Use the <c>QueryStatement</c> parameter to provide
        /// your SQL query, enclosed in single quotation marks. Use the optional <c>DeliveryS3Uri</c>
        /// parameter to deliver the query results to an S3 bucket.
        /// 
        ///  
        /// <para>
        ///  <c>StartQuery</c> requires you specify either the <c>QueryStatement</c> parameter,
        /// or a <c>QueryAlias</c> and any <c>QueryParameters</c>. In the current release, the
        /// <c>QueryAlias</c> and <c>QueryParameters</c> parameters are used only for the queries
        /// that populate the CloudTrail Lake dashboards.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartQuery service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidQueryStatementException">
        /// The query that was submitted has validation errors, or uses incorrect syntax or unsupported
        /// keywords. For more information about writing a query, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-create-edit-query.html">Create
        /// or edit a query</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3BucketNameException">
        /// This exception is thrown when the provided S3 bucket name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3PrefixException">
        /// This exception is thrown when the provided S3 prefix is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.MaxConcurrentQueriesException">
        /// You are already running the maximum number of concurrent queries. The maximum number
        /// of concurrent queries is 10. Wait a minute for some queries to finish, and then run
        /// the query again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartQuery">REST API Reference for StartQuery Operation</seealso>
        Task<StartQueryResponse> StartQueryAsync(StartQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopEventDataStoreIngestion


        /// <summary>
        /// Stops the ingestion of live events on an event data store specified as either an ARN
        /// or the ID portion of the ARN. To stop ingestion, the event data store <c>Status</c>
        /// must be <c>ENABLED</c> and the <c>eventCategory</c> must be <c>Management</c>, <c>Data</c>,
        /// <c>NetworkActivity</c>, or <c>ConfigurationItem</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEventDataStoreIngestion service method.</param>
        /// 
        /// <returns>The response from the StopEventDataStoreIngestion service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StopEventDataStoreIngestion">REST API Reference for StopEventDataStoreIngestion Operation</seealso>
        StopEventDataStoreIngestionResponse StopEventDataStoreIngestion(StopEventDataStoreIngestionRequest request);



        /// <summary>
        /// Stops the ingestion of live events on an event data store specified as either an ARN
        /// or the ID portion of the ARN. To stop ingestion, the event data store <c>Status</c>
        /// must be <c>ENABLED</c> and the <c>eventCategory</c> must be <c>Management</c>, <c>Data</c>,
        /// <c>NetworkActivity</c>, or <c>ConfigurationItem</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEventDataStoreIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopEventDataStoreIngestion service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StopEventDataStoreIngestion">REST API Reference for StopEventDataStoreIngestion Operation</seealso>
        Task<StopEventDataStoreIngestionResponse> StopEventDataStoreIngestionAsync(StopEventDataStoreIngestionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopImport


        /// <summary>
        /// Stops a specified import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopImport service method.</param>
        /// 
        /// <returns>The response from the StopImport service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ImportNotFoundException">
        /// The specified import was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StopImport">REST API Reference for StopImport Operation</seealso>
        StopImportResponse StopImport(StopImportRequest request);



        /// <summary>
        /// Stops a specified import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopImport service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ImportNotFoundException">
        /// The specified import was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StopImport">REST API Reference for StopImport Operation</seealso>
        Task<StopImportResponse> StopImportAsync(StopImportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopLogging


        /// <summary>
        /// Suspends the recording of Amazon Web Services API calls and log file delivery for
        /// the specified trail. Under most circumstances, there is no need to use this action.
        /// You can update a trail without stopping it first. This action is the only way to stop
        /// recording. For a trail enabled in all Regions, this operation must be called from
        /// the Region in which the trail was created, or an <c>InvalidHomeRegionException</c>
        /// will occur. This operation cannot be called on the shadow trails (replicated trails
        /// in other Regions) of a trail enabled in all Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopLogging service method.</param>
        /// 
        /// <returns>The response from the StopLogging service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
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
        /// Suspends the recording of Amazon Web Services API calls and log file delivery for
        /// the specified trail. Under most circumstances, there is no need to use this action.
        /// You can update a trail without stopping it first. This action is the only way to stop
        /// recording. For a trail enabled in all Regions, this operation must be called from
        /// the Region in which the trail was created, or an <c>InvalidHomeRegionException</c>
        /// will occur. This operation cannot be called on the shadow trails (replicated trails
        /// in other Regions) of a trail enabled in all Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopLogging service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StopLogging">REST API Reference for StopLogging Operation</seealso>
        Task<StopLoggingResponse> StopLoggingAsync(StopLoggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateChannel


        /// <summary>
        /// Updates a channel specified by a required channel ARN or UUID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelAlreadyExistsException">
        /// This exception is thrown when the provided channel already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse UpdateChannel(UpdateChannelRequest request);



        /// <summary>
        /// Updates a channel specified by a required channel ARN or UUID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelAlreadyExistsException">
        /// This exception is thrown when the provided channel already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDashboard


        /// <summary>
        /// Updates the specified dashboard. 
        /// 
        ///  
        /// <para>
        ///  To set a refresh schedule, CloudTrail must be granted permissions to run the <c>StartDashboardRefresh</c>
        /// operation to refresh the dashboard on your behalf. To provide permissions, run the
        /// <c>PutResourcePolicy</c> operation to attach a resource-based policy to the dashboard.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-dashboards">
        /// Resource-based policy example for a dashboard</a> in the <i>CloudTrail User Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  CloudTrail runs queries to populate the dashboard's widgets during a manual or scheduled
        /// refresh. CloudTrail must be granted permissions to run the <c>StartQuery</c> operation
        /// on your behalf. To provide permissions, run the <c>PutResourcePolicy</c> operation
        /// to attach a resource-based policy to each event data store. For more information,
        /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-eds-dashboard">Example:
        /// Allow CloudTrail to run queries to populate a dashboard</a> in the <i>CloudTrail User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidQueryStatementException">
        /// The query that was submitted has validation errors, or uses incorrect syntax or unsupported
        /// keywords. For more information about writing a query, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-create-edit-query.html">Create
        /// or edit a query</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ServiceQuotaExceededException">
        /// This exception is thrown when the quota is exceeded. For information about CloudTrail
        /// quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/ct.html#limits_cloudtrail">Service
        /// quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        UpdateDashboardResponse UpdateDashboard(UpdateDashboardRequest request);



        /// <summary>
        /// Updates the specified dashboard. 
        /// 
        ///  
        /// <para>
        ///  To set a refresh schedule, CloudTrail must be granted permissions to run the <c>StartDashboardRefresh</c>
        /// operation to refresh the dashboard on your behalf. To provide permissions, run the
        /// <c>PutResourcePolicy</c> operation to attach a resource-based policy to the dashboard.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-dashboards">
        /// Resource-based policy example for a dashboard</a> in the <i>CloudTrail User Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  CloudTrail runs queries to populate the dashboard's widgets during a manual or scheduled
        /// refresh. CloudTrail must be granted permissions to run the <c>StartQuery</c> operation
        /// on your behalf. To provide permissions, run the <c>PutResourcePolicy</c> operation
        /// to attach a resource-based policy to each event data store. For more information,
        /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-eds-dashboard">Example:
        /// Allow CloudTrail to run queries to populate a dashboard</a> in the <i>CloudTrail User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidQueryStatementException">
        /// The query that was submitted has validation errors, or uses incorrect syntax or unsupported
        /// keywords. For more information about writing a query, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-create-edit-query.html">Create
        /// or edit a query</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ServiceQuotaExceededException">
        /// This exception is thrown when the quota is exceeded. For information about CloudTrail
        /// quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/ct.html#limits_cloudtrail">Service
        /// quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        Task<UpdateDashboardResponse> UpdateDashboardAsync(UpdateDashboardRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEventDataStore


        /// <summary>
        /// Updates an event data store. The required <c>EventDataStore</c> value is an ARN or
        /// the ID portion of the ARN. Other parameters are optional, but at least one optional
        /// parameter must be specified, or CloudTrail throws an error. <c>RetentionPeriod</c>
        /// is in days, and valid values are integers between 7 and 3653 if the <c>BillingMode</c>
        /// is set to <c>EXTENDABLE_RETENTION_PRICING</c>, or between 7 and 2557 if <c>BillingMode</c>
        /// is set to <c>FIXED_RETENTION_PRICING</c>. By default, <c>TerminationProtection</c>
        /// is enabled.
        /// 
        ///  
        /// <para>
        /// For event data stores for CloudTrail events, <c>AdvancedEventSelectors</c> includes
        /// or excludes management, data, or network activity events in your event data store.
        /// For more information about <c>AdvancedEventSelectors</c>, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/APIReference/API_AdvancedEventSelector.html">AdvancedEventSelectors</a>.
        /// </para>
        ///  
        /// <para>
        ///  For event data stores for CloudTrail Insights events, Config configuration items,
        /// Audit Manager evidence, or non-Amazon Web Services events, <c>AdvancedEventSelectors</c>
        /// includes events of that type in your event data store.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventDataStore service method.</param>
        /// 
        /// <returns>The response from the UpdateEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreAlreadyExistsException">
        /// An event data store with that name already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreHasOngoingImportException">
        /// This exception is thrown when you try to update or delete an event data store that
        /// currently has an import in progress.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <c>PutEventSelectors</c> operation is called with
        /// a number of event selectors, advanced event selectors, or data resources that is not
        /// valid. The combination of event selectors or advanced event selectors and data resources
        /// is not valid. A trail can have up to 5 event selectors. If a trail uses advanced event
        /// selectors, a maximum of 500 total values for all conditions in all advanced event
        /// selectors is allowed. A trail is limited to 250 data resources. These data resources
        /// can be distributed across event selectors, but the overall total cannot exceed 250.
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
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <c>ReadWriteType</c>
        /// parameter with a value of <c>read-only</c> is not valid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidInsightSelectorsException">
        /// For <c>PutInsightSelectors</c>, this exception is thrown when the formatting or syntax
        /// of the <c>InsightSelectors</c> JSON statement is not valid, or the specified <c>InsightType</c>
        /// in the <c>InsightSelectors</c> statement is not valid. Valid values for <c>InsightType</c>
        /// are <c>ApiCallRateInsight</c> and <c>ApiErrorRateInsight</c>. To enable Insights on
        /// an event data store, the destination event data store specified by the <c>InsightsDestination</c>
        /// parameter must log Insights events and the source event data store specified by the
        /// <c>EventDataStore</c> parameter must log management events.
        /// 
        ///  
        /// <para>
        /// For <c>UpdateEventDataStore</c>, this exception is thrown if Insights are enabled
        /// on the event data store and the updated advanced event selectors are not compatible
        /// with the configured <c>InsightSelectors</c>. If the <c>InsightSelectors</c> includes
        /// an <c>InsightType</c> of <c>ApiCallRateInsight</c>, the source event data store must
        /// log <c>write</c> management events. If the <c>InsightSelectors</c> includes an <c>InsightType</c>
        /// of <c>ApiErrorRateInsight</c>, the source event data store must log management events.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same Region, or when the KMS key associated with the Amazon
        /// SNS topic either does not exist or is not in the same Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateEventDataStore">REST API Reference for UpdateEventDataStore Operation</seealso>
        UpdateEventDataStoreResponse UpdateEventDataStore(UpdateEventDataStoreRequest request);



        /// <summary>
        /// Updates an event data store. The required <c>EventDataStore</c> value is an ARN or
        /// the ID portion of the ARN. Other parameters are optional, but at least one optional
        /// parameter must be specified, or CloudTrail throws an error. <c>RetentionPeriod</c>
        /// is in days, and valid values are integers between 7 and 3653 if the <c>BillingMode</c>
        /// is set to <c>EXTENDABLE_RETENTION_PRICING</c>, or between 7 and 2557 if <c>BillingMode</c>
        /// is set to <c>FIXED_RETENTION_PRICING</c>. By default, <c>TerminationProtection</c>
        /// is enabled.
        /// 
        ///  
        /// <para>
        /// For event data stores for CloudTrail events, <c>AdvancedEventSelectors</c> includes
        /// or excludes management, data, or network activity events in your event data store.
        /// For more information about <c>AdvancedEventSelectors</c>, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/APIReference/API_AdvancedEventSelector.html">AdvancedEventSelectors</a>.
        /// </para>
        ///  
        /// <para>
        ///  For event data stores for CloudTrail Insights events, Config configuration items,
        /// Audit Manager evidence, or non-Amazon Web Services events, <c>AdvancedEventSelectors</c>
        /// includes events of that type in your event data store.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventDataStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreAlreadyExistsException">
        /// An event data store with that name already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreHasOngoingImportException">
        /// This exception is thrown when you try to update or delete an event data store that
        /// currently has an import in progress.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <c>PutEventSelectors</c> operation is called with
        /// a number of event selectors, advanced event selectors, or data resources that is not
        /// valid. The combination of event selectors or advanced event selectors and data resources
        /// is not valid. A trail can have up to 5 event selectors. If a trail uses advanced event
        /// selectors, a maximum of 500 total values for all conditions in all advanced event
        /// selectors is allowed. A trail is limited to 250 data resources. These data resources
        /// can be distributed across event selectors, but the overall total cannot exceed 250.
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
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <c>ReadWriteType</c>
        /// parameter with a value of <c>read-only</c> is not valid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidInsightSelectorsException">
        /// For <c>PutInsightSelectors</c>, this exception is thrown when the formatting or syntax
        /// of the <c>InsightSelectors</c> JSON statement is not valid, or the specified <c>InsightType</c>
        /// in the <c>InsightSelectors</c> statement is not valid. Valid values for <c>InsightType</c>
        /// are <c>ApiCallRateInsight</c> and <c>ApiErrorRateInsight</c>. To enable Insights on
        /// an event data store, the destination event data store specified by the <c>InsightsDestination</c>
        /// parameter must log Insights events and the source event data store specified by the
        /// <c>EventDataStore</c> parameter must log management events.
        /// 
        ///  
        /// <para>
        /// For <c>UpdateEventDataStore</c>, this exception is thrown if Insights are enabled
        /// on the event data store and the updated advanced event selectors are not compatible
        /// with the configured <c>InsightSelectors</c>. If the <c>InsightSelectors</c> includes
        /// an <c>InsightType</c> of <c>ApiCallRateInsight</c>, the source event data store must
        /// log <c>write</c> management events. If the <c>InsightSelectors</c> includes an <c>InsightType</c>
        /// of <c>ApiErrorRateInsight</c>, the source event data store must log management events.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same Region, or when the KMS key associated with the Amazon
        /// SNS topic either does not exist or is not in the same Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateEventDataStore">REST API Reference for UpdateEventDataStore Operation</seealso>
        Task<UpdateEventDataStoreResponse> UpdateEventDataStoreAsync(UpdateEventDataStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTrail


        /// <summary>
        /// Updates trail settings that control what events you are logging, and how to handle
        /// log files. Changes to a trail do not require stopping the CloudTrail service. Use
        /// this action to designate an existing bucket for log delivery. If the existing bucket
        /// has previously been a target for CloudTrail log files, an IAM policy exists for the
        /// bucket. <c>UpdateTrail</c> must be called from the Region in which the trail was created;
        /// otherwise, an <c>InvalidHomeRegionException</c> is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrail service method.</param>
        /// 
        /// <returns>The response from the UpdateTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailInvalidClientTokenIdException">
        /// This exception is thrown when a call results in the <c>InvalidClientTokenId</c> error
        /// code. This can occur when you are creating or updating a trail to send notifications
        /// to an Amazon SNS topic that is in a suspended Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudWatchLogsDeliveryUnavailableException">
        /// Cannot set a CloudWatch Logs delivery for this Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientSnsTopicPolicyException">
        /// This exception is thrown when the policy on the Amazon SNS topic is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsLogGroupArnException">
        /// This exception is thrown when the provided CloudWatch Logs log group is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsRoleArnException">
        /// This exception is thrown when the provided role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <c>PutEventSelectors</c> operation is called with
        /// a number of event selectors, advanced event selectors, or data resources that is not
        /// valid. The combination of event selectors or advanced event selectors and data resources
        /// is not valid. A trail can have up to 5 event selectors. If a trail uses advanced event
        /// selectors, a maximum of 500 total values for all conditions in all advanced event
        /// selectors is allowed. A trail is limited to 250 data resources. These data resources
        /// can be distributed across event selectors, but the overall total cannot exceed 250.
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
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <c>ReadWriteType</c>
        /// parameter with a value of <c>read-only</c> is not valid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyDisabledException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same Region, or when the KMS key associated with the Amazon
        /// SNS topic either does not exist or is not in the same Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotProvidedException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateTrail">REST API Reference for UpdateTrail Operation</seealso>
        UpdateTrailResponse UpdateTrail(UpdateTrailRequest request);



        /// <summary>
        /// Updates trail settings that control what events you are logging, and how to handle
        /// log files. Changes to a trail do not require stopping the CloudTrail service. Use
        /// this action to designate an existing bucket for log delivery. If the existing bucket
        /// has previously been a target for CloudTrail log files, an IAM policy exists for the
        /// bucket. <c>UpdateTrail</c> must be called from the Region in which the trail was created;
        /// otherwise, an <c>InvalidHomeRegionException</c> is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailInvalidClientTokenIdException">
        /// This exception is thrown when a call results in the <c>InvalidClientTokenId</c> error
        /// code. This can occur when you are creating or updating a trail to send notifications
        /// to an Amazon SNS topic that is in a suspended Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudWatchLogsDeliveryUnavailableException">
        /// Cannot set a CloudWatch Logs delivery for this Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientSnsTopicPolicyException">
        /// This exception is thrown when the policy on the Amazon SNS topic is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsLogGroupArnException">
        /// This exception is thrown when the provided CloudWatch Logs log group is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsRoleArnException">
        /// This exception is thrown when the provided role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <c>PutEventSelectors</c> operation is called with
        /// a number of event selectors, advanced event selectors, or data resources that is not
        /// valid. The combination of event selectors or advanced event selectors and data resources
        /// is not valid. A trail can have up to 5 event selectors. If a trail uses advanced event
        /// selectors, a maximum of 500 total values for all conditions in all advanced event
        /// selectors is allowed. A trail is limited to 250 data resources. These data resources
        /// can be distributed across event selectors, but the overall total cannot exceed 250.
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
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <c>ReadWriteType</c>
        /// parameter with a value of <c>read-only</c> is not valid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
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
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyDisabledException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same Region, or when the KMS key associated with the Amazon
        /// SNS topic either does not exist or is not in the same Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotProvidedException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateTrail">REST API Reference for UpdateTrail Operation</seealso>
        Task<UpdateTrailResponse> UpdateTrailAsync(UpdateTrailRequest request, CancellationToken cancellationToken = default(CancellationToken));

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