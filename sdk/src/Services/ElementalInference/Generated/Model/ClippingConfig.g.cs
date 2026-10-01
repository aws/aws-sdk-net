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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// A type of OutputConfig, used when the output in a feed is for the clip feature.
    /// </summary>
    public partial class ClippingConfig
    {
        /// <summary>
        /// Gets and sets the property CallbackMetadata. 
        /// <para>
        /// A string that you want Elemental Inference to always include in the event clipping
        /// metadata for this output. The string might identify the sports event in the source
        /// media, for example. 
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string CallbackMetadata { get; set; }

        /// <summary>
        /// Checks to see if the CallbackMetadata property is set.
        /// </summary>
        internal bool IsSetCallbackMetadata() => this.CallbackMetadata != null;

        /// <summary>
        /// Gets and sets the property DataSourceConfiguration. 
        /// <para>
        /// The data source to map onto this clipping output. This parameter is optional. When
        /// you include this parameter, Elemental Inference reads the event data for the fixture
        /// that you specify, and includes that data in the event clipping metadata for this output.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, Elemental Inference doesn't map a data source onto this
        /// output. 
        /// </para>
        /// </summary>
        public DataSourceConfiguration DataSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetDataSourceConfiguration() => this.DataSourceConfiguration != null;
    }
}
