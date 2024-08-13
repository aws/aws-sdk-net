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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Defines the valid range of work unit IDs for querying the execution service.
    /// </summary>
    public partial class WorkUnitRange
    {
        private long? _workUnitIdMax;
        private long? _workUnitIdMin;
        private string _workUnitToken;

        /// <summary>
        /// Gets and sets the property WorkUnitIdMax. 
        /// <para>
        /// Defines the maximum work unit ID in the range. The maximum value is inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? WorkUnitIdMax
        {
            get { return this._workUnitIdMax; }
            set { this._workUnitIdMax = value; }
        }

        // Check to see if WorkUnitIdMax property is set
        internal bool IsSetWorkUnitIdMax()
        {
            return this._workUnitIdMax.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkUnitIdMin. 
        /// <para>
        /// Defines the minimum work unit ID in the range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? WorkUnitIdMin
        {
            get { return this._workUnitIdMin; }
            set { this._workUnitIdMin = value; }
        }

        // Check to see if WorkUnitIdMin property is set
        internal bool IsSetWorkUnitIdMin()
        {
            return this._workUnitIdMin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkUnitToken. 
        /// <para>
        /// A work token used to query the execution service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkUnitToken
        {
            get { return this._workUnitToken; }
            set { this._workUnitToken = value; }
        }

        // Check to see if WorkUnitToken property is set
        internal bool IsSetWorkUnitToken()
        {
            return this._workUnitToken != null;
        }

    }
}