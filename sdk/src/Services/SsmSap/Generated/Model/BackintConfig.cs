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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
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
namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// Configuration parameters for AWS Backint Agent for SAP HANA. You can backup your SAP
    /// HANA database with AWS Backup or Amazon S3.
    /// </summary>
    public partial class BackintConfig
    {
        private BackintMode _backintMode;
        private bool? _ensureNoBackupInProcess;

        /// <summary>
        /// Gets and sets the property BackintMode. 
        /// <para>
        /// AWS service for your database backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BackintMode BackintMode
        {
            get { return this._backintMode; }
            set { this._backintMode = value; }
        }

        // Check to see if BackintMode property is set
        internal bool IsSetBackintMode()
        {
            return this._backintMode != null;
        }

        /// <summary>
        /// Gets and sets the property EnsureNoBackupInProcess.
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? EnsureNoBackupInProcess
        {
            get { return this._ensureNoBackupInProcess; }
            set { this._ensureNoBackupInProcess = value; }
        }

        // Check to see if EnsureNoBackupInProcess property is set
        internal bool IsSetEnsureNoBackupInProcess()
        {
            return this._ensureNoBackupInProcess.HasValue; 
        }

    }
}