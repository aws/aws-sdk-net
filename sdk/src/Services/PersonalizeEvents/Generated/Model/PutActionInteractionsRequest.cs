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
 * Do not modify this file. This file is generated from the personalize-events-2018-03-22.normal.json service model.
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
namespace Amazon.PersonalizeEvents.Model
{
    /// <summary>
    /// Container for the parameters to the PutActionInteractions operation.
    /// Records action interaction event data. An <i>action interaction</i> event is an interaction
    /// between a user and an <i>action</i>. For example, a user taking an action, such a
    /// enrolling in a membership program or downloading your app.
    /// 
    ///  
    /// <para>
    ///  For more information about recording action interactions, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/recording-action-interaction-events.html">Recording
    /// action interaction events</a>. For more information about actions in an Actions dataset,
    /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/actions-datasets.html">Actions
    /// dataset</a>.
    /// </para>
    /// </summary>
    public partial class PutActionInteractionsRequest : AmazonPersonalizeEventsRequest
    {
        private List<ActionInteraction> _actionInteractions = AWSConfigs.InitializeCollections ? new List<ActionInteraction>() : null;
        private string _trackingId;

        /// <summary>
        /// Gets and sets the property ActionInteractions. 
        /// <para>
        /// A list of action interaction events from the session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<ActionInteraction> ActionInteractions
        {
            get { return this._actionInteractions; }
            set { this._actionInteractions = value; }
        }

        // Check to see if ActionInteractions property is set
        internal bool IsSetActionInteractions()
        {
            return this._actionInteractions != null && (this._actionInteractions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrackingId. 
        /// <para>
        /// The ID of your action interaction event tracker. When you create an Action interactions
        /// dataset, Amazon Personalize creates an action interaction event tracker for you. For
        /// more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/action-interaction-tracker-id.html">Action
        /// interaction event tracker ID</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TrackingId
        {
            get { return this._trackingId; }
            set { this._trackingId = value; }
        }

        // Check to see if TrackingId property is set
        internal bool IsSetTrackingId()
        {
            return this._trackingId != null;
        }

    }
}