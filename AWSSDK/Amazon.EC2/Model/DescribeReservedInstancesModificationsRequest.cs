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

using System.Collections.Generic;
using System.Xml.Serialization;


namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedInstancesModifications operation.
    /// <para> The DescribeReservedInstancesModifications operation describes modifications made to Reserved Instances in your account. </para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeReservedInstancesModificationsRequest : EC2Request
    {
        private List<string> reservedInstancesModificationIdsField;
        private string nextTokenField;
        private List<Filter> filterField;

        /// <summary>
        /// An optional list of Reserved Instances modification IDs to describe.
        ///  
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesModificationIds")]
        public List<string> ReservedInstancesModificationIds
        {
            get
            {
                if (this.reservedInstancesModificationIdsField == null)
                    reservedInstancesModificationIdsField = new List<string>();
                return this.reservedInstancesModificationIdsField;
            }
            set { this.reservedInstancesModificationIdsField = value; }
        }

        // Check to see if ReservedInstancesModificationIds property is set
        internal bool IsSetReservedInstancesModificationIds()
        {
            return this.ReservedInstancesModificationIds.Count > 0;
        }

        /// <summary>
        /// A string specifying the next paginated set of results to return.
        ///  
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
        public string NextToken
        {
            get { return this.nextTokenField; }
            set { this.nextTokenField = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextTokenField != null;
        }

        /// <summary>
        /// A list of filters used to match properties for ReservedInstancesModifications. For a complete reference to the available filter keys for
        /// this operation, see the <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
        ///  
        /// </summary>
        [XmlElementAttribute(ElementName = "Filter")]
        public List<Filter> Filter
        {
            get
            {
                if (this.filterField == null)
                    this.filterField = new List<Filter>();
                return this.filterField;
            }
            set { this.filterField = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.Filter.Count > 0;
        }

    }
}
    
