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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about targets that resolved during the Automation execution.
    /// </summary>
    public partial class ResolvedTargets
    {
        private List<string> _parameterValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _truncated;

        /// <summary>
        /// Gets and sets the property ParameterValues. 
        /// <para>
        /// A list of parameter values sent to targets that resolved during the Automation execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ParameterValues
        {
            get { return this._parameterValues; }
            set { this._parameterValues = value; }
        }

        // Check to see if ParameterValues property is set
        internal bool IsSetParameterValues()
        {
            return this._parameterValues != null && (this._parameterValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Truncated. 
        /// <para>
        /// A boolean value indicating whether the resolved target list is truncated.
        /// </para>
        /// </summary>
        public bool? Truncated
        {
            get { return this._truncated; }
            set { this._truncated = value; }
        }

        // Check to see if Truncated property is set
        internal bool IsSetTruncated()
        {
            return this._truncated.HasValue; 
        }

    }
}