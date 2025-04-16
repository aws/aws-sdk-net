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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the DeleteObjects operation.
    /// </summary>
    public partial class DeleteObjectsResponse : AmazonWebServiceResponse
    {
        private List<DeletedObject> _deletedObjects = AWSConfigs.InitializeCollections ? new List<DeletedObject>() : null;
        private List<Error> _errors = AWSConfigs.InitializeCollections ? new List<Error>() : null;
        private RequestCharged _requestCharged;

        /// <summary>
        /// Gets and sets the property DeletedObjects. 
        /// <para>
        /// Container element for a successful delete. It identifies the object that was successfully
        /// deleted.
        /// </para>
        /// </summary>
        public List<DeletedObject> DeletedObjects
        {
            get { return this._deletedObjects; }
            set { this._deletedObjects = value; }
        }

        // Check to see if DeletedObjects property is set
        internal bool IsSetDeletedObjects()
        {
            return this._deletedObjects != null && (this._deletedObjects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Container for a failed delete action that describes the object that Amazon S3 attempted
        /// to delete and the error it encountered.
        /// </para>
        /// </summary>
        public List<Error> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestCharged.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this._requestCharged; }
            set { this._requestCharged = value; }
        }

        // Check to see if RequestCharged property is set
        internal bool IsSetRequestCharged()
        {
            return this._requestCharged != null;
        }

    }
}