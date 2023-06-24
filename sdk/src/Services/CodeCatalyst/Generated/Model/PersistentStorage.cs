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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Information about the persistent storage for a Dev Environment.
    /// </summary>
    public partial class PersistentStorage
    {
        private int? _sizeInGiB;

        /// <summary>
        /// Gets and sets the property SizeInGiB. 
        /// <para>
        /// The size of the persistent storage in gigabytes (specifically GiB).
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid values for storage are based on memory sizes in 16GB increments. Valid values
        /// are 16, 32, and 64.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
        public int SizeInGiB
        {
            get { return this._sizeInGiB.GetValueOrDefault(); }
            set { this._sizeInGiB = value; }
        }

        // Check to see if SizeInGiB property is set
        internal bool IsSetSizeInGiB()
        {
            return this._sizeInGiB.HasValue; 
        }

    }
}