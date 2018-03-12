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
    public partial class DeliveryClient : IDeliveryClient
    {
        private Logger _logger = Logger.GetLogger(typeof(DeliveryClient));

        private object _deliveryLock = new object();
        private bool _deliveryInProgress = false;

        private readonly IDeliveryPolicyFactory _policyFactory;
        private List<IDeliveryPolicy> _deliveryPolicies;

        private IEventStore _eventStore;
        private AmazonMobileAnalyticsClient _mobileAnalyticsLowLevelClient;

        private ClientContext _clientContext;
        private string _appID;
        private MobileAnalyticsManagerConfig _maConfig;
        private MobileAnalyticsManager _maManager;

        private const int MAX_ALLOWED_SELECTS = 200;

        /// <summary>
        /// Constructor of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.DeliveryClient"/> class.
        /// </summary>
        /// <param name="maConfig">Mobile Analytics Manager configuration. <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.MobileAnalyticsManagerConfig"/></param>
        /// <param name="clientContext">An instance of ClientContext. <see cref="Amazon.Runtime.Internal.ClientContext"/></param>
        /// <param name="credentials">An instance of Credentials. <see cref="Amazon.Runtime.AWSCredentials"/></param>
        /// <param name="regionEndPoint">Region endpoint. <see cref="Amazon.RegionEndpoint"/></param>
        /// <param name="maManager">Mobile Analytics Manager instance. <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.MobileAnalyticsManager"/></param>
        public DeliveryClient(MobileAnalyticsManagerConfig maConfig, ClientContext clientContext, AWSCredentials credentials, RegionEndpoint regionEndPoint, MobileAnalyticsManager maManager) :
            this(new DeliveryPolicyFactory(maConfig.AllowUseDataNetwork), maConfig, clientContext, credentials, regionEndPoint, maManager)
        {
        }

#if BCL35||UNITY
        /// <summary>
        /// Enqueues the events for delivery. The event is stored in an instance of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IEventStore"/>.
        /// </summary>
        /// <param name="eventObject">Event object.<see cref="Amazon.MobileAnalytics.Model.Event"/></param>
        public void EnqueueEventsForDelivery(Amazon.MobileAnalytics.Model.Event eventObject)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                EnqueueEventsHelper(eventObject);
            }));
        }

        /// <summary>
        /// Attempts the delivery. 
        /// Delivery will fail if any of the policies IsAllowed() returns false.
        /// The delivery are attmpted in batches of fixed size. To increase or decrease the size,
        /// you can override MaxRequestSize in MobileAnalyticsManagerConfig.<see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.MobileAnalyticsManagerConfig"/>
        /// </summary>
        public void AttemptDelivery()
        {
            lock (_deliveryLock)
            {
                if (_deliveryInProgress)
                {
                    _logger.InfoFormat("Delivery already in progress, failing new delivery");
                    return;
                }
                _deliveryInProgress = true;
            }

            //validate all the policies before attempting the delivery
            foreach (IDeliveryPolicy policy in _deliveryPolicies)
            {
                if (!policy.IsAllowed())
                {
                    _logger.InfoFormat("Policy restriction: {0}", policy.GetType().Name);
                    lock (_deliveryLock)
                    {
                        _deliveryInProgress = false;
                    }
                    return;
                }
            }

            List<JsonData> allEventList = _eventStore.GetEvents(_appID, MAX_ALLOWED_SELECTS);
            if (allEventList.Count == 0)
            {
                _logger.InfoFormat("No Events to deliver.");
                lock (_deliveryLock)
                {
                    _deliveryInProgress = false;
                }
                return;
            }

            List<string> submitEventsIdList = new List<string>();
            List<Amazon.MobileAnalytics.Model.Event> submitEventsList = new List<Amazon.MobileAnalytics.Model.Event>();
            long submitEventsLength = 0L;

            foreach (JsonData eventData in allEventList)
            {
                string eventString = (string)eventData["event"];
                submitEventsLength += eventString.Length;
                if (submitEventsLength < _maConfig.MaxRequestSize)
                {
                    try {
                        Amazon.MobileAnalytics.Model.Event _analyticsEvent = JsonMapper.ToObject<Amazon.MobileAnalytics.Model.Event>(eventString);
                        submitEventsList.Add(_analyticsEvent);
                    } catch (JsonException e) {
                        _logger.Error(e, "Could not load event from event store, discarding.");
                    }

                    submitEventsIdList.Add(eventData["id"].ToString());
                    
                }
                else
                {
                    SubmitEvents(submitEventsIdList, submitEventsList);
                    submitEventsIdList = new List<string>();
                    submitEventsList = new List<Amazon.MobileAnalytics.Model.Event>();
                    submitEventsLength = 0L;
                }
            }

            if (submitEventsLength > 0)
                SubmitEvents(submitEventsIdList, submitEventsList);
        }

        /// <summary>
        /// Submits a single batch of events to the service.
        /// </summary>
        /// <param name="rowIds">Row identifiers. The list of rowId, that is unique identifier of each event.</param>
        /// <param name="eventList">The list of events that need to be submitted.</param>
        private void SubmitEvents(List<string> rowIds, List<Amazon.MobileAnalytics.Model.Event> eventList)
        {
            PutEventsRequest putRequest = new PutEventsRequest();
            putRequest.Events = eventList;
            putRequest.ClientContext = Convert.ToBase64String(
                                        System.Text.Encoding.UTF8.GetBytes(_clientContext.ToJsonString()));
            putRequest.ClientContextEncoding = "base64";
            _logger.DebugFormat("Client Context is : {0}", _clientContext.ToJsonString());

            PutEventsResponse resp = null;

            try
            {
                resp = _mobileAnalyticsLowLevelClient.PutEvents(putRequest);
            }
            catch (AmazonMobileAnalyticsException e)
            {
                _logger.Error(e, "An AmazonMobileAnalyticsException occurred while sending Amazon Mobile Analytics request: error code is {0} ; error type is {1} ; request id is {2} ; status code is {3} ; error message is {4}", e.ErrorCode, e.ErrorType, e.RequestId, e.StatusCode, e.Message);
                // Delete events in any of the three error codes.
                if (e.ErrorCode.Equals("ValidationException", StringComparison.CurrentCultureIgnoreCase) ||
                    e.ErrorCode.Equals("SerializationException", StringComparison.CurrentCultureIgnoreCase) ||
                    e.ErrorCode.Equals("BadRequestException", StringComparison.CurrentCultureIgnoreCase))
                {
                    MobileAnalyticsErrorEventArgs eventArgs = new MobileAnalyticsErrorEventArgs(this.GetType().Name, "Amazon Mobile Analytics Service returned an error.", e, eventList);
                    _maManager.OnRaiseErrorEvent(eventArgs);

                    _logger.InfoFormat("The error code is not retriable. Delete {0} events from local storage.", rowIds.Count);
                    _eventStore.DeleteEvent(rowIds);
#if UNITY
                    if (_eventStore is FileEventStore _fileEventStore)
                        _fileEventStore.SaveDatabase();
#endif
                }
                else
                {
                    MobileAnalyticsErrorEventArgs eventArgs = new MobileAnalyticsErrorEventArgs(this.GetType().Name, "Amazon Mobile Analytics Service returned an error.", e, new List<Amazon.MobileAnalytics.Model.Event>());
                    _maManager.OnRaiseErrorEvent(eventArgs);
                }
            }
            catch (AmazonServiceException e)
            {
                _logger.Error(e, "An AmazonServiceException occurred while sending Amazon Mobile Analytics request:  error code is {0} ; error type is {1} ; request id is {2} ; status code is {3} ; error message is {4} ", e.ErrorCode, e.ErrorType, e.RequestId, e.StatusCode, e.Message);
                MobileAnalyticsErrorEventArgs eventArgs = new MobileAnalyticsErrorEventArgs(this.GetType().Name, "Amazon Web Service returned an error.", e, new List<Amazon.MobileAnalytics.Model.Event>());
                _maManager.OnRaiseErrorEvent(eventArgs);
            }
            catch (Exception e)
            {
                _logger.Error(e, "An exception occurred while sending Amazon Mobile Analytics request.");
                MobileAnalyticsErrorEventArgs eventArgs = new MobileAnalyticsErrorEventArgs(this.GetType().Name, "An exception occurred when sending request to Amazon Mobile Analytics.", e, new List<Amazon.MobileAnalytics.Model.Event>());
                _maManager.OnRaiseErrorEvent(eventArgs);
            }
            finally
            {
                if (resp != null && resp.HttpStatusCode == HttpStatusCode.Accepted)
                {
                    _logger.InfoFormat("Mobile Analytics client successfully delivered {0} events to service. Delete those events from local storage.", rowIds.Count);
                    _eventStore.DeleteEvent(rowIds);
#if UNITY
                    if (_eventStore is FileEventStore _fileEventStore)
                        _fileEventStore.SaveDatabase();
#endif
                }
                lock (_deliveryLock)
                {
                    _deliveryInProgress = false;
                }
            }

            
        }
