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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// List of limits that are specific to a given instance type.
    /// </summary>
    public partial class AdditionalLimit
    {
        private string _limitName;
        private List<string> _limitValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property LimitName. <ul> <li> 
        /// <para>
        ///  <c>MaximumNumberOfDataNodesSupported</c> - This attribute only applies to master
        /// nodes and specifies the maximum number of data nodes of a given instance type a master
        /// node can support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MaximumNumberOfDataNodesWithoutMasterNode</c> - This attribute only applies to
        /// data nodes and specifies the maximum number of data nodes of a given instance type
        /// can exist without a master node governing them.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string LimitName
        {
            get { return this._limitName; }
            set { this._limitName = value; }
        }

        // Check to see if LimitName property is set
        internal bool IsSetLimitName()
        {
            return this._limitName != null;
        }

        /// <summary>
        /// Gets and sets the property LimitValues. 
        /// <para>
        ///  The values of the additional instance type limits.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LimitValues
        {
            get { return this._limitValues; }
            set { this._limitValues = value; }
        }

        // Check to see if LimitValues property is set
        internal bool IsSetLimitValues()
        {
            return this._limitValues != null && (this._limitValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}