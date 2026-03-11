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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  DeleteObjects response and response metadata.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
    public partial class DeleteObjectsResponse : AmazonWebServiceResponse, System.Runtime.Serialization.ISerializable
#else
    public partial class DeleteObjectsResponse : AmazonWebServiceResponse
#endif
    {

        /// <summary>
        /// A default constructor for DeleteObjectsResponse
        /// </summary>
        public DeleteObjectsResponse()
        {
        }



#if !NETSTANDARD
        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about DeleteObjectsResponse
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected DeleteObjectsResponse(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            if (info != null)
            {
                this._deletedObjects = (List<DeletedObject>)info.GetValue("deleted", typeof(List<DeletedObject>));
                this._deleteErrors = (List<DeleteError>)info.GetValue("errors", typeof(List<DeleteError>));
                this._requestCharged = RequestCharged.FindValue((string) info.GetValue("requestCharged", typeof(string)));
            }
        }

        ///<summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the DeleteObjectsResponse.
        ///</summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        [System.Security.SecurityCritical]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            if (info != null)
            {
                info.AddValue("deleted", _deletedObjects);
                info.AddValue("errors", _deleteErrors);
                info.AddValue("requestCharged", (string) _requestCharged);
            }
        }
#endif
    }
}
    
