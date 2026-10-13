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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Mapping> Children { get; set; } = AWSConfigs.InitializeCollections ? new List<Mapping>() : null;

        /// <summary>
        /// Checks to see if the Children property is set.
        /// </summary>
        internal bool IsSetChildren() => this.Children != null && (this.Children.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Dropped. 
        /// <para>
        /// If true, then the column is removed.
        /// </para>
        /// </summary>
        public bool? Dropped { get; set; }

        /// <summary>
        /// Checks to see if the Dropped property is set.
        /// </summary>
        internal bool IsSetDropped() => this.Dropped.HasValue;

        /// <summary>
        /// Gets and sets the property FromPath. 
        /// <para>
        /// The table or column to be modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FromPath { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FromPath property is set.
        /// </summary>
        internal bool IsSetFromPath() => this.FromPath != null && (this.FromPath.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FromType. 
        /// <para>
        /// The type of the data to be modified.
        /// </para>
        /// </summary>
        public string FromType { get; set; }

        /// <summary>
        /// Checks to see if the FromType property is set.
        /// </summary>
        internal bool IsSetFromType() => this.FromType != null;

        /// <summary>
        /// Gets and sets the property ToKey. 
        /// <para>
        /// After the apply mapping, what the name of the column should be. Can be the same as
        /// <c>FromPath</c>.
        /// </para>
        /// </summary>
        public string ToKey { get; set; }

        /// <summary>
        /// Checks to see if the ToKey property is set.
        /// </summary>
        internal bool IsSetToKey() => this.ToKey != null;

        /// <summary>
        /// Gets and sets the property ToType. 
        /// <para>
        /// The data type that the data is to be modified to.
        /// </para>
        /// </summary>
        public string ToType { get; set; }

        /// <summary>
        /// Checks to see if the ToType property is set.
        /// </summary>
        internal bool IsSetToType() => this.ToType != null;
    }
}
