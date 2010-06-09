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
 *  API Version: 2009-10-16
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    ///<summary>
    ///Information about the endpoint.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class Endpoint
    {
        private string addressField;
        private Decimal? portField;

        /// <summary>
        /// Gets and sets the Address property.
        /// The DNS address of the DB Instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "Address")]
        public string Address
        {
            get { return this.addressField ; }
            set { this.addressField= value; }
        }

        /// <summary>
        /// Sets the Address property
        /// </summary>
        /// <param name="address">The DNS address of the DB Instance.</param>
        /// <returns>this instance</returns>
        public Endpoint WithAddress(string address)
        {
            this.addressField = address;
            return this;
        }

        /// <summary>
        /// Checks if Address property is set
        /// </summary>
        /// <returns>true if Address property is set</returns>
        public bool IsSetAddress()
        {
            return  this.addressField != null;
        }

        /// <summary>
        /// Gets and sets the Port property.
        /// The port that the database engine is listening on.
        /// </summary>
        [XmlElementAttribute(ElementName = "Port")]
        public Decimal Port
        {
            get { return this.portField.GetValueOrDefault() ; }
            set { this.portField= value; }
        }

        /// <summary>
        /// Sets the Port property
        /// </summary>
        /// <param name="port">The port that the database engine is listening on.</param>
        /// <returns>this instance</returns>
        public Endpoint WithPort(Decimal port)
        {
            this.portField = port;
            return this;
        }

        /// <summary>
        /// Checks if Port property is set
        /// </summary>
        /// <returns>true if Port property is set</returns>
        public bool IsSetPort()
        {
            return  this.portField.HasValue;
        }

    }
}
