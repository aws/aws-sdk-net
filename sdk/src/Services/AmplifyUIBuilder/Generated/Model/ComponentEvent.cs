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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
        private string _action;
        private string _bindingEvent;
        private ActionParameters _parameters;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform when a specific event is raised.
        /// </para>
        /// </summary>
        public string Action
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
        /// Gets and sets the property BindingEvent. 
        /// <para>
        /// Binds an event to an action on a component. When you specify a <c>bindingEvent</c>,
        /// the event is called when the action is performed.
        /// </para>
        /// </summary>
        public string BindingEvent
        {
            get { return this._bindingEvent; }
            set { this._bindingEvent = value; }
        }

        // Check to see if BindingEvent property is set
        internal bool IsSetBindingEvent()
        {
            return this._bindingEvent != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Describes information about the action.
        /// </para>
        /// </summary>
        public ActionParameters Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

    }
}