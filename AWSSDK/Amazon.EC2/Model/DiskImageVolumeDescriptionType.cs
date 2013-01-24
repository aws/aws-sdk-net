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
    /// Describes disk image volume.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DiskImageVolumeDescriptionType
    {    
        private Decimal? sizeField;
        private string idField;

        /// <summary>
        /// Size of the volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "Size")]
        public Decimal Size
        {
            get { return this.sizeField.GetValueOrDefault(); }
            set { this.sizeField = value; }
        }

        /// <summary>
        /// Sets the size of the volume.
        /// </summary>
        /// <param name="size">Size of the volume.</param>
        /// <returns>this instance</returns>
        public DiskImageVolumeDescriptionType WithSize(Decimal size)
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

        /// <summary>
        /// Volume identifier.
        /// </summary>
        [XmlElementAttribute(ElementName = "Id")]
        public string Id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <summary>
        /// Sets the volume identifier.
        /// </summary>
        /// <param name="id">Volume identifier.</param>
        /// <returns>this instance</returns>
        public DiskImageVolumeDescriptionType WithId(string id)
        {
            this.idField = id;
            return this;
        }

        /// <summary>
        /// Checks if Id property is set
        /// </summary>
        /// <returns>true if Id property is set</returns>
        public bool IsSetId()
        {
            return this.idField != null;
        }

    }
}
