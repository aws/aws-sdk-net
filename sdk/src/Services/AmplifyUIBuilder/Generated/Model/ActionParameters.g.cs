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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Represents the event action configuration for an element of a <c>Component</c> or
    /// <c>ComponentChild</c>. Use for the workflow feature in Amplify Studio that allows
    /// you to bind events and actions to components. <c>ActionParameters</c> defines the
    /// action that is performed when an event occurs on the component.
    /// </summary>
    public partial class ActionParameters
    {
        /// <summary>
        /// Gets and sets the property Anchor. 
        /// <para>
        /// The HTML anchor link to the location to open. Specify this value for a navigation
        /// action.
        /// </para>
        /// </summary>
        public ComponentProperty Anchor { get; set; }

        /// <summary>
        /// Checks to see if the Anchor property is set.
        /// </summary>
        internal bool IsSetAnchor() => this.Anchor != null;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// A dictionary of key-value pairs mapping Amplify Studio properties to fields in a data
        /// model. Use when the action performs an operation on an Amplify DataStore model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentProperty> Fields { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentProperty>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Global. 
        /// <para>
        /// Specifies whether the user should be signed out globally. Specify this value for an
        /// auth sign out action.
        /// </para>
        /// </summary>
        public ComponentProperty Global { get; set; }

        /// <summary>
        /// Checks to see if the Global property is set.
        /// </summary>
        internal bool IsSetGlobal() => this.Global != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the component that the <c>ActionParameters</c> apply to.
        /// </para>
        /// </summary>
        public ComponentProperty Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The name of the data model. Use when the action performs an operation on an Amplify
        /// DataStore model.
        /// </para>
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// A key-value pair that specifies the state property name and its initial value.
        /// </para>
        /// </summary>
        public MutationActionSetStateParameter State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The element within the same component to modify when the action occurs.
        /// </para>
        /// </summary>
        public ComponentProperty Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of navigation action. Valid values are <c>url</c> and <c>anchor</c>. This
        /// value is required for a navigation action.
        /// </para>
        /// </summary>
        public ComponentProperty Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to the location to open. Specify this value for a navigation action.
        /// </para>
        /// </summary>
        public ComponentProperty Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
