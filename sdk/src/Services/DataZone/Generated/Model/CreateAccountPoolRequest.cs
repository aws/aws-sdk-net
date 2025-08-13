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
    /// Container for the parameters to the CreateAccountPool operation.
    /// Creates an account pool.
    /// </summary>
    public partial class CreateAccountPoolRequest : AmazonDataZoneRequest
    {
        private AccountSource _accountSource;
        private string _description;
        private string _domainIdentifier;
        private string _name;
        private ResolutionStrategy _resolutionStrategy;

        /// <summary>
        /// Gets and sets the property AccountSource. 
        /// <para>
        /// The source of accounts for the account pool. In the current release, it's either a
        /// static list of accounts provided by the customer or a custom Amazon Web Services Lambda
        /// handler. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountSource AccountSource
        {
            get { return this._accountSource; }
            set { this._accountSource = value; }
        }

        // Check to see if AccountSource property is set
        internal bool IsSetAccountSource()
        {
            return this._accountSource != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the account pool.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
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
        /// The ID of the domain where the account pool is created.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the account pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=64)]
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
        /// Gets and sets the property ResolutionStrategy. 
        /// <para>
        /// The mechanism used to resolve the account selection from the account pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResolutionStrategy ResolutionStrategy
        {
            get { return this._resolutionStrategy; }
            set { this._resolutionStrategy = value; }
        }

        // Check to see if ResolutionStrategy property is set
        internal bool IsSetResolutionStrategy()
        {
            return this._resolutionStrategy != null;
        }

    }
}