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
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describe Volume Attribute result.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeVolumeAttributeResult
    {
        private string volumeIdField;
        private bool? autoEnableIOField;
        private List<ProductCode> productCodesField;

        /// <summary>
        /// Flag that signals if the AutoEnableIO attribute is true or false.
        /// </summary>
        [XmlElementAttribute(ElementName = "AutoEnableIO")]
        public bool AutoEnableIO
        {
            get { return this.autoEnableIOField.GetValueOrDefault(); }
            set { this.autoEnableIOField = value; }
        }

        /// <summary>
        /// Checks if AutoEnableIO property is set
        /// </summary>
        /// <returns>true if AutoEnableIO property is set</returns>
        public bool IsSetAutoEnableIO()
        {
            return autoEnableIOField.HasValue;
        }


        /// <summary>
        /// Volume ID of the target volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeId")]
        public string VolumeId
        {
            get { return this.volumeIdField; }
            set { this.volumeIdField = value; }
        }

        /// <summary>
        /// Checks if VolumeId property is set
        /// </summary>
        /// <returns>true if VolumeId property is set</returns>
        public bool IsSetVolumeId()
        {
            return this.volumeIdField != null;
        }

        /// <summary>
        /// Product codes for the volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductCode")]
        public List<ProductCode> ProductCodes
        {
            get
            {
                if (this.productCodesField == null)
                {
                    this.productCodesField = new List<ProductCode>();
                }
                return this.productCodesField;
            }
            set { this.productCodesField = value; }
        }

        /// <summary>
        /// Checks if ProductCodes property is set
        /// </summary>
        /// <returns>true if ProductCodes property is set</returns>
        public bool IsSetProductCodes()
        {
            return (ProductCodes.Count > 0);
        }

        /// <summary>
        /// XML Representation of this object
        /// </summary>
        /// <returns>XML String</returns>
        public string ToXML()
        {
            StringBuilder xml = new StringBuilder(1024);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }

        /// <summary>
        /// String Representation of this object. Overrides Object.ToString()
        /// </summary>
        /// <returns>This object as a string</returns>
        public override string ToString()
        {
            return this.ToXML();
        }
    }
}
