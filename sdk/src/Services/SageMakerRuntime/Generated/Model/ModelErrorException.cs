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
 * Do not modify this file. This file is generated from the runtime.sagemaker-2017-05-13.normal.json service model.
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
namespace Amazon.SageMakerRuntime.Model
{
    /// <summary>
    /// Model (owned by the customer in the container) returned 4xx or 5xx error code.
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class ModelErrorException : AmazonSageMakerRuntimeException
    {
        private string _logStreamArn;
        private string _originalMessage;
        private int? _originalStatusCode;

        /// <summary>
        /// Constructs a new ModelErrorException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ModelErrorException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of ModelErrorException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ModelErrorException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of ModelErrorException
        /// </summary>
        /// <param name="innerException"></param>
        public ModelErrorException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of ModelErrorException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ModelErrorException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of ModelErrorException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ModelErrorException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ModelErrorException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ModelErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.LogStreamArn = (string)info.GetValue("LogStreamArn", typeof(string));
            this.OriginalMessage = (string)info.GetValue("OriginalMessage", typeof(string));
            this.OriginalStatusCode = (int?)info.GetValue("OriginalStatusCode", typeof(int?));
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
            info.AddValue("LogStreamArn", this.LogStreamArn);
            info.AddValue("OriginalMessage", this.OriginalMessage);
            info.AddValue("OriginalStatusCode", this.OriginalStatusCode);
        }
#endif

        /// <summary>
        /// Gets and sets the property LogStreamArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the log stream. 
        /// </para>
        /// </summary>
        public string LogStreamArn
        {
            get { return this._logStreamArn; }
            set { this._logStreamArn = value; }
        }

        // Check to see if LogStreamArn property is set
        internal bool IsSetLogStreamArn()
        {
            return this._logStreamArn != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalMessage. 
        /// <para>
        ///  Original message. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string OriginalMessage
        {
            get { return this._originalMessage; }
            set { this._originalMessage = value; }
        }

        // Check to see if OriginalMessage property is set
        internal bool IsSetOriginalMessage()
        {
            return this._originalMessage != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalStatusCode. 
        /// <para>
        ///  Original status code. 
        /// </para>
        /// </summary>
        public int? OriginalStatusCode
        {
            get { return this._originalStatusCode; }
            set { this._originalStatusCode = value; }
        }

        // Check to see if OriginalStatusCode property is set
        internal bool IsSetOriginalStatusCode()
        {
            return this._originalStatusCode.HasValue; 
        }

    }
}