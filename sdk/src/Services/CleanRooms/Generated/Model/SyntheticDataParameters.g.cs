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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The parameters that control how synthetic data is generated, including privacy settings,
    /// column classifications, and other configuration options that affect the data synthesis
    /// process.
    /// </summary>
    public partial class SyntheticDataParameters
    {
        /// <summary>
        /// Gets and sets the property MlSyntheticDataParameters. 
        /// <para>
        /// The machine learning-specific parameters for synthetic data generation.
        /// </para>
        /// </summary>
        public MLSyntheticDataParameters MlSyntheticDataParameters { get; set; }

        /// <summary>
        /// Checks to see if the MlSyntheticDataParameters property is set.
        /// </summary>
        internal bool IsSetMlSyntheticDataParameters() => this.MlSyntheticDataParameters != null;
    }
}
