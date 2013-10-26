/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedInstances operation.
    /// <para> The DescribeReservedInstances operation describes Reserved Instances that were purchased for use with your account. </para>
    /// </summary>
    public partial class DescribeReservedInstancesRequest : AmazonEC2Request
    {
        private List<string> reservedInstancesIds = new List<string>();
        private List<Filter> filters = new List<Filter>();
        private OfferingTypeValues offeringType;


        /// <summary>
        /// The optional list of Reserved Instance IDs to describe.
        ///  
        /// </summary>
        public List<string> ReservedInstancesIds
        {
            get { return this.reservedInstancesIds; }
            set { this.reservedInstancesIds = value; }
        }

        // Check to see if ReservedInstancesIds property is set
        internal bool IsSetReservedInstancesIds()
        {
            return this.reservedInstancesIds.Count > 0;
        }

        /// <summary>
        /// A list of filters used to match properties for ReservedInstances. For a complete reference to the available filter keys for this operation,
        /// see the <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

        /// <summary>
        /// The Reserved Instance offering type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Heavy Utilization, Medium Utilization, Light Utilization</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public OfferingTypeValues OfferingType
        {
            get { return this.offeringType; }
            set { this.offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this.offeringType != null;
        }

    }
}
    
