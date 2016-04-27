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
using Amazon.S3.Model;
using System.Globalization;

namespace Amazon.S3
{
    /// <summary>
    /// AmazonS3 exception.
    /// Thrown when DeleteObjects returns successfully, but some of the objects
    /// were not deleted.
    /// </summary>
#if !PCL
    [Serializable]
#endif
    public class DeleteObjectsException : AmazonS3Exception
    {
        private DeleteObjectsResponse response;

        /// <summary>
        /// Gets and sets the ErrorResponse property.
        /// The DeleteObjectsErrorResponse associated with this exception.
        /// </summary>
        public DeleteObjectsResponse Response
        {
            get { return this.response; }
            set { this.response = value; }
        }


        /// <summary>
        /// Constructs an instance of DeleteObjectsException
        /// </summary>
        /// <param name="response"></param>
        public DeleteObjectsException(DeleteObjectsResponse response)
            : base(CreateMessage(response))
        {
            this.response = response;
        }

        private static string CreateMessage(DeleteObjectsResponse response)
        {
            if (response == null)
                throw new ArgumentNullException("response");

            string message = string.Format(CultureInfo.InvariantCulture, 
                "Error deleting objects. Deleted objects: {0}. Delete errors: {1}",
                response.DeletedObjects == null ? 0 : response.DeletedObjects.Count,
                response.DeleteErrors == null ? 0 : response.DeleteErrors.Count);
            return message;
        }

#if !PCL
        /// <summary>
        /// Constructs a new instance of the DeleteObjectsException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected DeleteObjectsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            if (info != null)
            {
                Response = info.GetValue("Response", typeof(DeleteObjectsResponse)) as DeleteObjectsResponse;
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
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);

            if (info != null)
            {
                info.AddValue("Response", Response);
            }
        }
#endif
    }
}
