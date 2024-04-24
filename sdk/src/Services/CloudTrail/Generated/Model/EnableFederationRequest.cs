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
    /// Container for the parameters to the EnableFederation operation.
    /// Enables Lake query federation on the specified event data store. Federating an event
    /// data store lets you view the metadata associated with the event data store in the
    /// Glue <a href="https://docs.aws.amazon.com/glue/latest/dg/components-overview.html#data-catalog-intro">Data
    /// Catalog</a> and run SQL queries against your event data using Amazon Athena. The table
    /// metadata stored in the Glue Data Catalog lets the Athena query engine know how to
    /// find, read, and process the data that you want to query.
    /// 
    ///  
    /// <para>
    /// When you enable Lake query federation, CloudTrail creates a managed database named
    /// <c>aws:cloudtrail</c> (if the database doesn't already exist) and a managed federated
    /// table in the Glue Data Catalog. The event data store ID is used for the table name.
    /// CloudTrail registers the role ARN and event data store in <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-federation-lake-formation.html">Lake
    /// Formation</a>, the service responsible for allowing fine-grained access control of
    /// the federated resources in the Glue Data Catalog.
    /// </para>
    ///  
    /// <para>
    /// For more information about Lake query federation, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-federation.html">Federate
    /// an event data store</a>.
    /// </para>
    /// </summary>
    public partial class EnableFederationRequest : AmazonCloudTrailRequest
    {
        private string _eventDataStore;
        private string _federationRoleArn;

        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        /// The ARN (or ID suffix of the ARN) of the event data store for which you want to enable
        /// Lake query federation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=256)]
        public string EventDataStore
        {
            get { return this._eventDataStore; }
            set { this._eventDataStore = value; }
        }

        // Check to see if EventDataStore property is set
        internal bool IsSetEventDataStore()
        {
            return this._eventDataStore != null;
        }

        /// <summary>
        /// Gets and sets the property FederationRoleArn. 
        /// <para>
        ///  The ARN of the federation role to use for the event data store. Amazon Web Services
        /// services like Lake Formation use this federation role to access data for the federated
        /// event data store. The federation role must exist in your account and provide the <a
        /// href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-federation.html#query-federation-permissions-role">required
        /// minimum permissions</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=125)]
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

    }
}