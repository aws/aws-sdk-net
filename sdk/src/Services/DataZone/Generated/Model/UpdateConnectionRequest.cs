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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConnection operation.
    /// Updates a connection. In Amazon DataZone, a connection enables you to connect your
    /// resources (domains, projects, and environments) to external resources and services.
    /// </summary>
    public partial class UpdateConnectionRequest : AmazonDataZoneRequest
    {
        private AwsLocation _awsLocation;
        private string _description;
        private string _domainIdentifier;
        private string _identifier;
        private ConnectionPropertiesPatch _props;

        /// <summary>
        /// Gets and sets the property AwsLocation. 
        /// <para>
        /// The location where a connection is to be updated.
        /// </para>
        /// </summary>
        public AwsLocation AwsLocation
        {
            get { return this._awsLocation; }
            set { this._awsLocation = value; }
        }

        // Check to see if AwsLocation property is set
        internal bool IsSetAwsLocation()
        {
            return this._awsLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain where a connection is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID of the connection to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Props. 
        /// <para>
        /// The connection props.
        /// </para>
        /// </summary>
        public ConnectionPropertiesPatch Props
        {
            get { return this._props; }
            set { this._props = value; }
        }

        // Check to see if Props property is set
        internal bool IsSetProps()
        {
            return this._props != null;
        }

    }
}