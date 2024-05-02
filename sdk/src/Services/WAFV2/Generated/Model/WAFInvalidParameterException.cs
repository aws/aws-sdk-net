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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
    /// The operation failed because WAF didn't recognize a parameter in the request. For
    /// example: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// You specified a parameter name or value that isn't valid.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
    /// be nested. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
    /// types available at <a>DefaultAction</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your request references an ARN that is malformed, or corresponds to a resource with
    /// which a web ACL can't be associated.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class WAFInvalidParameterException : AmazonWAFV2Exception
    {
        private ParameterExceptionField _field;
        private string _parameter;
        private string _reason;

        /// <summary>
        /// Constructs a new WAFInvalidParameterException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public WAFInvalidParameterException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of WAFInvalidParameterException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public WAFInvalidParameterException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of WAFInvalidParameterException
        /// </summary>
        /// <param name="innerException"></param>
        public WAFInvalidParameterException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of WAFInvalidParameterException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public WAFInvalidParameterException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of WAFInvalidParameterException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public WAFInvalidParameterException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the WAFInvalidParameterException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected WAFInvalidParameterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Field = (ParameterExceptionField)info.GetValue("Field", typeof(ParameterExceptionField));
            this.Parameter = (string)info.GetValue("Parameter", typeof(string));
            this.Reason = (string)info.GetValue("Reason", typeof(string));
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
            info.AddValue("Field", this.Field);
            info.AddValue("Parameter", this.Parameter);
            info.AddValue("Reason", this.Reason);
        }
#endif

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The settings where the invalid parameter was found. 
        /// </para>
        /// </summary>
        public ParameterExceptionField Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property Parameter. 
        /// <para>
        /// The invalid parameter that resulted in the exception. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Parameter
        {
            get { return this._parameter; }
            set { this._parameter = value; }
        }

        // Check to see if Parameter property is set
        internal bool IsSetParameter()
        {
            return this._parameter != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Additional information about the exception.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}