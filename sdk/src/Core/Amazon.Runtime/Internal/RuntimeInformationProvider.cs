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
using System.Linq;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Provides information about the current runtime environment.
    /// </summary>
    public interface IRuntimeInformationProvider
    {
        /// <summary>
        /// Indicates whether the current application is running on Mobile.
        /// </summary>
        /// <returns>true if the current application is running on Mobile; otherwise, false.</returns>
        bool IsMobile();
    }

    /// <inheritdoc />
    public class RuntimeInformationProvider : IRuntimeInformationProvider
    {
        /// <inheritdoc/>
        /// <remarks>
        /// SDK does not do intelligent checks like checking package references or reflection to determine whether
        /// the current project is a mobile project because of performance reasons. Moving forward, when .NET 6 support is added,
        /// it should use OperatingSystem.IsAndroid <see href="https://docs.microsoft.com/en-us/dotnet/api/system.operatingsystem.isandroid"/>
        /// or OperatingSystem.IsIOS <see href="https://docs.microsoft.com/en-us/dotnet/api/system.operatingsystem.isios"/> to determine
        /// whether the current application is running on Mobile or not.
        /// </remarks>
        public bool IsMobile()
        {
            return false;
        }
    }
}