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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Data for a user.
    /// </summary>
    public partial class UserData
    {
        /// <summary>
        /// Gets and sets the property ActiveSlotsByChannel. 
        /// <para>
        ///  A map of active slots by channel. The key is a channel name. The value is an integer:
        /// the number of active slots. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> ActiveSlotsByChannel { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the ActiveSlotsByChannel property is set.
        /// </summary>
        internal bool IsSetActiveSlotsByChannel() => this.ActiveSlotsByChannel != null && (this.ActiveSlotsByChannel.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailableSlotsByChannel. 
        /// <para>
        /// A map of available slots by channel. The key is a channel name. The value is an integer:
        /// the available number of slots. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> AvailableSlotsByChannel { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the AvailableSlotsByChannel property is set.
        /// </summary>
        internal bool IsSetAvailableSlotsByChannel() => this.AvailableSlotsByChannel != null && (this.AvailableSlotsByChannel.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Contacts. 
        /// <para>
        /// A list of contact reference information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgentContactReference> Contacts { get; set; } = AWSConfigs.InitializeCollections ? new List<AgentContactReference>() : null;

        /// <summary>
        /// Checks to see if the Contacts property is set.
        /// </summary>
        internal bool IsSetContacts() => this.Contacts != null && (this.Contacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HierarchyPath. 
        /// <para>
        /// Contains information about the levels of a hierarchy group assigned to a user.
        /// </para>
        /// </summary>
        public HierarchyPathReference HierarchyPath { get; set; }

        /// <summary>
        /// Checks to see if the HierarchyPath property is set.
        /// </summary>
        internal bool IsSetHierarchyPath() => this.HierarchyPath != null;

        /// <summary>
        /// Gets and sets the property MaxSlotsByChannel. 
        /// <para>
        /// A map of maximum slots by channel. The key is a channel name. The value is an integer:
        /// the maximum number of slots. This is calculated from <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_MediaConcurrency.html">MediaConcurrency</a>
        /// of the <c>RoutingProfile</c> assigned to the agent. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> MaxSlotsByChannel { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the MaxSlotsByChannel property is set.
        /// </summary>
        internal bool IsSetMaxSlotsByChannel() => this.MaxSlotsByChannel != null && (this.MaxSlotsByChannel.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextStatus. 
        /// <para>
        /// The Next status of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string NextStatus { get; set; }

        /// <summary>
        /// Checks to see if the NextStatus property is set.
        /// </summary>
        internal bool IsSetNextStatus() => this.NextStatus != null;

        /// <summary>
        /// Gets and sets the property RoutingProfile. 
        /// <para>
        /// Information about the routing profile that is assigned to the user.
        /// </para>
        /// </summary>
        public RoutingProfileReference RoutingProfile { get; set; }

        /// <summary>
        /// Checks to see if the RoutingProfile property is set.
        /// </summary>
        internal bool IsSetRoutingProfile() => this.RoutingProfile != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the agent that they manually set in their Contact Control Panel (CCP),
        /// or that the supervisor manually changes in the real-time metrics report.
        /// </para>
        /// </summary>
        public AgentStatusReference Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// Information about the user for the data that is returned. It contains the <c>resourceId</c>
        /// and ARN of the user. 
        /// </para>
        /// </summary>
        public UserReference User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
