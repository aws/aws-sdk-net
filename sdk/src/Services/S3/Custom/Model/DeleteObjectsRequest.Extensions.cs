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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteObjects operation.
    /// <para>This operation enables you to delete multiple objects from a bucket using a single HTTP request. You may specify up to 1000
    /// keys.</para>
    /// </summary>
    public partial class DeleteObjectsRequest : AmazonWebServiceRequest
    {
        private List<DeleteError> validationErrors;

        /// <summary>
        /// Gets the list of keys that were skipped during client-side validation.
        /// </summary>
        public List<DeleteError> ValidationErrors
        {
            get
            {
                if (validationErrors == null)
                {
                    validationErrors = new List<DeleteError>();
                }
                return validationErrors;
            }
        }

        private static Logger Logger
        {
            get
            {
                return Logger.GetLogger(typeof(DeleteObjectsRequest));
            }
        }

        /// <summary>
        /// Add a key to the set of keys of objects to be deleted.
        /// </summary>
        /// <param name="key">Object key</param>
        /// <remarks>
        /// Invalid keys (null, empty, or longer than 1024 characters) are skipped with an INFO-level log message.
        /// These validation errors are also tracked in the ValidationErrors collection.
        /// This allows the DeleteObjects operation to proceed with valid keys even when some keys are invalid.
        /// </remarks>
        public void AddKey(string key)
        {
            // Skip invalid keys instead of throwing exceptions
            // This allows the DeleteObjects operation to proceed with valid keys
            if (string.IsNullOrEmpty(key))
            {
                string message = "Skipping null or empty key in DeleteObjects request";
                Logger.InfoFormat(message);
                
                ValidationErrors.Add(new DeleteError {
                    Key = key ?? "(null)",
                    Code = "InvalidKey",
                    Message = "Key cannot be null or empty"
                });
                return;
            }
            if (key.Length > 1024)
            {
                string message = string.Format("Skipping key in DeleteObjects request: key length {0} exceeds maximum of 1024 characters", key.Length);
                Logger.InfoFormat(message);
                
                ValidationErrors.Add(new DeleteError {
                    Key = key.Substring(0, Math.Min(key.Length, 128)) + (key.Length > 128 ? "..." : ""),
                    Code = "KeyTooLongError",
                    Message = string.Format("Key length {0} exceeds maximum of 1024 characters", key.Length)
                });
                return;
            }

            AddKey(new KeyVersion { Key = key });
        }

        /// <summary>
        /// Add a key and a version to be deleted.
        /// </summary>
        /// <param name="key">Key of the object to be deleted.</param>
        /// <param name="version">Version of the object to be deleted.</param>
        /// <remarks>
        /// Invalid keys (null, empty, or longer than 1024 characters) are skipped with an INFO-level log message.
        /// These validation errors are also tracked in the ValidationErrors collection.
        /// This allows the DeleteObjects operation to proceed with valid keys even when some keys are invalid.
        /// </remarks>
        public void AddKey(string key, string version)
        {
            // Skip invalid keys instead of throwing exceptions
            // This allows the DeleteObjects operation to proceed with valid keys
            if (string.IsNullOrEmpty(key))
            {
                string message = "Skipping null or empty key in DeleteObjects request";
                Logger.InfoFormat(message);
                
                ValidationErrors.Add(new DeleteError {
                    Key = key ?? "(null)",
                    Code = "InvalidKey",
                    Message = "Key cannot be null or empty"
                });
                return;
            }
            if (key.Length > 1024)
            {
                string message = string.Format("Skipping key in DeleteObjects request: key length {0} exceeds maximum of 1024 characters", key.Length);
                Logger.InfoFormat(message);
                
                ValidationErrors.Add(new DeleteError {
                    Key = key.Substring(0, Math.Min(key.Length, 128)) + (key.Length > 128 ? "..." : ""),
                    Code = "KeyTooLongError",
                    Message = string.Format("Key length {0} exceeds maximum of 1024 characters", key.Length)
                });
                return;
            }

            AddKey(new KeyVersion { Key = key, VersionId = version });
        }

        /// <summary>
        /// Add a KeyVersion object representing the S3 object to be deleted.
        /// </summary>
        /// <param name="keyVersion">KeyVersion representation of object to be deleted.</param>
        private void AddKey(KeyVersion keyVersion)
        {
            if (this.Objects == null)
            {
                this.Objects = new List<KeyVersion>();
            }
            this.Objects.Add(keyVersion);
        }
    }
}
