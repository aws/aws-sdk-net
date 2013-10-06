﻿/*******************************************************************************
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
    /// Describe Account Attributes Result
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeAccountAttributesResult
    {
        private List<AccountAttribute> accountAttributesField;


        /// <summary>
        /// Gets and sets the AccountAttributes property.
        /// The list of AccountAttributes.
        /// </summary>
        [XmlElementAttribute(ElementName = "AccountAttributes")]
        public List<AccountAttribute> AccountAttributes
        {
            get
            {
                if (this.accountAttributesField == null)
                {
                    this.accountAttributesField = new List<AccountAttribute>();
                }
                return this.accountAttributesField;
            }
            set { this.accountAttributesField = value; }
        }

        /// <summary>
        /// Checks if AccountAttributes property is set
        /// </summary>
        /// <returns>true if AccountAttributes property is set</returns>
        public bool IsSetAccountAttributes()
        {
            return (AccountAttributes.Count > 0);
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
