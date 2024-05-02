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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Provides information about the data schema used with the given dataset.
    /// </summary>
    public partial class DatasetSchema
    {
        private string _inlineDataSchema;

        /// <summary>
        /// Gets and sets the property InlineDataSchema. 
        /// <para>
        /// The data schema used within the given dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000000)]
        public string InlineDataSchema
        {
            get { return this._inlineDataSchema; }
            set { this._inlineDataSchema = value; }
        }

        // Check to see if InlineDataSchema property is set
        internal bool IsSetInlineDataSchema()
        {
            return this._inlineDataSchema != null;
        }

    }
}