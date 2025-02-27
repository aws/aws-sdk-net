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

namespace Amazon.Runtime.Logging
{
    /// <summary>
    /// Registry for adding adaptors to logging frameworks like Microsoft.Extensions.Logging to the internal SDK's logging.
    /// </summary>
    public static class AdaptorLoggerFactoryRegistry
    {
        /// <summary>
        /// Register the IAdaptorLoggerFactory. The IAdaptorLoggerFactory will create loggers that
        /// output the SDK's logging to the adapted logging framework.
        /// </summary>
        /// <param name="factory"></param>
        public static void RegisterAdaptorLoggerFactory(IAdaptorLoggerFactory factory)
        {
            Amazon.Runtime.Internal.Util.Logger.RegisterAdaptorLoggerFactory(factory);
        }

        /// <summary>
        /// Deregister the IAdaptorLoggerFactory.
        /// </summary>
        /// <param name="factoryName">The name of the factory. The name of the factory comes from the Name property of the IAdaptorLoggerFactory.</param>
        public static void DeregisterAdaptorLoggerFactory(string factoryName)
        {
            Amazon.Runtime.Internal.Util.Logger.DeregisterAdaptorLoggerFactory(factoryName);
        }
    }
}
