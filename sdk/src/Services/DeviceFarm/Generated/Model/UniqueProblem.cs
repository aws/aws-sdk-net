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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// A collection of one or more problems, grouped by their result.
    /// </summary>
    public partial class UniqueProblem
    {
        private string _message;
        private List<Problem> _problems = AWSConfigs.InitializeCollections ? new List<Problem>() : null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the unique problems' result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16384)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Problems. 
        /// <para>
        /// Information about the problems.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Problem> Problems
        {
            get { return this._problems; }
            set { this._problems = value; }
        }

        // Check to see if Problems property is set
        internal bool IsSetProblems()
        {
            return this._problems != null && (this._problems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}