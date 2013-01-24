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

namespace Amazon.S3.Model
{
    /// <summary>
    /// AmazonS3 exception.
    /// Thrown when DeleteObjects returns successfully, but some of the objects
    /// were not deleted.
    /// </summary>
    public class DeleteObjectsException : AmazonS3Exception
    {
        private DeleteObjectsErrorResponse errorResponse;

        /// <summary>
        /// Gets and sets the ErrorResponse property.
        /// The DeleteObjectsErrorResponse associated with this exception.
        /// </summary>
        public DeleteObjectsErrorResponse ErrorResponse
        {
            get { return this.errorResponse; }
            set { this.errorResponse = value; }
        }


        internal DeleteObjectsException(DeleteObjectsErrorResponse errorResponse)
            : base(CreateMessage(errorResponse))
        {
            this.errorResponse = errorResponse;
        }

        private static string CreateMessage(DeleteObjectsErrorResponse errorResponse)
        {
            if (errorResponse == null)
                throw new ArgumentNullException("errorResponse");

            string message = string.Format(
                "Error deleting objects. Deleted objects: {0}. Delete errors: {1}",
                errorResponse.DeletedObjects == null ? 0 : errorResponse.DeletedObjects.Count,
                errorResponse.DeleteErrors == null ? 0 : errorResponse.DeleteErrors.Count);
            return message;
        }
    }
}
