/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

using Amazon.Runtime;

namespace Amazon.S3
{
    /// <summary>
    /// Base exception for S3 errors.
    /// </summary>
#if !PCL
    [Serializable]
#endif
    public class AmazonS3Exception : AmazonServiceException
    {
        /// <summary>
        /// Construct an instance of AmazonS3Exception
        /// </summary>
        /// <param name="message"></param>
        public AmazonS3Exception(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Construct an instance of AmazonS3Exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public AmazonS3Exception(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Construct an instance of AmazonS3Exception
        /// </summary>
        /// <param name="innerException"></param>
        public AmazonS3Exception(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

        /// <summary>
        /// Construct an instance of AmazonS3Exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public AmazonS3Exception(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, errorType, errorCode, requestId, statusCode)
        {
        }

        /// <summary>
        /// Construct an instance of AmazonS3Exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public AmazonS3Exception(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
        }

        /// <summary>
        /// Construct an instance of AmazonS3Exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        /// <param name="amazonId2"></param>
        public AmazonS3Exception(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode, string amazonId2)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
            this.AmazonId2 = amazonId2;
        }
        
        /// <summary>
        /// Construct an instance of AmazonS3Exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        /// <param name="amazonId2"></param>
        /// <param name="amazonCfId"></param>
        public AmazonS3Exception(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, 
            HttpStatusCode statusCode, string amazonId2, string amazonCfId)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
            this.AmazonId2 = amazonId2;
            this.AmazonCloudFrontId = amazonCfId;
        }

        /// <summary>
        /// A special token that helps AWS troubleshoot problems.
        /// </summary>
        public string AmazonId2 { get; protected set; }

        /// <summary>
        /// A special token that helps AWS troubleshoot S3 accelerate problems.
        /// </summary>
        public string AmazonCloudFrontId { get; protected set; }

        /// <summary>
        /// The entire response body for this exception, if available.
        /// </summary>
        public string ResponseBody { get; internal set; }

        #region Overrides

        /// <summary>
        /// Gets the exception message.
        /// </summary>
        public override string Message
        {
            get
            {
                if (string.IsNullOrEmpty(ResponseBody))
                    return base.Message;
                else
                    return base.Message + " " + "Response Body: " + ResponseBody;
            }
        }

        #endregion


#if !PCL
        /// <summary>
        /// Constructs a new instance of the AmazonS3Exception class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected AmazonS3Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            if (info != null)
            {
                this.AmazonId2 = info.GetString("AmazonId2");
                this.ResponseBody = info.GetString("ResponseBody");
            }
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

            if (info != null)
            {
                info.AddValue("AmazonId2", this.AmazonId2);
                info.AddValue("ResponseBody", this.ResponseBody);
            }
        }
#endif
    }
}
