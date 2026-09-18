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
    /// Import error data.
    /// </summary>
    public partial class ImportErrorData
    {
        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// Import error data source account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountID { get; set; }

        /// <summary>
        /// Checks to see if the AccountID property is set.
        /// </summary>
        internal bool IsSetAccountID() => this.AccountID != null;

        /// <summary>
        /// Gets and sets the property ApplicationID. 
        /// <para>
        /// Import error data application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string ApplicationID { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationID property is set.
        /// </summary>
        internal bool IsSetApplicationID() => this.ApplicationID != null;

        /// <summary>
        /// Gets and sets the property Ec2LaunchTemplateID. 
        /// <para>
        /// Import error data ec2 LaunchTemplate ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Ec2LaunchTemplateID { get; set; }

        /// <summary>
        /// Checks to see if the Ec2LaunchTemplateID property is set.
        /// </summary>
        internal bool IsSetEc2LaunchTemplateID() => this.Ec2LaunchTemplateID != null;

        /// <summary>
        /// Gets and sets the property RawError. 
        /// <para>
        /// Import error data raw error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public string RawError { get; set; }

        /// <summary>
        /// Checks to see if the RawError property is set.
        /// </summary>
        internal bool IsSetRawError() => this.RawError != null;

        /// <summary>
        /// Gets and sets the property RowNumber. 
        /// <para>
        /// Import error data row number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? RowNumber { get; set; }

        /// <summary>
        /// Checks to see if the RowNumber property is set.
        /// </summary>
        internal bool IsSetRowNumber() => this.RowNumber.HasValue;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Import error data source server ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;

        /// <summary>
        /// Gets and sets the property WaveID. 
        /// <para>
        /// Import error data wave id.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string WaveID { get; set; }

        /// <summary>
        /// Checks to see if the WaveID property is set.
        /// </summary>
        internal bool IsSetWaveID() => this.WaveID != null;
    }
}
