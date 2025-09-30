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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure that contains identifying information for a service level objective entity.
    /// </summary>
    public partial class ServiceLevelObjectiveEntity
    {
        private string _sloArn;
        private string _sloName;

        /// <summary>
        /// Gets and sets the property SloArn. 
        /// <para>
        /// The ARN of the service level objective. The SLO must be provided with ARN for cross-account
        /// access.
        /// </para>
        /// </summary>
        public string SloArn
        {
            get { return this._sloArn; }
            set { this._sloArn = value; }
        }

        // Check to see if SloArn property is set
        internal bool IsSetSloArn()
        {
            return this._sloArn != null;
        }

        /// <summary>
        /// Gets and sets the property SloName. 
        /// <para>
        /// The name of the service level objective.
        /// </para>
        /// </summary>
        public string SloName
        {
            get { return this._sloName; }
            set { this._sloName = value; }
        }

        // Check to see if SloName property is set
        internal bool IsSetSloName()
        {
            return this._sloName != null;
        }

    }
}