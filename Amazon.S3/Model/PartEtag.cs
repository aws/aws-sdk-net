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
    /// A container object for holding the part number and etag used when completing a
    /// multipart upload.
    /// </summary>
    public class PartETag : IComparable<PartETag>
    {
        private int partNumber;
        private string eTag;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public PartETag()
        {
        }

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has the following meanings:
        /// Value
        /// Meaning
        /// Less than zero
        /// This object is less than the <paramref name="other"/> parameter.
        /// Zero
        /// This object is equal to <paramref name="other"/>.
        /// Greater than zero
        /// This object is greater than <paramref name="other"/>.
        /// </returns>
        public int CompareTo(PartETag other)
        {
            return this.PartNumber.CompareTo(other.PartNumber);
        }
    
 
        /// <summary>
        /// Constructs an instance of PartETag and sets the part number and etag.
        /// </summary>
        /// <param name="partNumber">The part number.</param>
        /// <param name="eTag">the associated ETag for the part number.</param>
        public PartETag(int partNumber, string eTag)
        {
            this.partNumber = partNumber;
            this.eTag = eTag;
        }

        #region PartNumber

        /// <summary>
        /// Gets and sets the PartNumber property.
        /// </summary>
        public int PartNumber
        {
            get { return this.partNumber; }
            set { this.partNumber = value; }
        }

        /// <summary>
        /// Sets the PartNumber property for this request.
        /// </summary>
        /// <param name="partNumber">The value that PartNumber is set to</param>
        /// <returns>the request with the PartNumber set</returns>
        public PartETag WithPartNumber(int partNumber)
        {
            this.partNumber = partNumber;
            return this;
        }

        #endregion

        #region eTag

        /// <summary>
        /// Gets and sets the ETag property.
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        /// <summary>
        /// Sets the ETag property for this request.
        /// </summary>
        /// <param name="eTag">The value that ETag is set to</param>
        /// <returns>the request with the ETag set</returns>
        public PartETag WithETag(string eTag)
        {
            this.eTag = eTag;
            return this;
        }

        #endregion
    }
}
