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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Contains advanced options specific to X12 EDI processing, such as splitting large
    /// X12 files into smaller units.
    /// </summary>
    public partial class X12AdvancedOptions
    {
        /// <summary>
        /// Gets and sets the property SplitOptions. 
        /// <para>
        /// Specifies options for splitting X12 EDI files. These options control how large X12
        /// files are divided into smaller, more manageable units.
        /// </para>
        /// </summary>
        public X12SplitOptions SplitOptions { get; set; }

        /// <summary>
        /// Checks to see if the SplitOptions property is set.
        /// </summary>
        internal bool IsSetSplitOptions() => this.SplitOptions != null;

        /// <summary>
        /// Gets and sets the property ValidationOptions. 
        /// <para>
        /// Specifies validation options for X12 EDI processing. These options control how validation
        /// rules are applied during EDI document processing, including custom validation rules
        /// for element length constraints, code list validations, and element requirement checks.
        /// </para>
        /// </summary>
        public X12ValidationOptions ValidationOptions { get; set; }

        /// <summary>
        /// Checks to see if the ValidationOptions property is set.
        /// </summary>
        internal bool IsSetValidationOptions() => this.ValidationOptions != null;
    }
}
