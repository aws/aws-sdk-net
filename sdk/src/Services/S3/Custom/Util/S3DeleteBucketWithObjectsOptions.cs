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
using System.Linq;
using System.Text;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Options which control the behaviour of the DeleteS3BucketWithObjects operation.
    /// </summary>
    public class S3DeleteBucketWithObjectsOptions
    {
        /// <summary>
        /// Gets or sets a value which indicates whether the 
        /// operation should be aborted if an error is encountered during execution.
        /// </summary>
        public bool ContinueOnError { get; set; }

        /// <summary>
        /// Gets or sets a value which indicated whether verbose results shoule be returned to the
        /// <see cref="Action&lt;S3DeleteBucketWithObjectsUpdate&gt;" /> callback.
        /// If quiet mode is true the callback will receive only keys where the delete operation encountered an error.
        /// If quiet mode is false the callback will receive keys for both successful and unsuccessful delete operations.
        /// </summary>
        public bool QuietMode { get; set; }
    }


}
