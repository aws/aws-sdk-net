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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Returns the scaling activities specified for the given group. If the input list is empty, all the activities
    /// from the past six weeks are returned. Activities will be sorted by completion time. Activities that have no
    /// completion time are considered as using the most recent possible time.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class DescribeScalingActivitiesRequest
    {
        private List<string> activityIdsField;
        private string autoScalingGroupNameField;
        private Decimal? maxRecordsField;
        private string nextTokenField;

        /// <summary>
        /// Gets and sets the ActivityIds property.
        /// List specifying the requested scaling activities using the ID number of each Scaling Activity.
        /// </summary>
        [XmlElementAttribute(ElementName = "ActivityIds")]
        public List<string> ActivityIds
        {
            get
            {
                if (this.activityIdsField == null)
                {
                    this.activityIdsField = new List<string>();
                }
                return this.activityIdsField;
            }
            set { this.activityIdsField = value; }
        }

        /// <summary>
        /// Sets the ActivityIds property
        /// </summary>
        /// <param name="list">List specifying the requested scaling activities using the ID number of each Scaling Activity.</param>
        /// <returns>this instance</returns>
        public DescribeScalingActivitiesRequest WithActivityIds(params string[] list)
        {
            foreach (string item in list)
            {
                ActivityIds.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ActivityIds property is set
        /// </summary>
        /// <returns>true if ActivityIds property is set</returns>
        public bool IsSetActivityIds()
        {
            return (ActivityIds.Count > 0);
        }

        /// <summary>
        /// Gets and sets the AutoScalingGroupName property.
        /// Name of the AutoScalingGroup. AutoScalingGroup must exist within the scope of the caller's Amazon
        /// Web Services account.
        /// </summary>
        [XmlElementAttribute(ElementName = "AutoScalingGroupName")]
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupNameField; }
            set { this.autoScalingGroupNameField = value; }
        }

        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">Name of the AutoScalingGroup. AutoScalingGroup must exist within the scope of the caller's Amazon
        /// Web Services account.</param>
        /// <returns>this instance</returns>
        public DescribeScalingActivitiesRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this.autoScalingGroupNameField = autoScalingGroupName;
            return this;
        }

        /// <summary>
        /// Checks if AutoScalingGroupName property is set
        /// </summary>
        /// <returns>true if AutoScalingGroupName property is set</returns>
        public bool IsSetAutoScalingGroupName()
        {
            return this.autoScalingGroupNameField != null;
        }

        /// <summary>
        /// Gets and sets the MaxRecords property.
        /// The maximum number of scaling activities to return. Default is 100. Value must be greater than 10, less than 100.
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxRecords")]
        public Decimal MaxRecords
        {
            get { return this.maxRecordsField.GetValueOrDefault(); }
            set { this.maxRecordsField = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The maximum number of scaling activities to return. Default is 100. Value must be greater than 10, less than 100.</param>
        /// <returns>this instance</returns>
        public DescribeScalingActivitiesRequest WithMaxRecords(Decimal maxRecords)
        {
            this.maxRecordsField = maxRecords;
            return this;
        }

        /// <summary>
        /// Checks if MaxRecords property is set
        /// </summary>
        /// <returns>true if MaxRecords property is set</returns>
        public bool IsSetMaxRecords()
        {
            return this.maxRecordsField.HasValue;
        }

        /// <summary>
        /// Gets and sets the NextToken property.
        /// String that used to mark the start of the next batch of returned results for pagination.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
        public string NextToken
        {
            get { return this.nextTokenField; }
            set { this.nextTokenField = value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">String that used to mark the start of the next batch of returned results for pagination.</param>
        /// <returns>this instance</returns>
        public DescribeScalingActivitiesRequest WithNextToken(string nextToken)
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
