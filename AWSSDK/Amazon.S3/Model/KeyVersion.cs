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
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies an object key and optional object version.
    /// </summary>
    public class KeyVersion
    {
        private string key;
        private string versionId;

        /// <summary>
        /// The object key.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// The object version id.
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Constructs a KeyVersion object, specifying only the key.
        /// </summary>
        /// <param name="key">Key of the object.</param>
        public KeyVersion(string key)
            : this(key, null) { }

        /// <summary>
        /// Constructs a KeyVersion object. specifying both the
        /// key and the version.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="versionId"></param>
        public KeyVersion(string key, string versionId)
        {
            Key = key;
            VersionId = versionId;
        }
    }
}
