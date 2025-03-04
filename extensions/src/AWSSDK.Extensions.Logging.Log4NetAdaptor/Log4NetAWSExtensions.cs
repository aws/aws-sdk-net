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
using Amazon.Runtime.Logging;

namespace Amazon.Extensions.Logging.Log4NetAdaptor
{
    /// <summary>
    /// Extension methods for adding the logging of the AWS SDK to log4net.
    /// </summary>
    public static class Log4NetAWSExtensions
    {
        /// <summary>
        /// Configure the AWS SDK for .NET to output its logs through log4net.
        /// </summary>
        /// <returns></returns>
        public static void ConfigureAWSSDKLogging()
        {
            var adaptorFactory = new AdaptorLoggerFactoryImpl();
            AdaptorLoggerFactoryRegistry.RegisterAdaptorLoggerFactory(adaptorFactory);
        }
    }
}
