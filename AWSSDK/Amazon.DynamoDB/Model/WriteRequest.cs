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
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.DynamoDB.Model
{
    /// <summary>
    /// <para>This structure is a Union of PutRequest and DeleteRequest. It can contain exactly one of <c>PutRequest</c> or <c>DeleteRequest</c> .
    /// Never Both. This is enforced in the code.</para>
    /// </summary>
    public class WriteRequest  
    {
        
        private PutRequest putRequest;
        private DeleteRequest deleteRequest;

        /// <summary>
        /// A container for a Put BatchWrite request
        ///  
        /// </summary>
        public PutRequest PutRequest
        {
            get { return this.putRequest; }
            set { this.putRequest = value; }
        }

        /// <summary>
        /// Sets the PutRequest property
        /// </summary>
        /// <param name="putRequest">The value to set for the PutRequest property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WriteRequest WithPutRequest(PutRequest putRequest)
        {
            this.putRequest = putRequest;
            return this;
        }
            

        // Check to see if PutRequest property is set
        internal bool IsSetPutRequest()
        {
            return this.putRequest != null;       
        }

        /// <summary>
        /// A container for a Delete BatchWrite request
        ///  
        /// </summary>
        public DeleteRequest DeleteRequest
        {
            get { return this.deleteRequest; }
            set { this.deleteRequest = value; }
        }

        /// <summary>
        /// Sets the DeleteRequest property
        /// </summary>
        /// <param name="deleteRequest">The value to set for the DeleteRequest property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WriteRequest WithDeleteRequest(DeleteRequest deleteRequest)
        {
            this.deleteRequest = deleteRequest;
            return this;
        }
            

        // Check to see if DeleteRequest property is set
        internal bool IsSetDeleteRequest()
        {
            return this.deleteRequest != null;       
        }
    }
}
