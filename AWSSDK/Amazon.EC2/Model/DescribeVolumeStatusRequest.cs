/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2012-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the components of a Describe Volume Status request.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2012-06-15/", IsNullable = false)]
    public class DescribeVolumeStatusRequest
    {
        private List<string> volumeIdField;
        private List<Filter> filterField;
        private string nextTokenField;
        private int? maxResultsField;

        /// <summary>
        /// Gets and sets the list of volume IDs. If not specified, all volumes are described. 
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeSet")]
        public List<string> VolumeId
        {
            get
            {
                if (this.volumeIdField == null)
                {
                    this.volumeIdField = new List<string>();
                }
                return this.volumeIdField;
            }
            set { this.volumeIdField = value; }
        }

        /// <summary>
        /// Sets the list of volume IDs.
        /// </summary>
        /// <param name="list">Volume IDs to describe.</param>
        /// <returns>this instance</returns>
        public DescribeVolumeStatusRequest WithVolumeId(params string[] list)
        {
            foreach (string item in list)
            {
                VolumeId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if VolumeId property is set
        /// </summary>
        /// <returns>true if VolumeId property is set</returns>
        public bool IsSetVolumeId()
        {
            return (VolumeId.Count > 0);
        }


        /// <summary>
        /// Gets and sets the Filter property.
        /// A list of filters used to specify which volumes to return.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.
        /// </summary>
        [XmlElementAttribute(ElementName = "FilterSet")]
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
        /// Sets the Filter property
        /// </summary>
        /// <param name="list">A list of filters used to specify which volumes to return.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        public DescribeVolumeStatusRequest WithFilter(params Filter[] list)
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
        /// Gets and sets a string specifying the next paginated set of results to return. 
        /// </summary>
        public string NextToken
        {
            get { return this.nextTokenField; }
            set { this.nextTokenField = value; }
        }

        /// <summary>
        /// Sets the token specifying the next paginated set of results to return. 
        /// </summary>
        /// <param name="nextToken"></param>
        /// <returns>this instance</returns>
        public DescribeVolumeStatusRequest WithNextToken(string nextToken)
        {
            this.nextTokenField = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if the NextToken property is set.
        /// </summary>
        /// <returns>true if NextToken property is set</returns>
        public bool IsSetNextToken()
        {
            return this.nextTokenField != null;
        }


        /// <summary>
        /// Gets and sets the maximum number of paginated volume items per response.
        /// </summary>
        public int MaxResults
        {
            get { return this.maxResultsField.GetValueOrDefault(); }
            set { this.maxResultsField = value; }
        }

        /// <summary>
        /// Sets the maximum number of paginated volume items per response.
        /// </summary>
        /// <param name="maxResults">Maximum number of paginated volume items</param>
        /// <returns>this instance</returns>
        public DescribeVolumeStatusRequest WithMaxResults(int maxResults)
        {
            this.maxResultsField = maxResults;
            return this;
        }

        /// <summary>
        /// Checks if the MaxResults property is set.
        /// </summary>
        /// <returns>true if MaxResults property is set</returns>
        public bool IsSetMaxResults()
        {
            return this.maxResultsField.HasValue;
        }
    }
}
