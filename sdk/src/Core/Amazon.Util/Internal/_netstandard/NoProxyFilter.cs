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
    /// This is a stub implementation because in .NET Core we rely on the .NET runtime to evaluate the no_proxy environment variable.
    /// </summary>
    public class NoProxyFilter
    {
        public static readonly NoProxyFilter Instance = new NoProxyFilter();

        public NoProxyFilter() 
        {
        }

        /// <summary>
        /// This is a stub method because in .NET Core we rely on the .NET runtime to evaluate the no_proxy environment variable.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public bool Match(Uri uri)
        {
            return false;
        }
    }
}