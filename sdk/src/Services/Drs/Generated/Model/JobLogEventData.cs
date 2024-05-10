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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Metadata associated with a Job log.
    /// </summary>
    public partial class JobLogEventData
    {
        private ConversionProperties _conversionProperties;
        private string _conversionServerID;
        private EventResourceData _eventResourceData;
        private string _rawError;
        private string _sourceServerID;
        private string _targetInstanceID;

        /// <summary>
        /// Gets and sets the property ConversionProperties. 
        /// <para>
        /// Properties of a conversion job
        /// </para>
        /// </summary>
        public ConversionProperties ConversionProperties
        {
            get { return this._conversionProperties; }
            set { this._conversionProperties = value; }
        }

        // Check to see if ConversionProperties property is set
        internal bool IsSetConversionProperties()
        {
            return this._conversionProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ConversionServerID. 
        /// <para>
        /// The ID of a conversion server.
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
        /// Gets and sets the property EventResourceData. 
        /// <para>
        /// Properties of resource related to a job event.
        /// </para>
        /// </summary>
        public EventResourceData EventResourceData
        {
            get { return this._eventResourceData; }
            set { this._eventResourceData = value; }
        }

        // Check to see if EventResourceData property is set
        internal bool IsSetEventResourceData()
        {
            return this._eventResourceData != null;
        }

        /// <summary>
        /// Gets and sets the property RawError. 
        /// <para>
        /// A string representing a job error.
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
        /// The ID of a Source Server.
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
        /// The ID of a Recovery Instance.
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