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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// The configuration of a Dataset. Set one member, which determines the dataset type.
    /// </summary>
    public partial class DatasetConfig
    {
        /// <summary>
        /// Gets and sets the property MedicalCoding. 
        /// <para>
        /// The configuration of a medical coding dataset, which tailors medical coding jobs to
        /// your coded examples.
        /// </para>
        /// </summary>
        public MedicalCodingDatasetConfig MedicalCoding { get; set; }

        /// <summary>
        /// Checks to see if the MedicalCoding property is set.
        /// </summary>
        internal bool IsSetMedicalCoding() => this.MedicalCoding != null;
    }
}
