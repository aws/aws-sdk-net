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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
        private string _dataSourceSelectionCriteria;
        private EncryptedLogGroupStrategy _encryptedLogGroupStrategy;
        private string _logGroupSelectionCriteria;

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
        [AWSProperty(Min=1, Max=2000)]
        public string DataSourceSelectionCriteria
        {
            get { return this._dataSourceSelectionCriteria; }
            set { this._dataSourceSelectionCriteria = value; }
        }

        // Check to see if DataSourceSelectionCriteria property is set
        internal bool IsSetDataSourceSelectionCriteria()
        {
            return this._dataSourceSelectionCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptedLogGroupStrategy. 
        /// <para>
        /// A strategy determining whether to centralize source log groups that are encrypted
        /// with customer managed KMS keys (CMK). ALLOW will consider CMK encrypted source log
        /// groups for centralization while SKIP will skip CMK encrypted source log groups from
        /// centralization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptedLogGroupStrategy EncryptedLogGroupStrategy
        {
            get { return this._encryptedLogGroupStrategy; }
            set { this._encryptedLogGroupStrategy = value; }
        }

        // Check to see if EncryptedLogGroupStrategy property is set
        internal bool IsSetEncryptedLogGroupStrategy()
        {
            return this._encryptedLogGroupStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupSelectionCriteria. 
        /// <para>
        /// The selection criteria that specifies which source log groups to centralize. The selection
        /// criteria uses the same format as OAM link filters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string LogGroupSelectionCriteria
        {
            get { return this._logGroupSelectionCriteria; }
            set { this._logGroupSelectionCriteria = value; }
        }

        // Check to see if LogGroupSelectionCriteria property is set
        internal bool IsSetLogGroupSelectionCriteria()
        {
            return this._logGroupSelectionCriteria != null;
        }

    }
}