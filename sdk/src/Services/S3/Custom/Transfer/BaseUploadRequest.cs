using Amazon.Runtime;
/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// The base class TransferUtility request classes.
    /// </summary>
    public abstract class BaseUploadRequest
    {
#if (BCL && !BCL45)
        private TimeSpan? timeout = null;

        /// <summary>
        /// Overrides the default request timeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The value of this property is assigned to the Timeout property of the HTTPWebRequest/HttpClient object used
        /// to send requests. Each TransferUtility's Download method may perform multiple server requests to complete the operation. 
        /// This timeout does not apply to the overall operation. 
        /// </para>
        /// <para>
        /// Please specify a timeout value only if the operation will not complete within the default intervals
        /// specified for an HttpWebRequest/HttpClient.
        /// </para>
        /// </remarks>
        /// <exception cref="System.ArgumentOutOfRangeException">The timeout specified is less than or equal to zero and is not Infinite.</exception>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        /// <seealso cref="P:System.Net.Http.HttpClient.Timeout"/>
        public TimeSpan? Timeout
        {
            get { return timeout; }
            set
            {
                ClientConfig.ValidateTimeout(value);
                this.timeout = value;
            }
        }
#endif
    }
}