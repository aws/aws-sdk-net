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
 * Do not modify this file. This file is generated from the supportauthz-2026-06-30.normal.json service model.
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
namespace Amazon.SupportAuthZ.Model
{
    /// <summary>
    /// The set of actions authorized by a permit. Specify either all actions or a list of
    /// specific actions.
    /// </summary>
    public partial class ActionSet
    {
        private List<string> _actions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Unit _allActions;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of specific support actions to authorize. Maximum of 10 actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllActions. 
        /// <para>
        /// Authorizes all available support actions.
        /// </para>
        /// </summary>
        public Unit AllActions
        {
            get { return this._allActions; }
            set { this._allActions = value; }
        }

        // Check to see if AllActions property is set
        internal bool IsSetAllActions()
        {
            return this._allActions != null;
        }

    }
}