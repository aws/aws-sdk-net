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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Custom metadata that is associated to predefined attributes to control behavior in
    /// upstream services, such as controlling how a predefined attribute should be displayed
    /// in the Connect Customer admin website.
    /// </summary>
    public partial class PredefinedAttributeConfiguration
    {
        /// <summary>
        /// Gets and sets the property EnableValueValidationOnAssociation. 
        /// <para>
        /// When this parameter is set to true, Connect Customer enforces strict validation on
        /// the specific values, if the values are predefined in attributes. The contact will
        /// store only valid and predefined values for teh predefined attribute key.
        /// </para>
        /// </summary>
        public bool? EnableValueValidationOnAssociation { get; set; }

        /// <summary>
        /// Checks to see if the EnableValueValidationOnAssociation property is set.
        /// </summary>
        internal bool IsSetEnableValueValidationOnAssociation() => this.EnableValueValidationOnAssociation.HasValue;

        /// <summary>
        /// Gets and sets the property IsReadOnly. 
        /// <para>
        /// A boolean flag used to indicate whether a predefined attribute should be displayed
        /// in the Connect Customer admin website.
        /// </para>
        /// </summary>
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Checks to see if the IsReadOnly property is set.
        /// </summary>
        internal bool IsSetIsReadOnly() => this.IsReadOnly.HasValue;
    }
}
