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

using System;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Utility for safely resolving configuration with consistent error handling.
    /// </summary>
    internal static class SafeConfigurationResolver
    {
        /// <summary>
        /// Safely executes a configuration resolver with consistent exception handling.
        /// </summary>
        /// <typeparam name="T">The type of configuration to resolve.</typeparam>
        /// <param name="resolver">The resolver function to execute.</param>
        /// <param name="operationName">The name of the operation for logging.</param>
        /// <param name="logger">The logger instance.</param>
        /// <returns>The resolved configuration, or null if resolution failed.</returns>
        public static T SafeResolve<T>(Func<T> resolver, string operationName, Logger logger) where T : class
        {
            try
            {
                return resolver();
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, $"Invalid argument while {operationName}");
                return null;
            }
            catch (InvalidOperationException ex)
            {
                logger.Error(ex, $"Invalid operation while {operationName}");
                return null;
            }
        }
    }
}