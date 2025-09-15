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
    /// Configuration for backing up centralized log data to a secondary region.
    /// </summary>
    public partial class LogsBackupConfiguration
    {
        private string _kmsKeyArn;
        private string _region;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// KMS Key arn belonging to the primary destination account and backup region, to encrypt
        /// newly created central log groups in the backup destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Logs specific backup destination region within the primary destination account to
        /// which log data should be centralized.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}