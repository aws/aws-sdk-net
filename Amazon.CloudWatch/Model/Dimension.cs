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
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.CloudWatch.Model
{
    ///<summary>
    ///Amazon CloudWatch organizes data into dimensions. Dimensions are name-value pairs that are
    ///provided by the services feeding data to Amazon CloudWatch. Dimensions can be used to filter result
    ///sets returned by Amazon CloudWatch queries.
    ///
    ///For more information, see http://docs.amazonwebservices.com/AmazonCloudWatch/latest/DeveloperGuide/arch-Amazon-CloudWatch-dimensions.html.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://monitoring.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class Dimension
    {
        private string nameField;
        private string valueField;

        /// <summary>
        /// Gets and sets the Name property.
        /// Name of the dimension.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField ; }
            set { this.nameField= value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">Name of the dimension.</param>
        /// <returns>this instance</returns>
        public Dimension WithName(string name)
        {
            this.nameField = name;
            return this;
        }

        /// <summary>
        /// Checks if Name property is set
        /// </summary>
        /// <returns>true if Name property is set</returns>
        public bool IsSetName()
        {
            return  this.nameField != null;
        }

        /// <summary>
        /// Gets and sets the Value property.
        /// Value of a dimension.
        /// </summary>
        [XmlElementAttribute(ElementName = "Value")]
        public string Value
        {
            get { return this.valueField ; }
            set { this.valueField= value; }
        }

        /// <summary>
        /// Sets the Value property
        /// </summary>
        /// <param name="value">Value of a dimension.</param>
        /// <returns>this instance</returns>
        public Dimension WithValue(string value)
        {
            this.valueField = value;
            return this;
        }

        /// <summary>
        /// Checks if Value property is set
        /// </summary>
        /// <returns>true if Value property is set</returns>
        public bool IsSetValue()
        {
            return  this.valueField != null;
        }

    }
}
