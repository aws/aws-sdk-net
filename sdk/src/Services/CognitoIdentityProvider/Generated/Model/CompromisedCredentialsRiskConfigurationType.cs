/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The compromised credentials risk configuration type.
    /// </summary>
    public partial class CompromisedCredentialsRiskConfigurationType
    {
        private CompromisedCredentialsActionsType _actions;
        private List<string> _eventFilter = new List<string>();

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The compromised credentials risk configuration actions.
        /// </para>
        /// </summary>
        public CompromisedCredentialsActionsType Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null;
        }

        /// <summary>
        /// Gets and sets the property EventFilter. 
        /// <para>
        /// Perform the action for these events. The default is to perform all events if no event
        /// filter is specified.
        /// </para>
        /// </summary>
        public List<string> EventFilter
        {
            get { return this._eventFilter; }
            set { this._eventFilter = value; }
        }

        // Check to see if EventFilter property is set
        internal bool IsSetEventFilter()
        {
            return this._eventFilter != null && this._eventFilter.Count > 0; 
        }

    }
}