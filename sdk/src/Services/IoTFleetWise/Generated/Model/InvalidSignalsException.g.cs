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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// The request couldn't be completed because it contains signals that aren't valid.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class InvalidSignalsException : AmazonIoTFleetWiseException
    {
        /// <summary>
        /// Default constructor for InvalidSignalsException
        /// message.
        /// </summary>
        public InvalidSignalsException() : base() { }

        /// <summary>
        /// Constructs a new InvalidSignalsException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public InvalidSignalsException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of InvalidSignalsException
        /// </summary>
        public InvalidSignalsException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of InvalidSignalsException
        /// </summary>
        public InvalidSignalsException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of InvalidSignalsException
        /// </summary>
        public InvalidSignalsException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of InvalidSignalsException
        /// </summary>
        public InvalidSignalsException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property InvalidSignals. 
        /// <para>
        /// The signals which caused the exception.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InvalidSignal> InvalidSignals { get; set; } = AWSConfigs.InitializeCollections ? new List<InvalidSignal>() : null;

        /// <summary>
        /// Checks to see if the InvalidSignals property is set.
        /// </summary>
        internal bool IsSetInvalidSignals() => this.InvalidSignals != null && (this.InvalidSignals.Count > 0 || !AWSConfigs.InitializeCollections);

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the InvalidSignalsException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected InvalidSignalsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.InvalidSignals = (List<InvalidSignal>)info.GetValue("InvalidSignals", typeof(List<InvalidSignal>));
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
            info.AddValue("InvalidSignals", this.InvalidSignals);
        }
#endif
    }
}
