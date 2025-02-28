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
using Amazon.Extensions.Logging.ILoggerAdaptor;

namespace Microsoft.Extensions.Logging
{
    /// <summary>
    /// Extension methods for adding the logging of the AWS SDK into ILogger from Microsoft.Extensions.Logging.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Configure the AWS SDK for .NET to output its logs through Microsoft.Extensions.Logging.
        /// </summary>
        /// <param name="loggerFactory"></param>
        /// <returns></returns>
        public static void ConfigureAWSSDKLogging(this ILoggerFactory loggerFactory)
        {
            var adaptorFactory = new AdaptorLoggerFactoryImpl(loggerFactory);
            Amazon.Runtime.Logging.AdaptorLoggerFactoryRegistry.RegisterAdaptorLoggerFactory(adaptorFactory);
        }
    }
}
