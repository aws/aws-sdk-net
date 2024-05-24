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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Job log data
    /// </summary>
    public partial class JobLogEventData
    {
        private string _conversionServerID;
        private string _rawError;
        private string _sourceServerID;
        private string _targetInstanceID;

        /// <summary>
        /// Gets and sets the property ConversionServerID. 
        /// <para>
        /// Job Event conversion Server ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string ConversionServerID
        {
            get { return this._conversionServerID; }
            set { this._conversionServerID = value; }
        }

        // Check to see if ConversionServerID property is set
        internal bool IsSetConversionServerID()
        {
            return this._conversionServerID != null;
        }

        /// <summary>
        /// Gets and sets the property RawError. 
        /// <para>
        /// Job error.
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
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Job Event Source Server ID.
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
        /// Gets and sets the property TargetInstanceID. 
        /// <para>
        /// Job Event Target instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string TargetInstanceID
        {
            get { return this._targetInstanceID; }
            set { this._targetInstanceID = value; }
        }

        // Check to see if TargetInstanceID property is set
        internal bool IsSetTargetInstanceID()
        {
            return this._targetInstanceID != null;
        }

    }
}