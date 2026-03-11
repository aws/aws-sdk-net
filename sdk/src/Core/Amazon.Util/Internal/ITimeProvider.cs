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

namespace Amazon.Util.Internal
{
    /// <summary>
    /// Interface that can be used to mock the current (corrected) UTC time for testing purposes.
    /// <para />
    /// The default implementation will use the value from <see cref="AWSSDKUtils"/> that takes
    /// any manual clock correction into account.
    /// </summary>
    public interface ITimeProvider
    {
        public DateTime CorrectedUtcNow { get; }
    }

    /// <summary>
    /// Default implementation of <see cref="ITimeProvider" /> using <see cref="AWSSDKUtils.CorrectedUtcNow"/>.
    /// </summary>
    public sealed class DefaultTimeProvider : ITimeProvider
    {
        public static readonly DefaultTimeProvider Instance = new();
        
        private DefaultTimeProvider() { }

        public DateTime CorrectedUtcNow => AWSSDKUtils.CorrectedUtcNow;
    }
}
