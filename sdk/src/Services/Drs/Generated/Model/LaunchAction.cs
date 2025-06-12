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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Launch action.
    /// </summary>
    public partial class LaunchAction
    {
        private string _actionCode;
        private string _actionId;
        private string _actionVersion;
        private bool? _active;
        private LaunchActionCategory _category;
        private string _description;
        private string _name;
        private bool? _optional;
        private int? _order;
        private Dictionary<string, LaunchActionParameter> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, LaunchActionParameter>() : null;
        private LaunchActionType _type;

        /// <summary>
        /// Gets and sets the property ActionCode. 
        /// <para>
        /// Launch action code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string ActionCode
        {
            get { return this._actionCode; }
            set { this._actionCode = value; }
        }

        // Check to see if ActionCode property is set
        internal bool IsSetActionCode()
        {
            return this._actionCode != null;
        }

        /// <summary>
        /// Gets and sets the property ActionId.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ActionId
        {
            get { return this._actionId; }
            set { this._actionId = value; }
        }

        // Check to see if ActionId property is set
        internal bool IsSetActionId()
        {
            return this._actionId != null;
        }

        /// <summary>
        /// Gets and sets the property ActionVersion.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string ActionVersion
        {
            get { return this._actionVersion; }
            set { this._actionVersion = value; }
        }

        // Check to see if ActionVersion property is set
        internal bool IsSetActionVersion()
        {
            return this._actionVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Whether the launch action is active.
        /// </para>
        /// </summary>
        public bool? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Category.
        /// </summary>
        public LaunchActionCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Description.
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
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Optional. 
        /// <para>
        /// Whether the launch will not be marked as failed if this action fails.
        /// </para>
        /// </summary>
        public bool? Optional
        {
            get { return this._optional; }
            set { this._optional = value; }
        }

        // Check to see if Optional property is set
        internal bool IsSetOptional()
        {
            return this._optional.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Order.
        /// </summary>
        [AWSProperty(Min=2, Max=10000)]
        public int? Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Parameters.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public Dictionary<string, LaunchActionParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Launch action type.
        /// </para>
        /// </summary>
        public LaunchActionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}