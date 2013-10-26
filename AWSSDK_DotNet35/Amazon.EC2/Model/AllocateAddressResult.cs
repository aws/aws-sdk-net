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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> Result returned from allocating an Elastic IP. </para>
    /// </summary>
    public partial class AllocateAddressResult : AmazonWebServiceResponse
    {
        
        private string publicIp;
        private DomainType domain;
        private string allocationId;


        /// <summary>
        /// IP address for use with your account.
        ///  
        /// </summary>
        public string PublicIp
        {
            get { return this.publicIp; }
            set { this.publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this.publicIp != null;
        }
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
        public string AllocationId
        {
            get { return this.allocationId; }
            set { this.allocationId = value; }
        }

        // Check to see if AllocationId property is set
        internal bool IsSetAllocationId()
        {
            return this.allocationId != null;
        }
    }
}
