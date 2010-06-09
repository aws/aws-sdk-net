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
    ///A metric being used to generate statistics for this customer.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://monitoring.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class Metric
    {
        private string measureNameField;
        private List<Dimension> dimensionsField;
        private string namespaceValueField;

        /// <summary>
        /// Gets and sets the MeasureName property.
        /// The measure name that corresponds to the measure for the gathered metric.
        /// </summary>
        [XmlElementAttribute(ElementName = "MeasureName")]
        public string MeasureName
        {
            get { return this.measureNameField ; }
            set { this.measureNameField= value; }
        }

        /// <summary>
        /// Sets the MeasureName property
        /// </summary>
        /// <param name="measureName">The measure name that corresponds to the measure for the gathered metric.</param>
        /// <returns>this instance</returns>
        public Metric WithMeasureName(string measureName)
        {
            this.measureNameField = measureName;
            return this;
        }

        /// <summary>
        /// Checks if MeasureName property is set
        /// </summary>
        /// <returns>true if MeasureName property is set</returns>
        public bool IsSetMeasureName()
        {
            return  this.measureNameField != null;
        }
        /// <summary>
        /// Gets and sets the Dimensions property.
        /// Amazon CloudWatch organizes data into dimensions. Dimensions are name-value pairs that are
        /// provided by the services feeding data to Amazon CloudWatch.
        /// </summary>
        [XmlElementAttribute(ElementName = "Dimensions")]
        public List<Dimension> Dimensions
        {
            get
            {
                if (this.dimensionsField == null)
                {
                    this.dimensionsField = new List<Dimension>();
                }
                return this.dimensionsField;
            }
            set { this.dimensionsField = value; }
        }

        /// <summary>
        /// Sets the Dimensions property
        /// </summary>
        /// <param name="list">Amazon CloudWatch organizes data into dimensions. Dimensions are name-value pairs that are
        /// provided by the services feeding data to Amazon CloudWatch.</param>
        /// <returns>this instance</returns>
        public Metric WithDimensions(params Dimension[] list)
        {
            foreach (Dimension item in list)
            {
                Dimensions.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Dimensions property is set
        /// </summary>
        /// <returns>true if Dimensions property is set</returns>
        public bool IsSetDimensions()
        {
            return (Dimensions.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Namespace property.
        /// The namespace corresponding to the service of interest. For example, AWS/EC2 represents Amazon EC2.
        /// </summary>
        [XmlElementAttribute(ElementName = "Namespace")]
        public string Namespace
        {
            get { return this.namespaceValueField ; }
            set { this.namespaceValueField= value; }
        }

        /// <summary>
        /// Sets the Namespace property
        /// </summary>
        /// <param name="namespaceValue">The namespace corresponding to the service of interest. For example, AWS/EC2 represents Amazon EC2.</param>
        /// <returns>this instance</returns>
        public Metric WithNamespace(string namespaceValue)
        {
            this.namespaceValueField = namespaceValue;
            return this;
        }

        /// <summary>
        /// Checks if Namespace property is set
        /// </summary>
        /// <returns>true if Namespace property is set</returns>
        public bool IsSetNamespace()
        {
            return  this.namespaceValueField != null;
        }

    }
}
