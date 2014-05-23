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
    public class LifecycleRuleNoncurrentVersionTransition : IXmlSerializable
    {
        private int noncurrentDays;
        private S3StorageClass storageClass;

        /// <summary>
        /// Indicates the lifetime, in days, of the objects that are subject to the rule. The value must be a non-zero positive integer.
        ///  
        /// </summary>
        public int NoncurrentDays
        {
            get { return this.noncurrentDays; }
            set { this.noncurrentDays = value; }
        }

        /// <summary>
        /// Sets the NoncurrentDays property for this request.
        /// </summary>
        /// <param name="noncurrentDays">the value that NoncurrentDays is set to.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LifecycleRuleNoncurrentVersionTransition WithNoncurrentDays(int noncurrentDays)
        {
            this.NoncurrentDays = noncurrentDays;
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
        public LifecycleRuleNoncurrentVersionTransition WithStorageClass(S3StorageClass storageClass)
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
                    switch (reader.Name)
                    {
                        case "NoncurrentDays":
                            value = reader.ReadElementContentAsString();
                            if (!string.IsNullOrEmpty(value))
                                this.NoncurrentDays = int.Parse(value, CultureInfo.InvariantCulture);
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
