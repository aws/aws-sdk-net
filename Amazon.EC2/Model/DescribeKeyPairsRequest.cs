/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Returns information about key pairs available to you. If you specify key pairs, information
    /// about those key pairs is returned. Otherwise, information for all registered key pairs is
    /// returned.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeKeyPairsRequest
    {
        private List<string> keyNameField;

        /// <summary>
        /// Gets and sets the KeyName property.
        /// Key pair to describe.
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyName")]
        public List<string> KeyName
        {
            get
            {
                if (this.keyNameField == null)
                {
                    this.keyNameField = new List<string>();
                }
                return this.keyNameField;
            }
            set { this.keyNameField = value; }
        }

        /// <summary>
        /// Sets the KeyName property
        /// </summary>
        /// <param name="list">Key pair to describe.</param>
        /// <returns>this instance</returns>
        public DescribeKeyPairsRequest WithKeyName(params string[] list)
        {
            foreach (string item in list)
            {
                KeyName.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if KeyName property is set
        /// </summary>
        /// <returns>true if KeyName property is set</returns>
        public bool IsSetKeyName()
        {
            return (KeyName.Count > 0);
        }

    }
}
