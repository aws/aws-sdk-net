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
    /// Describe Key Pairs Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeKeyPairsResult
    {
        private List<KeyPair> keyPairField;
        /// <summary>
        /// Gets and sets the KeyPair property.
        /// List of key pairs
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyPair")]
        public List<KeyPair> KeyPair
        {
            get
            {
                if (this.keyPairField == null)
                {
                    this.keyPairField = new List<KeyPair>();
                }
                return this.keyPairField;
            }
            set { this.keyPairField = value; }
        }

        /// <summary>
        /// Sets the KeyPair property
        /// </summary>
        /// <param name="list">List of key pairs</param>
        /// <returns>this instance</returns>
        public DescribeKeyPairsResult WithKeyPair(params KeyPair[] list)
        {
            foreach (KeyPair item in list)
            {
                KeyPair.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if KeyPair property is set
        /// </summary>
        /// <returns>true if KeyPair property is set</returns>
        public bool IsSetKeyPair()
        {
            return (KeyPair.Count > 0);
        }

    }
}
