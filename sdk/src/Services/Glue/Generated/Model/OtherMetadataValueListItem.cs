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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure containing other metadata for a schema version belonging to the same metadata
    /// key.
    /// </summary>
    public partial class OtherMetadataValueListItem
    {
        private string _createdTime;
        private string _metadataValue;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time at which the entry was created.
        /// </para>
        /// </summary>
        public string CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataValue. 
        /// <para>
        /// The metadata key’s corresponding value for the other metadata belonging to the same
        /// metadata key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string MetadataValue
        {
            get { return this._metadataValue; }
            set { this._metadataValue = value; }
        }

        // Check to see if MetadataValue property is set
        internal bool IsSetMetadataValue()
        {
            return this._metadataValue != null;
        }

    }
}