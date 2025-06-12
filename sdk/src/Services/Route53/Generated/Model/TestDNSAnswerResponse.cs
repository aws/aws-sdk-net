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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the response to a <c>TestDNSAnswer</c> request.
    /// </summary>
    public partial class TestDNSAnswerResponse : AmazonWebServiceResponse
    {
        private string _nameserver;
        private string _recordName;
        private RRType _recordType;
        private List<string> _recordData = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _responseCode;
        private string _protocol;

        /// <summary>
        /// Gets and sets the property Nameserver. 
        /// <para>
        /// The Amazon Route 53 name server used to respond to the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string Nameserver
        {
            get { return this._nameserver; }
            set { this._nameserver = value; }
        }

        // Check to see if Nameserver property is set
        internal bool IsSetNameserver()
        {
            return this._nameserver != null;
        }

        /// <summary>
        /// Gets and sets the property RecordName. 
        /// <para>
        /// The name of the resource record set that you submitted a request for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string RecordName
        {
            get { return this._recordName; }
            set { this._recordName = value; }
        }

        // Check to see if RecordName property is set
        internal bool IsSetRecordName()
        {
            return this._recordName != null;
        }

        /// <summary>
        /// Gets and sets the property RecordType. 
        /// <para>
        /// The type of the resource record set that you submitted a request for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RRType RecordType
        {
            get { return this._recordType; }
            set { this._recordType = value; }
        }

        // Check to see if RecordType property is set
        internal bool IsSetRecordType()
        {
            return this._recordType != null;
        }

        /// <summary>
        /// Gets and sets the property RecordData. 
        /// <para>
        /// A list that contains values that Amazon Route 53 returned for this resource record
        /// set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RecordData
        {
            get { return this._recordData; }
            set { this._recordData = value; }
        }

        // Check to see if RecordData property is set
        internal bool IsSetRecordData()
        {
            return this._recordData != null && (this._recordData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResponseCode. 
        /// <para>
        /// A code that indicates whether the request is valid or not. The most common response
        /// code is <c>NOERROR</c>, meaning that the request is valid. If the response is not
        /// valid, Amazon Route 53 returns a response code that describes the error. For a list
        /// of possible response codes, see <a href="http://www.iana.org/assignments/dns-parameters/dns-parameters.xhtml#dns-parameters-6">DNS
        /// RCODES</a> on the IANA website. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResponseCode
        {
            get { return this._responseCode; }
            set { this._responseCode = value; }
        }

        // Check to see if ResponseCode property is set
        internal bool IsSetResponseCode()
        {
            return this._responseCode != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol that Amazon Route 53 used to respond to the request, either <c>UDP</c>
        /// or <c>TCP</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

    }
}