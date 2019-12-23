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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AWSHealth.Model;

namespace Amazon.AWSHealth
{
    /// <summary>
    /// Interface for accessing AWSHealth
    ///
    /// AWS Health 
    /// <para>
    /// The AWS Health API provides programmatic access to the AWS Health information that
    /// is presented in the <a href="https://phd.aws.amazon.com/phd/home#/">AWS Personal Health
    /// Dashboard</a>. You can get information about events that affect your AWS resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeEvents</a>: Summary information about events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeEventDetails</a>: Detailed information about one or more events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeAffectedEntities</a>: Information about AWS resources that are affected
    /// by one or more events.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// In addition, these operations provide information about event types and summary counts
    /// of events or affected entities:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeEventTypes</a>: Information about the kinds of events that AWS Health
    /// tracks.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeEventAggregates</a>: A count of the number of events that meet specified
    /// criteria.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeEntityAggregates</a>: A count of the number of affected entities that
    /// meet specified criteria.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// AWS Health integrates with AWS Organizations to provide a centralized view of AWS
    /// Health events across all accounts in your organization.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeEventsForOrganization</a>: Summary information about events across the
    /// organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeAffectedAccountsForOrganization</a>: List of accounts in your organization
    /// impacted by an event.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeEventDetailsForOrganization</a>: Detailed information about events in
    /// your organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeAffectedEntitiesForOrganization</a>: Information about AWS resources in
    /// your organization that are affected by events.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can use the following operations to enable or disable AWS Health from working
    /// with AWS Organizations.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>EnableHealthServiceAccessForOrganization</a>: Enables AWS Health to work with
    /// AWS Organizations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisableHealthServiceAccessForOrganization</a>: Disables AWS Health from working
    /// with AWS Organizations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeHealthServiceStatusForOrganization</a>: Status information about enabling
    /// or disabling AWS Health from working with AWS Organizations.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The Health API requires a Business or Enterprise support plan from <a href="http://aws.amazon.com/premiumsupport/">AWS
    /// Support</a>. Calling the Health API from an account that does not have a Business
    /// or Enterprise support plan causes a <code>SubscriptionRequiredException</code>.
    /// </para>
    ///  
    /// <para>
    /// For authentication of requests, AWS Health uses the <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a>.
    /// </para>
    ///  
    /// <para>
    /// See the <a href="https://docs.aws.amazon.com/health/latest/ug/what-is-aws-health.html">AWS
    /// Health User Guide</a> for information about how to use the API.
    /// </para>
    ///  
    /// <para>
    ///  <b>Service Endpoint</b> 
    /// </para>
    ///  
    /// <para>
    /// The HTTP endpoint for the AWS Health API is:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// https://health.us-east-1.amazonaws.com 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonAWSHealth : IAmazonService, IDisposable
    {

        
        #region  DescribeAffectedAccountsForOrganization


        /// <summary>
        /// Returns a list of accounts in the organization from AWS Organizations that are affected
        /// by the provided event.
        /// 
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable AWS Health to work with
        /// AWS Organizations. To do this, call the <a>EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedAccountsForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeAffectedAccountsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedAccountsForOrganization">REST API Reference for DescribeAffectedAccountsForOrganization Operation</seealso>
        DescribeAffectedAccountsForOrganizationResponse DescribeAffectedAccountsForOrganization(DescribeAffectedAccountsForOrganizationRequest request);



        /// <summary>
        /// Returns a list of accounts in the organization from AWS Organizations that are affected
        /// by the provided event.
        /// 
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable AWS Health to work with
        /// AWS Organizations. To do this, call the <a>EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedAccountsForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAffectedAccountsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedAccountsForOrganization">REST API Reference for DescribeAffectedAccountsForOrganization Operation</seealso>
        Task<DescribeAffectedAccountsForOrganizationResponse> DescribeAffectedAccountsForOrganizationAsync(DescribeAffectedAccountsForOrganizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAffectedEntities


        /// <summary>
        /// Returns a list of entities that have been affected by the specified events, based
        /// on the specified filter criteria. Entities can refer to individual customer resources,
        /// groups of customer resources, or any other construct, depending on the AWS service.
        /// Events that have impact beyond that of the affected entities, or where the extent
        /// of impact is unknown, include at least one entity indicating this.
        /// 
        ///  
        /// <para>
        /// At least one event ARN is required. Results are sorted by the <code>lastUpdatedTime</code>
        /// of the entity, starting with the most recent.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedEntities service method.</param>
        /// 
        /// <returns>The response from the DescribeAffectedEntities service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntities">REST API Reference for DescribeAffectedEntities Operation</seealso>
        DescribeAffectedEntitiesResponse DescribeAffectedEntities(DescribeAffectedEntitiesRequest request);



        /// <summary>
        /// Returns a list of entities that have been affected by the specified events, based
        /// on the specified filter criteria. Entities can refer to individual customer resources,
        /// groups of customer resources, or any other construct, depending on the AWS service.
        /// Events that have impact beyond that of the affected entities, or where the extent
        /// of impact is unknown, include at least one entity indicating this.
        /// 
        ///  
        /// <para>
        /// At least one event ARN is required. Results are sorted by the <code>lastUpdatedTime</code>
        /// of the entity, starting with the most recent.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAffectedEntities service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntities">REST API Reference for DescribeAffectedEntities Operation</seealso>
        Task<DescribeAffectedEntitiesResponse> DescribeAffectedEntitiesAsync(DescribeAffectedEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAffectedEntitiesForOrganization


        /// <summary>
        /// Returns a list of entities that have been affected by one or more events for one or
        /// more accounts in your organization in AWS Organizations, based on the filter criteria.
        /// Entities can refer to individual customer resources, groups of customer resources,
        /// or any other construct, depending on the AWS service.
        /// 
        ///  
        /// <para>
        /// At least one event ARN and account ID are required. Results are sorted by the <code>lastUpdatedTime</code>
        /// of the entity, starting with the most recent.
        /// </para>
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable AWS Health to work with
        /// AWS Organizations. To do this, call the <a>EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's master account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedEntitiesForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeAffectedEntitiesForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntitiesForOrganization">REST API Reference for DescribeAffectedEntitiesForOrganization Operation</seealso>
        DescribeAffectedEntitiesForOrganizationResponse DescribeAffectedEntitiesForOrganization(DescribeAffectedEntitiesForOrganizationRequest request);



        /// <summary>
        /// Returns a list of entities that have been affected by one or more events for one or
        /// more accounts in your organization in AWS Organizations, based on the filter criteria.
        /// Entities can refer to individual customer resources, groups of customer resources,
        /// or any other construct, depending on the AWS service.
        /// 
        ///  
        /// <para>
        /// At least one event ARN and account ID are required. Results are sorted by the <code>lastUpdatedTime</code>
        /// of the entity, starting with the most recent.
        /// </para>
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable AWS Health to work with
        /// AWS Organizations. To do this, call the <a>EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's master account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedEntitiesForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAffectedEntitiesForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntitiesForOrganization">REST API Reference for DescribeAffectedEntitiesForOrganization Operation</seealso>
        Task<DescribeAffectedEntitiesForOrganizationResponse> DescribeAffectedEntitiesForOrganizationAsync(DescribeAffectedEntitiesForOrganizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEntityAggregates


        /// <summary>
        /// Returns the number of entities that are affected by each of the specified events.
        /// If no events are specified, the counts of all affected entities are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntityAggregates service method.</param>
        /// 
        /// <returns>The response from the DescribeEntityAggregates service method, as returned by AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEntityAggregates">REST API Reference for DescribeEntityAggregates Operation</seealso>
        DescribeEntityAggregatesResponse DescribeEntityAggregates(DescribeEntityAggregatesRequest request);



        /// <summary>
        /// Returns the number of entities that are affected by each of the specified events.
        /// If no events are specified, the counts of all affected entities are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntityAggregates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEntityAggregates service method, as returned by AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEntityAggregates">REST API Reference for DescribeEntityAggregates Operation</seealso>
        Task<DescribeEntityAggregatesResponse> DescribeEntityAggregatesAsync(DescribeEntityAggregatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventAggregates


        /// <summary>
        /// Returns the number of events of each event type (issue, scheduled change, and account
        /// notification). If no filter is specified, the counts of all events in each category
        /// are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventAggregates service method.</param>
        /// 
        /// <returns>The response from the DescribeEventAggregates service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventAggregates">REST API Reference for DescribeEventAggregates Operation</seealso>
        DescribeEventAggregatesResponse DescribeEventAggregates(DescribeEventAggregatesRequest request);



        /// <summary>
        /// Returns the number of events of each event type (issue, scheduled change, and account
        /// notification). If no filter is specified, the counts of all events in each category
        /// are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventAggregates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventAggregates service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventAggregates">REST API Reference for DescribeEventAggregates Operation</seealso>
        Task<DescribeEventAggregatesResponse> DescribeEventAggregatesAsync(DescribeEventAggregatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventDetails


        /// <summary>
        /// Returns detailed information about one or more specified events. Information includes
        /// standard event data (region, service, and so on, as returned by <a>DescribeEvents</a>),
        /// a detailed event description, and possible additional metadata that depends upon the
        /// nature of the event. Affected entities are not included; to retrieve those, use the
        /// <a>DescribeAffectedEntities</a> operation.
        /// 
        ///  
        /// <para>
        /// If a specified event cannot be retrieved, an error message is returned for that event.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventDetails service method.</param>
        /// 
        /// <returns>The response from the DescribeEventDetails service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetails">REST API Reference for DescribeEventDetails Operation</seealso>
        DescribeEventDetailsResponse DescribeEventDetails(DescribeEventDetailsRequest request);



        /// <summary>
        /// Returns detailed information about one or more specified events. Information includes
        /// standard event data (region, service, and so on, as returned by <a>DescribeEvents</a>),
        /// a detailed event description, and possible additional metadata that depends upon the
        /// nature of the event. Affected entities are not included; to retrieve those, use the
        /// <a>DescribeAffectedEntities</a> operation.
        /// 
        ///  
        /// <para>
        /// If a specified event cannot be retrieved, an error message is returned for that event.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventDetails service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetails">REST API Reference for DescribeEventDetails Operation</seealso>
        Task<DescribeEventDetailsResponse> DescribeEventDetailsAsync(DescribeEventDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventDetailsForOrganization


        /// <summary>
        /// Returns detailed information about one or more specified events for one or more accounts
        /// in your organization. Information includes standard event data (Region, service, and
        /// so on, as returned by <a>DescribeEventsForOrganization</a>, a detailed event description,
        /// and possible additional metadata that depends upon the nature of the event. Affected
        /// entities are not included; to retrieve those, use the <a>DescribeAffectedEntitiesForOrganization</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable AWS Health to work with
        /// AWS Organizations. To do this, call the <a>EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventDetailsForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeEventDetailsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetailsForOrganization">REST API Reference for DescribeEventDetailsForOrganization Operation</seealso>
        DescribeEventDetailsForOrganizationResponse DescribeEventDetailsForOrganization(DescribeEventDetailsForOrganizationRequest request);



        /// <summary>
        /// Returns detailed information about one or more specified events for one or more accounts
        /// in your organization. Information includes standard event data (Region, service, and
        /// so on, as returned by <a>DescribeEventsForOrganization</a>, a detailed event description,
        /// and possible additional metadata that depends upon the nature of the event. Affected
        /// entities are not included; to retrieve those, use the <a>DescribeAffectedEntitiesForOrganization</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable AWS Health to work with
        /// AWS Organizations. To do this, call the <a>EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventDetailsForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventDetailsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetailsForOrganization">REST API Reference for DescribeEventDetailsForOrganization Operation</seealso>
        Task<DescribeEventDetailsForOrganizationResponse> DescribeEventDetailsForOrganizationAsync(DescribeEventDetailsForOrganizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Returns information about events that meet the specified filter criteria. Events are
        /// returned in a summary form and do not include the detailed description, any additional
        /// metadata that depends on the event type, or any affected resources. To retrieve that
        /// information, use the <a>DescribeEventDetails</a> and <a>DescribeAffectedEntities</a>
        /// operations.
        /// 
        ///  
        /// <para>
        /// If no filter criteria are specified, all events are returned. Results are sorted by
        /// <code>lastModifiedTime</code>, starting with the most recent.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);



        /// <summary>
        /// Returns information about events that meet the specified filter criteria. Events are
        /// returned in a summary form and do not include the detailed description, any additional
        /// metadata that depends on the event type, or any affected resources. To retrieve that
        /// information, use the <a>DescribeEventDetails</a> and <a>DescribeAffectedEntities</a>
        /// operations.
        /// 
        ///  
        /// <para>
        /// If no filter criteria are specified, all events are returned. Results are sorted by
        /// <code>lastModifiedTime</code>, starting with the most recent.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventsForOrganization


        /// <summary>
        /// Returns information about events across your organization in AWS Organizations, meeting
        /// the specified filter criteria. Events are returned in a summary form and do not include
        /// the accounts impacted, detailed description, any additional metadata that depends
        /// on the event type, or any affected resources. To retrieve that information, use the
        /// <a>DescribeAffectedAccountsForOrganization</a>, <a>DescribeEventDetailsForOrganization</a>,
        /// and <a>DescribeAffectedEntitiesForOrganization</a> operations.
        /// 
        ///  
        /// <para>
        /// If no filter criteria are specified, all events across your organization are returned.
        /// Results are sorted by <code>lastModifiedTime</code>, starting with the most recent.
        /// </para>
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable Health to work with AWS
        /// Organizations. To do this, call the <a>EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventsForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeEventsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventsForOrganization">REST API Reference for DescribeEventsForOrganization Operation</seealso>
        DescribeEventsForOrganizationResponse DescribeEventsForOrganization(DescribeEventsForOrganizationRequest request);



        /// <summary>
        /// Returns information about events across your organization in AWS Organizations, meeting
        /// the specified filter criteria. Events are returned in a summary form and do not include
        /// the accounts impacted, detailed description, any additional metadata that depends
        /// on the event type, or any affected resources. To retrieve that information, use the
        /// <a>DescribeAffectedAccountsForOrganization</a>, <a>DescribeEventDetailsForOrganization</a>,
        /// and <a>DescribeAffectedEntitiesForOrganization</a> operations.
        /// 
        ///  
        /// <para>
        /// If no filter criteria are specified, all events across your organization are returned.
        /// Results are sorted by <code>lastModifiedTime</code>, starting with the most recent.
        /// </para>
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable Health to work with AWS
        /// Organizations. To do this, call the <a>EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventsForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventsForOrganization">REST API Reference for DescribeEventsForOrganization Operation</seealso>
        Task<DescribeEventsForOrganizationResponse> DescribeEventsForOrganizationAsync(DescribeEventsForOrganizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventTypes


        /// <summary>
        /// Returns the event types that meet the specified filter criteria. If no filter criteria
        /// are specified, all event types are returned, in no particular order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeEventTypes service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventTypes">REST API Reference for DescribeEventTypes Operation</seealso>
        DescribeEventTypesResponse DescribeEventTypes(DescribeEventTypesRequest request);



        /// <summary>
        /// Returns the event types that meet the specified filter criteria. If no filter criteria
        /// are specified, all event types are returned, in no particular order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventTypes service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventTypes">REST API Reference for DescribeEventTypes Operation</seealso>
        Task<DescribeEventTypesResponse> DescribeEventTypesAsync(DescribeEventTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeHealthServiceStatusForOrganization


        /// <summary>
        /// This operation provides status information on enabling or disabling AWS Health to
        /// work with your organization. To call this operation, you must sign in as an IAM user,
        /// assume an IAM role, or sign in as the root user (not recommended) in the organization's
        /// master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHealthServiceStatusForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeHealthServiceStatusForOrganization service method, as returned by AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeHealthServiceStatusForOrganization">REST API Reference for DescribeHealthServiceStatusForOrganization Operation</seealso>
        DescribeHealthServiceStatusForOrganizationResponse DescribeHealthServiceStatusForOrganization(DescribeHealthServiceStatusForOrganizationRequest request);



        /// <summary>
        /// This operation provides status information on enabling or disabling AWS Health to
        /// work with your organization. To call this operation, you must sign in as an IAM user,
        /// assume an IAM role, or sign in as the root user (not recommended) in the organization's
        /// master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHealthServiceStatusForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHealthServiceStatusForOrganization service method, as returned by AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeHealthServiceStatusForOrganization">REST API Reference for DescribeHealthServiceStatusForOrganization Operation</seealso>
        Task<DescribeHealthServiceStatusForOrganizationResponse> DescribeHealthServiceStatusForOrganizationAsync(DescribeHealthServiceStatusForOrganizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableHealthServiceAccessForOrganization


        /// <summary>
        /// Calling this operation disables Health from working with AWS Organizations. This does
        /// not remove the Service Linked Role (SLR) from the the master account in your organization.
        /// Use the IAM console, API, or AWS CLI to remove the SLR if desired. To call this operation,
        /// you must sign in as an IAM user, assume an IAM role, or sign in as the root user (not
        /// recommended) in the organization's master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableHealthServiceAccessForOrganization service method.</param>
        /// 
        /// <returns>The response from the DisableHealthServiceAccessForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.ConcurrentModificationException">
        /// <a>EnableHealthServiceAccessForOrganization</a> is already in progress. Wait for
        /// the action to complete before trying again. To get the current status, use the <a>DescribeHealthServiceStatusForOrganization</a>
        /// operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DisableHealthServiceAccessForOrganization">REST API Reference for DisableHealthServiceAccessForOrganization Operation</seealso>
        DisableHealthServiceAccessForOrganizationResponse DisableHealthServiceAccessForOrganization(DisableHealthServiceAccessForOrganizationRequest request);



        /// <summary>
        /// Calling this operation disables Health from working with AWS Organizations. This does
        /// not remove the Service Linked Role (SLR) from the the master account in your organization.
        /// Use the IAM console, API, or AWS CLI to remove the SLR if desired. To call this operation,
        /// you must sign in as an IAM user, assume an IAM role, or sign in as the root user (not
        /// recommended) in the organization's master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableHealthServiceAccessForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableHealthServiceAccessForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.ConcurrentModificationException">
        /// <a>EnableHealthServiceAccessForOrganization</a> is already in progress. Wait for
        /// the action to complete before trying again. To get the current status, use the <a>DescribeHealthServiceStatusForOrganization</a>
        /// operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DisableHealthServiceAccessForOrganization">REST API Reference for DisableHealthServiceAccessForOrganization Operation</seealso>
        Task<DisableHealthServiceAccessForOrganizationResponse> DisableHealthServiceAccessForOrganizationAsync(DisableHealthServiceAccessForOrganizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableHealthServiceAccessForOrganization


        /// <summary>
        /// Calling this operation enables AWS Health to work with AWS Organizations. This applies
        /// a Service Linked Role (SLR) to the master account in the organization. To learn more
        /// about the steps in this process, visit enabling service access for AWS Health in AWS
        /// Organizations. To call this operation, you must sign in as an IAM user, assume an
        /// IAM role, or sign in as the root user (not recommended) in the organization's master
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableHealthServiceAccessForOrganization service method.</param>
        /// 
        /// <returns>The response from the EnableHealthServiceAccessForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.ConcurrentModificationException">
        /// <a>EnableHealthServiceAccessForOrganization</a> is already in progress. Wait for
        /// the action to complete before trying again. To get the current status, use the <a>DescribeHealthServiceStatusForOrganization</a>
        /// operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/EnableHealthServiceAccessForOrganization">REST API Reference for EnableHealthServiceAccessForOrganization Operation</seealso>
        EnableHealthServiceAccessForOrganizationResponse EnableHealthServiceAccessForOrganization(EnableHealthServiceAccessForOrganizationRequest request);



        /// <summary>
        /// Calling this operation enables AWS Health to work with AWS Organizations. This applies
        /// a Service Linked Role (SLR) to the master account in the organization. To learn more
        /// about the steps in this process, visit enabling service access for AWS Health in AWS
        /// Organizations. To call this operation, you must sign in as an IAM user, assume an
        /// IAM role, or sign in as the root user (not recommended) in the organization's master
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableHealthServiceAccessForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableHealthServiceAccessForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.ConcurrentModificationException">
        /// <a>EnableHealthServiceAccessForOrganization</a> is already in progress. Wait for
        /// the action to complete before trying again. To get the current status, use the <a>DescribeHealthServiceStatusForOrganization</a>
        /// operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/EnableHealthServiceAccessForOrganization">REST API Reference for EnableHealthServiceAccessForOrganization Operation</seealso>
        Task<EnableHealthServiceAccessForOrganizationResponse> EnableHealthServiceAccessForOrganizationAsync(EnableHealthServiceAccessForOrganizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}