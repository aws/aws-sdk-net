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

namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// This error is thrown when a request is invalid.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class ComplexErrorException : AmazonRestJsonProtocolException
    {
        /// <summary>
        /// Default constructor for ComplexErrorException
        /// message.
        /// </summary>
        public ComplexErrorException() : base() { }

        /// <summary>
        /// Constructs a new ComplexErrorException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ComplexErrorException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of ComplexErrorException
        /// </summary>
        public ComplexErrorException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of ComplexErrorException
        /// </summary>
        public ComplexErrorException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of ComplexErrorException
        /// </summary>
        public ComplexErrorException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of ComplexErrorException
        /// </summary>
        public ComplexErrorException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property Header.
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// Checks to see if the Header property is set.
        /// </summary>
        internal bool IsSetHeader() => this.Header != null;

        /// <summary>
        /// Gets and sets the property Nested.
        /// </summary>
        public ComplexNestedErrorData Nested { get; set; }

        /// <summary>
        /// Checks to see if the Nested property is set.
        /// </summary>
        internal bool IsSetNested() => this.Nested != null;

        /// <summary>
        /// Gets and sets the property TopLevel.
        /// </summary>
        public string TopLevel { get; set; }

        /// <summary>
        /// Checks to see if the TopLevel property is set.
        /// </summary>
        internal bool IsSetTopLevel() => this.TopLevel != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ComplexErrorException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ComplexErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Header = (string)info.GetValue("Header", typeof(string));
            this.Nested = (ComplexNestedErrorData)info.GetValue("Nested", typeof(ComplexNestedErrorData));
            this.TopLevel = (string)info.GetValue("TopLevel", typeof(string));
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
            info.AddValue("Header", this.Header);
            info.AddValue("Nested", this.Nested);
            info.AddValue("TopLevel", this.TopLevel);
        }
#endif
    }
}
