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
namespace Amazon.Runtime.Endpoints
{
    /// <summary>
    /// Base class for endpoint parameters.
    /// Used for endpoint resolution.
    /// </summary>
    public class EndpointParameters : PropertyBag
    {
        /// <summary>
        /// Returns true when <paramref name="other"/> is the same type as this instance and holds the same
        /// parameter values. The endpoint resolver uses this to decide whether an endpoint resolved earlier
        /// in the same request can be reused.
        /// </summary>
        internal bool ParametersEqual(EndpointParameters other)
        {
            return other != null && other.GetType() == GetType() && ParameterValuesEqual(other);
        }

        /// <summary>
        /// Returns true when <paramref name="other"/>, which is always the same type as this instance, holds
        /// the same parameter values. Derived classes that store parameters outside the property bag must
        /// override this to compare those values, and call the base implementation for the rest.
        /// </summary>
        /// <param name="other">The parameters to compare with.</param>
        /// <returns>True when the parameter values are equal.</returns>
        protected virtual bool ParameterValuesEqual(EndpointParameters other)
        {
            return ContentEquals(other);
        }
    }
}
