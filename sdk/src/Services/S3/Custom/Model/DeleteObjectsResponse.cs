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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  DeleteObjects response and response metadata.
    /// </summary>
#if !PCL
    [Serializable]
#endif
    public class DeleteObjectsResponse : AmazonWebServiceResponse
    {
        private List<DeletedObject> deleted = new List<DeletedObject>();
        private List<DeleteError> errors = new List<DeleteError>();

        /// <summary>
        /// Gets and sets the DeletedObjects property.
        /// A list of successful deletes.
        /// Set only when Quiet=false on DeleteObjectsRequest.
        /// </summary>
        public List<DeletedObject> DeletedObjects
        {
            get { return this.deleted; }
            set { this.deleted = value; }
        }

        // Check to see if Deleted property is set
        internal bool IsSetDeletedObjects()
        {
            return this.deleted.Count > 0;
        }

        /// <summary>
        /// Gets and sets the DeleteErrors property.
        /// A list of errors encountered while deleting objects.
        /// </summary>
        public List<DeleteError> DeleteErrors
        {
            get { return this.errors; }
            set { this.errors = value; }
        }

        // Check to see if DeleteErrors property is set
        internal bool IsSetDeleteErrors()
        {
            return this.errors.Count > 0;
        }
    }
}
    
