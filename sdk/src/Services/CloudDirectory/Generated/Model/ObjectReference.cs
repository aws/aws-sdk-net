/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Reference that identifies an object.
    /// </summary>
    public partial class ObjectReference
    {
        private string _selector;

        /// <summary>
        /// Gets and sets the property Selector. 
        /// <para>
        /// Allows you to specify an object. You can identify an object in one of the following
        /// ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>$ObjectIdentifier</i> - Identifies the object by <code>ObjectIdentifier</code>
        /// 
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