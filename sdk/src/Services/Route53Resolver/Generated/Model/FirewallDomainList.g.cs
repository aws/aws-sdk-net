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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// High-level information about a list of firewall domains for use in a <a>FirewallRule</a>.
    /// This is returned by <a>GetFirewallDomainList</a>.
    /// 
    ///  
    /// <para>
    /// To retrieve the domains that are defined for this domain list, call <a>ListFirewallDomains</a>.
    /// </para>
    /// </summary>
    public partial class FirewallDomainList
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall domain list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the domain list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the domain list was created, in Unix time format and Coordinated
        /// Universal Time (UTC). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string defined by you to identify the request. This allows you to retry failed
        /// requests without the risk of running the operation twice. This can be any unique string,
        /// for example, a timestamp. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property DomainCount. 
        /// <para>
        /// The number of domain names that are specified in the domain list.
        /// </para>
        /// </summary>
        public int? DomainCount { get; set; }

        /// <summary>
        /// Checks to see if the DomainCount property is set.
        /// </summary>
        internal bool IsSetDomainCount() => this.DomainCount.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the domain list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ManagedListType. 
        /// <para>
        /// The type of the managed domain list, for example <c>THREAT</c>.
        /// </para>
        /// </summary>
        public DomainListType ManagedListType { get; set; }

        /// <summary>
        /// Checks to see if the ManagedListType property is set.
        /// </summary>
        internal bool IsSetManagedListType() => this.ManagedListType != null;

        /// <summary>
        /// Gets and sets the property ManagedOwnerName. 
        /// <para>
        /// The owner of the list, used only for lists that are not managed by you. For example,
        /// the managed domain list <c>AWSManagedDomainsMalwareDomainList</c> has the managed
        /// owner name <c>Route 53 Resolver DNS Firewall</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ManagedOwnerName { get; set; }

        /// <summary>
        /// Checks to see if the ManagedOwnerName property is set.
        /// </summary>
        internal bool IsSetManagedOwnerName() => this.ManagedOwnerName != null;

        /// <summary>
        /// Gets and sets the property ModificationTime. 
        /// <para>
        /// The date and time that the domain list was last modified, in Unix time format and
        /// Coordinated Universal Time (UTC). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string ModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the ModificationTime property is set.
        /// </summary>
        internal bool IsSetModificationTime() => this.ModificationTime != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the domain list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the domain list. 
        /// </para>
        /// </summary>
        public FirewallDomainListStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Additional information about the status of the list, if available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
