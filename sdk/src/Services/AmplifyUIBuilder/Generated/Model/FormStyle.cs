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
    /// Describes the configuration for the form's style.
    /// </summary>
    public partial class FormStyle
    {
        private FormStyleConfig _horizontalGap;
        private FormStyleConfig _outerPadding;
        private FormStyleConfig _verticalGap;

        /// <summary>
        /// Gets and sets the property HorizontalGap. 
        /// <para>
        /// The spacing for the horizontal gap.
        /// </para>
        /// </summary>
        public FormStyleConfig HorizontalGap
        {
            get { return this._horizontalGap; }
            set { this._horizontalGap = value; }
        }

        // Check to see if HorizontalGap property is set
        internal bool IsSetHorizontalGap()
        {
            return this._horizontalGap != null;
        }

        /// <summary>
        /// Gets and sets the property OuterPadding. 
        /// <para>
        /// The size of the outer padding for the form.
        /// </para>
        /// </summary>
        public FormStyleConfig OuterPadding
        {
            get { return this._outerPadding; }
            set { this._outerPadding = value; }
        }

        // Check to see if OuterPadding property is set
        internal bool IsSetOuterPadding()
        {
            return this._outerPadding != null;
        }

        /// <summary>
        /// Gets and sets the property VerticalGap. 
        /// <para>
        /// The spacing for the vertical gap.
        /// </para>
        /// </summary>
        public FormStyleConfig VerticalGap
        {
            get { return this._verticalGap; }
            set { this._verticalGap = value; }
        }

        // Check to see if VerticalGap property is set
        internal bool IsSetVerticalGap()
        {
            return this._verticalGap != null;
        }

    }
}