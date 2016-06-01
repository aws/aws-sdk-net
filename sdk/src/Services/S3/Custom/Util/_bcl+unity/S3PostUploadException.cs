/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */

using System;
using System.Collections.Generic;
using System.Net;
using System.Xml;
using System.Xml.Serialization;

namespace Amazon.S3.Util
{
    /// <summary>
    /// An exception detailing a failed HTTP POST upload atempt to Amazon S3.
    /// </summary>
#if !PCL
    [Serializable]
#endif
    public class S3PostUploadException : Exception
    {
        /// <summary>
        /// Initializes a new instance of S3PostUploadException with a specified error message
        /// </summary>
        /// <param name="message">The error message</param>
        public S3PostUploadException(string message) : base(message) {}
        
        /// <summary>
        /// Initializes a new instance of S3PostUploadException with a specified error code and error message
        /// </summary>
        /// <param name="errorCode">The error code</param>
        /// <param name="message">The error message</param>
        public S3PostUploadException(string errorCode, string message) : base(message)
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// The error code returned by S3
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// The S3 request id
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// The S3 host id
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// The HTTP error status code returned by S3
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Additional information about the error
        /// </summary>
        /// <remarks>
        /// Some errors are accompanied by more specific information, which vary from error to error
        /// </remarks>
        public IDictionary<string, string> ExtraFields { get; set; }

        /// <summary>
        /// Parse an S3 Error response and create an S3PostUploadException
        /// </summary>
        /// <param name="response">The response from S3</param>
        /// <returns>An S3PostUploadException with the information from the response</returns>
        public static S3PostUploadException FromResponse(HttpWebResponse response)
        {
            var serializer = new XmlSerializer(typeof(S3PostUploadError));

            S3PostUploadError err = null;

            try
            {
                err = serializer.Deserialize(response.GetResponseStream()) as S3PostUploadError;
            }
            catch
            {
                return new S3PostUploadException("Unknown", "Unknown error");
            }

            var ex = new S3PostUploadException(err.ErrorCode, err.ErrorMessage)
            {
                RequestId = err.RequestId,
                HostId = err.HostId,
            };

            ex.StatusCode = response.StatusCode;
            ex.ExtraFields = new Dictionary<string, string>();
            if (err.elements != null)
            {
                foreach (var f in err.elements)
                {
                    ex.ExtraFields.Add(f.LocalName, f.InnerText);
                }
            }

            return ex;
        }

#if !PCL
        /// <summary>
        /// Constructs a new instance of the S3PostUploadException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected S3PostUploadException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            if (info != null)
            {
                this.ErrorCode = info.GetString("ErrorCode");
                this.RequestId = info.GetString("RequestId");
                this.HostId = info.GetString("HostId");
                this.StatusCode = (HttpStatusCode)info.GetValue("StatusCode", typeof(HttpStatusCode));
                this.ExtraFields = (IDictionary<string, string>)info.GetValue("ExtraFields", typeof(IDictionary<string, string>));
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
        //// These FxCop rules are giving false-positives for this method
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);

            if (info != null)
            {
                info.AddValue("ErrorCode", this.ErrorCode);
                info.AddValue("RequestId", this.RequestId);
                info.AddValue("HostId", this.HostId);
                info.AddValue("StatusCode", this.StatusCode);
                info.AddValue("ExtraFields", this.ExtraFields);
            }
        }
#endif
    }

    /// <summary>
    /// Class for unmarshalling response XML
    /// </summary>
    [XmlRoot("Error")]
    public class S3PostUploadError
    {
        /// <summary>
        /// Gets and sets the ErrorCode property.
        /// </summary>
        [XmlElement("Code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets and sets the ErrorMessage property.
        /// </summary>
        [XmlElement("Message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets and sets the RequestId property.
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets and sets the HostId property.
        /// </summary>
        [XmlElement("HostId")]
        public string HostId { get; set; }

        /// <summary>
        /// Gets and sets the elements property.
        /// </summary>
        [XmlAnyElement()]
        public XmlElement[] elements { get; set; }
    }
}
