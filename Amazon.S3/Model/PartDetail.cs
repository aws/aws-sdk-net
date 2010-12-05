﻿/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// PartDetails is a container for elements related to a particular part. A response can contain
    /// zero or more Part elements.
    /// </summary>
    public class PartDetail
    {
        private int partNumber;
        private DateTime lastModified;
        private string eTag;
        private long size;

        /// <summary>
        /// Gets and sets the part number identifying the part.
        /// </summary>
        public int PartNumber
        {
            get { return this.partNumber; }
            set { this.partNumber = value; }
        }

        /// <summary>
        /// Gets and sets the date and time at which the part was uploaded.
        /// </summary>
        public DateTime LastModified
        {
            get { return this.lastModified; }
            set { this.lastModified = value; }
        }

        /// <summary>
        /// Gets and sets the entity tag returned when the part was uploaded.
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        /// <summary>
        /// Gets and sets the size of the uploaded part data.
        /// </summary>
        public long Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

    }
}
