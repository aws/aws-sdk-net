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
    /// Returns a full description of the launch configurations given the specified names. If no names are specified, then the full
    /// details of all launch configurations are returned. For more information on launch configurations, see Launch Configuration.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class DescribeLaunchConfigurationsResult
    {
        private List<LaunchConfiguration> launchConfigurationsField;
        private string nextTokenField;
        /// <summary>
        /// Gets and sets the LaunchConfigurations property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LaunchConfigurations")]
        public List<LaunchConfiguration> LaunchConfigurations
        {
            get
            {
                if (this.launchConfigurationsField == null)
                {
                    this.launchConfigurationsField = new List<LaunchConfiguration>();
                }
                return this.launchConfigurationsField;
            }
            set { this.launchConfigurationsField = value; }
        }

        /// <summary>
        /// Sets the LaunchConfigurations property
        /// </summary>
        /// <param name="list">LaunchConfigurations property</param>
        /// <returns>this instance</returns>
        public DescribeLaunchConfigurationsResult WithLaunchConfigurations(params LaunchConfiguration[] list)
        {
            foreach (LaunchConfiguration item in list)
            {
                LaunchConfigurations.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if LaunchConfigurations property is set
        /// </summary>
        /// <returns>true if LaunchConfigurations property is set</returns>
        public bool IsSetLaunchConfigurations()
        {
            return (LaunchConfigurations.Count > 0);
        }

        /// <summary>
        /// Gets and sets the NextToken property.
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
        /// <param name="nextToken">NextToken property</param>
        /// <returns>this instance</returns>
        public DescribeLaunchConfigurationsResult WithNextToken(string nextToken)
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
