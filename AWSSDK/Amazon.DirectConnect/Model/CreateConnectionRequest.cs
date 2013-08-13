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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConnection operation.
    /// <para>Creates a new network connection between the customer network and a specific AWS Direct Connect location.</para> <para>A connection
    /// links your internal network to an AWS Direct Connect location over a standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of
    /// the cable is connected to your router, the other to an AWS Direct Connect router. A Direct Connect location provides access to Amazon Web
    /// Services in the region it is associated with. You can establish connections with AWS Direct Connect locations in multiple regions, but a
    /// connection in one region does not provide connectivity to other regions.</para>
    /// </summary>
    /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreateConnection"/>
    public class CreateConnectionRequest : AmazonWebServiceRequest
    {
        private string offeringId;
        private string connectionName;

        /// <summary>
        /// The ID of the offering. Example: us-west-1_EqSV5_1G Default: None
        ///  
        /// </summary>
        public string OfferingId
        {
            get { return this.offeringId; }
            set { this.offeringId = value; }
        }

        /// <summary>
        /// Sets the OfferingId property
        /// </summary>
        /// <param name="offeringId">The value to set for the OfferingId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateConnectionRequest WithOfferingId(string offeringId)
        {
            this.offeringId = offeringId;
            return this;
        }
            

        // Check to see if OfferingId property is set
        internal bool IsSetOfferingId()
        {
            return this.offeringId != null;       
        }

        /// <summary>
        /// The name of the connection. Example: "<i>1G Connection to AWS</i>" Default: None
        ///  
        /// </summary>
        public string ConnectionName
        {
            get { return this.connectionName; }
            set { this.connectionName = value; }
        }

        /// <summary>
        /// Sets the ConnectionName property
        /// </summary>
        /// <param name="connectionName">The value to set for the ConnectionName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateConnectionRequest WithConnectionName(string connectionName)
        {
            this.connectionName = connectionName;
            return this;
        }
            

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this.connectionName != null;       
        }
    }
}
    
