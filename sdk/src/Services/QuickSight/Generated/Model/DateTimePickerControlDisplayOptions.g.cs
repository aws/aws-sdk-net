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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The display options of a control.
    /// </summary>
    public partial class DateTimePickerControlDisplayOptions
    {
        /// <summary>
        /// Gets and sets the property DateIconVisibility. 
        /// <para>
        /// The date icon visibility of the <c>DateTimePickerControlDisplayOptions</c>.
        /// </para>
        /// </summary>
        public Visibility DateIconVisibility { get; set; }

        /// <summary>
        /// Checks to see if the DateIconVisibility property is set.
        /// </summary>
        internal bool IsSetDateIconVisibility() => this.DateIconVisibility != null;

        /// <summary>
        /// Gets and sets the property DateTimeFormat. 
        /// <para>
        /// Customize how dates are formatted in controls.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string DateTimeFormat { get; set; }

        /// <summary>
        /// Checks to see if the DateTimeFormat property is set.
        /// </summary>
        internal bool IsSetDateTimeFormat() => this.DateTimeFormat != null;

        /// <summary>
        /// Gets and sets the property HelperTextVisibility. 
        /// <para>
        /// The helper text visibility of the <c>DateTimePickerControlDisplayOptions</c>.
        /// </para>
        /// </summary>
        public Visibility HelperTextVisibility { get; set; }

        /// <summary>
        /// Checks to see if the HelperTextVisibility property is set.
        /// </summary>
        internal bool IsSetHelperTextVisibility() => this.HelperTextVisibility != null;

        /// <summary>
        /// Gets and sets the property InfoIconLabelOptions. 
        /// <para>
        /// The configuration of info icon label options.
        /// </para>
        /// </summary>
        public SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the InfoIconLabelOptions property is set.
        /// </summary>
        internal bool IsSetInfoIconLabelOptions() => this.InfoIconLabelOptions != null;

        /// <summary>
        /// Gets and sets the property TitleOptions. 
        /// <para>
        /// The options to configure the title visibility, name, and font size.
        /// </para>
        /// </summary>
        public LabelOptions TitleOptions { get; set; }

        /// <summary>
        /// Checks to see if the TitleOptions property is set.
        /// </summary>
        internal bool IsSetTitleOptions() => this.TitleOptions != null;
    }
}
