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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateApplications operation. Disassociate
    /// applications from wave.
    /// </summary>
    public partial class DisassociateApplicationsRequest : AmazonMgnRequest
    {
        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// Account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountID { get; set; }

        /// <summary>
        /// Checks to see if the AccountID property is set.
        /// </summary>
        internal bool IsSetAccountID() => this.AccountID != null;

        /// <summary>
        /// Gets and sets the property ApplicationIDs. 
        /// <para>
        /// Application IDs list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<string> ApplicationIDs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApplicationIDs property is set.
        /// </summary>
        internal bool IsSetApplicationIDs() => this.ApplicationIDs != null && (this.ApplicationIDs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WaveID. 
        /// <para>
        /// Wave ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 22, Max = 22)]
        public string WaveID { get; set; }

        /// <summary>
        /// Checks to see if the WaveID property is set.
        /// </summary>
        internal bool IsSetWaveID() => this.WaveID != null;
    }
}
