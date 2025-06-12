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
    /// The definition for a <c>TopicVisual</c>.
    /// </summary>
    public partial class TopicVisual
    {
        private TopicIR _ir;
        private VisualRole _role;
        private List<TopicVisual> _supportingVisuals = AWSConfigs.InitializeCollections ? new List<TopicVisual>() : null;
        private string _visualId;

        /// <summary>
        /// Gets and sets the property Ir. 
        /// <para>
        /// The ir for the <c>TopicVisual</c>.
        /// </para>
        /// </summary>
        public TopicIR Ir
        {
            get { return this._ir; }
            set { this._ir = value; }
        }

        // Check to see if Ir property is set
        internal bool IsSetIr()
        {
            return this._ir != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The role for the <c>TopicVisual</c>.
        /// </para>
        /// </summary>
        public VisualRole Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property SupportingVisuals. 
        /// <para>
        /// The supporting visuals for the <c>TopicVisual</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicVisual> SupportingVisuals
        {
            get { return this._supportingVisuals; }
            set { this._supportingVisuals = value; }
        }

        // Check to see if SupportingVisuals property is set
        internal bool IsSetSupportingVisuals()
        {
            return this._supportingVisuals != null && (this._supportingVisuals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VisualId. 
        /// <para>
        /// The visual ID for the <c>TopicVisual</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string VisualId
        {
            get { return this._visualId; }
            set { this._visualId = value; }
        }

        // Check to see if VisualId property is set
        internal bool IsSetVisualId()
        {
            return this._visualId != null;
        }

    }
}