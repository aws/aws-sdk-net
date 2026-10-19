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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
    /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
    /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
    /// quotas</a> in the <i>WAF Developer Guide</i>.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class WAFLimitsExceededException : AmazonWAFV2Exception
    {
        /// <summary>
        /// Default constructor for WAFLimitsExceededException
        /// message.
        /// </summary>
        public WAFLimitsExceededException() : base() { }

        /// <summary>
        /// Constructs a new WAFLimitsExceededException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public WAFLimitsExceededException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of WAFLimitsExceededException
        /// </summary>
        public WAFLimitsExceededException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of WAFLimitsExceededException
        /// </summary>
        public WAFLimitsExceededException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of WAFLimitsExceededException
        /// </summary>
        public WAFLimitsExceededException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of WAFLimitsExceededException
        /// </summary>
        public WAFLimitsExceededException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Source type for the exception. 
        /// </para>
        /// </summary>
        public string SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the WAFLimitsExceededException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected WAFLimitsExceededException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.SourceType = (string)info.GetValue("SourceType", typeof(string));
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
        [System.Security.SecurityCritical]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("SourceType", this.SourceType);
        }
#endif
    }
}
