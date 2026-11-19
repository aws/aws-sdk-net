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

namespace Amazon.AbuseSignal.Model
{
    /// <summary>
    /// The report is well-formed and satisfies the XARF schema, but it does not meet one
    /// or more submission requirements (for example, the submission lookback window or <c>source_identifier</c>
    /// restrictions). This error is distinct from <c>ValidationException</c> (HTTP 400),
    /// which indicates that the report is not well-formed. Retrying the same report will
    /// not succeed; the report content must change.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class SubmissionRequirementException : AmazonAbuseSignalException
    {
        /// <summary>
        /// Default constructor for SubmissionRequirementException
        /// message.
        /// </summary>
        public SubmissionRequirementException() : base() { }

        /// <summary>
        /// Constructs a new SubmissionRequirementException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public SubmissionRequirementException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of SubmissionRequirementException
        /// </summary>
        public SubmissionRequirementException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of SubmissionRequirementException
        /// </summary>
        public SubmissionRequirementException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of SubmissionRequirementException
        /// </summary>
        public SubmissionRequirementException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of SubmissionRequirementException
        /// </summary>
        public SubmissionRequirementException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property UnmetRequirements. 
        /// <para>
        /// A list of the specific submission requirements that the report did not meet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<SubmissionRequirement> UnmetRequirements { get; set; } = AWSConfigs.InitializeCollections ? new List<SubmissionRequirement>() : null;

        /// <summary>
        /// Checks to see if the UnmetRequirements property is set.
        /// </summary>
        internal bool IsSetUnmetRequirements() => this.UnmetRequirements != null && (this.UnmetRequirements.Count > 0 || !AWSConfigs.InitializeCollections);

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the SubmissionRequirementException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected SubmissionRequirementException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.UnmetRequirements = (List<SubmissionRequirement>)info.GetValue("UnmetRequirements", typeof(List<SubmissionRequirement>));
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
            info.AddValue("UnmetRequirements", this.UnmetRequirements);
        }
#endif
    }
}
