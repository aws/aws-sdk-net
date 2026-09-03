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

namespace Amazon.SSOOIDC.Internal
{
    /// <summary>
    /// This interface allows for testing to provide stubs for time consuming events like Sleep
    /// </summary>
    public interface IGetSsoTokenContext
    {
        /// <summary>
        /// Sleep for given milliseconds.
        /// </summary>
        /// <param name="ms"></param>
        void Sleep(int ms);
    }
}