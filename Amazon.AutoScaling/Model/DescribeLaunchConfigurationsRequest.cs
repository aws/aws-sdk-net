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
    public class DescribeLaunchConfigurationsRequest
    {
        private List<string> launchConfigurationNamesField;
        private string nextTokenField;
        private Decimal? maxRecordsField;

        /// <summary>
        /// Gets and sets the LaunchConfigurationNames property.
        /// List of the launch configurations for which details are requested. Any specified launch configuration that cannot be
        /// found are omitted from the returned results.
        /// </summary>
        [XmlElementAttribute(ElementName = "LaunchConfigurationNames")]
        public List<string> LaunchConfigurationNames
        {
            get
            {
                if (this.launchConfigurationNamesField == null)
                {
                    this.launchConfigurationNamesField = new List<string>();
                }
                return this.launchConfigurationNamesField;
            }
            set { this.launchConfigurationNamesField = value; }
        }

        /// <summary>
        /// Sets the LaunchConfigurationNames property
        /// </summary>
        /// <param name="list">List of the launch configurations for which details are requested. Any specified launch configuration that cannot be
        /// found are omitted from the returned results.</param>
        /// <returns>this instance</returns>
        public DescribeLaunchConfigurationsRequest WithLaunchConfigurationNames(params string[] list)
        {
            foreach (string item in list)
            {
                LaunchConfigurationNames.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if LaunchConfigurationNames property is set
        /// </summary>
        /// <returns>true if LaunchConfigurationNames property is set</returns>
        public bool IsSetLaunchConfigurationNames()
        {
            return (LaunchConfigurationNames.Count > 0);
        }

        /// <summary>
        /// Gets and sets the NextToken property.
        /// String value that specifies where to start the list of scaling activities for pagination of long results.
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
        /// <param name="nextToken">String value that specifies where to start the list of scaling activities for pagination of long results.</param>
        /// <returns>this instance</returns>
        public DescribeLaunchConfigurationsRequest WithNextToken(string nextToken)
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

        /// <summary>
        /// Gets and sets the MaxRecords property.
        /// The maximum number of scaling activities to return. Default is 100.
        /// Value must be greater than 10 and less than 100.
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
        /// <param name="maxRecords">The maximum number of scaling activities to return. Default is 100.
        /// Value must be greater than 10 and less than 100.</param>
        /// <returns>this instance</returns>
        public DescribeLaunchConfigurationsRequest WithMaxRecords(Decimal maxRecords)
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

    }
}
