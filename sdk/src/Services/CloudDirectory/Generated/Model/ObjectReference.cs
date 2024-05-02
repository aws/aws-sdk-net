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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// The reference that identifies an object.
    /// </summary>
    public partial class ObjectReference
    {
        private string _selector;

        /// <summary>
        /// Gets and sets the property Selector. 
        /// <para>
        /// A path selector supports easy selection of an object by the parent/child links leading
        /// to it from the directory root. Use the link names from each parent/child link to construct
        /// the path. Path selectors start with a slash (/) and link names are separated by slashes.
        /// For more information about paths, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_access_objects.html">Access
        /// Objects</a>. You can identify an object in one of the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>$ObjectIdentifier</i> - An object identifier is an opaque string provided by Amazon
        /// Cloud Directory. When creating objects, the system will provide you with the identifier
        /// of the created object. An object’s identifier is immutable and no two objects will
        /// ever share the same object identifier. To identify an object with ObjectIdentifier,
        /// the ObjectIdentifier must be wrapped in double quotes. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>/some/path</i> - Identifies the object based on path
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>#SomeBatchReference</i> - Identifies the object in a batch call
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Selector
        {
            get { return this._selector; }
            set { this._selector = value; }
        }

        // Check to see if Selector property is set
        internal bool IsSetSelector()
        {
            return this._selector != null;
        }

    }
}