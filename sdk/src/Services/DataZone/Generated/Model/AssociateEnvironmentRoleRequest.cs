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
    /// Container for the parameters to the AssociateEnvironmentRole operation.
    /// Associates the environment role in Amazon DataZone.
    /// </summary>
    public partial class AssociateEnvironmentRoleRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private string _environmentIdentifier;
        private string _environmentRoleArn;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which the environment role is associated.
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
        /// The ID of the Amazon DataZone environment.
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
        /// Gets and sets the property EnvironmentRoleArn. 
        /// <para>
        /// The ARN of the environment role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentRoleArn
        {
            get { return this._environmentRoleArn; }
            set { this._environmentRoleArn = value; }
        }

        // Check to see if EnvironmentRoleArn property is set
        internal bool IsSetEnvironmentRoleArn()
        {
            return this._environmentRoleArn != null;
        }

    }
}