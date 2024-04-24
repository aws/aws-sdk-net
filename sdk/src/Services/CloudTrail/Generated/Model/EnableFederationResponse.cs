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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the EnableFederation operation.
    /// </summary>
    public partial class EnableFederationResponse : AmazonWebServiceResponse
    {
        private string _eventDataStoreArn;
        private string _federationRoleArn;
        private FederationStatus _federationStatus;

        /// <summary>
        /// Gets and sets the property EventDataStoreArn. 
        /// <para>
        ///  The ARN of the event data store for which you enabled Lake query federation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=256)]
        public string EventDataStoreArn
        {
            get { return this._eventDataStoreArn; }
            set { this._eventDataStoreArn = value; }
        }

        // Check to see if EventDataStoreArn property is set
        internal bool IsSetEventDataStoreArn()
        {
            return this._eventDataStoreArn != null;
        }

        /// <summary>
        /// Gets and sets the property FederationRoleArn. 
        /// <para>
        ///  The ARN of the federation role. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=125)]
        public string FederationRoleArn
        {
            get { return this._federationRoleArn; }
            set { this._federationRoleArn = value; }
        }

        // Check to see if FederationRoleArn property is set
        internal bool IsSetFederationRoleArn()
        {
            return this._federationRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property FederationStatus. 
        /// <para>
        ///  The federation status. 
        /// </para>
        /// </summary>
        public FederationStatus FederationStatus
        {
            get { return this._federationStatus; }
            set { this._federationStatus = value; }
        }

        // Check to see if FederationStatus property is set
        internal bool IsSetFederationStatus()
        {
            return this._federationStatus != null;
        }

    }
}