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
    /// <summary>
    /// Request to describe historical pricing for Spot
    /// Instances.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-06-15/", IsNullable = false)]
    public class DescribeSpotPriceHistoryRequest
    {    
        private string startTimeField;
        private string endTimeField;
        private List<string> instanceTypeField;
        private List<string> productDescriptionField;

        /// <summary>
        /// Gets and sets the StartTime property.
        /// Start date and time of the Spot Instance price
        /// history data.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartTime")]
        public string StartTime
        {
            get { return this.startTimeField; }
            set { this.startTimeField = value; }
        }

        /// <summary>
        /// Sets the StartTime property
        /// </summary>
        /// <param name="startTime">Start date and time of the Spot Instance price
        /// history data.</param>
        /// <returns>this instance</returns>
        public DescribeSpotPriceHistoryRequest WithStartTime(string startTime)
        {
            this.startTimeField = startTime;
            return this;
        }

        /// <summary>
        /// Checks if StartTime property is set
        /// </summary>
        /// <returns>true if StartTime property is set</returns>
        public bool IsSetStartTime()
        {
            return this.startTimeField != null;
        }

        /// <summary>
        /// Gets and sets the EndTime property.
        /// End date and time of the Spot Instance price
        /// history data.
        /// </summary>
        [XmlElementAttribute(ElementName = "EndTime")]
        public string EndTime
        {
            get { return this.endTimeField; }
            set { this.endTimeField = value; }
        }

        /// <summary>
        /// Sets the EndTime property
        /// </summary>
        /// <param name="endTime">End date and time of the Spot Instance price
        /// history data.</param>
        /// <returns>this instance</returns>
        public DescribeSpotPriceHistoryRequest WithEndTime(string endTime)
        {
            this.endTimeField = endTime;
            return this;
        }

        /// <summary>
        /// Checks if EndTime property is set
        /// </summary>
        /// <returns>true if EndTime property is set</returns>
        public bool IsSetEndTime()
        {
            return this.endTimeField != null;
        }

        /// <summary>
        /// Gets and sets the InstanceType property.
        /// A list of instance types.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceType")]
        public List<string> InstanceType
        {
            get
            {
                if (this.instanceTypeField == null)
                {
                    this.instanceTypeField = new List<string>();
                }
                return this.instanceTypeField;
            }
            set { this.instanceTypeField = value; }
        }

        /// <summary>
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="list">A list of instance types.</param>
        /// <returns>this instance</returns>
        public DescribeSpotPriceHistoryRequest WithInstanceType(params string[] list)
        {
            foreach (string item in list)
            {
                InstanceType.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if InstanceType property is set
        /// </summary>
        /// <returns>true if InstanceType property is set</returns>
        public bool IsSetInstanceType()
        {
            return (InstanceType.Count > 0);
        }

        /// <summary>
        /// Gets and sets the ProductDescription property.
        /// A list of AMI descriptions
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductDescription")]
        public List<string> ProductDescription
        {
            get
            {
                if (this.productDescriptionField == null)
                {
                    this.productDescriptionField = new List<string>();
                }
                return this.productDescriptionField;
            }
            set { this.productDescriptionField = value; }
        }

        /// <summary>
        /// Sets the ProductDescription property
        /// </summary>
        /// <param name="list">A list of AMI descriptions</param>
        /// <returns>this instance</returns>
        public DescribeSpotPriceHistoryRequest WithProductDescription(params string[] list)
        {
            foreach (string item in list)
            {
                ProductDescription.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ProductDescription property is set
        /// </summary>
        /// <returns>true if ProductDescription property is set</returns>
        public bool IsSetProductDescription()
        {
            return (ProductDescription.Count > 0);
        }

    }
}
