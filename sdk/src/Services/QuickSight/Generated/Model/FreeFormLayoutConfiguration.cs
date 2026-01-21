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
    /// The configuration of a free-form layout.
    /// </summary>
    public partial class FreeFormLayoutConfiguration
    {
        private FreeFormLayoutCanvasSizeOptions _canvasSizeOptions;
        private List<FreeFormLayoutElement> _elements = AWSConfigs.InitializeCollections ? new List<FreeFormLayoutElement>() : null;
        private List<SheetLayoutGroup> _groups = AWSConfigs.InitializeCollections ? new List<SheetLayoutGroup>() : null;

        /// <summary>
        /// Gets and sets the property CanvasSizeOptions.
        /// </summary>
        public FreeFormLayoutCanvasSizeOptions CanvasSizeOptions
        {
            get { return this._canvasSizeOptions; }
            set { this._canvasSizeOptions = value; }
        }

        // Check to see if CanvasSizeOptions property is set
        internal bool IsSetCanvasSizeOptions()
        {
            return this._canvasSizeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Elements. 
        /// <para>
        /// The elements that are included in a free-form layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=430)]
        public List<FreeFormLayoutElement> Elements
        {
            get { return this._elements; }
            set { this._elements = value; }
        }

        // Check to see if Elements property is set
        internal bool IsSetElements()
        {
            return this._elements != null && (this._elements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The groups that are included in a free-form layout.
        /// </para>
        /// </summary>
        [AWSProperty(Max=215)]
        public List<SheetLayoutGroup> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && (this._groups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}