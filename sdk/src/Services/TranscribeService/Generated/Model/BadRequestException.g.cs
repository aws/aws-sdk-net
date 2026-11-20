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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Your request didn't pass one or more validation tests. This can occur when a parameter
    /// has an invalid value, when you combine parameters in a way that isn't supported, when
    /// the entity you're trying to delete doesn't exist, or if it's in a non-terminal state
    /// (such as <c>IN PROGRESS</c>). See the exception message field for more information.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class BadRequestException : AmazonTranscribeServiceException
    {
        /// <summary>
        /// Default constructor for BadRequestException
        /// message.
        /// </summary>
        public BadRequestException() : base() { }

        /// <summary>
        /// Constructs a new BadRequestException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public BadRequestException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of BadRequestException
        /// </summary>
        public BadRequestException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of BadRequestException
        /// </summary>
        public BadRequestException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of BadRequestException
        /// </summary>
        public BadRequestException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of BadRequestException
        /// </summary>
        public BadRequestException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A code that identifies why the audio in your request was rejected. Currently, <c>TranscribeAudio</c>
        /// returns this field, and only for problems with your audio. It isn't returned for other
        /// validation errors.
        /// </para>
        ///  
        /// <para>
        /// Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>audioTooLong</c>: The audio is longer than the maximum duration of 1 hour.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>audioTooShort</c>: The audio is shorter than 0.5 seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>audioFileTooLarge</c>: The audio is larger than the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unsupportedAudioFormat</c>: The media format isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unsupportedChannelCount</c>: You enabled <c>ChannelIdentification</c> and the
        /// audio has more than two channels.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>invalidAudio</c>: Amazon Transcribe couldn't decode the audio.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mediaDownloadFailed</c>: Amazon Transcribe couldn't download the audio at your
        /// <c>MediaFileUri</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BadRequestExceptionReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the BadRequestException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected BadRequestException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Reason = (BadRequestExceptionReason)info.GetValue("Reason", typeof(BadRequestExceptionReason));
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
            info.AddValue("Reason", this.Reason);
        }
#endif
    }
}
