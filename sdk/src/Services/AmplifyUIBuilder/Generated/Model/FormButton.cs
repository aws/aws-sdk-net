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
    /// Describes the configuration for a button UI element that is a part of a form.
    /// </summary>
    public partial class FormButton
    {
        private string _children;
        private bool? _excluded;
        private FieldPosition _position;

        /// <summary>
        /// Gets and sets the property Children. 
        /// <para>
        /// Describes the button's properties.
        /// </para>
        /// </summary>
        public string Children
        {
            get { return this._children; }
            set { this._children = value; }
        }

        // Check to see if Children property is set
        internal bool IsSetChildren()
        {
            return this._children != null;
        }

        /// <summary>
        /// Gets and sets the property Excluded. 
        /// <para>
        /// Specifies whether the button is visible on the form.
        /// </para>
        /// </summary>
        public bool? Excluded
        {
            get { return this._excluded; }
            set { this._excluded = value; }
        }

        // Check to see if Excluded property is set
        internal bool IsSetExcluded()
        {
            return this._excluded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position of the button.
        /// </para>
        /// </summary>
        public FieldPosition Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

    }
}