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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This exception is thrown when the <c>PutEventSelectors</c> operation is called with
    /// a number of event selectors, advanced event selectors, or data resources that is not
    /// valid. The combination of event selectors or advanced event selectors and data resources
    /// is not valid. A trail can have up to 5 event selectors. If a trail uses advanced event
    /// selectors, a maximum of 500 total values for all conditions in all advanced event
    /// selectors is allowed. A trail is limited to 250 data resources. These data resources
    /// can be distributed across event selectors, but the overall total cannot exceed 250.
    /// 
    ///  
    /// <para>
    /// You can:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify a valid number of event selectors (1 to 5) for a trail.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify a valid number of data resources (1 to 250) for an event selector. The limit
    /// of number of resources on an individual event selector is configurable up to 250.
    /// However, this upper limit is allowed only if the total number of data resources does
    /// not exceed 250 across all event selectors for a trail.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify up to 500 values for all conditions in all advanced event selectors for a
    /// trail.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify a valid value for a parameter. For example, specifying the <c>ReadWriteType</c>
    /// parameter with a value of <c>read-only</c> is not valid.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class InvalidEventSelectorsException : AmazonCloudTrailException
    {

        /// <summary>
        /// Constructs a new InvalidEventSelectorsException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public InvalidEventSelectorsException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of InvalidEventSelectorsException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public InvalidEventSelectorsException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of InvalidEventSelectorsException
        /// </summary>
        /// <param name="innerException"></param>
        public InvalidEventSelectorsException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of InvalidEventSelectorsException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InvalidEventSelectorsException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of InvalidEventSelectorsException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InvalidEventSelectorsException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the InvalidEventSelectorsException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected InvalidEventSelectorsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
        [System.Security.SecurityCritical]
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
#endif

    }
}