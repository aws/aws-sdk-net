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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The reference of a metadata form.
    /// </summary>
    public partial class MetadataFormReference
    {
        private string _typeIdentifier;
        private string _typeRevision;

        /// <summary>
        /// Gets and sets the property TypeIdentifier. 
        /// <para>
        /// The type ID of the metadata form reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=385)]
        public string TypeIdentifier
        {
            get { return this._typeIdentifier; }
            set { this._typeIdentifier = value; }
        }

        // Check to see if TypeIdentifier property is set
        internal bool IsSetTypeIdentifier()
        {
            return this._typeIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TypeRevision. 
        /// <para>
        /// The type revision of the metadata form reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TypeRevision
        {
            get { return this._typeRevision; }
            set { this._typeRevision = value; }
        }

        // Check to see if TypeRevision property is set
        internal bool IsSetTypeRevision()
        {
            return this._typeRevision != null;
        }

    }
}