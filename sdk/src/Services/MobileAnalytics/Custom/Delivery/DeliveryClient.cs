/*
 * Copyright 2015-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Net;

using Amazon.Runtime;
using Amazon.MobileAnalytics.MobileAnalyticsManager;
using Amazon.MobileAnalytics;
using Amazon.MobileAnalytics.Model;

using ThirdParty.Json.LitJson;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Internal;

#if PCL || BCL45
using System.Threading.Tasks;
#endif

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// Delivery client periodically sends events in local persistent storage to Mobile Analytics server.
    /// Once the events is delivered successfully, those events would be deleted from local storage.
    /// </summary>
    public class DeliveryClient : IDeliveryClient
    {
        private Logger _logger = Logger.GetLogger(typeof(DeliveryClient));

        private static object _deliveryLock = new object();

        private readonly IDeliveryPolicyFactory _policyFactory;
        private List<IDeliveryPolicy> _deliveryPolicies;

        private IEventStore _eventStore;
        private AmazonMobileAnalyticsClient _mobileAnalyticsLowLevelClient;

        private ClientContext _clientContext;
        private string _appID;
        private MobileAnalyticsManagerConfig _maConfig;

        private const int MAX_ALLOWED_SELECTS = 200;

        /// <summary>
        /// Constructor of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.DeliveryClient"/> class.
        /// </summary>
        /// <param name="maConfig">Mobile Analytics Manager configuration. <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.MobileAnalyticsManagerConfig"/></param>
        /// <param name="clientContext">An instance of ClientContext. <see cref="Amazon.Runtime.Internal.ClientContext"/></param>
        /// <param name="credentials">An instance of Credentials. <see cref="Amazon.Runtime.AWSCredentials"/></param>
        /// <param name="regionEndPoint">Region end point. <see cref="Amazon.RegionEndpoint"/></param>
        public DeliveryClient(MobileAnalyticsManagerConfig maConfig, ClientContext clientContext, AWSCredentials credentials, RegionEndpoint regionEndPoint) :
            this(new DeliveryPolicyFactory(maConfig.AllowUseDataNetwork), maConfig, clientContext, credentials, regionEndPoint)
        {
        }

        /// <summary>
        /// Constructor of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.DeliveryClient"/> class.
        /// </summary>
        /// <param name="policyFactory">An instance of IDeliveryPolicyFactory. <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IDeliveryPolicyFactory"/></param>
        /// <param name="maConfig">Mobile Analytics Manager configuration. <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.MobileAnalyticsManagerConfig"/></param>
        /// <param name="clientContext">An instance of ClientContext. <see cref="Amazon.Runtime.Internal.ClientContext"/></param>
        /// <param name="credentials">An instance of Credentials. <see cref="Amazon.Runtime.AWSCredentials"/></param>
        /// <param name="regionEndPoint">Region end point. <see cref="Amazon.RegionEndpoint"/></param>
        public DeliveryClient(IDeliveryPolicyFactory policyFactory, MobileAnalyticsManagerConfig maConfig, ClientContext clientContext, AWSCredentials credentials, RegionEndpoint regionEndPoint)
        {
            _policyFactory = policyFactory;
            _deliveryPolicies = new List<IDeliveryPolicy>();
            _deliveryPolicies.Add(_policyFactory.NewConnectivityPolicy());

            _clientContext = clientContext;
            _appID = clientContext.AppID;
            _maConfig = maConfig;
            _eventStore = new SQLiteEventStore(maConfig);

#if PCL
            _mobileAnalyticsLowLevelClient = new AmazonMobileAnalyticsClient(credentials, regionEndPoint);
#elif BCL
            if (null == credentials && null == regionEndPoint)
            {
                _mobileAnalyticsLowLevelClient = new AmazonMobileAnalyticsClient();
            }
            else if (null == credentials)
            {
                _mobileAnalyticsLowLevelClient = new AmazonMobileAnalyticsClient(regionEndPoint);
            }
            else if (null == regionEndPoint)
            {
                _mobileAnalyticsLowLevelClient = new AmazonMobileAnalyticsClient(credentials);
            }
            else
            {
                _mobileAnalyticsLowLevelClient = new AmazonMobileAnalyticsClient(credentials, regionEndPoint);
            }
#endif
        }


        /// <summary>
        /// Enqueues the events for delivery. The event is stored in an instance of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IEventStore"/>.
        /// </summary>
        /// <param name="eventObject">Event object.<see cref="Amazon.MobileAnalytics.Model.Event"/></param>
        public void EnqueueEventsForDelivery(Amazon.MobileAnalytics.Model.Event eventObject)
        {
#if BCL35            
            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
#elif PCL || BCL45
            Task.Run( () =>
            {
#endif
                string eventString = JsonMapper.ToJson(eventObject);

                try
                {
                    _eventStore.PutEvent(eventString, _appID);
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Event {0} is unable to be stored.", eventObject.EventType);
                }

                _logger.DebugFormat("Event {0} is queued for delivery", eventObject.EventType);
#if BCL35
            }));
#elif PCL || BCL45
            });
#endif
        }

        /// <summary>
        /// Attempts the delivery. 
        /// Delivery will fail if any of the policies isAllowed() returns false.
        /// The delivery are attmpted in batches of fixed size. To increase or decrease the size,
        /// you can override MaxRequestSize in MobileAnalyticsManagerConfig.<see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.MobileAnalyticsManagerConfig"/>
        /// </summary>
#if BCL35        
        public void AttemptDelivery()
#elif PCL || BCL45
        public async Task AttemptDeliveryAsync()
#endif
        {
            if (_mobileAnalyticsLowLevelClient == null)
            {
                throw new InvalidOperationException("You must set Client before attempting delivery");
            }

            //validate all the policies before attempting the delivery
            foreach (IDeliveryPolicy policy in _deliveryPolicies)
            {
                if (!policy.IsAllowed())
                {
                    _logger.InfoFormat("Policy restriction: {0}", policy.GetType().Name);
                    return;
                }
            }

            List<JsonData> allEventList = _eventStore.GetEvents(_appID, MAX_ALLOWED_SELECTS);
            if (allEventList.Count == 0)
            {
                _logger.InfoFormat("No Events to deliver.");
                return;
            }

            List<string> submitEventsIdList = new List<string>();
            List<Amazon.MobileAnalytics.Model.Event> submitEventsList = new List<Amazon.MobileAnalytics.Model.Event>();
            long submitEventsLength = 0L;

            foreach (JsonData eventData in allEventList)
            {
                submitEventsLength += ((string)eventData["event"]).Length;
                if (submitEventsLength < _maConfig.MaxRequestSize)
                {
                    Amazon.MobileAnalytics.Model.Event _analyticsEvent = JsonMapper.ToObject<Amazon.MobileAnalytics.Model.Event>((string)eventData["event"]);

                    submitEventsIdList.Add(eventData["id"].ToString());
                    submitEventsList.Add(_analyticsEvent);
                }
                else
                {
#if BCL35                    
                    SubmitEvents(submitEventsIdList, submitEventsList);
#elif PCL || BCL45
                    await SubmitEvents(submitEventsIdList, submitEventsList);
#endif
                    submitEventsIdList = new List<string>();
                    submitEventsList = new List<Amazon.MobileAnalytics.Model.Event>();
                    submitEventsLength = 0L;
                }
            }

            if (submitEventsLength > 0)
#if BCL35
                SubmitEvents(submitEventsIdList, submitEventsList);
#elif PCL || BCL45
                await SubmitEvents(submitEventsIdList, submitEventsList);
#endif
        }


        /// <summary>
        /// Submits a single batch of events to the service.
        /// </summary>
        /// <param name="rowIds">Row identifiers. The list of rowId, that is unique identifier of each event.</param>
        /// <param name="eventList">The list of events that need to be submitted.</param>
#if BCL35        
        private void SubmitEvents(List<string> rowIds, List<Amazon.MobileAnalytics.Model.Event> eventList)
#elif PCL || BCL45
        private async Task SubmitEvents(List<string> rowIds, List<Amazon.MobileAnalytics.Model.Event> eventList)
#endif
        {
            if (eventList == null || eventList.Count == 0)
            {
                return;
            }

            PutEventsRequest putRequest = new PutEventsRequest();
            putRequest.Events = eventList;
            putRequest.ClientContext = Convert.ToBase64String(
                                        System.Text.Encoding.UTF8.GetBytes(_clientContext.ToJsonString()));
            putRequest.ClientContextEncoding = "base64";
            _logger.DebugFormat("Client Context is : {0}", _clientContext.ToJsonString());

            PutEventsResponse resp = null;

            try
            {
#if BCL35                
                resp = _mobileAnalyticsLowLevelClient.PutEvents(putRequest);
#elif PCL || BCL45
                resp = await _mobileAnalyticsLowLevelClient.PutEventsAsync(putRequest);
#endif
            }
            catch (Amazon.MobileAnalytics.Model.BadRequestException e)
            {
                _logger.Error(e, "Get BadRequestException from Mobile Analytics client : {0}", e.ToString());

                // Delete events in any of the three error types.
                if (e.ErrorCode.Equals("ValidationException", StringComparison.CurrentCultureIgnoreCase) ||
                     e.ErrorCode.Equals("SerializationException", StringComparison.CurrentCultureIgnoreCase) ||
                     e.ErrorCode.Equals("BadRequestException", StringComparison.CurrentCultureIgnoreCase))
                {
                    _logger.InfoFormat("Exception is not retriable. So we delete those events from local storage.");
                    _eventStore.DeleteEvent(rowIds);
                }
            }
            catch (AmazonServiceException e)
            {
                _logger.Error(e, "Get AmazonServiceException from Mobile Analytics client : ", e.ToString());
            }
            catch (AmazonClientException e)
            {
                _logger.Error(e, "Get AmazonClientException from Mobile Analytics client : ", e.ToString());
            }
            catch (Exception e)
            {
                _logger.Error(e, "Get Exception from Mobile Analytics client : ", e.ToString());
            }
            finally
            {
                if (resp != null && resp.HttpStatusCode == HttpStatusCode.Accepted)
                {
                    _logger.InfoFormat("Mobile Analytics client successfully deliver {0} events to service. Delete those events from local storage.", rowIds.Count);
                    _eventStore.DeleteEvent(rowIds);
                }
            }
        }


        /// <summary>
        /// Set custom policies to the delivery client. This will allow you to fine grain control on when an attempt should be made to deliver the events to the service.
        /// </summary>
        /// <param name="policy">An instance of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IDeliveryPolicy"/></param>
        public void AddDeliveryPolicies(IDeliveryPolicy policy)
        {
            if (policy != null)
                _deliveryPolicies.Add(policy);
        }
    }
}
