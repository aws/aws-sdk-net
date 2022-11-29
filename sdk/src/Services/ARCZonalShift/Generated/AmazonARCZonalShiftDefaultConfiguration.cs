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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Amazon.Runtime;

namespace Amazon.ARCZonalShift
{
    /// <summary>
    /// Configuration for accessing Amazon ARCZonalShift service
    /// </summary>
    public static class AmazonARCZonalShiftDefaultConfiguration
    {
        /// <summary>
        /// Collection of all <see cref="DefaultConfiguration"/>s supported by
        /// ARCZonalShift
        /// </summary>
        public static ReadOnlyCollection<IDefaultConfiguration> GetAllConfigurations()
        {
            return new ReadOnlyCollection<IDefaultConfiguration>(new List<IDefaultConfiguration>
            {
                Standard,
                InRegion,
                CrossRegion,
                Mobile,
                Auto,
                Legacy
            });
        }

        /// <summary>
        /// <p>The STANDARD mode provides the latest recommended default values that should be safe to run in most scenarios</p><p>Note that the default values vended from this mode might change as best practices may evolve. As a result, it is encouraged to perform tests when upgrading the SDK</p>
        /// </summary>
        public static IDefaultConfiguration Standard {get;} = new DefaultConfiguration
        {
            Name = DefaultConfigurationMode.Standard,
            RetryMode = RequestRetryMode.Standard,
            StsRegionalEndpoints = StsRegionalEndpointsValue.Regional,
            S3UsEast1RegionalEndpoint = S3UsEast1RegionalEndpointValue.Regional,
            // 0:00:03.1
            ConnectTimeout = TimeSpan.FromMilliseconds(3100L),
            // 0:00:03.1
            TlsNegotiationTimeout = TimeSpan.FromMilliseconds(3100L),
            TimeToFirstByteTimeout = null,
            HttpRequestTimeout = null
        };
        /// <summary>
        /// <p>The IN_REGION mode builds on the standard mode and includes optimization tailored for applications which call AWS services from within the same AWS region</p><p>Note that the default values vended from this mode might change as best practices may evolve. As a result, it is encouraged to perform tests when upgrading the SDK</p>
        /// </summary>
        public static IDefaultConfiguration InRegion {get;} = new DefaultConfiguration
        {
            Name = DefaultConfigurationMode.InRegion,
            RetryMode = RequestRetryMode.Standard,
            StsRegionalEndpoints = StsRegionalEndpointsValue.Regional,
            S3UsEast1RegionalEndpoint = S3UsEast1RegionalEndpointValue.Regional,
            // 0:00:01.1
            ConnectTimeout = TimeSpan.FromMilliseconds(1100L),
            // 0:00:01.1
            TlsNegotiationTimeout = TimeSpan.FromMilliseconds(1100L),
            TimeToFirstByteTimeout = null,
            HttpRequestTimeout = null
        };
        /// <summary>
        /// <p>The CROSS_REGION mode builds on the standard mode and includes optimization tailored for applications which call AWS services in a different region</p><p>Note that the default values vended from this mode might change as best practices may evolve. As a result, it is encouraged to perform tests when upgrading the SDK</p>
        /// </summary>
        public static IDefaultConfiguration CrossRegion {get;} = new DefaultConfiguration
        {
            Name = DefaultConfigurationMode.CrossRegion,
            RetryMode = RequestRetryMode.Standard,
            StsRegionalEndpoints = StsRegionalEndpointsValue.Regional,
            S3UsEast1RegionalEndpoint = S3UsEast1RegionalEndpointValue.Regional,
            // 0:00:03.1
            ConnectTimeout = TimeSpan.FromMilliseconds(3100L),
            // 0:00:03.1
            TlsNegotiationTimeout = TimeSpan.FromMilliseconds(3100L),
            TimeToFirstByteTimeout = null,
            HttpRequestTimeout = null
        };
        /// <summary>
        /// <p>The MOBILE mode builds on the standard mode and includes optimization tailored for mobile applications</p><p>Note that the default values vended from this mode might change as best practices may evolve. As a result, it is encouraged to perform tests when upgrading the SDK</p>
        /// </summary>
        public static IDefaultConfiguration Mobile {get;} = new DefaultConfiguration
        {
            Name = DefaultConfigurationMode.Mobile,
            RetryMode = RequestRetryMode.Standard,
            StsRegionalEndpoints = StsRegionalEndpointsValue.Regional,
            S3UsEast1RegionalEndpoint = S3UsEast1RegionalEndpointValue.Regional,
            // 0:00:30
            ConnectTimeout = TimeSpan.FromMilliseconds(30000L),
            // 0:00:30
            TlsNegotiationTimeout = TimeSpan.FromMilliseconds(30000L),
            TimeToFirstByteTimeout = null,
            HttpRequestTimeout = null
        };
        /// <summary>
        /// <p>The AUTO mode is an experimental mode that builds on the standard mode. The SDK will attempt to discover the execution environment to determine the appropriate settings automatically.</p><p>Note that the auto detection is heuristics-based and does not guarantee 100% accuracy. STANDARD mode will be used if the execution environment cannot be determined. The auto detection might query <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-metadata.html">EC2 Instance Metadata service</a>, which might introduce latency. Therefore we recommend choosing an explicit defaults_mode instead if startup latency is critical to your application</p>
        /// </summary>
        public static IDefaultConfiguration Auto {get;} = new DefaultConfiguration
        {
            Name = DefaultConfigurationMode.Auto,
            RetryMode = RequestRetryMode.Standard,
            StsRegionalEndpoints = StsRegionalEndpointsValue.Regional,
            S3UsEast1RegionalEndpoint = S3UsEast1RegionalEndpointValue.Regional,
            // 0:00:01.1
            ConnectTimeout = TimeSpan.FromMilliseconds(1100L),
            // 0:00:01.1
            TlsNegotiationTimeout = TimeSpan.FromMilliseconds(1100L),
            TimeToFirstByteTimeout = null,
            HttpRequestTimeout = null
        };
        /// <summary>
        /// <p>The LEGACY mode provides default settings that vary per SDK and were used prior to establishment of defaults_mode</p>
        /// </summary>
        public static IDefaultConfiguration Legacy {get;} = new DefaultConfiguration
        {
            Name = DefaultConfigurationMode.Legacy,
            RetryMode = RequestRetryMode.Legacy,
            StsRegionalEndpoints = StsRegionalEndpointsValue.Legacy,
            S3UsEast1RegionalEndpoint = S3UsEast1RegionalEndpointValue.Legacy,
            ConnectTimeout = null,
            TlsNegotiationTimeout = null,
            TimeToFirstByteTimeout = null,
            HttpRequestTimeout = null
        };
    }
}