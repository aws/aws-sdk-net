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
    /// For <c>PutInsightSelectors</c>, this exception is thrown when the formatting or syntax
    /// of the <c>InsightSelectors</c> JSON statement is not valid, or the specified <c>InsightType</c>
    /// in the <c>InsightSelectors</c> statement is not valid. Valid values for <c>InsightType</c>
    /// are <c>ApiCallRateInsight</c> and <c>ApiErrorRateInsight</c>. To enable Insights on
    /// an event data store, the destination event data store specified by the <c>InsightsDestination</c>
    /// parameter must log Insights events and the source event data store specified by the
    /// <c>EventDataStore</c> parameter must log management events.
    /// 
    ///  
    /// <para>
    /// For <c>UpdateEventDataStore</c>, this exception is thrown if Insights are enabled
    /// on the event data store and the updated advanced event selectors are not compatible
    /// with the configured <c>InsightSelectors</c>. If the <c>InsightSelectors</c> includes
    /// an <c>InsightType</c> of <c>ApiCallRateInsight</c>, the source event data store must
    /// log <c>write</c> management events. If the <c>InsightSelectors</c> includes an <c>InsightType</c>
    /// of <c>ApiErrorRateInsight</c>, the source event data store must log management events.
    /// </para>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class InvalidInsightSelectorsException : AmazonCloudTrailException
    {

        /// <summary>
        /// Constructs a new InvalidInsightSelectorsException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public InvalidInsightSelectorsException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of InvalidInsightSelectorsException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public InvalidInsightSelectorsException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of InvalidInsightSelectorsException
        /// </summary>
        /// <param name="innerException"></param>
        public InvalidInsightSelectorsException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of InvalidInsightSelectorsException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InvalidInsightSelectorsException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of InvalidInsightSelectorsException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InvalidInsightSelectorsException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the InvalidInsightSelectorsException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected InvalidInsightSelectorsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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