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

namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Represents a specific change to be made to a benefit application field.
    /// </summary>
    public partial class Amendment
    {
        /// <summary>
        /// Gets and sets the property FieldPath. 
        /// <para>
        /// The JSON path or field identifier specifying which field in the benefit application
        /// to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FieldPath { get; set; }

        /// <summary>
        /// Checks to see if the FieldPath property is set.
        /// </summary>
        internal bool IsSetFieldPath() => this.FieldPath != null;

        /// <summary>
        /// Gets and sets the property NewValue. 
        /// <para>
        /// The new value to set for the specified field in the benefit application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NewValue { get; set; }

        /// <summary>
        /// Checks to see if the NewValue property is set.
        /// </summary>
        internal bool IsSetNewValue() => this.NewValue != null;
    }
}
