/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{

    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class PortRange
    {    
        private Decimal? fromField;
        private Decimal? toField;

        /// <summary>
        /// Gets and sets the From property.
        /// The first port in the range. A value of -1 indicates all ports.
        /// </summary>
        [XmlElementAttribute(ElementName = "From")]
        public Decimal From
        {
            get { return this.fromField.GetValueOrDefault(); }
            set { this.fromField = value; }
        }

        /// <summary>
        /// Sets the From property
        /// </summary>
        /// <param name="from">The first port in the range. A value of -1 indicates all ports.</param>
        /// <returns>this instance</returns>
        public PortRange WithFrom(Decimal from)
        {
            this.fromField = from;
            return this;
        }

        /// <summary>
        /// Checks if From property is set
        /// </summary>
        /// <returns>true if From property is set</returns>
        public bool IsSetFrom()
        {
            return this.fromField.HasValue;
        }

        /// <summary>
        /// Gets and sets the To property.
        /// The last port in the range. A value of -1 indicates all ports
        /// </summary>
        [XmlElementAttribute(ElementName = "To")]
        public Decimal To
        {
            get { return this.toField.GetValueOrDefault(); }
            set { this.toField = value; }
        }

        /// <summary>
        /// Sets the To property
        /// </summary>
        /// <param name="to">The last port in the range. A value of -1 indicates all ports</param>
        /// <returns>this instance</returns>
        public PortRange WithTo(Decimal to)
        {
            this.toField = to;
            return this;
        }

        /// <summary>
        /// Checks if To property is set
        /// </summary>
        /// <returns>true if To property is set</returns>
        public bool IsSetTo()
        {
            return this.toField.HasValue;
        }

    }
}
