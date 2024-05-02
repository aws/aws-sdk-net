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
    /// A CIS check.
    /// </summary>
    public partial class CisCheckAggregation
    {
        private string _accountId;
        private string _checkDescription;
        private string _checkId;
        private CisSecurityLevel _level;
        private string _platform;
        private string _scanArn;
        private StatusCounts _statusCounts;
        private string _title;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID for the CIS check.
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
        /// The description for the CIS check.
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
        /// The check ID for the CIS check.
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
        /// Gets and sets the property Level. 
        /// <para>
        /// The CIS check level.
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
        /// The CIS check platform.
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
        /// Gets and sets the property ScanArn. 
        /// <para>
        /// The scan ARN for the CIS check scan ARN.
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
        /// Gets and sets the property StatusCounts. 
        /// <para>
        /// The CIS check status counts.
        /// </para>
        /// </summary>
        public StatusCounts StatusCounts
        {
            get { return this._statusCounts; }
            set { this._statusCounts = value; }
        }

        // Check to see if StatusCounts property is set
        internal bool IsSetStatusCounts()
        {
            return this._statusCounts != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The CIS check title.
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