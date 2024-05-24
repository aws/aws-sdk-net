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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Briefly describes a Fleet Advisor collector.
    /// </summary>
    public partial class CollectorShortInfoResponse
    {
        private string _collectorName;
        private string _collectorReferencedId;

        /// <summary>
        /// Gets and sets the property CollectorName. 
        /// <para>
        /// The name of the Fleet Advisor collector.
        /// </para>
        /// </summary>
        public string CollectorName
        {
            get { return this._collectorName; }
            set { this._collectorName = value; }
        }

        // Check to see if CollectorName property is set
        internal bool IsSetCollectorName()
        {
            return this._collectorName != null;
        }

        /// <summary>
        /// Gets and sets the property CollectorReferencedId. 
        /// <para>
        /// The reference ID of the Fleet Advisor collector.
        /// </para>
        /// </summary>
        public string CollectorReferencedId
        {
            get { return this._collectorReferencedId; }
            set { this._collectorReferencedId = value; }
        }

        // Check to see if CollectorReferencedId property is set
        internal bool IsSetCollectorReferencedId()
        {
            return this._collectorReferencedId != null;
        }

    }
}