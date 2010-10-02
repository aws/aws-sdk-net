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
 *  API Version: 2010-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Specifies whether to enable monitoring for the
    ///						Spot Instance.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-06-15/", IsNullable = false)]
    public class MonitoringSpecification
    {    
        private bool? enabledField;

        /// <summary>
        /// Gets and sets the Enabled property.
        /// Enable monitoring for the Spot instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "Enabled")]
        public bool Enabled
        {
            get { return this.enabledField.GetValueOrDefault(); }
            set { this.enabledField = value; }
        }

        /// <summary>
        /// Sets the Enabled property
        /// </summary>
        /// <param name="enabled">Enable monitoring for the Spot instance.</param>
        /// <returns>this instance</returns>
        public MonitoringSpecification WithEnabled(bool enabled)
        {
            this.enabledField = enabled;
            return this;
        }

        /// <summary>
        /// Checks if Enabled property is set
        /// </summary>
        /// <returns>true if Enabled property is set</returns>
        public bool IsSetEnabled()
        {
            return this.enabledField.HasValue;
        }

    }
}
