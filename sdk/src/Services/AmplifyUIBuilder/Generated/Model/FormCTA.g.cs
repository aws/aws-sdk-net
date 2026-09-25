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
    /// Describes the call to action button configuration for the form.
    /// </summary>
    public partial class FormCTA
    {
        /// <summary>
        /// Gets and sets the property Cancel. 
        /// <para>
        /// Displays a cancel button.
        /// </para>
        /// </summary>
        public FormButton Cancel { get; set; }

        /// <summary>
        /// Checks to see if the Cancel property is set.
        /// </summary>
        internal bool IsSetCancel() => this.Cancel != null;

        /// <summary>
        /// Gets and sets the property Clear. 
        /// <para>
        /// Displays a clear button.
        /// </para>
        /// </summary>
        public FormButton Clear { get; set; }

        /// <summary>
        /// Checks to see if the Clear property is set.
        /// </summary>
        internal bool IsSetClear() => this.Clear != null;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position of the button.
        /// </para>
        /// </summary>
        public FormButtonsPosition Position { get; set; }

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null;

        /// <summary>
        /// Gets and sets the property Submit. 
        /// <para>
        /// Displays a submit button.
        /// </para>
        /// </summary>
        public FormButton Submit { get; set; }

        /// <summary>
        /// Checks to see if the Submit property is set.
        /// </summary>
        internal bool IsSetSubmit() => this.Submit != null;
    }
}
