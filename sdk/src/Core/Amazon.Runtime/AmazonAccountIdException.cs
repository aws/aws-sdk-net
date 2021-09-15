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

namespace Amazon.Runtime
{
    /// <summary>
    /// Base exception for AccountId error.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public class AmazonAccountIdException : AmazonClientException
    {
        /// <summary>
        /// Construct an instance of AmazonAccountIdException
        /// </summary>
        public AmazonAccountIdException()
            : base("AccountId is invalid. The AccountId length should be 12 and only contain numeric characters with no spaces or periods.")
        {

        }

        /// <summary>
        /// Construct an instance of AmazonAccountIdException
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public AmazonAccountIdException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Construct an instance of AmazonAccountIdException
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public AmazonAccountIdException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the AmazonAccountIdException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected AmazonAccountIdException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}
