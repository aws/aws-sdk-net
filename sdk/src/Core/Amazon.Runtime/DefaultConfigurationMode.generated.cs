/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */

 /*
 * Do not modify this file. This file is generated from the sdk-default-configuration.json file.
 */

namespace Amazon.Runtime
{
    /// <summary>
    /// Enumeration of the supported Default Configurations available to to <see cref="AmazonServiceClient" /> objects.
    /// </summary>
    public enum DefaultConfigurationMode
    {
        /// <summary>
        /// <p>The STANDARD mode provides the latest recommended default values that should be safe to run in most scenarios</p><p>Note that the default values vended from this mode might change as best practices may evolve. As a result, it is encouraged to perform tests when upgrading the SDK</p>
        /// </summary>
        Standard,
        /// <summary>
        /// <p>The IN_REGION mode builds on the standard mode and includes optimization tailored for applications which call AWS services from within the same AWS region</p><p>Note that the default values vended from this mode might change as best practices may evolve. As a result, it is encouraged to perform tests when upgrading the SDK</p>
        /// </summary>
        InRegion,
        /// <summary>
        /// <p>The CROSS_REGION mode builds on the standard mode and includes optimization tailored for applications which call AWS services in a different region</p><p>Note that the default values vended from this mode might change as best practices may evolve. As a result, it is encouraged to perform tests when upgrading the SDK</p>
        /// </summary>
        CrossRegion,
        /// <summary>
        /// <p>The MOBILE mode builds on the standard mode and includes optimization tailored for mobile applications</p><p>Note that the default values vended from this mode might change as best practices may evolve. As a result, it is encouraged to perform tests when upgrading the SDK</p>
        /// </summary>
        Mobile,
        /// <summary>
        /// <p>The AUTO mode is an experimental mode that builds on the standard mode. The SDK will attempt to discover the execution environment to determine the appropriate settings automatically.</p><p>Note that the auto detection is heuristics-based and does not guarantee 100% accuracy. STANDARD mode will be used if the execution environment cannot be determined. The auto detection might query <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-metadata.html">EC2 Instance Metadata service</a>, which might introduce latency. Therefore we recommend choosing an explicit defaults_mode instead if startup latency is critical to your application</p>
        /// </summary>
        Auto,
        /// <summary>
        /// <p>The LEGACY mode provides default settings that vary per SDK and were used prior to establishment of defaults_mode</p>
        /// </summary>
        Legacy
    }
}