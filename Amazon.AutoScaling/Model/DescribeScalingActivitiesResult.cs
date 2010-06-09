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
    public class DescribeScalingActivitiesResult
    {
        private List<Activity> activitiesField;
        private string nextTokenField;
        /// <summary>
        /// Gets and sets the Activities property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Activities")]
        public List<Activity> Activities
        {
            get
            {
                if (this.activitiesField == null)
                {
                    this.activitiesField = new List<Activity>();
                }
                return this.activitiesField;
            }
            set { this.activitiesField = value; }
        }

        /// <summary>
        /// Sets the Activities property
        /// </summary>
        /// <param name="list">Activities property</param>
        /// <returns>this instance</returns>
        public DescribeScalingActivitiesResult WithActivities(params Activity[] list)
        {
            foreach (Activity item in list)
            {
                Activities.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Activities property is set
        /// </summary>
        /// <returns>true if Activities property is set</returns>
        public bool IsSetActivities()
        {
            return (Activities.Count > 0);
        }

        /// <summary>
        /// Gets and sets the NextToken property.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
        public string NextToken
        {
            get { return this.nextTokenField ; }
            set { this.nextTokenField= value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">NextToken property</param>
        /// <returns>this instance</returns>
        public DescribeScalingActivitiesResult WithNextToken(string nextToken)
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
            return  this.nextTokenField != null;
        }

    }
}
