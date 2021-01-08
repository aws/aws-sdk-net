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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// You cannot perform a specified action if an assessment run is currently in progress.
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class AssessmentRunInProgressException : AmazonInspectorException
    {
        private List<string> _assessmentRunArns = new List<string>();
        private bool? _assessmentRunArnsTruncated;
        private bool? _canRetry;

        /// <summary>
        /// Constructs a new AssessmentRunInProgressException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public AssessmentRunInProgressException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of AssessmentRunInProgressException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public AssessmentRunInProgressException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of AssessmentRunInProgressException
        /// </summary>
        /// <param name="innerException"></param>
        public AssessmentRunInProgressException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of AssessmentRunInProgressException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public AssessmentRunInProgressException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of AssessmentRunInProgressException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public AssessmentRunInProgressException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the AssessmentRunInProgressException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected AssessmentRunInProgressException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.AssessmentRunArns = (List<string>)info.GetValue("AssessmentRunArns", typeof(List<string>));
            this.AssessmentRunArnsTruncated = (bool)info.GetValue("AssessmentRunArnsTruncated", typeof(bool));
            this.CanRetry = (bool)info.GetValue("CanRetry", typeof(bool));
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
#if BCL35
        [System.Security.Permissions.SecurityPermission(
            System.Security.Permissions.SecurityAction.LinkDemand,
            Flags = System.Security.Permissions.SecurityPermissionFlag.SerializationFormatter)]
#endif
        [System.Security.SecurityCritical]
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("AssessmentRunArns", this.AssessmentRunArns);
            info.AddValue("AssessmentRunArnsTruncated", this.AssessmentRunArnsTruncated);
            info.AddValue("CanRetry", this.CanRetry);
        }
#endif

        /// <summary>
        /// Gets and sets the property AssessmentRunArns. 
        /// <para>
        /// The ARNs of the assessment runs that are currently in progress.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> AssessmentRunArns
        {
            get { return this._assessmentRunArns; }
            set { this._assessmentRunArns = value; }
        }

        // Check to see if AssessmentRunArns property is set
        internal bool IsSetAssessmentRunArns()
        {
            return this._assessmentRunArns != null && this._assessmentRunArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AssessmentRunArnsTruncated. 
        /// <para>
        /// Boolean value that indicates whether the ARN list of the assessment runs is truncated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool AssessmentRunArnsTruncated
        {
            get { return this._assessmentRunArnsTruncated.GetValueOrDefault(); }
            set { this._assessmentRunArnsTruncated = value; }
        }

        // Check to see if AssessmentRunArnsTruncated property is set
        internal bool IsSetAssessmentRunArnsTruncated()
        {
            return this._assessmentRunArnsTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CanRetry. 
        /// <para>
        /// You can immediately retry your request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool CanRetry
        {
            get { return this._canRetry.GetValueOrDefault(); }
            set { this._canRetry = value; }
        }

        // Check to see if CanRetry property is set
        internal bool IsSetCanRetry()
        {
            return this._canRetry.HasValue; 
        }

    }
}