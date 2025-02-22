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
using Amazon.EC2.Model;
using Amazon.Runtime;
using System;

namespace Amazon.EC2
{
    public partial interface IAmazonEC2 : IAmazonService, IDisposable
	{
        /// <summary>
        /// Checks whether you have the required permissions for the action, without actually making the request.
        /// </summary>
        /// <param name="request">Request to do a dry run of.</param>
        /// <returns>Result of the dry run.</returns>
        [Obsolete("This method has been deprecated. Use DryRun property at request level instead.")]
        DryRunResponse DryRun(AmazonEC2Request request);
	}
}
