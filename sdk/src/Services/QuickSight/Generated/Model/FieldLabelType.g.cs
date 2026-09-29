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
    /// The field label type.
    /// </summary>
    public partial class FieldLabelType
    {
        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// Indicates the field that is targeted by the field label.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string FieldId { get; set; }

        /// <summary>
        /// Checks to see if the FieldId property is set.
        /// </summary>
        internal bool IsSetFieldId() => this.FieldId != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of the field label.
        /// </para>
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}
