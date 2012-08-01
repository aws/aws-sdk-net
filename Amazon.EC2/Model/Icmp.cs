/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

    [XmlRootAttribute(IsNullable = false)]
    public class Icmp
    {    
        private Decimal? codeField;
        private Decimal? typeField;

        /// <summary>
        /// Gets and sets the Code property.
        /// The ICMP code. A value of -1 is a wildcard meaning all codes.
        /// </summary>
        [XmlElementAttribute(ElementName = "Code")]
        public Decimal Code
        {
            get { return this.codeField.GetValueOrDefault(); }
            set { this.codeField = value; }
        }

        /// <summary>
        /// Sets the Code property
        /// </summary>
        /// <param name="code">The ICMP code. A value of -1 is a wildcard meaning all codes.</param>
        /// <returns>this instance</returns>
        public Icmp WithCode(Decimal code)
        {
            this.codeField = code;
            return this;
        }

        /// <summary>
        /// Checks if Code property is set
        /// </summary>
        /// <returns>true if Code property is set</returns>
        public bool IsSetCode()
        {
            return this.codeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Type property.
        /// The ICMP type. A value of -1 is a wildcard meaning all types.
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public Decimal Type
        {
            get { return this.typeField.GetValueOrDefault(); }
            set { this.typeField = value; }
        }

        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The ICMP type. A value of -1 is a wildcard meaning all types.</param>
        /// <returns>this instance</returns>
        public Icmp WithType(Decimal type)
        {
            this.typeField = type;
            return this;
        }

        /// <summary>
        /// Checks if Type property is set
        /// </summary>
        /// <returns>true if Type property is set</returns>
        public bool IsSetType()
        {
            return this.typeField.HasValue;
        }

    }
}
