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
    /// A container holding the part number and etag used when completing a multipart upload.
    /// </summary>
    public class PartETag : IComparable<PartETag>
    {
        private int? partNumber;
        private string eTag;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public PartETag()
        {
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

        #region PartNumber

        /// <summary>
        /// The part number identifying the part.
        /// </summary>
        public int PartNumber
        {
            get { return this.partNumber.GetValueOrDefault(); }
            set { this.partNumber = value; }
        }

        // Check to see if PartNumber property is set
        internal bool IsSetPartNumber()
        {
            return this.partNumber.HasValue;
        }

        #endregion

        #region eTag

        /// <summary>
        /// The entity tag associated with the part.
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this.eTag != null;
        }

        #endregion
    }
}
