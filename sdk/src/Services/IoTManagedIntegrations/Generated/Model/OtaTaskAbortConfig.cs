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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Over-the-air (OTA) task abort config.
    /// </summary>
    public partial class OtaTaskAbortConfig
    {
        private List<AbortConfigCriteria> _abortConfigCriteriaList = AWSConfigs.InitializeCollections ? new List<AbortConfigCriteria>() : null;

        /// <summary>
        /// Gets and sets the property AbortConfigCriteriaList. 
        /// <para>
        /// The list of criteria for the abort config.
        /// </para>
        /// </summary>
        public List<AbortConfigCriteria> AbortConfigCriteriaList
        {
            get { return this._abortConfigCriteriaList; }
            set { this._abortConfigCriteriaList = value; }
        }

        // Check to see if AbortConfigCriteriaList property is set
        internal bool IsSetAbortConfigCriteriaList()
        {
            return this._abortConfigCriteriaList != null && (this._abortConfigCriteriaList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}