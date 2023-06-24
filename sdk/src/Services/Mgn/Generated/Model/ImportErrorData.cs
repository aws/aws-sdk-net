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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Import error data.
    /// </summary>
    public partial class ImportErrorData
    {
        private string _applicationid;
        private string _ec2LaunchTemplateID;
        private string _rawError;
        private long? _rowNumber;
        private string _sourceServerID;
        private string _waveid;

        /// <summary>
        /// Gets and sets the property ApplicationID. 
        /// <para>
        /// Import error data application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string ApplicationID
        {
            get { return this._applicationid; }
            set { this._applicationid = value; }
        }

        // Check to see if ApplicationID property is set
        internal bool IsSetApplicationID()
        {
            return this._applicationid != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2LaunchTemplateID. 
        /// <para>
        /// Import error data ec2 LaunchTemplate ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Ec2LaunchTemplateID
        {
            get { return this._ec2LaunchTemplateID; }
            set { this._ec2LaunchTemplateID = value; }
        }

        // Check to see if Ec2LaunchTemplateID property is set
        internal bool IsSetEc2LaunchTemplateID()
        {
            return this._ec2LaunchTemplateID != null;
        }

        /// <summary>
        /// Gets and sets the property RawError. 
        /// <para>
        /// Import error data raw error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public string RawError
        {
            get { return this._rawError; }
            set { this._rawError = value; }
        }

        // Check to see if RawError property is set
        internal bool IsSetRawError()
        {
            return this._rawError != null;
        }

        /// <summary>
        /// Gets and sets the property RowNumber. 
        /// <para>
        /// Import error data row number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long RowNumber
        {
            get { return this._rowNumber.GetValueOrDefault(); }
            set { this._rowNumber = value; }
        }

        // Check to see if RowNumber property is set
        internal bool IsSetRowNumber()
        {
            return this._rowNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Import error data source server ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string SourceServerID
        {
            get { return this._sourceServerID; }
            set { this._sourceServerID = value; }
        }

        // Check to see if SourceServerID property is set
        internal bool IsSetSourceServerID()
        {
            return this._sourceServerID != null;
        }

        /// <summary>
        /// Gets and sets the property WaveID. 
        /// <para>
        /// Import error data wave id.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string WaveID
        {
            get { return this._waveid; }
            set { this._waveid = value; }
        }

        // Check to see if WaveID property is set
        internal bool IsSetWaveID()
        {
            return this._waveid != null;
        }

    }
}