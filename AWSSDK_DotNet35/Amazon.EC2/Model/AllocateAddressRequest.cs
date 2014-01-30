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
    /// Container for the parameters to the AllocateAddress operation.
    /// <para>Acquires an Elastic IP address.</para> <para>An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. For more
    /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic IP Addresses</a> in the
    /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class AllocateAddressRequest : AmazonEC2Request
    {
        private DomainType domain;


        /// <summary>
        /// Set to <c>vpc</c> to allocate the address for use with instances in a VPC. Default: The address is for use with instances in EC2-Classic.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>vpc, standard</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public DomainType Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;
        }

    }
}
    
