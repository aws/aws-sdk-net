/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the AddIpRoutes operation.
    /// If the DNS server for your on-premises domain uses a publicly addressable IP address,
    /// you must add a CIDR address block to correctly route traffic to and from your Microsoft
    /// AD on Amazon Web Services. <i>AddIpRoutes</i> adds this address block. You can also
    /// use <i>AddIpRoutes</i> to facilitate routing traffic that uses public IP ranges from
    /// your Microsoft AD on AWS to a peer VPC. 
    /// 
    ///  
    /// <para>
    /// Before you call <i>AddIpRoutes</i>, ensure that all of the required permissions have
    /// been explicitly granted through a policy. For details about what permissions are required
    /// to run the <i>AddIpRoutes</i> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">AWS
    /// Directory Service API Permissions: Actions, Resources, and Conditions Reference</a>.
    /// </para>
    /// </summary>
    public partial class AddIpRoutesRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private List<IpRoute> _ipRoutes = new List<IpRoute>();
        private bool? _updateSecurityGroupForDirectoryControllers;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// Identifier (ID) of the directory to which to add the address block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property IpRoutes. 
        /// <para>
        /// IP address blocks, using CIDR format, of the traffic to route. This is often the IP
        /// address block of the DNS server used for your on-premises domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<IpRoute> IpRoutes
        {
            get { return this._ipRoutes; }
            set { this._ipRoutes = value; }
        }

        // Check to see if IpRoutes property is set
        internal bool IsSetIpRoutes()
        {
            return this._ipRoutes != null && this._ipRoutes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdateSecurityGroupForDirectoryControllers. 
        /// <para>
        /// If set to true, updates the inbound and outbound rules of the security group that
        /// has the description: "AWS created security group for <i>directory ID</i> directory
        /// controllers." Following are the new rules: 
        /// </para>
        ///  
        /// <para>
        /// Inbound:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Type: Custom UDP Rule, Protocol: UDP, Range: 88, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: Custom UDP Rule, Protocol: UDP, Range: 123, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: Custom UDP Rule, Protocol: UDP, Range: 138, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: Custom UDP Rule, Protocol: UDP, Range: 389, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: Custom UDP Rule, Protocol: UDP, Range: 464, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: Custom UDP Rule, Protocol: UDP, Range: 445, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: Custom TCP Rule, Protocol: TCP, Range: 88, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: Custom TCP Rule, Protocol: TCP, Range: 135, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: Custom TCP Rule, Protocol: TCP, Range: 445, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: Custom TCP Rule, Protocol: TCP, Range: 464, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: Custom TCP Rule, Protocol: TCP, Range: 636, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: Custom TCP Rule, Protocol: TCP, Range: 1024-65535, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: Custom TCP Rule, Protocol: TCP, Range: 3268-33269, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: DNS (UDP), Protocol: UDP, Range: 53, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: DNS (TCP), Protocol: TCP, Range: 53, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: LDAP, Protocol: TCP, Range: 389, Source: 0.0.0.0/0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type: All ICMP, Protocol: All, Range: N/A, Source: 0.0.0.0/0
        /// </para>
        ///  </li> </ul>  
        /// <para>
        /// Outbound:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Type: All traffic, Protocol: All, Range: All, Destination: 0.0.0.0/0
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// These security rules impact an internal network interface that is not exposed publicly.
        /// </para>
        /// </summary>
        public bool UpdateSecurityGroupForDirectoryControllers
        {
            get { return this._updateSecurityGroupForDirectoryControllers.GetValueOrDefault(); }
            set { this._updateSecurityGroupForDirectoryControllers = value; }
        }

        // Check to see if UpdateSecurityGroupForDirectoryControllers property is set
        internal bool IsSetUpdateSecurityGroupForDirectoryControllers()
        {
            return this._updateSecurityGroupForDirectoryControllers.HasValue; 
        }

    }
}