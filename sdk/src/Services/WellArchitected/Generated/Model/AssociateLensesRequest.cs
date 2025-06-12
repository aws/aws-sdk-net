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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateLenses operation.
    /// Associate a lens to a workload.
    /// 
    ///  
    /// <para>
    /// Up to 10 lenses can be associated with a workload in a single API operation. A maximum
    /// of 20 lenses can be associated with a workload.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Disclaimer</b> 
    /// </para>
    ///  
    /// <para>
    /// By accessing and/or applying custom lenses created by another Amazon Web Services
    /// user or account, you acknowledge that custom lenses created by other users and shared
    /// with you are Third Party Content as defined in the Amazon Web Services Customer Agreement.
    /// 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AssociateLensesRequest : AmazonWellArchitectedRequest
    {
        private List<string> _lensAliases = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _workloadId;

        /// <summary>
        /// Gets and sets the property LensAliases.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> LensAliases
        {
            get { return this._lensAliases; }
            set { this._lensAliases = value; }
        }

        // Check to see if LensAliases property is set
        internal bool IsSetLensAliases()
        {
            return this._lensAliases != null && (this._lensAliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string WorkloadId
        {
            get { return this._workloadId; }
            set { this._workloadId = value; }
        }

        // Check to see if WorkloadId property is set
        internal bool IsSetWorkloadId()
        {
            return this._workloadId != null;
        }

    }
}