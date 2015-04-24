/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.S3.IO
{
    /// <summary>
    /// Enumeration indicated whether a file system element is a file or directory.
    /// </summary>
    public enum FileSystemType
    {
        /// <summary>
        /// Type is a directory.
        /// </summary>
        Directory,
        /// <summary>
        /// Type is a file.
        /// </summary>
        File
    };

    /// <summary>
    /// Common interface for both S3FileInfo and S3DirectoryInfo.
    /// </summary>
    public interface IS3FileSystemInfo
    {
        /// <summary>
        /// Returns true if the item exists in S3.
        /// </summary>
        bool Exists
        {
            get;
        }

        /// <summary>
        /// Returns the extension of the item.
        /// </summary>
        string Extension
        {
            get;
        }

        /// <summary>
        /// Returns the fully qualified path to the item.
        /// </summary>
        string FullName
        {
            get;
        }

        /// <summary>
        /// Returns the last modified time for this item from S3 in local timezone.
        /// </summary>
        DateTime LastWriteTime
        {
            get;
        }

        /// <summary>
        /// Returns the last modified time for this item from S3 in UTC timezone.
        /// </summary>
        DateTime LastWriteTimeUtc
        {
            get;
        }

        /// <summary>
        /// Returns the name of the item without parent information.
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// Indicates what type of item this object represents.
        /// </summary>
        FileSystemType Type
        {
            get;
        }

        /// <summary>
        /// Deletes this item from S3.
        /// </summary>
        void Delete();
    }
}
