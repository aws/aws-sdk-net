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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
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
namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
    /// for more details.
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class ConflictException : AmazonVoiceIDException
    {
        private ConflictType _conflictType;

        /// <summary>
        /// Constructs a new ConflictException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ConflictException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of ConflictException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ConflictException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of ConflictException
        /// </summary>
        /// <param name="innerException"></param>
        public ConflictException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of ConflictException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ConflictException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of ConflictException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ConflictException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ConflictException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ConflictException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.ConflictType = (ConflictType)info.GetValue("ConflictType", typeof(ConflictType));
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
            info.AddValue("ConflictType", this.ConflictType);
        }
#endif

        /// <summary>
        /// Gets and sets the property ConflictType. 
        /// <para>
        /// The type of conflict which caused a ConflictException. Possible types and the corresponding
        /// error messages are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DOMAIN_NOT_ACTIVE</c>: The domain is not active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANNOT_CHANGE_SPEAKER_AFTER_ENROLLMENT</c>: You cannot change the speaker ID after
        /// an enrollment has been requested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENROLLMENT_ALREADY_EXISTS</c>: There is already an enrollment for this session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SPEAKER_NOT_SET</c>: You must set the speaker ID before requesting an enrollment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SPEAKER_OPTED_OUT</c>: You cannot request an enrollment for an opted out speaker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONCURRENT_CHANGES</c>: The request could not be processed as the resource was
        /// modified by another request during execution.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConflictType ConflictType
        {
            get { return this._conflictType; }
            set { this._conflictType = value; }
        }

        // Check to see if ConflictType property is set
        internal bool IsSetConflictType()
        {
            return this._conflictType != null;
        }

    }
}