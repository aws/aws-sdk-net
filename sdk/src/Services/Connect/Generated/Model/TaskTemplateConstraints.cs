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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Describes constraints that apply to the template fields.
    /// </summary>
    public partial class TaskTemplateConstraints
    {
        private List<InvisibleFieldInfo> _invisibleFields = AWSConfigs.InitializeCollections ? new List<InvisibleFieldInfo>() : null;
        private List<ReadOnlyFieldInfo> _readOnlyFields = AWSConfigs.InitializeCollections ? new List<ReadOnlyFieldInfo>() : null;
        private List<RequiredFieldInfo> _requiredFields = AWSConfigs.InitializeCollections ? new List<RequiredFieldInfo>() : null;

        /// <summary>
        /// Gets and sets the property InvisibleFields. 
        /// <para>
        /// Lists the fields that are invisible to agents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InvisibleFieldInfo> InvisibleFields
        {
            get { return this._invisibleFields; }
            set { this._invisibleFields = value; }
        }

        // Check to see if InvisibleFields property is set
        internal bool IsSetInvisibleFields()
        {
            return this._invisibleFields != null && (this._invisibleFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReadOnlyFields. 
        /// <para>
        /// Lists the fields that are read-only to agents, and cannot be edited.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReadOnlyFieldInfo> ReadOnlyFields
        {
            get { return this._readOnlyFields; }
            set { this._readOnlyFields = value; }
        }

        // Check to see if ReadOnlyFields property is set
        internal bool IsSetReadOnlyFields()
        {
            return this._readOnlyFields != null && (this._readOnlyFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequiredFields. 
        /// <para>
        /// Lists the fields that are required to be filled by agents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RequiredFieldInfo> RequiredFields
        {
            get { return this._requiredFields; }
            set { this._requiredFields = value; }
        }

        // Check to see if RequiredFields property is set
        internal bool IsSetRequiredFields()
        {
            return this._requiredFields != null && (this._requiredFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}