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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Configuration for selecting and handling source log groups for centralization.
    /// </summary>
    public partial class SourceLogsConfiguration
    {
        /// <summary>
        /// Gets and sets the property CentralizeWithDataProtection. 
        /// <para>
        /// Specifies whether this centralization rule centralizes log events with data protection
        /// applied. If you don't specify this setting, or you set it to <c>DISABLED</c>, the
        /// rule centralizes the original log events, including any sensitive data that a data
        /// protection policy on the source log group masks.
        /// </para>
        ///  
        /// <para>
        /// When you set this to <c>ENABLED</c>, the rule centralizes the same masked data that
        /// anyone in the source account without the <c>logs:Unmask</c> permission sees. The rule
        /// doesn't copy the original values to the destination, so you can't unmask them in the
        /// destination account. The rule centralizes log events from source log groups that don't
        /// have a data protection policy without changes.
        /// </para>
        ///  
        /// <para>
        /// The setting applies only to log events that the rule centralizes after you enable
        /// it. It doesn't change log events that the rule already centralized.
        /// </para>
        /// </summary>
        public CentralizeWithDataProtection CentralizeWithDataProtection { get; set; }

        /// <summary>
        /// Checks to see if the CentralizeWithDataProtection property is set.
        /// </summary>
        internal bool IsSetCentralizeWithDataProtection() => this.CentralizeWithDataProtection != null;

        /// <summary>
        /// Gets and sets the property DataSourceSelectionCriteria. 
        /// <para>
        /// The selection criteria that specifies which data sources to centralize. The selection
        /// criteria uses the same filter expression format as <c>LogGroupSelectionCriteria</c>,
        /// but operates on <c>DataSourceName</c> and <c>DataSourceType</c> operands. When both
        /// <c>LogGroupSelectionCriteria</c> and <c>DataSourceSelectionCriteria</c> are specified,
        /// a log event must match both criteria to be centralized.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string DataSourceSelectionCriteria { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceSelectionCriteria property is set.
        /// </summary>
        internal bool IsSetDataSourceSelectionCriteria() => this.DataSourceSelectionCriteria != null;

        /// <summary>
        /// Gets and sets the property EncryptedLogGroupStrategy. 
        /// <para>
        /// A strategy determining whether to centralize source log groups that are encrypted
        /// with customer managed KMS keys (CMK). ALLOW will consider CMK encrypted source log
        /// groups for centralization while SKIP will skip CMK encrypted source log groups from
        /// centralization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncryptedLogGroupStrategy EncryptedLogGroupStrategy { get; set; }

        /// <summary>
        /// Checks to see if the EncryptedLogGroupStrategy property is set.
        /// </summary>
        internal bool IsSetEncryptedLogGroupStrategy() => this.EncryptedLogGroupStrategy != null;

        /// <summary>
        /// Gets and sets the property LogGroupSelectionCriteria. 
        /// <para>
        /// The selection criteria that specifies which source log groups to centralize. The selection
        /// criteria uses the same format as OAM link filters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string LogGroupSelectionCriteria { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupSelectionCriteria property is set.
        /// </summary>
        internal bool IsSetLogGroupSelectionCriteria() => this.LogGroupSelectionCriteria != null;
    }
}
