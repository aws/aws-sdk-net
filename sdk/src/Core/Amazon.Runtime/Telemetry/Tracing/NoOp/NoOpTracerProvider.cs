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

namespace Amazon.Runtime.Telemetry.Tracing.NoOp
{
    /// <summary>
    /// A no-op implementation of <see cref="TracerProvider"/>.
    /// This provider does not perform any tracing operations, serving as a default placeholder.
    /// </summary>
    internal class NoOpTracerProvider : TracerProvider
    {
        /// <summary>
        /// Creates a no-op <see cref="Tracer"/> instance for a given scope.
        /// This tracer does not perform any operations and serves as a placeholder.
        /// </summary>
        /// <param name="scope">The name of the instrumentation scope that uniquely identifies the tracer.</param>
        /// <returns>A no-op <see cref="Tracer"/> instance.</returns>
        public override Tracer GetTracer(string scope)
        {
            return new NoOpTracer();
        }
    }
}