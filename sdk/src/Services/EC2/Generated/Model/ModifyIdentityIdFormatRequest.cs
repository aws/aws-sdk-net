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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyIdentityIdFormat operation.
    /// Modifies the ID format of a resource for a specified IAM user, IAM role, or the root
    /// user for an account; or all IAM users, IAM roles, and the root user for an account.
    /// You can specify that resources should receive longer IDs (17-character IDs) when they
    /// are created. 
    /// 
    ///  
    /// <para>
    /// This request can only be used to modify longer ID settings for resource types that
    /// are within the opt-in period. Resources currently in their opt-in period include:
    /// <c>bundle</c> | <c>conversion-task</c> | <c>customer-gateway</c> | <c>dhcp-options</c>
    /// | <c>elastic-ip-allocation</c> | <c>elastic-ip-association</c> | <c>export-task</c>
    /// | <c>flow-log</c> | <c>image</c> | <c>import-task</c> | <c>internet-gateway</c> |
    /// <c>network-acl</c> | <c>network-acl-association</c> | <c>network-interface</c> | <c>network-interface-attachment</c>
    /// | <c>prefix-list</c> | <c>route-table</c> | <c>route-table-association</c> | <c>security-group</c>
    /// | <c>subnet</c> | <c>subnet-cidr-block-association</c> | <c>vpc</c> | <c>vpc-cidr-block-association</c>
    /// | <c>vpc-endpoint</c> | <c>vpc-peering-connection</c> | <c>vpn-connection</c> | <c>vpn-gateway</c>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
    /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// This setting applies to the principal specified in the request; it does not apply
    /// to the principal that makes the request. 
    /// </para>
    ///  
    /// <para>
    /// Resources created with longer IDs are visible to all IAM roles and users, regardless
    /// of these settings and provided that they have permission to use the relevant <c>Describe</c>
    /// command for the resource type.
    /// </para>
    /// </summary>
    public partial class ModifyIdentityIdFormatRequest : AmazonEC2Request
    {
        private string _principalArn;
        private string _resource;
        private bool? _useLongIds;

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the principal, which can be an IAM user, IAM role, or the root user. Specify
        /// <c>all</c> to modify the ID format for all IAM users, IAM roles, and the root user
        /// of the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrincipalArn
        {
            get { return this._principalArn; }
            set { this._principalArn = value; }
        }

        // Check to see if PrincipalArn property is set
        internal bool IsSetPrincipalArn()
        {
            return this._principalArn != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The type of resource: <c>bundle</c> | <c>conversion-task</c> | <c>customer-gateway</c>
        /// | <c>dhcp-options</c> | <c>elastic-ip-allocation</c> | <c>elastic-ip-association</c>
        /// | <c>export-task</c> | <c>flow-log</c> | <c>image</c> | <c>import-task</c> | <c>internet-gateway</c>
        /// | <c>network-acl</c> | <c>network-acl-association</c> | <c>network-interface</c> |
        /// <c>network-interface-attachment</c> | <c>prefix-list</c> | <c>route-table</c> | <c>route-table-association</c>
        /// | <c>security-group</c> | <c>subnet</c> | <c>subnet-cidr-block-association</c> | <c>vpc</c>
        /// | <c>vpc-cidr-block-association</c> | <c>vpc-endpoint</c> | <c>vpc-peering-connection</c>
        /// | <c>vpn-connection</c> | <c>vpn-gateway</c>.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, use the <c>all-current</c> option to include all resource types that
        /// are currently within their opt-in period for longer IDs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property UseLongIds. 
        /// <para>
        /// Indicates whether the resource should use longer IDs (17-character IDs)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? UseLongIds
        {
            get { return this._useLongIds; }
            set { this._useLongIds = value; }
        }

        // Check to see if UseLongIds property is set
        internal bool IsSetUseLongIds()
        {
            return this._useLongIds.HasValue; 
        }

    }
}