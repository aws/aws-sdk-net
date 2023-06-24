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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Entity that comprises information abount duplicate timestamps in the dataset.
    /// </summary>
    public partial class DuplicateTimestamps
    {
        private int? _totalNumberOfDuplicateTimestamps;

        /// <summary>
        /// Gets and sets the property TotalNumberOfDuplicateTimestamps. 
        /// <para>
        ///  Indicates the total number of duplicate timestamps. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int TotalNumberOfDuplicateTimestamps
        {
            get { return this._totalNumberOfDuplicateTimestamps.GetValueOrDefault(); }
            set { this._totalNumberOfDuplicateTimestamps = value; }
        }

        // Check to see if TotalNumberOfDuplicateTimestamps property is set
        internal bool IsSetTotalNumberOfDuplicateTimestamps()
        {
            return this._totalNumberOfDuplicateTimestamps.HasValue; 
        }

    }
}