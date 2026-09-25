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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the configuration of an event. You can bind an event and a corresponding
    /// action to a <c>Component</c> or a <c>ComponentChild</c>. A button click is an example
    /// of an event.
    /// </summary>
    public partial class ComponentEvent
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform when a specific event is raised.
        /// </para>
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property BindingEvent. 
        /// <para>
        /// Binds an event to an action on a component. When you specify a <c>bindingEvent</c>,
        /// the event is called when the action is performed.
        /// </para>
        /// </summary>
        public string BindingEvent { get; set; }

        /// <summary>
        /// Checks to see if the BindingEvent property is set.
        /// </summary>
        internal bool IsSetBindingEvent() => this.BindingEvent != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Describes information about the action.
        /// </para>
        /// </summary>
        public ActionParameters Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null;
    }
}
