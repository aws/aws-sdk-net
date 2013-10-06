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
 *  API Version: 2006-03-01
 *
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The DeleteObjectsResponse contains a list of successful
    /// deletes, as well as any headers returned by S3.
    /// </summary>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class DeleteObjectsResponse : S3Response
    {
        private List<DeletedObject> deletedObjects;

        /// <summary>
        /// Gets and sets the DeletedObjects property.
        /// A list of successful deletes.
        /// Set only when Quiet=false on DeleteObjectsRequest.
        /// </summary>
        public List<DeletedObject> DeletedObjects
        {
            get { return this.deletedObjects; }
            set { this.deletedObjects = value; }
        }
    }

    /// <summary>
    /// The DeleteObjectsResponse contains a list of successful
    /// and failed deletes, as well as any headers returned by S3.
    /// </summary>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class DeleteObjectsErrorResponse : DeleteObjectsResponse
    {
        private List<DeleteError> deleteErrors;

        /// <summary>
        /// Gets and sets the DeleteErrors property.
        /// A list of errors encountered while deleting objects.
        /// </summary>
        public List<DeleteError> DeleteErrors
        {
            get { return this.deleteErrors; }
            set { this.deleteErrors = value; }
        }
    }
}