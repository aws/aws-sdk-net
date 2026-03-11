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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Rules that control which options are available in a child field based on the selected
    /// value in a parent field.
    /// </summary>
    public partial class FieldOptionsCaseRule
    {
        private string _childFieldId;
        private List<ParentChildFieldOptionsMapping> _parentChildFieldOptionsMappings = AWSConfigs.InitializeCollections ? new List<ParentChildFieldOptionsMapping>() : null;
        private string _parentFieldId;

        /// <summary>
        /// Gets and sets the property ChildFieldId. 
        /// <para>
        /// The identifier of the child field whose options are controlled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string ChildFieldId
        {
            get { return this._childFieldId; }
            set { this._childFieldId = value; }
        }

        // Check to see if ChildFieldId property is set
        internal bool IsSetChildFieldId()
        {
            return this._childFieldId != null;
        }

        /// <summary>
        /// Gets and sets the property ParentChildFieldOptionsMappings. 
        /// <para>
        /// A mapping between a parent field option value and child field option values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public List<ParentChildFieldOptionsMapping> ParentChildFieldOptionsMappings
        {
            get { return this._parentChildFieldOptionsMappings; }
            set { this._parentChildFieldOptionsMappings = value; }
        }

        // Check to see if ParentChildFieldOptionsMappings property is set
        internal bool IsSetParentChildFieldOptionsMappings()
        {
            return this._parentChildFieldOptionsMappings != null && (this._parentChildFieldOptionsMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParentFieldId. 
        /// <para>
        /// The identifier of the parent field that controls options.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string ParentFieldId
        {
            get { return this._parentFieldId; }
            set { this._parentFieldId = value; }
        }

        // Check to see if ParentFieldId property is set
        internal bool IsSetParentFieldId()
        {
            return this._parentFieldId != null;
        }

    }
}