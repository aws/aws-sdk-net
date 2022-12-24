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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Data for a user.
    /// </summary>
    public partial class UserData
    {
        private Dictionary<string, int> _activeSlotsByChannel = new Dictionary<string, int>();
        private Dictionary<string, int> _availableSlotsByChannel = new Dictionary<string, int>();
        private List<AgentContactReference> _contacts = new List<AgentContactReference>();
        private HierarchyPathReference _hierarchyPath;
        private Dictionary<string, int> _maxSlotsByChannel = new Dictionary<string, int>();
        private string _nextStatus;
        private RoutingProfileReference _routingProfile;
        private AgentStatusReference _status;
        private UserReference _user;

        /// <summary>
        /// Gets and sets the property ActiveSlotsByChannel. 
        /// <para>
        ///  A map of active slots by channel. The key is a channel name. The value is an integer:
        /// the number of active slots. 
        /// </para>
        /// </summary>
        public Dictionary<string, int> ActiveSlotsByChannel
        {
            get { return this._activeSlotsByChannel; }
            set { this._activeSlotsByChannel = value; }
        }

        // Check to see if ActiveSlotsByChannel property is set
        internal bool IsSetActiveSlotsByChannel()
        {
            return this._activeSlotsByChannel != null && this._activeSlotsByChannel.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AvailableSlotsByChannel. 
        /// <para>
        /// A map of available slots by channel. The key is a channel name. The value is an integer:
        /// the available number of slots. 
        /// </para>
        /// </summary>
        public Dictionary<string, int> AvailableSlotsByChannel
        {
            get { return this._availableSlotsByChannel; }
            set { this._availableSlotsByChannel = value; }
        }

        // Check to see if AvailableSlotsByChannel property is set
        internal bool IsSetAvailableSlotsByChannel()
        {
            return this._availableSlotsByChannel != null && this._availableSlotsByChannel.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Contacts. 
        /// <para>
        /// A list of contact reference information.
        /// </para>
        /// </summary>
        public List<AgentContactReference> Contacts
        {
            get { return this._contacts; }
            set { this._contacts = value; }
        }

        // Check to see if Contacts property is set
        internal bool IsSetContacts()
        {
            return this._contacts != null && this._contacts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HierarchyPath. 
        /// <para>
        /// Contains information about the levels of a hierarchy group assigned to a user.
        /// </para>
        /// </summary>
        public HierarchyPathReference HierarchyPath
        {
            get { return this._hierarchyPath; }
            set { this._hierarchyPath = value; }
        }

        // Check to see if HierarchyPath property is set
        internal bool IsSetHierarchyPath()
        {
            return this._hierarchyPath != null;
        }

        /// <summary>
        /// Gets and sets the property MaxSlotsByChannel. 
        /// <para>
        /// A map of maximum slots by channel. The key is a channel name. The value is an integer:
        /// the maximum number of slots. This is calculated from <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_MediaConcurrency.html">MediaConcurrency</a>
        /// of the <code>RoutingProfile</code> assigned to the agent. 
        /// </para>
        /// </summary>
        public Dictionary<string, int> MaxSlotsByChannel
        {
            get { return this._maxSlotsByChannel; }
            set { this._maxSlotsByChannel = value; }
        }

        // Check to see if MaxSlotsByChannel property is set
        internal bool IsSetMaxSlotsByChannel()
        {
            return this._maxSlotsByChannel != null && this._maxSlotsByChannel.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextStatus. 
        /// <para>
        /// The Next status of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string NextStatus
        {
            get { return this._nextStatus; }
            set { this._nextStatus = value; }
        }

        // Check to see if NextStatus property is set
        internal bool IsSetNextStatus()
        {
            return this._nextStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingProfile. 
        /// <para>
        /// Information about the routing profile that is assigned to the user.
        /// </para>
        /// </summary>
        public RoutingProfileReference RoutingProfile
        {
            get { return this._routingProfile; }
            set { this._routingProfile = value; }
        }

        // Check to see if RoutingProfile property is set
        internal bool IsSetRoutingProfile()
        {
            return this._routingProfile != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the agent that they manually set in their Contact Control Panel (CCP),
        /// or that the supervisor manually changes in the real-time metrics report.
        /// </para>
        /// </summary>
        public AgentStatusReference Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// Information about the user for the data that is returned. It contains the <code>resourceId</code>
        /// and ARN of the user. 
        /// </para>
        /// </summary>
        public UserReference User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}