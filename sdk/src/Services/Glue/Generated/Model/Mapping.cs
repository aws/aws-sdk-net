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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies the mapping of data property keys.
    /// </summary>
    public partial class Mapping
    {
        private List<Mapping> _children = AWSConfigs.InitializeCollections ? new List<Mapping>() : null;
        private bool? _dropped;
        private List<string> _fromPath = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _fromType;
        private string _toKey;
        private string _toType;

        /// <summary>
        /// Gets and sets the property Children. 
        /// <para>
        /// Only applicable to nested data structures. If you want to change the parent structure,
        /// but also one of its children, you can fill out this data strucutre. It is also <c>Mapping</c>,
        /// but its <c>FromPath</c> will be the parent's <c>FromPath</c> plus the <c>FromPath</c>
        /// from this structure.
        /// </para>
        ///  
        /// <para>
        /// For the children part, suppose you have the structure:
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "FromPath": "OuterStructure", "ToKey": "OuterStructure", "ToType": "Struct",
        /// "Dropped": false, "Chidlren": [{ "FromPath": "inner", "ToKey": "inner", "ToType":
        /// "Double", "Dropped": false, }] }</c> 
        /// </para>
        ///  
        /// <para>
        /// You can specify a <c>Mapping</c> that looks like:
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "FromPath": "OuterStructure", "ToKey": "OuterStructure", "ToType": "Struct",
        /// "Dropped": false, "Chidlren": [{ "FromPath": "inner", "ToKey": "inner", "ToType":
        /// "Double", "Dropped": false, }] }</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Mapping> Children
        {
            get { return this._children; }
            set { this._children = value; }
        }

        // Check to see if Children property is set
        internal bool IsSetChildren()
        {
            return this._children != null && (this._children.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Dropped. 
        /// <para>
        /// If true, then the column is removed.
        /// </para>
        /// </summary>
        public bool? Dropped
        {
            get { return this._dropped; }
            set { this._dropped = value; }
        }

        // Check to see if Dropped property is set
        internal bool IsSetDropped()
        {
            return this._dropped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FromPath. 
        /// <para>
        /// The table or column to be modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FromPath
        {
            get { return this._fromPath; }
            set { this._fromPath = value; }
        }

        // Check to see if FromPath property is set
        internal bool IsSetFromPath()
        {
            return this._fromPath != null && (this._fromPath.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FromType. 
        /// <para>
        /// The type of the data to be modified.
        /// </para>
        /// </summary>
        public string FromType
        {
            get { return this._fromType; }
            set { this._fromType = value; }
        }

        // Check to see if FromType property is set
        internal bool IsSetFromType()
        {
            return this._fromType != null;
        }

        /// <summary>
        /// Gets and sets the property ToKey. 
        /// <para>
        /// After the apply mapping, what the name of the column should be. Can be the same as
        /// <c>FromPath</c>.
        /// </para>
        /// </summary>
        public string ToKey
        {
            get { return this._toKey; }
            set { this._toKey = value; }
        }

        // Check to see if ToKey property is set
        internal bool IsSetToKey()
        {
            return this._toKey != null;
        }

        /// <summary>
        /// Gets and sets the property ToType. 
        /// <para>
        /// The data type that the data is to be modified to.
        /// </para>
        /// </summary>
        public string ToType
        {
            get { return this._toType; }
            set { this._toType = value; }
        }

        // Check to see if ToType property is set
        internal bool IsSetToType()
        {
            return this._toType != null;
        }

    }
}