#endif

#if PCL || BCL45
        /// <summary>
        /// Enqueues the events for delivery. The event is stored in an instance of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IEventStore"/>.
        /// </summary>
        /// <param name="eventObject">Event object.<see cref="Amazon.MobileAnalytics.Model.Event"/></param>
        public void EnqueueEventsForDelivery(Amazon.MobileAnalytics.Model.Event eventObject)
        {
            Task.Run(() =>
            {
                EnqueueEventsHelper(eventObject);
            });
        }

        /// <summary>
        /// Attempts the delivery. 
        /// Delivery will fail if any of the policies IsAllowed() returns false.
        /// The delivery are attmpted in batches of fixed size. To increase or decrease the size,
        /// you can override MaxRequestSize in MobileAnalyticsManagerConfig.<see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.MobileAnalyticsManagerConfig"/>
        /// </summary>
        public async Task AttemptDeliveryAsync()
        {
            lock (_deliveryLock)
            {
                if (_deliveryInProgress)
                {
                    _logger.InfoFormat("Delivery already in progress, failing new delivery");
                    return;
                }
                _deliveryInProgress = true;
            }

            //validate all the policies before attempting the delivery
            foreach (IDeliveryPolicy policy in _deliveryPolicies)
            {
                if (!policy.IsAllowed())
                {
                    _logger.InfoFormat("Policy restriction: {0}", policy.GetType().Name);
                    lock (_deliveryLock)
                    {
                        _deliveryInProgress = false;
                    }
                    return;
                }
            }

            List<JsonData> allEventList = _eventStore.GetEvents(_appID, MAX_ALLOWED_SELECTS);
            if (allEventList.Count == 0)
            {
                _logger.InfoFormat("No Events to deliver.");
                lock (_deliveryLock)
                {
                    _deliveryInProgress = false;
                }
                return;
            }

            List<string> submitEventsIdList = new List<string>();
            List<Amazon.MobileAnalytics.Model.Event> submitEventsList = new List<Amazon.MobileAnalytics.Model.Event>();
            long submitEventsLength = 0L;

            foreach (JsonData eventData in allEventList)
            {
                string eventString = (string)eventData["event"];
                submitEventsLength += eventString.Length;
                if (submitEventsLength < _maConfig.MaxRequestSize)
                {
                    Amazon.MobileAnalytics.Model.Event _analyticsEvent = JsonMapper.ToObject<Amazon.MobileAnalytics.Model.Event>(eventString);

                    submitEventsIdList.Add(eventData["id"].ToString());
                    submitEventsList.Add(_analyticsEvent);
                }
                else
                {
                    await SubmitEvents(submitEventsIdList, submitEventsList).ConfigureAwait(false);
                    submitEventsIdList = new List<string>();
                    submitEventsList = new List<Amazon.MobileAnalytics.Model.Event>();
                    submitEventsLength = 0L;
                }
            }

            if (submitEventsLength > 0)
                await SubmitEvents(submitEventsIdList, submitEventsList).ConfigureAwait(false);
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

            PutEventsRequest putRequest = new PutEventsRequest();
            putRequest.Events = eventList;
            putRequest.ClientContext = Convert.ToBase64String(
                                        System.Text.Encoding.UTF8.GetBytes(_clientContext.ToJsonString()));
            putRequest.ClientContextEncoding = "base64";
            _logger.DebugFormat("Client Context is : {0}", _clientContext.ToJsonString());

            PutEventsResponse resp = null;

            try
            {
                resp = await _mobileAnalyticsLowLevelClient.PutEventsAsync(putRequest).ConfigureAwait(false);
            }
            catch (AmazonMobileAnalyticsException e)
            {
                _logger.Error(e, "An AmazonMobileAnalyticsException occurred while sending Amazon Mobile Analytics request: error code is {0} ; error type is {1} ; request id is {2} ; status code is {3} ; error message is {4}", e.ErrorCode, e.ErrorType, e.RequestId, e.StatusCode, e.Message);
                // Delete events in any of the three error codes.
                if (e.StatusCode == HttpStatusCode.BadRequest &&
                     (e.ErrorCode.Equals("ValidationException", StringComparison.CurrentCultureIgnoreCase) ||
                      e.ErrorCode.Equals("SerializationException", StringComparison.CurrentCultureIgnoreCase) ||
                      e.ErrorCode.Equals("BadRequestException", StringComparison.CurrentCultureIgnoreCase)))
                {
                    MobileAnalyticsErrorEventArgs eventArgs = new MobileAnalyticsErrorEventArgs(this.GetType().Name, "Amazon Mobile Analytics Service returned an error.", e, eventList);
                    _maManager.OnRaiseErrorEvent(eventArgs); 

                    _logger.InfoFormat("The error code is not retriable. Delete {0} events from local storage.", rowIds.Count);
                    _eventStore.DeleteEvent(rowIds);
                }
                else
                {
                    MobileAnalyticsErrorEventArgs eventArgs = new MobileAnalyticsErrorEventArgs(this.GetType().Name, "Amazon Mobile Analytics Service returned an error.", e, new List<Amazon.MobileAnalytics.Model.Event>());
                    _maManager.OnRaiseErrorEvent(eventArgs);
                }
            }
            catch (AmazonServiceException e)
            {
                _logger.Error(e, "An AmazonServiceException occurred while sending Amazon Mobile Analytics request:  error code is {0} ; error type is {1} ; request id is {2} ; status code is {3} ; error message is {4} ", e.ErrorCode, e.ErrorType, e.RequestId, e.StatusCode, e.Message);
                MobileAnalyticsErrorEventArgs eventArgs = new MobileAnalyticsErrorEventArgs(this.GetType().Name, "Amazon Web Service returned an error.", e, new List<Amazon.MobileAnalytics.Model.Event>());
                _maManager.OnRaiseErrorEvent(eventArgs);
            }
            catch (Exception e)
            {
                _logger.Error(e, "An exception occurred while sending Amazon Mobile Analytics request.");
                MobileAnalyticsErrorEventArgs eventArgs = new MobileAnalyticsErrorEventArgs(this.GetType().Name, "An exception occurred when sending request to Amazon Mobile Analytics.", e, new List<Amazon.MobileAnalytics.Model.Event>());
                _maManager.OnRaiseErrorEvent(eventArgs);
            }
            finally
            {
                if (resp != null && resp.HttpStatusCode == HttpStatusCode.Accepted)
                {
                    _logger.InfoFormat("Mobile Analytics client successfully delivered {0} events to service. Delete those events from local storage.", rowIds.Count);
                    _eventStore.DeleteEvent(rowIds);
                }
                lock (_deliveryLock)
                {
                    _deliveryInProgress = false;
                }
            }
        }
