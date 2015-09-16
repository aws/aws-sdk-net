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

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System;
using Amazon.Runtime.Internal.Util;

#if PCL || BCL45
using System.Threading.Tasks;
#endif

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// Amazon Mobile Analytics background runner.
    /// Background runner periodically calls delivery client to send events to server.
    /// </summary>
    public partial class BackgroundRunner
    {
        private Logger _logger = Logger.GetLogger(typeof(BackgroundRunner));
        private object _lock = new object();

        // Background thread wait time. Thread will sleep for the interval mention. Value is in Seconds.
        // Default 60 seconds.
        private const int BackgroundSubmissionWaitTime = 60;
    }
}

