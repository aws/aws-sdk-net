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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes the capacity for a fleet.
    /// </summary>
    public partial class ComputeCapacity
    {
        private int? _desiredInstances;

        /// <summary>
        /// Gets and sets the property DesiredInstances. 
        /// <para>
        /// The desired number of streaming instances.
        /// </para>
        /// </summary>
        public int DesiredInstances
        {
            get { return this._desiredInstances.GetValueOrDefault(); }
            set { this._desiredInstances = value; }
        }

        // Check to see if DesiredInstances property is set
        internal bool IsSetDesiredInstances()
        {
            return this._desiredInstances.HasValue; 
        }

    }
}