#endif

        private void EnqueueEventsHelper(Amazon.MobileAnalytics.Model.Event eventObject)
        {
            string eventString = null;
            try
            {
                eventString = JsonMapper.ToJson(eventObject);
            }
            catch (Exception e)
            {
                _logger.Error(e, "An exception occurred when converting low level client event to json string.");
                List<Amazon.MobileAnalytics.Model.Event> eventList = new List<Amazon.MobileAnalytics.Model.Event>();
                eventList.Add(eventObject);
                MobileAnalyticsErrorEventArgs eventArgs = new MobileAnalyticsErrorEventArgs(this.GetType().Name, "An exception occurred when converting low level client event to json string.", e, eventList);
                _maManager.OnRaiseErrorEvent(eventArgs);
            }

            if (null != eventString)
            {
                try
                {
                    _eventStore.PutEvent(eventString, _appID);
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Event {0} was not stored.", eventObject.EventType);
                    MobileAnalyticsErrorEventArgs eventArgs = new MobileAnalyticsErrorEventArgs(this.GetType().Name, "An exception occurred when storing event into event store.", e, new List<Amazon.MobileAnalytics.Model.Event>());
                    _maManager.OnRaiseErrorEvent(eventArgs);
                }
                _logger.DebugFormat("Event {0} is queued for delivery", eventObject.EventType);
            }
        }


        #region dispose pattern implementation
        /// <summary>
        /// Dispose pattern implementation
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose pattern implementation
        /// </summary>
        /// <param name="disposing">if disposing</param>
        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                _eventStore.Dispose();
                _mobileAnalyticsLowLevelClient.Dispose();
            }
        }

        #endregion

    }
}
