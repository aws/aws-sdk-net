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

namespace Amazon.Runtime.Telemetry.Metrics
{
    /// <summary>
    /// Represents a no-op implementation of <see cref="MeterProvider"/>.
    /// This provider does not perform any metrics operations, serving as a default placeholder.
    /// The no-op meter provider ensures that calls to metrics methods do not cause null reference exceptions.
    /// </summary>
    public class NoOpMeterProvider : MeterProvider
    {
        // Implement no-op meter provider methods
    }
}