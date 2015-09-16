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
        /// <summary>
        /// Constructor of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.DeliveryClient"/> class.
        /// </summary>
        /// <param name="policyFactory">An instance of IDeliveryPolicyFactory. <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IDeliveryPolicyFactory"/></param>
        /// <param name="maConfig">Mobile Analytics Manager configuration. <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.MobileAnalyticsManagerConfig"/></param>
        /// <param name="clientContext">An instance of ClientContext. <see cref="Amazon.Runtime.Internal.ClientContext"/></param>
        /// <param name="credentials">An instance of Credentials. <see cref="Amazon.Runtime.AWSCredentials"/></param>
        /// <param name="regionEndPoint">Region endpoint. <see cref="Amazon.RegionEndpoint"/></param>
        /// <param name="maManager">Mobile Analytics Manager instance. <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.MobileAnalyticsManager"/></param>
        public DeliveryClient(IDeliveryPolicyFactory policyFactory, MobileAnalyticsManagerConfig maConfig, ClientContext clientContext, AWSCredentials credentials, RegionEndpoint regionEndPoint, MobileAnalyticsManager maManager)
        {
            _policyFactory = policyFactory;
            _deliveryPolicies = new List<IDeliveryPolicy>();
            _deliveryPolicies.Add(_policyFactory.NewConnectivityPolicy());

            _clientContext = clientContext;
            _appID = clientContext.AppID;
            _maConfig = maConfig;
            _eventStore = new SQLiteEventStore(maConfig);
            _maManager = maManager;

            _mobileAnalyticsLowLevelClient = new AmazonMobileAnalyticsClient(credentials, regionEndPoint);
        }
    }
}
