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
    /// Limits that are applicable for the given Amazon OpenSearch Service storage type.
    /// </summary>
    public partial class StorageTypeLimit
    {
        private string _limitName;
        private List<string> _limitValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property LimitName. 
        /// <para>
        ///  Name of storage limits that are applicable for the given storage type. If <c>StorageType</c>
        /// is <c>ebs</c>, the following options are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>MinimumVolumeSize</b> - Minimum volume size that is available for the given storage
        /// type. Can be empty if not applicable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MaximumVolumeSize</b> - Maximum volume size that is available for the given storage
        /// type. Can be empty if not applicable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MaximumIops</b> - Maximum amount of IOPS that is available for the given the storage
        /// type. Can be empty if not applicable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MinimumIops</b> - Minimum amount of IOPS that is available for the given the storage
        /// type. Can be empty if not applicable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MaximumThroughput</b> - Maximum amount of throughput that is available for the
        /// given the storage type. Can be empty if not applicable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MinimumThroughput</b> - Minimum amount of throughput that is available for the
        /// given the storage type. Can be empty if not applicable.
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
        /// The limit values.
        /// </para>
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