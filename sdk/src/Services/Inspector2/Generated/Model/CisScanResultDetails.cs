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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The CIS scan result details.
    /// </summary>
    public partial class CisScanResultDetails
    {
        private string _accountId;
        private string _checkDescription;
        private string _checkId;
        private string _findingArn;
        private CisSecurityLevel _level;
        private string _platform;
        private string _remediation;
        private string _scanArn;
        private CisFindingStatus _status;
        private string _statusReason;
        private string _targetResourceId;
        private string _title;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The CIS scan result details' account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CheckDescription. 
        /// <para>
        /// The account ID that's associated with the CIS scan result details.
        /// </para>
        /// </summary>
        public string CheckDescription
        {
            get { return this._checkDescription; }
            set { this._checkDescription = value; }
        }

        // Check to see if CheckDescription property is set
        internal bool IsSetCheckDescription()
        {
            return this._checkDescription != null;
        }

        /// <summary>
        /// Gets and sets the property CheckId. 
        /// <para>
        /// The CIS scan result details' check ID.
        /// </para>
        /// </summary>
        public string CheckId
        {
            get { return this._checkId; }
            set { this._checkId = value; }
        }

        // Check to see if CheckId property is set
        internal bool IsSetCheckId()
        {
            return this._checkId != null;
        }

        /// <summary>
        /// Gets and sets the property FindingArn. 
        /// <para>
        /// The CIS scan result details' finding ARN.
        /// </para>
        /// </summary>
        public string FindingArn
        {
            get { return this._findingArn; }
            set { this._findingArn = value; }
        }

        // Check to see if FindingArn property is set
        internal bool IsSetFindingArn()
        {
            return this._findingArn != null;
        }

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The CIS scan result details' level.
        /// </para>
        /// </summary>
        public CisSecurityLevel Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The CIS scan result details' platform.
        /// </para>
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property Remediation. 
        /// <para>
        /// The CIS scan result details' remediation.
        /// </para>
        /// </summary>
        public string Remediation
        {
            get { return this._remediation; }
            set { this._remediation = value; }
        }

        // Check to see if Remediation property is set
        internal bool IsSetRemediation()
        {
            return this._remediation != null;
        }

        /// <summary>
        /// Gets and sets the property ScanArn. 
        /// <para>
        /// The CIS scan result details' scan ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScanArn
        {
            get { return this._scanArn; }
            set { this._scanArn = value; }
        }

        // Check to see if ScanArn property is set
        internal bool IsSetScanArn()
        {
            return this._scanArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The CIS scan result details' status.
        /// </para>
        /// </summary>
        public CisFindingStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The CIS scan result details' status reason.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResourceId. 
        /// <para>
        /// The CIS scan result details' target resource ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=341)]
        public string TargetResourceId
        {
            get { return this._targetResourceId; }
            set { this._targetResourceId = value; }
        }

        // Check to see if TargetResourceId property is set
        internal bool IsSetTargetResourceId()
        {
            return this._targetResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The CIS scan result details' title.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}