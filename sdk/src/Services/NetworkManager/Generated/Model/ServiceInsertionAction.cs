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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes the action that the service insertion will take for any segments associated
    /// with it.
    /// </summary>
    public partial class ServiceInsertionAction
    {
        private SegmentActionServiceInsertion _action;
        private SendViaMode _mode;
        private Via _via;
        private WhenSentTo _whenSentTo;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action the service insertion takes for traffic. <c>send-via</c> sends east-west
        /// traffic between attachments. <c>send-to</c> sends north-south traffic to the security
        /// appliance, and then from that to either the Internet or to an on-premesis location.
        /// 
        /// </para>
        /// </summary>
        public SegmentActionServiceInsertion Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Describes the mode packets take for the <c>send-via</c> action. This is not used when
        /// the action is <c>send-to</c>. <c>dual-hop</c> packets traverse attachments in both
        /// the source to the destination core network edges. This mode requires that an inspection
        /// attachment must be present in all Regions of the service insertion-enabled segments.
        /// For <c>single-hop</c>, packets traverse a single intermediate inserted attachment.
        /// You can use <c>EdgeOverride</c> to specify a specific edge to use. 
        /// </para>
        /// </summary>
        public SendViaMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property Via. 
        /// <para>
        /// The list of network function groups and any edge overrides for the chosen service
        /// insertion action. Used for both <c>send-to</c> or <c>send-via</c>.
        /// </para>
        /// </summary>
        public Via Via
        {
            get { return this._via; }
            set { this._via = value; }
        }

        // Check to see if Via property is set
        internal bool IsSetVia()
        {
            return this._via != null;
        }

        /// <summary>
        /// Gets and sets the property WhenSentTo. 
        /// <para>
        /// The list of destination segments if the service insertion action is <c>send-via</c>.
        /// </para>
        /// </summary>
        public WhenSentTo WhenSentTo
        {
            get { return this._whenSentTo; }
            set { this._whenSentTo = value; }
        }

        // Check to see if WhenSentTo property is set
        internal bool IsSetWhenSentTo()
        {
            return this._whenSentTo != null;
        }

    }
}