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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// This is the response object from the GetInstrumentationConfigurationStatus operation.
    /// </summary>
    public partial class GetInstrumentationConfigurationStatusResponse : AmazonWebServiceResponse
    {
        private string _environment;
        private List<InstrumentationStatusEvent> _events = AWSConfigs.InitializeCollections ? new List<InstrumentationStatusEvent>() : null;
        private Location _location;
        private string _nextToken;
        private string _service;
        private DynamicInstrumentationSignalType _signalType;
        private InstrumentationConfigurationStatus _status;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment echoed from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The list of status events within the requested time window, sorted with the most recent
        /// first. Error events include an error cause.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<InstrumentationStatusEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The code location echoed from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Location Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token to continue retrieving status events.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The service name echoed from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property SignalType. 
        /// <para>
        /// The telemetry signal type echoed from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DynamicInstrumentationSignalType SignalType
        {
            get { return this._signalType; }
            set { this._signalType = value; }
        }

        // Check to see if SignalType property is set
        internal bool IsSetSignalType()
        {
            return this._signalType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status that was queried. If not specified in the request, this is <c>ACTIVE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstrumentationConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}