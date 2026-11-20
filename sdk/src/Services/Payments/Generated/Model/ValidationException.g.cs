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

namespace Amazon.Payments.Model
{
    /// <summary>
    /// The request isn't valid. Check <c>reason</c> and <c>fieldList</c> for the cause, correct
    /// the request, and try again.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class ValidationException : AmazonPaymentsException
    {
        /// <summary>
        /// Default constructor for ValidationException
        /// message.
        /// </summary>
        public ValidationException() : base() { }

        /// <summary>
        /// Constructs a new ValidationException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ValidationException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of ValidationException
        /// </summary>
        public ValidationException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of ValidationException
        /// </summary>
        public ValidationException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of ValidationException
        /// </summary>
        public ValidationException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of ValidationException
        /// </summary>
        public ValidationException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property FieldList. 
        /// <para>
        /// The request members that failed validation. This member is populated when <c>reason</c>
        /// is <c>FIELD_VALIDATION_FAILED</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<ValidationExceptionField> FieldList { get; set; } = AWSConfigs.InitializeCollections ? new List<ValidationExceptionField>() : null;

        /// <summary>
        /// Checks to see if the FieldList property is set.
        /// </summary>
        internal bool IsSetFieldList() => this.FieldList != null && (this.FieldList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason that validation failed. The following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CANNOT_PARSE</c> – The request body couldn't be parsed, or a value isn't of the
        /// expected type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FIELD_VALIDATION_FAILED</c> – One or more members failed validation. <c>fieldList</c>
        /// names them.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_PAGINATION_TOKEN</c> – The <c>nextToken</c> is malformed or expired, or
        /// doesn't match the original request. Start again from the first page.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNSUPPORTED_ACTION</c> – The request is well formed, but the action isn't supported
        /// for your account, Region, or resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OTHER</c> – The request isn't valid for another reason.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ValidationExceptionReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ValidationException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.FieldList = (List<ValidationExceptionField>)info.GetValue("FieldList", typeof(List<ValidationExceptionField>));
            this.Reason = (ValidationExceptionReason)info.GetValue("Reason", typeof(ValidationExceptionReason));
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
            info.AddValue("FieldList", this.FieldList);
            info.AddValue("Reason", this.Reason);
        }
#endif
    }
}
