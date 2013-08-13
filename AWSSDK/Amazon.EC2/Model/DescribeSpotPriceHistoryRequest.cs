/*******************************************************************************
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
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the Spot Price history.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeSpotPriceHistoryRequest : EC2Request
    {    
        private string startTimeField;
        private string endTimeField;
        private List<string> instanceTypeField;
        private List<string> productDescriptionField;
        private List<Filter> filterField;
        private string availabilityZoneField;
        private int? maxResultsField;
        private string nextTokenField;

        /// <summary>
        /// Start date and time of the Spot Instance price history data.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartTime")]
        public string StartTime
        {
            get { return this.startTimeField; }
            set { this.startTimeField = value; }
        }

        /// <summary>
        /// Sets the start date and time of the Spot Instance price history data.
        /// </summary>
        /// <param name="startTime">Start date and time of the Spot Instance price
        /// history data.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// End date and time of the Spot Instance price history data.
        /// </summary>
        [XmlElementAttribute(ElementName = "EndTime")]
        public string EndTime
        {
            get { return this.endTimeField; }
            set { this.endTimeField = value; }
        }

        /// <summary>
        /// Sets end date and time of the Spot Instance price history data.
        /// </summary>
        /// <param name="endTime">End date and time of the Spot Instance price
        /// history data.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// One ore more instance types to return.
        /// <remarks>
        /// Valid values:
        /// m1.small | m1.large | m1.xlarge |
        /// c1.medium | c1.xlarge | m2.xlarge | m2.2xlarge |
        /// m2.4xlarge | m3.xlarge | m3.2xlarge | t1.micro
        /// </remarks>
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
        /// Sets instance types to return.
        /// </summary>
        /// <param name="list">A list of instance types.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// A list of AMI descriptions to filter by.
        /// </summary>
        /// <remarks>
        /// Valie values: Linux/UNIX | SUSE Linux | Windows |
        /// Linux/UNIX (Amazon VPC) | SUSE Linux (Amazon VPC) |
        /// Windows (Amazon VPC)
        /// </remarks>
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
        /// Sets a list of AMI descriptions to filter by.
        /// </summary>
        /// <param name="list">A list of AMI descriptions</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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

        /// <summary>
        /// A list of filters used to match system-defined properties and user-defined tags associated 
        /// with the specified SpotPriceHistory.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.
        /// </summary>
        [XmlElementAttribute(ElementName = "Filter")]
        public List<Filter> Filter
        {
            get
            {
                if (this.filterField == null)
                {
                    this.filterField = new List<Filter>();
                }
                return this.filterField;
            }
            set { this.filterField = value; }
        }

        /// <summary>
        /// Sets filters used to match system-defined properties and user-defined tags associated 
        /// with the specified SpotPriceHistory.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags associated 
        /// with the specified SpotPriceHistory.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSpotPriceHistoryRequest WithFilter(params Filter[] list)
        {
            foreach (Filter item in list)
            {
                Filter.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Filter property is set
        /// </summary>
        /// <returns>true if Filter property is set</returns>
        public bool IsSetFilter()
        {
            return (Filter.Count > 0);
        }


        /// <summary>
        /// Availability zone to filter the results by.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the availability zone to filter the results by.
        /// </summary>
        /// <param name="availabilityZone">Filters the results by availability zone.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSpotPriceHistoryRequest WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

        /// <summary>
        /// The number of rows to return.
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxResults")]
        public int MaxResults
        {
            get { return this.maxResultsField.GetValueOrDefault(); }
            set { this.maxResultsField = value; }
        }

        /// <summary>
        /// Sets the number of rows to return.
        /// </summary>
        /// <param name="maxResults">Specifies the number of rows to return.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSpotPriceHistoryRequest WithMaxResults(int maxResults)
        {
            this.maxResultsField = maxResults;
            return this;
        }

        /// <summary>
        /// Checks if MaxResults property is set
        /// </summary>
        /// <returns>true if MaxResults property is set</returns>
        public bool IsSetMaxResults()
        {
            return this.maxResultsField.HasValue;
        }

        /// <summary>
        /// Token for the next set of rows to return.
        /// </summary>
        public string NextToken
        {
            get { return this.nextTokenField; }
            set { this.nextTokenField = value; }
        }

        /// <summary>
        /// Sets the token for the next set of rows to return.
        /// </summary>
        /// <param name="nextToken">Specifies the next set of rows to return.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSpotPriceHistoryRequest WithNextToken(string nextToken)
        {
            this.nextTokenField = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if NextToken property is set
        /// </summary>
        /// <returns>true if NextToken property is set</returns>
        public bool IsSetNextToken()
        {
            return this.nextTokenField != null;
        }
    }
}
