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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// The information for a change request.
    /// </summary>
    public partial class ChangeBatch
    {
        private string _comment;
        private List<Change> _changes = AWSConfigs.InitializeCollections ? new List<Change>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ChangeBatch() { }

        /// <summary>
        /// Instantiates ChangeBatch with the parameterized properties
        /// </summary>
        /// <param name="changes">Information about the changes to make to the record sets.</param>
        public ChangeBatch(List<Change> changes)
        {
            _changes = changes;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        ///  <i>Optional:</i> Any comments you want to include about a change batch request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property Changes. 
        /// <para>
        /// Information about the changes to make to the record sets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<Change> Changes
        {
            get { return this._changes; }
            set { this._changes = value; }
        }

        // Check to see if Changes property is set
        internal bool IsSetChanges()
        {
            return this._changes != null && (this._changes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}