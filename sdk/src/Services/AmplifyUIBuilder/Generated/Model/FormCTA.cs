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
    /// Describes the call to action button configuration for the form.
    /// </summary>
    public partial class FormCTA
    {
        private FormButton _cancel;
        private FormButton _clear;
        private FormButtonsPosition _position;
        private FormButton _submit;

        /// <summary>
        /// Gets and sets the property Cancel. 
        /// <para>
        /// Displays a cancel button.
        /// </para>
        /// </summary>
        public FormButton Cancel
        {
            get { return this._cancel; }
            set { this._cancel = value; }
        }

        // Check to see if Cancel property is set
        internal bool IsSetCancel()
        {
            return this._cancel != null;
        }

        /// <summary>
        /// Gets and sets the property Clear. 
        /// <para>
        /// Displays a clear button.
        /// </para>
        /// </summary>
        public FormButton Clear
        {
            get { return this._clear; }
            set { this._clear = value; }
        }

        // Check to see if Clear property is set
        internal bool IsSetClear()
        {
            return this._clear != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position of the button.
        /// </para>
        /// </summary>
        public FormButtonsPosition Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property Submit. 
        /// <para>
        /// Displays a submit button.
        /// </para>
        /// </summary>
        public FormButton Submit
        {
            get { return this._submit; }
            set { this._submit = value; }
        }

        // Check to see if Submit property is set
        internal bool IsSetSubmit()
        {
            return this._submit != null;
        }

    }
}