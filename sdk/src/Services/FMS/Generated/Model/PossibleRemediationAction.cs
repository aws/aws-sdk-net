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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// A list of remediation actions.
    /// </summary>
    public partial class PossibleRemediationAction
    {
        private string _description;
        private bool? _isDefaultAction;
        private List<RemediationActionWithOrder> _orderedRemediationActions = AWSConfigs.InitializeCollections ? new List<RemediationActionWithOrder>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the list of remediation actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefaultAction. 
        /// <para>
        /// Information about whether an action is taken by default.
        /// </para>
        /// </summary>
        public bool? IsDefaultAction
        {
            get { return this._isDefaultAction; }
            set { this._isDefaultAction = value; }
        }

        // Check to see if IsDefaultAction property is set
        internal bool IsSetIsDefaultAction()
        {
            return this._isDefaultAction.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrderedRemediationActions. 
        /// <para>
        /// The ordered list of remediation actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RemediationActionWithOrder> OrderedRemediationActions
        {
            get { return this._orderedRemediationActions; }
            set { this._orderedRemediationActions = value; }
        }

        // Check to see if OrderedRemediationActions property is set
        internal bool IsSetOrderedRemediationActions()
        {
            return this._orderedRemediationActions != null && (this._orderedRemediationActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}