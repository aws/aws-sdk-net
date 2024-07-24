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

namespace Amazon.Runtime.Telemetry.Tracing
{
    /// <summary>
    /// Abstract class representing a provider for creating tracer instances.
    /// Tracer providers are used to create tracers which record tracing data.
    /// </summary>
    public abstract class TracerProvider
    {
        /// <summary>
        /// Creates a new <see cref="Tracer"/> instance for a given scope.
        /// Tracers are used as an entry point for creating spans.
        /// </summary>
        /// <param name="scope">The name of the instrumentation scope that uniquely identifies the tracer.</param>
        /// <returns>A <see cref="Tracer"/> instance for the specified scope.</returns>
        public abstract Tracer GetTracer(string scope);
    }
}