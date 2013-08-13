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
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Globalization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// LifecycleTransition defines when and how objects transition.
    /// </summary>
    public class LifecycleTransition : IXmlSerializable
    {
        private int days;
        private DateTime date;
        private S3StorageClass storageClass;

        /// <summary>
        /// Gets and sets the number of days before transition
        /// Required if the Date property is not set.
        /// </summary>
        public int Days
        {
            get { return this.days; }
            set { this.days = value; }
        }

        /// <summary>
        /// Sets the Days property for this request.
        /// Required if the Date property is not set.
        /// </summary>
        /// <param name="days">the value that Days is set to.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LifecycleTransition WithDays(int days)
        {
            this.Days = days;
            return this;
        }

        /// <summary>
        /// Gets and sets the date till transition.  The Date is stored in UTC with the time portion stripped from the DateTime.
        /// Required if the Days property is not set.
        /// </summary>
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        /// <summary>
        /// Sets the Date property for this request.  The Date is stored in UTC with the time portion stripped from the DateTime.
        /// Required if the Days property is not set.
        /// </summary>
        /// <param name="date">the value that Date is set to.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LifecycleTransition WithDate(DateTime date)
        {
            this.Date = date;
            return this;
        }

        /// <summary>
        /// Gets and sets the storage class the object will transition to.
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        /// <summary>
        /// Sets the StorageClass property for this request.
        /// </summary>
        /// <param name="storageClass">the value that StorageClass is set to.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LifecycleTransition WithStorageClass(S3StorageClass storageClass)
        {
            this.StorageClass = storageClass;
            return this;
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        void IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
        {
            throw new System.NotImplementedException("The method or operation is not implemented.");
        }

        void IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
        {
            string value;
            while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
            {
                reader.Read();

                if (reader.NodeType == System.Xml.XmlNodeType.Element)
                {
                    switch(reader.Name)
                    {
                        case "Date":
                            value = reader.ReadElementContentAsString();
                            if (!string.IsNullOrEmpty(value))
                                this.Date = DateTime.Parse(value, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
                            break;

                        case "Days":
                            value = reader.ReadElementContentAsString();
                            if (!string.IsNullOrEmpty(value))
                                this.Days = int.Parse(value, CultureInfo.InvariantCulture);
                            break;

                        case "StorageClass":
                            value = reader.ReadElementContentAsString();
                            if (!string.IsNullOrEmpty(value))
                            {
                                this.StorageClass = Util.AmazonS3Util.ConvertToS3StorageClass(value);
                            }
                            break;
                    }
                }
            }

            reader.Read();
        } 
    }
}
