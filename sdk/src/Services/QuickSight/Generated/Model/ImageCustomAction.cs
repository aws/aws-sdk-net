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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A custom action defined on an image.
    /// </summary>
    public partial class ImageCustomAction
    {
        private List<ImageCustomActionOperation> _actionOperations = AWSConfigs.InitializeCollections ? new List<ImageCustomActionOperation>() : null;
        private string _customActionId;
        private string _name;
        private WidgetStatus _status;
        private ImageCustomActionTrigger _trigger;

        /// <summary>
        /// Gets and sets the property ActionOperations. 
        /// <para>
        /// A list of <c>ImageCustomActionOperations</c>.
        /// </para>
        ///  
        /// <para>
        /// This is a union type structure. For this structure to be valid, only one of the attributes
        /// can be defined.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<ImageCustomActionOperation> ActionOperations
        {
            get { return this._actionOperations; }
            set { this._actionOperations = value; }
        }

        // Check to see if ActionOperations property is set
        internal bool IsSetActionOperations()
        {
            return this._actionOperations != null && (this._actionOperations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomActionId. 
        /// <para>
        /// The ID of the custom action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string CustomActionId
        {
            get { return this._customActionId; }
            set { this._customActionId = value; }
        }

        // Check to see if CustomActionId property is set
        internal bool IsSetCustomActionId()
        {
            return this._customActionId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the custom action.
        /// </para>
        /// </summary>
        public WidgetStatus Status
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
        /// Gets and sets the property Trigger. 
        /// <para>
        /// The trigger of the <c>VisualCustomAction</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values are defined as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLICK</c>: Initiates a custom action by a left pointer click on a data point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MENU</c>: Initiates a custom action by right pointer click from the menu.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageCustomActionTrigger Trigger
        {
            get { return this._trigger; }
            set { this._trigger = value; }
        }

        // Check to see if Trigger property is set
        internal bool IsSetTrigger()
        {
            return this._trigger != null;
        }

    }
}