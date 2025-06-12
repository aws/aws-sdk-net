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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties that can be applied to a field when connector is being used as a destination.
    /// </summary>
    public partial class DestinationFieldProperties
    {
        private bool? _isCreatable;
        private bool? _isDefaultedOnCreate;
        private bool? _isNullable;
        private bool? _isUpdatable;
        private bool? _isUpsertable;
        private List<string> _supportedWriteOperations = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property IsCreatable. 
        /// <para>
        ///  Specifies if the destination field can be created by the current user. 
        /// </para>
        /// </summary>
        public bool? IsCreatable
        {
            get { return this._isCreatable; }
            set { this._isCreatable = value; }
        }

        // Check to see if IsCreatable property is set
        internal bool IsSetIsCreatable()
        {
            return this._isCreatable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsDefaultedOnCreate. 
        /// <para>
        /// Specifies whether the field can use the default value during a Create operation.
        /// </para>
        /// </summary>
        public bool? IsDefaultedOnCreate
        {
            get { return this._isDefaultedOnCreate; }
            set { this._isDefaultedOnCreate = value; }
        }

        // Check to see if IsDefaultedOnCreate property is set
        internal bool IsSetIsDefaultedOnCreate()
        {
            return this._isDefaultedOnCreate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsNullable. 
        /// <para>
        ///  Specifies if the destination field can have a null value. 
        /// </para>
        /// </summary>
        public bool? IsNullable
        {
            get { return this._isNullable; }
            set { this._isNullable = value; }
        }

        // Check to see if IsNullable property is set
        internal bool IsSetIsNullable()
        {
            return this._isNullable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsUpdatable. 
        /// <para>
        ///  Specifies whether the field can be updated during an <c>UPDATE</c> or <c>UPSERT</c>
        /// write operation. 
        /// </para>
        /// </summary>
        public bool? IsUpdatable
        {
            get { return this._isUpdatable; }
            set { this._isUpdatable = value; }
        }

        // Check to see if IsUpdatable property is set
        internal bool IsSetIsUpdatable()
        {
            return this._isUpdatable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsUpsertable. 
        /// <para>
        ///  Specifies if the flow run can either insert new rows in the destination field if
        /// they do not already exist, or update them if they do. 
        /// </para>
        /// </summary>
        public bool? IsUpsertable
        {
            get { return this._isUpsertable; }
            set { this._isUpsertable = value; }
        }

        // Check to see if IsUpsertable property is set
        internal bool IsSetIsUpsertable()
        {
            return this._isUpsertable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportedWriteOperations. 
        /// <para>
        ///  A list of supported write operations. For each write operation listed, this field
        /// can be used in <c>idFieldNames</c> when that write operation is present as a destination
        /// option. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedWriteOperations
        {
            get { return this._supportedWriteOperations; }
            set { this._supportedWriteOperations = value; }
        }

        // Check to see if SupportedWriteOperations property is set
        internal bool IsSetSupportedWriteOperations()
        {
            return this._supportedWriteOperations != null && (this._supportedWriteOperations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}