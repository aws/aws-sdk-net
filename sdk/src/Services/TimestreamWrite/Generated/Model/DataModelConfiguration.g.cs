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

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// </summary>
    public partial class DataModelConfiguration
    {
        /// <summary>
        /// Gets and sets the property DataModel. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public DataModel DataModel { get; set; }

        /// <summary>
        /// Checks to see if the DataModel property is set.
        /// </summary>
        internal bool IsSetDataModel() => this.DataModel != null;

        /// <summary>
        /// Gets and sets the property DataModelS3Configuration. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public DataModelS3Configuration DataModelS3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the DataModelS3Configuration property is set.
        /// </summary>
        internal bool IsSetDataModelS3Configuration() => this.DataModelS3Configuration != null;
    }
}
