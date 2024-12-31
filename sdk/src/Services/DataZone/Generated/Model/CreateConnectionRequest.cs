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
    /// Container for the parameters to the CreateConnection operation.
    /// Creates a new connection. In Amazon DataZone, a connection enables you to connect
    /// your resources (domains, projects, and environments) to external resources and services.
    /// </summary>
    public partial class CreateConnectionRequest : AmazonDataZoneRequest
    {
        private AwsLocation _awsLocation;
        private string _clientToken;
        private string _description;
        private string _domainIdentifier;
        private string _environmentIdentifier;
        private string _name;
        private ConnectionPropertiesInput _props;

        /// <summary>
        /// Gets and sets the property AwsLocation. 
        /// <para>
        /// The location where the connection is created.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A connection description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=128)]
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
        /// The ID of the domain where the connection is created.
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
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The ID of the environment where the connection is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentIdentifier
        {
            get { return this._environmentIdentifier; }
            set { this._environmentIdentifier = value; }
        }

        // Check to see if EnvironmentIdentifier property is set
        internal bool IsSetEnvironmentIdentifier()
        {
            return this._environmentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The connection name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Props. 
        /// <para>
        /// The connection props.
        /// </para>
        /// </summary>
        public ConnectionPropertiesInput Props
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