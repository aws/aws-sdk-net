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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
    /// Represents the state configuration when an action modifies a property of another element
    /// within the same component.
    /// </summary>
    public partial class MutationActionSetStateParameter
    {
        private string _componentName;
        private string _property;
        private ComponentProperty _set;

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component that is being modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property Property. 
        /// <para>
        /// The name of the component property to apply the state configuration to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Property
        {
            get { return this._property; }
            set { this._property = value; }
        }

        // Check to see if Property property is set
        internal bool IsSetProperty()
        {
            return this._property != null;
        }

        /// <summary>
        /// Gets and sets the property Set. 
        /// <para>
        /// The state configuration to assign to the property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComponentProperty Set
        {
            get { return this._set; }
            set { this._set = value; }
        }

        // Check to see if Set property is set
        internal bool IsSetSet()
        {
            return this._set != null;
        }

    }
}