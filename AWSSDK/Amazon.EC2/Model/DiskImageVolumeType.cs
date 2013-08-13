/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Details about the size of the image.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DiskImageVolumeType
    {    
        private Decimal? sizeField;

        /// <summary>
        /// The size, in GB (2^30 bytes), of the Amazon EBS volume that will hold the converted image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Size")]
        public Decimal Size
        {
            get { return this.sizeField.GetValueOrDefault(); }
            set { this.sizeField = value; }
        }

        /// <summary>
        /// Sets the size, in GB (2^30 bytes), of the Amazon EBS volume that will hold the converted image.
        /// </summary>
        /// <param name="size">The size, in GB (2^30 bytes), of the Amazon EBS volume that will hold the converted image.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DiskImageVolumeType WithSize(Decimal size)
        {
            this.sizeField = size;
            return this;
        }

        /// <summary>
        /// Checks if Size property is set
        /// </summary>
        /// <returns>true if Size property is set</returns>
        public bool IsSetSize()
        {
            return this.sizeField.HasValue;
        }

    }
}
